using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using eBay.Service.Call;
using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using eBay.Service.Util;
using System.Threading;


namespace eBayLister
{
    public class eBayWrapper
    {
        private event dChangeStatus changeStatus;
        private event dChangeStatus addLogStatus;
        private event dChangeStatus reportProgress;
        private event dChangeStatus reportTotalItems;

        private ApiContext context;
        public eBayWrapper() {
            this.changeStatus += new dChangeStatus(eBayLister.Program.mainForm.changeStatus);
            this.addLogStatus += new dChangeStatus(eBayLister.Program.mainForm.addLogStatus);
            this.reportProgress += new dChangeStatus(eBayLister.Program.mainForm.progressChanged);
            this.reportTotalItems += new dChangeStatus(eBayLister.Program.mainForm.totalItems);

            context = new ApiContext();
            context.ApiCredential.eBayToken = eBayLister.UserSettings.Default.userToken;
            context.ApiCredential.ApiAccount.Application = eBayLister.UserSettings.Default.appId;
            context.ApiCredential.ApiAccount.Certificate = eBayLister.UserSettings.Default.certId;
            context.ApiCredential.ApiAccount.Developer = eBayLister.UserSettings.Default.devId;
            context.SoapApiServerUrl = eBayLister.UserSettings.Default.soapApiServerUrl;
            // 647
            context.Version = eBayLister.UserSettings.Default.ApiVersion;
            context.Timeout = Int32.Parse(eBayLister.UserSettings.Default.Timeout);
            context.ApiLogManager = new ApiLogManager();
            context.ApiLogManager.ApiLoggerList.Add(new FileLogger("Logs.txt", true, true, true));
            context.ApiLogManager.EnableLogging = true;
            context.Site = (SiteCodeType)Enum.Parse(typeof(SiteCodeType),eBayLister.UserSettings.Default.Site,true);
        }

