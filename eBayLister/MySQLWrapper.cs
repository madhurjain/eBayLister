using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace eBayLister
{
    public class MySQLWrapper
    {
        private event dChangeStatus changeStatus;
        private event dChangeStatus addLogStatus;

        static MySqlConnection connection = null;
        static MySqlConnection connection2 = null;
        static MySqlCommand command = null;
        static MySqlCommand command2 = null;
        
        public MySQLWrapper() {
            this.changeStatus += new dChangeStatus(eBayLister.Program.mainForm.changeStatus);
            this.addLogStatus += new dChangeStatus(eBayLister.Program.mainForm.addLogStatus);
            if (!getConnection())
                throw new Exception("Unable to connect to MySQL");
        }

        private bool getConnection()
        {
            string connectionString = "datasource=" + eBayLister.UserSettings.Default.MySQLHost +
                                      ";username=" + eBayLister.UserSettings.Default.MySQLUsername +
                                      ";password=" + eBayLister.UserSettings.Default.MySQLPassword +
                                      ";database=" + eBayLister.UserSettings.Default.MySQLDatabase;
            try { 
                if(connection == null || connection.State == ConnectionState.Closed){
                    connection = new MySqlConnection();
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command = connection.CreateCommand();
                }
                if (connection2 == null || connection2.State == ConnectionState.Closed)
                {
                    connection2 = new MySqlConnection();
                    connection2.ConnectionString = connectionString;
                    connection2.Open();
                    command2 = connection2.CreateCommand();
                }
                return true;
            }
            catch(MySqlException ex){
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        public static void testConnection(string host,string username, string password, string database) {
            try
            {
                MySqlConnection tConnection = new MySqlConnection("datasource=" + host + ";username=" + username +
                                                              ";password=" + password + ";database=" + database);
                tConnection.Open();
                MessageBox.Show("Connection Test Succeeded!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                tConnection.Close();
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool closeConnection() {
            try {
                if (connection != null) {
                    if (connection.State == ConnectionState.Open) {
                        connection.Close();
                    }
                    connection = null;
                }
                if (connection2 != null)
                {
                    if (connection2.State == ConnectionState.Open)
                    {
                        connection2.Close();
                    }
                    connection2 = null;
                }
                return true;
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void destroy() {
            closeConnection();
            command = null;
            command2 = null;
        }

        public void loadDataFromFile(string fileName) {
            changeStatus("Loading data to MySQL ...");
            addLogStatus("Loading data from file " + fileName + " to MySQL ...");
            command.CommandText = "LOAD DATA LOCAL INFILE 'eBayDataFiles/" + fileName + "' INTO TABLE ebay_data.tempdata FIELDS TERMINATED BY '\\t' LINES TERMINATED BY '\\n' IGNORE 1 LINES;";
            int recordsAdded = command.ExecuteNonQuery();
            addLogStatus(recordsAdded + " records added to database.");
            changeStatus("");
        }

        public String checkIfListed(string SKU) {
            string listedItemId = "-1";
            command2.CommandText = "SELECT itemID FROM listeditems WHERE SKU='" + SKU + "';";
            MySqlDataReader listedItems = command2.ExecuteReader();
            if (listedItems.HasRows) {
                listedItems.Read();
                listedItemId = listedItems.GetString(0);
            }
            listedItems.Close();
            return listedItemId;
        }

        

        public void addListedItem(string SKU,string itemID) {
            command2.CommandText = "INSERT INTO listeditems(SKU,itemID) VALUES('" + SKU + "','" + itemID + "');";
            command2.ExecuteNonQuery();
        }

        public void deleteListedItem(string SKU) {
            command2.CommandText = "DELETE FROM listeditems WHERE SKU='" + SKU + "';";
            command2.ExecuteNonQuery();
        }

        public void deleteTempItem(string SKU) {
            command2.CommandText = "DELETE FROM tempdata WHERE SKU='" + SKU + "';";
            command2.ExecuteNonQuery();
        }

        public void addToLogs(string SKU,string comment) {
            command2.CommandText = "INSERT INTO logs(SKU,Comments,TimeStamp) VALUES('" + SKU + "','" + comment + "',NOW());";
            command2.ExecuteNonQuery();
        }

        public void updateReListedItem(string SKU, string itemID) {
            command2.CommandText = "UPDATE listeditems SET ItemID = '" + itemID + "' WHERE SKU = '" + SKU + "';";
            command2.ExecuteNonQuery();
        }

        public string getSKU(string itemID) {
            command.CommandText = "SELECT SKU FROM listeditems WHERE ItemID = '" + itemID + "';";
            Object sku = command.ExecuteScalar();
            if (sku == null)
                return "";
            else
                return sku.ToString();
        }

        public string getItemCount() {
            command.CommandText = "SELECT COUNT(SKU) FROM tempdata;";
            MySqlDataReader reader = command.ExecuteReader();
            string noOfRows = "0";
            if (reader.HasRows)
            {
                reader.Read();
                noOfRows = reader.GetString(0);
            }
            reader.Close();
            return noOfRows;
        }

        public class eBayData {
            MySqlDataReader reader = null;
            eBayItem item = null;
            bool hasRows = false;
            public eBayData() {
                command.CommandText = "SELECT * FROM tempdata;";
                reader = command.ExecuteReader();
                item = new eBayItem();
            }
            public bool hasNext() {
                hasRows = reader.Read();
                if (hasRows)
                {
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
            }
            public eBayItem getItem() {
                int i = 0;
                item.SKU = reader.GetString(0);
                item.Author = reader.GetString(1);
                item.Title = reader.GetString(2);
                item.bookCondition = reader.GetString(3);
                item.bookSize = reader.GetString(4);
                item.jacketCondition = reader.GetString(5);
                item.Binding = reader.GetString(6);
                item.ISBN = reader.GetString(7);
                item.Publisher = reader.GetString(8);
                item.publishPlace = reader.GetString(9);
                item.publishDate = reader.GetString(10);
                item.Edition = reader.GetString(11);
                item.Signature = reader.GetString(12);
                item.Notes = reader.GetString(13);
                item.Quantity = reader.GetUInt16(14);
                item.Price = reader.GetDouble(15);
                item.Image = reader.GetString(16);
                for (i = 0; i < 5; i++) {
                    item.Category[i] = reader.GetString(i + 17);
                }
                for (i = 0; i < 9; i++)
                {
                    item.Keyword[i] = reader.GetString(i + 22);
                }
                item.Weight = reader.GetDecimal(31);
                item.UPC = reader.GetString(32);
                item.Description = reader.GetString(33);
                return item;
            }
        }   
    
        public class eBayItem{
            public string SKU;
            public string Author;
            public string Title;
            public string bookCondition;
            public string bookSize;
            public string jacketCondition;
            public string Binding;
            public string ISBN;
            public string Publisher;
            public string publishPlace;
            public string publishDate;
            public string Edition;
            public string Signature;
            public string Notes;
            public ushort Quantity;
            public double Price;
            public string Image;
            public decimal Weight;
            public string[] Category = new string[5];
            public string[] Keyword = new string[9];
            public string UPC;
            public string Description;
        }
    }
}