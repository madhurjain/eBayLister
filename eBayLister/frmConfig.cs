using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using eBay.Service.Core.Soap;

namespace eBayLister
{
    public partial class frmConfig : Form
    {
        public EventHandler txtChanged;
        public bool btxtChanged = false;
        public frmConfig()
        {
            InitializeComponent();
            txtChanged = new EventHandler(this.Text_Changed);
            addEventHandlers_TextBoxes(this);
            if (eBayLister.UserSettings.Default.Returns.Equals("Returns Not Accepted")) {
                lblReturnsNotAccepted.Visible = true;
                lblReturnsWithin.Visible = false;
                lblRefundAs.Visible = false;
                lblReturnShippingPaidBy.Visible = false;
                cBoxReturnsWithin.Visible = false;
                cBoxRefundAs.Visible = false;
                cBoxShippingPaidBy.Visible = false;
            }
        }

        private void addEventHandlers_TextBoxes(Control c)
        {
            if (c is Panel || c is GroupBox || c is Form) {
                foreach(Control x in c.Controls)
                    addEventHandlers_TextBoxes(x);
            }
            else if (c is TextBox || c is ComboBox || c is RichTextBox)
            {
                c.TextChanged += txtChanged;
            }
        }

        private void Text_Changed(object sender, EventArgs e) {
            btxtChanged = true;
            btnApply.Enabled = true;
        }

        private void treeViewConfig_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Name) {
                case "eBayNode":
                    hideAllPanels();
                    pnleBayGeneral.Visible = true;
                    break;
                case "eBayAuthNode":
                    hideAllPanels();
                    pnleBay.Visible = true;
                    break;
                case "eBayReturnPolicyNode":
                    hideAllPanels();
                    pnleBayReturnPolicy.Visible = true;
                    break;
                case "eBayShippingDetailsNode":
                    hideAllPanels();
                    pnleBayShippingDetails.Visible = true;
                    break;
                case "MySQLNode":
                    hideAllPanels();
                    pnlMySQL.Visible = true;
                    break;
                case "FTPNode":
                    hideAllPanels();
                    pnlFTP.Visible = true;
                    break;
                case "eBayMiscNode":
                    hideAllPanels();
                    pnleBayMisc.Visible = true;
                    break;
                default:
                    hideAllPanels();
                    break;
            }
        }

        private void hideAllPanels() {
            foreach (Control c in this.Controls)
                if (c is Panel)
                    c.Visible = false;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            eBayLister.UserSettings.Default.Reload();
            this.Close();
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            eBayLister.UserSettings.Default.Save();
            btnApply.Enabled = false;
        }

        private void btnTestMySQLConnection_Click(object sender, EventArgs e)
        {
            MySQLWrapper.testConnection(txtHost.Text, txtUsername.Text, 
                                        txtPassword.Text, txtDatabase.Text);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(btxtChanged)
                eBayLister.UserSettings.Default.Save();
            this.Close();
        }

        private string USDtoINR() {
            System.Net.WebClient client = new System.Net.WebClient();
            string fullHTML = client.DownloadString("http://www.xe.com/ucc/convert.cgi?Amount=1&From=USD&To=INR");
            int iINR = fullHTML.IndexOf(@"1&nbsp;USD&nbsp;=&nbsp;");
            if (-1 != iINR)
            {
                iINR += 23;
                return fullHTML.Substring(iINR, 5);
            }
            else
            {
                return "";
            }
            /*
            System.Net.WebClient client = new System.Net.WebClient();
            string fullHTML = client.DownloadString("http://www.xe.com/ucc/convert.cgi?Amount=1&From=USD&To=INR");
            // string regEx = @"(?<=<title.*>?==*)([\s\S]*)(?=INR</title>)";
            string regEx = @"(?<=<td class=""rate"".*>?==*)([\s\S]*)(?=INR</td>)";
            using(WebBrowser w = new WebBrowser){
            }
            System.Text.RegularExpressions.Regex ex = new System.Text.RegularExpressions.Regex(regEx, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            Console.WriteLine(ex.Match(fullHTML).Value.Trim());
            // return ex.Match(fullHTML).Value.Trim();
             */
        }

        private void btnGetConversion_Click(object sender, EventArgs e)
        {
            txtConversionRate.Text = USDtoINR();
        }

        private void cBoxReturns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxReturns.SelectedItem != null)
            {
                if (cBoxReturns.SelectedItem.ToString().Equals("Returns Not Accepted"))
                {
                    lblReturnsNotAccepted.Visible = true;
                    lblReturnsWithin.Visible = false;
                    lblRefundAs.Visible = false;
                    lblReturnShippingPaidBy.Visible = false;
                    cBoxReturnsWithin.Visible = false;
                    cBoxRefundAs.Visible = false;
                    cBoxShippingPaidBy.Visible = false;
                }
                else
                {
                    lblReturnsNotAccepted.Visible = false;
                    lblReturnsWithin.Visible = true;
                    lblRefundAs.Visible = true;
                    lblReturnShippingPaidBy.Visible = true;
                    cBoxReturnsWithin.Visible = true;
                    cBoxRefundAs.Visible = true;
                    cBoxShippingPaidBy.Visible = true;
                }
            }
        }

        private void btnTestFTPConnection_Click(object sender, EventArgs e)
        {
            FTPWrapper.testFTP(txtFTPHost.Text, txtFTPUser.Text, txtFTPPassword.Text,txtFTPDirectory.Text);
        }
    }
}