        private bool initialize() {
            GeteBayOfficialTimeCall apiCall = new GeteBayOfficialTimeCall(context);
            try
            {
                string eBayTime = apiCall.GeteBayOfficialTime().ToString();
                Console.WriteLine(eBayTime);
                return true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + "\r\nPlease check Configuration","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }

        private void destroy() {
            context = null;
        }

        public void relistItems() {
            MySQLWrapper s = null;    
            
            try
            {
                changeStatus("Initializing...");
                addLogStatus("Initializing...");
                if (!initialize())
                    throw new Exception("ERROR : Unable to connect to eBay Service");
                s = new MySQLWrapper();
                GetMyeBaySellingCall eBaySelling = new GetMyeBaySellingCall(context);
                PaginatedItemArrayType pArr = new PaginatedItemArrayType();
                eBaySelling.UnsoldList = new ItemListCustomizationType();
                eBaySelling.UnsoldList.Include = true;
                eBaySelling.GetMyeBaySelling();
                ItemTypeCollection unsoldItems = new ItemTypeCollection();
                pArr = eBaySelling.UnsoldListReturn;
                if (pArr != null)
                {
                    string sku = "";
                    unsoldItems = pArr.ItemArray;
                    RelistItemCall relistItem = new RelistItemCall(context);
                    StringCollection deleteFieldList = new StringCollection();
                    ItemType tItem = new ItemType();
                    changeStatus("ReListing...");
                    addLogStatus("Total Unsold items : " + unsoldItems.Count);
                    for (int i = 0; i < unsoldItems.Count; i++)
                    {
                        tItem.ItemID = unsoldItems[i].ItemID;
                        sku = s.getSKU(unsoldItems[i].ItemID);
                        if(sku != ""){
                            relistItem.RelistItem(tItem);
                            s.updateReListedItem(sku, relistItem.ItemID);
                            s.addToLogs(sku, "Re-Listed with Item Id : " + relistItem.ItemID);
                            addLogStatus("Item : " + unsoldItems[i].ItemID + " relisted with Item ID : " + relistItem.ItemID);
                        }
                        else{
                            throw new Exception("ItemId : " + unsoldItems[i].ItemID + " not found in database!");
                        }
                    }
                    addLogStatus("Done!");
                }
                else {
                    addLogStatus("No Unsold Items!");
                }
            }
            catch (Exception ex)
            {
                addLogStatus("ERROR : " + ex.Message);
            }
            finally {
                s.destroy();
                destroy();
            }
        }

        public void startListing()
        {
            int itemCount = 0;
            string eBayItems = "0";
            MySQLWrapper s = null;
            try
            {
                s = new MySQLWrapper();
                eBayItems = s.getItemCount();
                if (eBayItems == "0")
                    throw new Exception("No items found in database");
                reportTotalItems(eBayItems);
                changeStatus("Initializing...");
                addLogStatus("Initializing...");

                if (!initialize())
                    throw new Exception("ERROR : Unable to connect to eBay Service");
                MySQLWrapper.eBayData ebayData = new MySQLWrapper.eBayData();
                MySQLWrapper.eBayItem item;
                string listedItemId = "-1";
                string generatedItemId = "-1";
                while (ebayData.hasNext() && eBayLister.Program.mainForm.listingContinue)
                {
                    listedItemId = "-1";
                    generatedItemId = "-1";
                    itemCount++;
                    reportProgress(itemCount.ToString());
                    
                    
                    item = ebayData.getItem();
                    listedItemId = s.checkIfListed(item.SKU);
                    if (listedItemId != "-1")
                    {
                        if (item.Quantity == 0)
                        {
                            addLogStatus("Removing item " + item.SKU);
                            removeItem(listedItemId, item.SKU);
                            s.deleteTempItem(item.SKU);
                            s.deleteListedItem(item.SKU);
                            s.addToLogs(item.SKU, "Deleted");
                        }
                        else
                        {
                            addLogStatus("Modifying item " + item.SKU);
                            modifyItem(listedItemId, item.SKU, item.Quantity);
                            s.deleteTempItem(item.SKU);
                            s.addToLogs(item.SKU, "Quantity changed to " + item.Quantity);
                        }
                    }
                    else
                    {
                        addLogStatus("Listing item " + item.SKU);
                        generatedItemId = addItem(item);
                        if (generatedItemId != "-1")
                        {
                            s.deleteTempItem(item.SKU);
                            s.addListedItem(item.SKU, generatedItemId);
                            s.addToLogs(item.SKU, "Listed with Item Id : " + generatedItemId);
                        }
                    }
                     
                }
                if(eBayLister.Program.mainForm.listingContinue)
                    addLogStatus("Done!");
            }
            catch (Exception ex) {
                addLogStatus("ERROR : " + ex.Message);
            }
            finally{
                s.destroy();
                destroy();
            }
        }

        private bool verifyAddItem(MySQLWrapper.eBayItem ebayItem){           
            bool itemListing = false;
            TextReader tr = new StreamReader("template.txt");
            StringBuilder htmlDescription = new StringBuilder();
            htmlDescription.Insert(0,tr.ReadToEnd());
            tr.Close();
            htmlDescription.Replace("{0}", ebayItem.Title);
            htmlDescription.Replace("{1}", ebayItem.Author);
            htmlDescription.Replace("{2}", ebayItem.Publisher);
            htmlDescription.Replace("{3}", ebayItem.publishDate);
            htmlDescription.Replace("{4}", ebayItem.Binding);
            htmlDescription.Replace("{5}", ebayItem.ISBN);
            if (ebayItem.UPC != "")
                htmlDescription.Replace("{6}", "<b>UPC : </b>" + ebayItem.UPC + "</br>");
            else
                htmlDescription.Replace("{6}", "");
            htmlDescription.Replace("{7}", ebayItem.Weight.ToString());
            htmlDescription.Replace("{8}", ebayItem.Notes);
            htmlDescription.Replace("{9}", ebayItem.Description);
            
            ItemType item = new ItemType();
            item.SKU = ebayItem.SKU;
            item.Title = ebayItem.Title;
            item.Description = htmlDescription.ToString();
            item.Currency = CurrencyCodeType.INR;
            item.Country = CountryCodeType.IN;
            item.ListingType = ListingTypeCodeType.FixedPriceItem;
            item.Quantity = ebayItem.Quantity;
            item.Location = eBayLister.UserSettings.Default.itemCityState;               
            item.ListingDuration = getListingDuration();
            item.PrimaryCategory = new CategoryType();
            if (eBayLister.UserSettings.Default.ListInCategory.Equals("Other Books"))
            {
                item.PrimaryCategory.CategoryID = "268";
            }
            else {
                item.PrimaryCategory.CategoryID = "37558";
            }
            item.StartPrice = new AmountType();
            item.StartPrice.currencyID = CurrencyCodeType.INR;
            item.StartPrice.Value = ebayItem.Price * 
                Convert.ToDouble(eBayLister.UserSettings.Default.ConversionRate);
      
            item.PaymentMethods = new BuyerPaymentMethodCodeTypeCollection();
            item.PaymentMethods.Add(BuyerPaymentMethodCodeType.PaisaPayAccepted);
            item.ShippingDetails = this.getShippingDetails();
            item.ReturnPolicy = this.getReturnPolicy();

            string handlingTime = eBayLister.UserSettings.Default.handlingTime;
            handlingTime = handlingTime.Remove(handlingTime.IndexOf(' '));
            item.DispatchTimeMax = Convert.ToInt32(handlingTime);
           
            AttributeType conditionAttribute = new AttributeType();
            conditionAttribute.attributeLabel = "Condition";
            ValTypeCollection valueCollection = new ValTypeCollection();
            ValType valueType = new ValType();
            if(ebayItem.bookCondition.Contains("Used"))
                valueType.ValueLiteral = "Used";
            else
                valueType.ValueLiteral = "New";
            valueCollection.Add(valueType);
            conditionAttribute.Value = valueCollection;
            item.AttributeArray = new AttributeTypeCollection();
            item.AttributeArray.Add(conditionAttribute);

            VerifyAddItemCall apiCall = new VerifyAddItemCall(context);

            try
            {
                FeeTypeCollection fees = apiCall.VerifyAddItem(item);
                foreach (FeeType fee in fees)
                {
                    if (fee.Name == "ListingFee")
                        addLogStatus("Success!     Listing Fee : " + Convert.ToString(fee.Fee.Value));
                }
                itemListing = true;
            }
            catch (ApiException ex)
            {
                itemListing = false;
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
            return itemListing;
        }

        private string modifyItem(string itemId,string SKU,ushort quantity) {
            string returnId = "-1";
            ItemType item = new ItemType();
            item.SKU = SKU;
            item.ItemID = itemId;
            item.Quantity = quantity;
            StringCollection deleteFieldList = new StringCollection();
            ReviseItemCall apiCall = new ReviseItemCall(context);
            apiCall.ReviseItem(item, deleteFieldList);
            returnId = apiCall.ItemID;
            return returnId;
        }

        private string addItem(MySQLWrapper.eBayItem ebayItem)
        {
            string listedItemId = "-1";
            StringBuilder htmlDescription = new StringBuilder();
            TextReader tr = new StreamReader("template.txt");
            htmlDescription.Insert(0, tr.ReadToEnd());
            tr.Close();
            htmlDescription.Replace("{0}", ebayItem.Title);
            htmlDescription.Replace("{1}", ebayItem.Author);
            htmlDescription.Replace("{2}", ebayItem.Publisher);
            htmlDescription.Replace("{3}", ebayItem.publishDate);
            htmlDescription.Replace("{4}", ebayItem.Binding);
            htmlDescription.Replace("{5}", ebayItem.ISBN);
            if (ebayItem.UPC != "")
                htmlDescription.Replace("{6}", "<b>UPC : </b>" + ebayItem.UPC + "</br>");
            else
                htmlDescription.Replace("{6}", "");
            htmlDescription.Replace("{7}", ebayItem.Weight.ToString());
            htmlDescription.Replace("{8}", ebayItem.Notes);
            htmlDescription.Replace("{9}", ebayItem.Description);
            
            ItemType item = new ItemType();

            
            item.InventoryTrackingMethod = InventoryTrackingMethodCodeType.SKU;
            item.SKU = ebayItem.SKU;

            // Title max length 55 chars
            if (ebayItem.Title.Length > 55)
                item.Title = ebayItem.Title.Substring(0, 54);
            else
                item.Title = ebayItem.Title;

            if (ebayItem.Image != "") {
                item.PictureDetails = new PictureDetailsType();
                item.PictureDetails.PictureURL.Add(ebayItem.Image);
            }
            
            item.Description = htmlDescription.ToString();
            item.Currency = CurrencyCodeType.INR;
            item.ListingType = ListingTypeCodeType.FixedPriceItem;
            item.Quantity = ebayItem.Quantity;
            item.PostalCode = eBayLister.UserSettings.Default.itemPincode;
            item.Location = eBayLister.UserSettings.Default.itemCityState;
            item.Country = (CountryCodeType)Enum.Parse(typeof(CountryCodeType), eBayLister.UserSettings.Default.itemCountry, true);
            item.ListingDuration = getListingDuration();
            item.PrimaryCategory = new CategoryType();
            if (eBayLister.UserSettings.Default.ListInCategory.Equals("Other Books"))
            {
                item.PrimaryCategory.CategoryID = "268";
            }
            else
            {
                item.PrimaryCategory.CategoryID = "37558";
            }
            item.StartPrice = new AmountType();
            item.StartPrice.currencyID = CurrencyCodeType.INR;
            item.StartPrice.Value = ebayItem.Price *
                Convert.ToDouble(eBayLister.UserSettings.Default.ConversionRate);    
            item.PaymentMethods = new BuyerPaymentMethodCodeTypeCollection();
            item.PaymentMethods.Add(BuyerPaymentMethodCodeType.PaisaPayAccepted);
            item.ShippingDetails = this.getShippingDetails();
            item.ReturnPolicy = this.getReturnPolicy();
            string handlingTime = eBayLister.UserSettings.Default.handlingTime;
            handlingTime = handlingTime.Remove(handlingTime.IndexOf(' '));
            item.DispatchTimeMax = Convert.ToInt32(handlingTime);

            AttributeType conditionAttribute = new AttributeType();
            conditionAttribute.attributeLabel = "Condition";
            ValTypeCollection valueCollection = new ValTypeCollection();
            ValType valueType = new ValType();
            if (ebayItem.bookCondition.Contains("Used"))
                valueType.ValueLiteral = "Used";
            else
                valueType.ValueLiteral = "New";
            valueCollection.Add(valueType);
            conditionAttribute.Value = valueCollection;
            item.AttributeArray = new AttributeTypeCollection();
            item.AttributeArray.Add(conditionAttribute);           
            AddItemCall apiCall = new AddItemCall(context);

            
            FeeTypeCollection fees = apiCall.AddItem(item);
            foreach (FeeType fee in fees)
            {
                
                if (fee.Name == "ListingFee")
                    addLogStatus("Success!     Listing Fee : " + Convert.ToString(fee.Fee.Value));
            }

            listedItemId = apiCall.ItemID;
            return listedItemId;
        }

        private void removeItem(string itemId, string SKU) {
            EndFixedPriceItemCall apiCall = new EndFixedPriceItemCall(context);
            apiCall.EndFixedPriceItem(itemId, EndReasonCodeType.OtherListingError, SKU);            
        }


        private ShippingDetailsType getShippingDetails()
        {
            ShippingDetailsType sd = new ShippingDetailsType();
            AmountType at = new AmountType();
            sd.PaymentInstructions = eBayLister.UserSettings.Default.paymentInstructions;
            sd.ShippingType = ShippingTypeCodeType.Flat;

            ShippingServiceOptionsType st1 = new ShippingServiceOptionsType();
            st1.ShippingService = ShippingServiceCodeType.IN_Express.ToString();

            at = new AmountType();
            at.currencyID = CurrencyCodeType.INR;
            at.Value = Convert.ToDouble(eBayLister.UserSettings.Default.shippingCost) * 
                                        Convert.ToDouble(eBayLister.UserSettings.Default.ConversionRate);
            st1.ShippingServiceCost = at;
            ShippingServiceOptionsTypeCollection serviceOptions = new ShippingServiceOptionsTypeCollection();
            serviceOptions.Add(st1);
            sd.ShippingServiceOptions = serviceOptions;
            return sd;
        }

        private ReturnPolicyType getReturnPolicy()
        {
            ReturnPolicyType rp = new ReturnPolicyType();
            if (eBayLister.UserSettings.Default.Returns.Equals("Returns Not Accepted"))
            {
                rp.ReturnsAcceptedOption = "ReturnsNotAccepted";
            }
            else
            {
                rp.ReturnsAcceptedOption = "ReturnsAccepted";
                string temp = "";
                string[] x;
                short indexOfSpace = -1;
                temp = eBayLister.UserSettings.Default.Refund;
                indexOfSpace = (short)temp.IndexOf(' ');
                if (indexOfSpace > 0)
                {
                    temp = temp.Remove(indexOfSpace, 1);
                }
                rp.Refund = temp;
                temp = eBayLister.UserSettings.Default.returnsWithin;
                x = temp.Split();
                rp.ReturnsWithinOption = x[1] + "_" + x[0];
                rp.ShippingCostPaidByOption = eBayLister.UserSettings.Default.returnsShippingCostPaidBy;
            }
            return rp;
        }

        private string getListingDuration() {
            string duration = eBayLister.UserSettings.Default.listingDuration;
            string[] a;
            int x = duration.IndexOf('(');
            if (x > 0)
            {
                x--;
                duration = duration.Remove(x);
            }
            a = duration.Split();
            duration = a[1] + "_" + a[0];
            return duration;
        }
    }
}
