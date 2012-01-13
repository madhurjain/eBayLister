namespace eBayLister
{
    partial class frmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Authentication");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Return Policy");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Shipping Details");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Miscellaneous");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("eBay", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("MySQL");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("FTP");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.pnleBay = new System.Windows.Forms.Panel();
            this.grpBoxeBayAuth = new System.Windows.Forms.GroupBox();
            this.rtxtBoxuserToken = new System.Windows.Forms.RichTextBox();
            this.lblUserToken = new System.Windows.Forms.Label();
            this.txtCertId = new System.Windows.Forms.TextBox();
            this.lblCertId = new System.Windows.Forms.Label();
            this.txtDevId = new System.Windows.Forms.TextBox();
            this.lblDevId = new System.Windows.Forms.Label();
            this.lblAppId = new System.Windows.Forms.Label();
            this.txtAppId = new System.Windows.Forms.TextBox();
            this.lbleBayAuthSettings = new System.Windows.Forms.Label();
            this.pnlMySQL = new System.Windows.Forms.Panel();
            this.grpBoxMySQL = new System.Windows.Forms.GroupBox();
            this.btnTestMySQLConnection = new System.Windows.Forms.Button();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblMySQL = new System.Windows.Forms.Label();
            this.treeViewConfig = new System.Windows.Forms.TreeView();
            this.grpBoxApply = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlFTP = new System.Windows.Forms.Panel();
            this.grpBoxFTP = new System.Windows.Forms.GroupBox();
            this.txtFTPPollingInterval = new System.Windows.Forms.TextBox();
            this.lblFTPPollingInterval = new System.Windows.Forms.Label();
            this.txtFTPDirectory = new System.Windows.Forms.TextBox();
            this.lblFTPDirectory = new System.Windows.Forms.Label();
            this.btnTestFTPConnection = new System.Windows.Forms.Button();
            this.txtFileExtn = new System.Windows.Forms.TextBox();
            this.lblFileExtn = new System.Windows.Forms.Label();
            this.lblFTPPassword = new System.Windows.Forms.Label();
            this.txtFTPPassword = new System.Windows.Forms.TextBox();
            this.txtFTPUser = new System.Windows.Forms.TextBox();
            this.lblFTPUser = new System.Windows.Forms.Label();
            this.lblFTPHost = new System.Windows.Forms.Label();
            this.txtFTPHost = new System.Windows.Forms.TextBox();
            this.lblFTP = new System.Windows.Forms.Label();
            this.pnleBayGeneral = new System.Windows.Forms.Panel();
            this.grpBoxeBayGeneral = new System.Windows.Forms.GroupBox();
            this.btnGetConversion = new System.Windows.Forms.Button();
            this.txtConversionRate = new System.Windows.Forms.TextBox();
            this.lblConversionRate = new System.Windows.Forms.Label();
            this.cBoxSite = new System.Windows.Forms.ComboBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.txtAPIServerURL = new System.Windows.Forms.TextBox();
            this.lblAPIServerURL = new System.Windows.Forms.Label();
            this.lblAPIVersion = new System.Windows.Forms.Label();
            this.txtAPIVersion = new System.Windows.Forms.TextBox();
            this.lbleBayGeneral = new System.Windows.Forms.Label();
            this.pnleBayReturnPolicy = new System.Windows.Forms.Panel();
            this.cBoxReturns = new System.Windows.Forms.ComboBox();
            this.grpBoxeBayReturnPolicy = new System.Windows.Forms.GroupBox();
            this.cBoxShippingPaidBy = new System.Windows.Forms.ComboBox();
            this.lblReturnShippingPaidBy = new System.Windows.Forms.Label();
            this.cBoxRefundAs = new System.Windows.Forms.ComboBox();
            this.lblRefundAs = new System.Windows.Forms.Label();
            this.cBoxReturnsWithin = new System.Windows.Forms.ComboBox();
            this.lblReturnsWithin = new System.Windows.Forms.Label();
            this.lblReturnsNotAccepted = new System.Windows.Forms.Label();
            this.lbleBayReturnPolicy = new System.Windows.Forms.Label();
            this.pnleBayShippingDetails = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCityState = new System.Windows.Forms.TextBox();
            this.txtPincode = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCityState = new System.Windows.Forms.Label();
            this.lblPincode = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblItemLocation = new System.Windows.Forms.Label();
            this.lblUSD = new System.Windows.Forms.Label();
            this.txtShippingCost = new System.Windows.Forms.TextBox();
            this.cBoxHandlingTime = new System.Windows.Forms.ComboBox();
            this.lblHandlingTime = new System.Windows.Forms.Label();
            this.lblShippingCost = new System.Windows.Forms.Label();
            this.lbleBayShippingDetails = new System.Windows.Forms.Label();
            this.pnleBayMisc = new System.Windows.Forms.Panel();
            this.grpBoxeBayMisc = new System.Windows.Forms.GroupBox();
            this.rtxtPaymentInstructions = new System.Windows.Forms.RichTextBox();
            this.cBoxListingDuration = new System.Windows.Forms.ComboBox();
            this.lblListingDuration = new System.Windows.Forms.Label();
            this.lblPaymentInstructions = new System.Windows.Forms.Label();
            this.lbleBayMisc = new System.Windows.Forms.Label();
            this.pnleBay.SuspendLayout();
            this.grpBoxeBayAuth.SuspendLayout();
            this.pnlMySQL.SuspendLayout();
            this.grpBoxMySQL.SuspendLayout();
            this.grpBoxApply.SuspendLayout();
            this.pnlFTP.SuspendLayout();
            this.grpBoxFTP.SuspendLayout();
            this.pnleBayGeneral.SuspendLayout();
            this.grpBoxeBayGeneral.SuspendLayout();
            this.pnleBayReturnPolicy.SuspendLayout();
            this.grpBoxeBayReturnPolicy.SuspendLayout();
            this.pnleBayShippingDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnleBayMisc.SuspendLayout();
            this.grpBoxeBayMisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnleBay
            // 
            this.pnleBay.Controls.Add(this.grpBoxeBayAuth);
            this.pnleBay.Controls.Add(this.lbleBayAuthSettings);
            this.pnleBay.Location = new System.Drawing.Point(138, 14);
            this.pnleBay.Name = "pnleBay";
            this.pnleBay.Size = new System.Drawing.Size(405, 288);
            this.pnleBay.TabIndex = 1;
            this.pnleBay.Visible = false;
            // 
            // grpBoxeBayAuth
            // 
            this.grpBoxeBayAuth.Controls.Add(this.rtxtBoxuserToken);
            this.grpBoxeBayAuth.Controls.Add(this.lblUserToken);
            this.grpBoxeBayAuth.Controls.Add(this.txtCertId);
            this.grpBoxeBayAuth.Controls.Add(this.lblCertId);
            this.grpBoxeBayAuth.Controls.Add(this.txtDevId);
            this.grpBoxeBayAuth.Controls.Add(this.lblDevId);
            this.grpBoxeBayAuth.Controls.Add(this.lblAppId);
            this.grpBoxeBayAuth.Controls.Add(this.txtAppId);
            this.grpBoxeBayAuth.Location = new System.Drawing.Point(17, 31);
            this.grpBoxeBayAuth.Name = "grpBoxeBayAuth";
            this.grpBoxeBayAuth.Size = new System.Drawing.Size(376, 242);
            this.grpBoxeBayAuth.TabIndex = 3;
            this.grpBoxeBayAuth.TabStop = false;
            // 
            // rtxtBoxuserToken
            // 
            this.rtxtBoxuserToken.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "userToken", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rtxtBoxuserToken.Location = new System.Drawing.Point(80, 107);
            this.rtxtBoxuserToken.Name = "rtxtBoxuserToken";
            this.rtxtBoxuserToken.Size = new System.Drawing.Size(279, 117);
            this.rtxtBoxuserToken.TabIndex = 3;
            this.rtxtBoxuserToken.Text = global::eBayLister.UserSettings.Default.userToken;
            // 
            // lblUserToken
            // 
            this.lblUserToken.AutoSize = true;
            this.lblUserToken.Location = new System.Drawing.Point(11, 110);
            this.lblUserToken.Name = "lblUserToken";
            this.lblUserToken.Size = new System.Drawing.Size(63, 13);
            this.lblUserToken.TabIndex = 7;
            this.lblUserToken.Text = "User Token";
            // 
            // txtCertId
            // 
            this.txtCertId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "certId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCertId.Location = new System.Drawing.Point(80, 78);
            this.txtCertId.Name = "txtCertId";
            this.txtCertId.Size = new System.Drawing.Size(279, 20);
            this.txtCertId.TabIndex = 2;
            this.txtCertId.Text = global::eBayLister.UserSettings.Default.certId;
            // 
            // lblCertId
            // 
            this.lblCertId.AutoSize = true;
            this.lblCertId.Location = new System.Drawing.Point(11, 81);
            this.lblCertId.Name = "lblCertId";
            this.lblCertId.Size = new System.Drawing.Size(37, 13);
            this.lblCertId.TabIndex = 5;
            this.lblCertId.Text = "CertID";
            // 
            // txtDevId
            // 
            this.txtDevId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "devId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDevId.Location = new System.Drawing.Point(80, 18);
            this.txtDevId.Name = "txtDevId";
            this.txtDevId.Size = new System.Drawing.Size(279, 20);
            this.txtDevId.TabIndex = 0;
            this.txtDevId.Text = global::eBayLister.UserSettings.Default.devId;
            // 
            // lblDevId
            // 
            this.lblDevId.AutoSize = true;
            this.lblDevId.Location = new System.Drawing.Point(11, 21);
            this.lblDevId.Name = "lblDevId";
            this.lblDevId.Size = new System.Drawing.Size(38, 13);
            this.lblDevId.TabIndex = 3;
            this.lblDevId.Text = "DevID";
            // 
            // lblAppId
            // 
            this.lblAppId.AutoSize = true;
            this.lblAppId.Location = new System.Drawing.Point(11, 51);
            this.lblAppId.Name = "lblAppId";
            this.lblAppId.Size = new System.Drawing.Size(37, 13);
            this.lblAppId.TabIndex = 1;
            this.lblAppId.Text = "AppID";
            // 
            // txtAppId
            // 
            this.txtAppId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "appId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtAppId.Location = new System.Drawing.Point(80, 48);
            this.txtAppId.Name = "txtAppId";
            this.txtAppId.Size = new System.Drawing.Size(279, 20);
            this.txtAppId.TabIndex = 1;
            this.txtAppId.Text = global::eBayLister.UserSettings.Default.appId;
            // 
            // lbleBayAuthSettings
            // 
            this.lbleBayAuthSettings.AutoSize = true;
            this.lbleBayAuthSettings.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbleBayAuthSettings.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleBayAuthSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbleBayAuthSettings.Location = new System.Drawing.Point(14, 12);
            this.lbleBayAuthSettings.MinimumSize = new System.Drawing.Size(376, 0);
            this.lbleBayAuthSettings.Name = "lbleBayAuthSettings";
            this.lbleBayAuthSettings.Size = new System.Drawing.Size(376, 16);
            this.lbleBayAuthSettings.TabIndex = 0;
            this.lbleBayAuthSettings.Text = "eBay - Authentication";
            this.lbleBayAuthSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMySQL
            // 
            this.pnlMySQL.Controls.Add(this.grpBoxMySQL);
            this.pnlMySQL.Controls.Add(this.lblMySQL);
            this.pnlMySQL.Location = new System.Drawing.Point(138, 14);
            this.pnlMySQL.Name = "pnlMySQL";
            this.pnlMySQL.Size = new System.Drawing.Size(408, 288);
            this.pnlMySQL.TabIndex = 4;
            this.pnlMySQL.Visible = false;
            // 
            // grpBoxMySQL
            // 
            this.grpBoxMySQL.Controls.Add(this.btnTestMySQLConnection);
            this.grpBoxMySQL.Controls.Add(this.txtDatabase);
            this.grpBoxMySQL.Controls.Add(this.lblDatabase);
            this.grpBoxMySQL.Controls.Add(this.lblPassword);
            this.grpBoxMySQL.Controls.Add(this.txtPassword);
            this.grpBoxMySQL.Controls.Add(this.txtUsername);
            this.grpBoxMySQL.Controls.Add(this.lblUsername);
            this.grpBoxMySQL.Controls.Add(this.lblHost);
            this.grpBoxMySQL.Controls.Add(this.txtHost);
            this.grpBoxMySQL.Location = new System.Drawing.Point(17, 32);
            this.grpBoxMySQL.Name = "grpBoxMySQL";
            this.grpBoxMySQL.Size = new System.Drawing.Size(376, 189);
            this.grpBoxMySQL.TabIndex = 3;
            this.grpBoxMySQL.TabStop = false;
            // 
            // btnTestMySQLConnection
            // 
            this.btnTestMySQLConnection.Location = new System.Drawing.Point(80, 139);
            this.btnTestMySQLConnection.Name = "btnTestMySQLConnection";
            this.btnTestMySQLConnection.Size = new System.Drawing.Size(140, 23);
            this.btnTestMySQLConnection.TabIndex = 4;
            this.btnTestMySQLConnection.Text = "&Test Connection";
            this.btnTestMySQLConnection.UseVisualStyleBackColor = true;
            this.btnTestMySQLConnection.Click += new System.EventHandler(this.btnTestMySQLConnection_Click);
            // 
            // txtDatabase
            // 
            this.txtDatabase.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "MySQLDatabase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDatabase.Location = new System.Drawing.Point(80, 100);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(140, 20);
            this.txtDatabase.TabIndex = 3;
            this.txtDatabase.Text = global::eBayLister.UserSettings.Default.MySQLDatabase;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(15, 103);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblDatabase.TabIndex = 7;
            this.lblDatabase.Text = "Database";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(15, 77);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "MySQLPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPassword.Location = new System.Drawing.Point(80, 74);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(140, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = global::eBayLister.UserSettings.Default.MySQLPassword;
            // 
            // txtUsername
            // 
            this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "MySQLUsername", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtUsername.Location = new System.Drawing.Point(80, 48);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(140, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = global::eBayLister.UserSettings.Default.MySQLUsername;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(15, 51);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(15, 25);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(29, 13);
            this.lblHost.TabIndex = 1;
            this.lblHost.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "MySQLHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtHost.Location = new System.Drawing.Point(80, 22);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(140, 20);
            this.txtHost.TabIndex = 0;
            this.txtHost.Text = global::eBayLister.UserSettings.Default.MySQLHost;
            // 
            // lblMySQL
            // 
            this.lblMySQL.AutoSize = true;
            this.lblMySQL.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblMySQL.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySQL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMySQL.Location = new System.Drawing.Point(17, 11);
            this.lblMySQL.MinimumSize = new System.Drawing.Size(376, 0);
            this.lblMySQL.Name = "lblMySQL";
            this.lblMySQL.Size = new System.Drawing.Size(376, 16);
            this.lblMySQL.TabIndex = 0;
            this.lblMySQL.Text = "MySQL";
            this.lblMySQL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // treeViewConfig
            // 
            this.treeViewConfig.Location = new System.Drawing.Point(12, 14);
            this.treeViewConfig.Name = "treeViewConfig";
            treeNode1.Name = "eBayAuthNode";
            treeNode1.Text = "Authentication";
            treeNode2.Name = "eBayReturnPolicyNode";
            treeNode2.Text = "Return Policy";
            treeNode3.Name = "eBayShippingDetailsNode";
            treeNode3.Text = "Shipping Details";
            treeNode4.Name = "eBayMiscNode";
            treeNode4.Text = "Miscellaneous";
            treeNode5.Name = "eBayNode";
            treeNode5.Text = "eBay";
            treeNode6.Name = "MySQLNode";
            treeNode6.Text = "MySQL";
            treeNode7.Name = "FTPNode";
            treeNode7.Text = "FTP";
            this.treeViewConfig.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.treeViewConfig.Size = new System.Drawing.Size(120, 288);
            this.treeViewConfig.TabIndex = 0;
            this.treeViewConfig.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewConfig_AfterSelect);
            // 
            // grpBoxApply
            // 
            this.grpBoxApply.Controls.Add(this.btnApply);
            this.grpBoxApply.Controls.Add(this.btnCancel);
            this.grpBoxApply.Controls.Add(this.btnOK);
            this.grpBoxApply.Location = new System.Drawing.Point(155, 308);
            this.grpBoxApply.Name = "grpBoxApply";
            this.grpBoxApply.Size = new System.Drawing.Size(376, 48);
            this.grpBoxApply.TabIndex = 3;
            this.grpBoxApply.TabStop = false;
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(245, 15);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(114, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(113, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(18, 15);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(49, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnlFTP
            // 
            this.pnlFTP.Controls.Add(this.grpBoxFTP);
            this.pnlFTP.Controls.Add(this.lblFTP);
            this.pnlFTP.Location = new System.Drawing.Point(138, 14);
            this.pnlFTP.Name = "pnlFTP";
            this.pnlFTP.Size = new System.Drawing.Size(408, 288);
            this.pnlFTP.TabIndex = 5;
            this.pnlFTP.Visible = false;
            // 
            // grpBoxFTP
            // 
            this.grpBoxFTP.Controls.Add(this.txtFTPPollingInterval);
            this.grpBoxFTP.Controls.Add(this.lblFTPPollingInterval);
            this.grpBoxFTP.Controls.Add(this.txtFTPDirectory);
            this.grpBoxFTP.Controls.Add(this.lblFTPDirectory);
            this.grpBoxFTP.Controls.Add(this.btnTestFTPConnection);
            this.grpBoxFTP.Controls.Add(this.txtFileExtn);
            this.grpBoxFTP.Controls.Add(this.lblFileExtn);
            this.grpBoxFTP.Controls.Add(this.lblFTPPassword);
            this.grpBoxFTP.Controls.Add(this.txtFTPPassword);
            this.grpBoxFTP.Controls.Add(this.txtFTPUser);
            this.grpBoxFTP.Controls.Add(this.lblFTPUser);
            this.grpBoxFTP.Controls.Add(this.lblFTPHost);
            this.grpBoxFTP.Controls.Add(this.txtFTPHost);
            this.grpBoxFTP.Location = new System.Drawing.Point(17, 31);
            this.grpBoxFTP.Name = "grpBoxFTP";
            this.grpBoxFTP.Size = new System.Drawing.Size(376, 236);
            this.grpBoxFTP.TabIndex = 3;
            this.grpBoxFTP.TabStop = false;
            // 
            // txtFTPPollingInterval
            // 
            this.txtFTPPollingInterval.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "FTPPollingInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFTPPollingInterval.Location = new System.Drawing.Point(103, 201);
            this.txtFTPPollingInterval.Name = "txtFTPPollingInterval";
            this.txtFTPPollingInterval.Size = new System.Drawing.Size(58, 20);
            this.txtFTPPollingInterval.TabIndex = 6;
            this.txtFTPPollingInterval.Text = global::eBayLister.UserSettings.Default.FTPPollingInterval;
            // 
            // lblFTPPollingInterval
            // 
            this.lblFTPPollingInterval.AutoSize = true;
            this.lblFTPPollingInterval.Location = new System.Drawing.Point(15, 204);
            this.lblFTPPollingInterval.Name = "lblFTPPollingInterval";
            this.lblFTPPollingInterval.Size = new System.Drawing.Size(76, 13);
            this.lblFTPPollingInterval.TabIndex = 12;
            this.lblFTPPollingInterval.Text = "Polling Interval";
            // 
            // txtFTPDirectory
            // 
            this.txtFTPDirectory.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "FTPDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFTPDirectory.Location = new System.Drawing.Point(80, 100);
            this.txtFTPDirectory.Name = "txtFTPDirectory";
            this.txtFTPDirectory.Size = new System.Drawing.Size(140, 20);
            this.txtFTPDirectory.TabIndex = 3;
            this.txtFTPDirectory.Text = global::eBayLister.UserSettings.Default.FTPDir;
            // 
            // lblFTPDirectory
            // 
            this.lblFTPDirectory.AutoSize = true;
            this.lblFTPDirectory.Location = new System.Drawing.Point(15, 103);
            this.lblFTPDirectory.Name = "lblFTPDirectory";
            this.lblFTPDirectory.Size = new System.Drawing.Size(49, 13);
            this.lblFTPDirectory.TabIndex = 10;
            this.lblFTPDirectory.Text = "Directory";
            // 
            // btnTestFTPConnection
            // 
            this.btnTestFTPConnection.Location = new System.Drawing.Point(121, 127);
            this.btnTestFTPConnection.Name = "btnTestFTPConnection";
            this.btnTestFTPConnection.Size = new System.Drawing.Size(99, 23);
            this.btnTestFTPConnection.TabIndex = 4;
            this.btnTestFTPConnection.Text = "&Test Connection";
            this.btnTestFTPConnection.UseVisualStyleBackColor = true;
            this.btnTestFTPConnection.Click += new System.EventHandler(this.btnTestFTPConnection_Click);
            // 
            // txtFileExtn
            // 
            this.txtFileExtn.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "FTPFileExt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFileExtn.Location = new System.Drawing.Point(103, 164);
            this.txtFileExtn.Name = "txtFileExtn";
            this.txtFileExtn.Size = new System.Drawing.Size(58, 20);
            this.txtFileExtn.TabIndex = 5;
            this.txtFileExtn.Text = global::eBayLister.UserSettings.Default.FTPFileExt;
            // 
            // lblFileExtn
            // 
            this.lblFileExtn.AutoSize = true;
            this.lblFileExtn.Location = new System.Drawing.Point(15, 167);
            this.lblFileExtn.Name = "lblFileExtn";
            this.lblFileExtn.Size = new System.Drawing.Size(50, 13);
            this.lblFileExtn.TabIndex = 7;
            this.lblFileExtn.Text = "File Type";
            // 
            // lblFTPPassword
            // 
            this.lblFTPPassword.AutoSize = true;
            this.lblFTPPassword.Location = new System.Drawing.Point(15, 77);
            this.lblFTPPassword.Name = "lblFTPPassword";
            this.lblFTPPassword.Size = new System.Drawing.Size(53, 13);
            this.lblFTPPassword.TabIndex = 6;
            this.lblFTPPassword.Text = "Password";
            // 
            // txtFTPPassword
            // 
            this.txtFTPPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "FTPPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFTPPassword.Location = new System.Drawing.Point(80, 74);
            this.txtFTPPassword.Name = "txtFTPPassword";
            this.txtFTPPassword.PasswordChar = '*';
            this.txtFTPPassword.Size = new System.Drawing.Size(140, 20);
            this.txtFTPPassword.TabIndex = 2;
            this.txtFTPPassword.Text = global::eBayLister.UserSettings.Default.FTPPassword;
            // 
            // txtFTPUser
            // 
            this.txtFTPUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "FTPUsername", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFTPUser.Location = new System.Drawing.Point(80, 48);
            this.txtFTPUser.Name = "txtFTPUser";
            this.txtFTPUser.Size = new System.Drawing.Size(140, 20);
            this.txtFTPUser.TabIndex = 1;
            this.txtFTPUser.Text = global::eBayLister.UserSettings.Default.FTPUsername;
            // 
            // lblFTPUser
            // 
            this.lblFTPUser.AutoSize = true;
            this.lblFTPUser.Location = new System.Drawing.Point(15, 51);
            this.lblFTPUser.Name = "lblFTPUser";
            this.lblFTPUser.Size = new System.Drawing.Size(55, 13);
            this.lblFTPUser.TabIndex = 3;
            this.lblFTPUser.Text = "Username";
            // 
            // lblFTPHost
            // 
            this.lblFTPHost.AutoSize = true;
            this.lblFTPHost.Location = new System.Drawing.Point(15, 25);
            this.lblFTPHost.Name = "lblFTPHost";
            this.lblFTPHost.Size = new System.Drawing.Size(29, 13);
            this.lblFTPHost.TabIndex = 1;
            this.lblFTPHost.Text = "Host";
            // 
            // txtFTPHost
            // 
            this.txtFTPHost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "FTPHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFTPHost.Location = new System.Drawing.Point(80, 22);
            this.txtFTPHost.Name = "txtFTPHost";
            this.txtFTPHost.Size = new System.Drawing.Size(140, 20);
            this.txtFTPHost.TabIndex = 0;
            this.txtFTPHost.Text = global::eBayLister.UserSettings.Default.FTPHost;
            // 
            // lblFTP
            // 
            this.lblFTP.AutoSize = true;
            this.lblFTP.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblFTP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFTP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFTP.Location = new System.Drawing.Point(17, 11);
            this.lblFTP.MinimumSize = new System.Drawing.Size(376, 0);
            this.lblFTP.Name = "lblFTP";
            this.lblFTP.Size = new System.Drawing.Size(376, 16);
            this.lblFTP.TabIndex = 0;
            this.lblFTP.Text = "FTP";
            this.lblFTP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnleBayGeneral
            // 
            this.pnleBayGeneral.Controls.Add(this.grpBoxeBayGeneral);
            this.pnleBayGeneral.Controls.Add(this.lbleBayGeneral);
            this.pnleBayGeneral.Location = new System.Drawing.Point(138, 14);
            this.pnleBayGeneral.Name = "pnleBayGeneral";
            this.pnleBayGeneral.Size = new System.Drawing.Size(405, 288);
            this.pnleBayGeneral.TabIndex = 4;
            this.pnleBayGeneral.Visible = false;
            // 
            // grpBoxeBayGeneral
            // 
            this.grpBoxeBayGeneral.Controls.Add(this.btnGetConversion);
            this.grpBoxeBayGeneral.Controls.Add(this.txtConversionRate);
            this.grpBoxeBayGeneral.Controls.Add(this.lblConversionRate);
            this.grpBoxeBayGeneral.Controls.Add(this.cBoxSite);
            this.grpBoxeBayGeneral.Controls.Add(this.lblSite);
            this.grpBoxeBayGeneral.Controls.Add(this.txtTimeout);
            this.grpBoxeBayGeneral.Controls.Add(this.lblTimeout);
            this.grpBoxeBayGeneral.Controls.Add(this.txtAPIServerURL);
            this.grpBoxeBayGeneral.Controls.Add(this.lblAPIServerURL);
            this.grpBoxeBayGeneral.Controls.Add(this.lblAPIVersion);
            this.grpBoxeBayGeneral.Controls.Add(this.txtAPIVersion);
            this.grpBoxeBayGeneral.Location = new System.Drawing.Point(17, 31);
            this.grpBoxeBayGeneral.Name = "grpBoxeBayGeneral";
            this.grpBoxeBayGeneral.Size = new System.Drawing.Size(376, 242);
            this.grpBoxeBayGeneral.TabIndex = 3;
            this.grpBoxeBayGeneral.TabStop = false;
            // 
            // btnGetConversion
            // 
            this.btnGetConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetConversion.Location = new System.Drawing.Point(148, 134);
            this.btnGetConversion.Name = "btnGetConversion";
            this.btnGetConversion.Size = new System.Drawing.Size(96, 24);
            this.btnGetConversion.TabIndex = 5;
            this.btnGetConversion.Text = "Get from &xe.com";
            this.btnGetConversion.UseVisualStyleBackColor = true;
            this.btnGetConversion.Click += new System.EventHandler(this.btnGetConversion_Click);
            // 
            // txtConversionRate
            // 
            this.txtConversionRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "ConversionRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtConversionRate.Location = new System.Drawing.Point(103, 134);
            this.txtConversionRate.Name = "txtConversionRate";
            this.txtConversionRate.Size = new System.Drawing.Size(39, 20);
            this.txtConversionRate.TabIndex = 4;
            this.txtConversionRate.Text = global::eBayLister.UserSettings.Default.ConversionRate;
            // 
            // lblConversionRate
            // 
            this.lblConversionRate.AutoSize = true;
            this.lblConversionRate.Location = new System.Drawing.Point(11, 137);
            this.lblConversionRate.Name = "lblConversionRate";
            this.lblConversionRate.Size = new System.Drawing.Size(86, 13);
            this.lblConversionRate.TabIndex = 9;
            this.lblConversionRate.Text = "Conversion Rate";
            // 
            // cBoxSite
            // 
            this.cBoxSite.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "Site", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cBoxSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSite.FormattingEnabled = true;
            this.cBoxSite.Items.AddRange(new object[] {
            "India",
            "US"});
            this.cBoxSite.Location = new System.Drawing.Point(103, 107);
            this.cBoxSite.Name = "cBoxSite";
            this.cBoxSite.Size = new System.Drawing.Size(141, 21);
            this.cBoxSite.TabIndex = 3;
            this.cBoxSite.Text = global::eBayLister.UserSettings.Default.Site;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(11, 110);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(25, 13);
            this.lblSite.TabIndex = 7;
            this.lblSite.Text = "Site";
            // 
            // txtTimeout
            // 
            this.txtTimeout.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "Timeout", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTimeout.Location = new System.Drawing.Point(103, 78);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(39, 20);
            this.txtTimeout.TabIndex = 2;
            this.txtTimeout.Text = global::eBayLister.UserSettings.Default.Timeout;
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Location = new System.Drawing.Point(11, 81);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(45, 13);
            this.lblTimeout.TabIndex = 5;
            this.lblTimeout.Text = "Timeout";
            // 
            // txtAPIServerURL
            // 
            this.txtAPIServerURL.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "soapApiServerUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtAPIServerURL.Location = new System.Drawing.Point(103, 18);
            this.txtAPIServerURL.Name = "txtAPIServerURL";
            this.txtAPIServerURL.Size = new System.Drawing.Size(259, 20);
            this.txtAPIServerURL.TabIndex = 0;
            this.txtAPIServerURL.Text = global::eBayLister.UserSettings.Default.soapApiServerUrl;
            // 
            // lblAPIServerURL
            // 
            this.lblAPIServerURL.AutoSize = true;
            this.lblAPIServerURL.Location = new System.Drawing.Point(11, 21);
            this.lblAPIServerURL.Name = "lblAPIServerURL";
            this.lblAPIServerURL.Size = new System.Drawing.Size(83, 13);
            this.lblAPIServerURL.TabIndex = 3;
            this.lblAPIServerURL.Text = "API Server URL";
            // 
            // lblAPIVersion
            // 
            this.lblAPIVersion.AutoSize = true;
            this.lblAPIVersion.Location = new System.Drawing.Point(11, 51);
            this.lblAPIVersion.Name = "lblAPIVersion";
            this.lblAPIVersion.Size = new System.Drawing.Size(62, 13);
            this.lblAPIVersion.TabIndex = 1;
            this.lblAPIVersion.Text = "API Version";
            // 
            // txtAPIVersion
            // 
            this.txtAPIVersion.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "ApiVersion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtAPIVersion.Location = new System.Drawing.Point(103, 49);
            this.txtAPIVersion.Name = "txtAPIVersion";
            this.txtAPIVersion.Size = new System.Drawing.Size(39, 20);
            this.txtAPIVersion.TabIndex = 1;
            this.txtAPIVersion.Text = global::eBayLister.UserSettings.Default.ApiVersion;
            // 
            // lbleBayGeneral
            // 
            this.lbleBayGeneral.AutoSize = true;
            this.lbleBayGeneral.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbleBayGeneral.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleBayGeneral.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbleBayGeneral.Location = new System.Drawing.Point(14, 12);
            this.lbleBayGeneral.MinimumSize = new System.Drawing.Size(376, 0);
            this.lbleBayGeneral.Name = "lbleBayGeneral";
            this.lbleBayGeneral.Size = new System.Drawing.Size(376, 16);
            this.lbleBayGeneral.TabIndex = 0;
            this.lbleBayGeneral.Text = "eBay - General";
            this.lbleBayGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnleBayReturnPolicy
            // 
            this.pnleBayReturnPolicy.Controls.Add(this.cBoxReturns);
            this.pnleBayReturnPolicy.Controls.Add(this.grpBoxeBayReturnPolicy);
            this.pnleBayReturnPolicy.Controls.Add(this.lbleBayReturnPolicy);
            this.pnleBayReturnPolicy.Location = new System.Drawing.Point(138, 14);
            this.pnleBayReturnPolicy.Name = "pnleBayReturnPolicy";
            this.pnleBayReturnPolicy.Size = new System.Drawing.Size(405, 288);
            this.pnleBayReturnPolicy.TabIndex = 4;
            this.pnleBayReturnPolicy.Visible = false;
            // 
            // cBoxReturns
            // 
            this.cBoxReturns.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "Returns", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cBoxReturns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxReturns.FormattingEnabled = true;
            this.cBoxReturns.ItemHeight = 13;
            this.cBoxReturns.Items.AddRange(new object[] {
            "Returns Accepted",
            "Returns Not Accepted"});
            this.cBoxReturns.Location = new System.Drawing.Point(38, 41);
            this.cBoxReturns.Name = "cBoxReturns";
            this.cBoxReturns.Size = new System.Drawing.Size(133, 21);
            this.cBoxReturns.TabIndex = 4;
            this.cBoxReturns.Text = global::eBayLister.UserSettings.Default.Returns;
            this.cBoxReturns.SelectedIndexChanged += new System.EventHandler(this.cBoxReturns_SelectedIndexChanged);
            // 
            // grpBoxeBayReturnPolicy
            // 
            this.grpBoxeBayReturnPolicy.Controls.Add(this.cBoxShippingPaidBy);
            this.grpBoxeBayReturnPolicy.Controls.Add(this.lblReturnShippingPaidBy);
            this.grpBoxeBayReturnPolicy.Controls.Add(this.cBoxRefundAs);
            this.grpBoxeBayReturnPolicy.Controls.Add(this.lblRefundAs);
            this.grpBoxeBayReturnPolicy.Controls.Add(this.cBoxReturnsWithin);
            this.grpBoxeBayReturnPolicy.Controls.Add(this.lblReturnsWithin);
            this.grpBoxeBayReturnPolicy.Controls.Add(this.lblReturnsNotAccepted);
            this.grpBoxeBayReturnPolicy.Location = new System.Drawing.Point(17, 43);
            this.grpBoxeBayReturnPolicy.Name = "grpBoxeBayReturnPolicy";
            this.grpBoxeBayReturnPolicy.Size = new System.Drawing.Size(376, 230);
            this.grpBoxeBayReturnPolicy.TabIndex = 3;
            this.grpBoxeBayReturnPolicy.TabStop = false;
            // 
            // cBoxShippingPaidBy
            // 
            this.cBoxShippingPaidBy.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "returnsShippingCostPaidBy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cBoxShippingPaidBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxShippingPaidBy.FormattingEnabled = true;
            this.cBoxShippingPaidBy.Items.AddRange(new object[] {
            "Buyer",
            "Seller"});
            this.cBoxShippingPaidBy.Location = new System.Drawing.Point(167, 129);
            this.cBoxShippingPaidBy.Name = "cBoxShippingPaidBy";
            this.cBoxShippingPaidBy.Size = new System.Drawing.Size(106, 21);
            this.cBoxShippingPaidBy.TabIndex = 7;
            this.cBoxShippingPaidBy.Text = global::eBayLister.UserSettings.Default.returnsShippingCostPaidBy;
            // 
            // lblReturnShippingPaidBy
            // 
            this.lblReturnShippingPaidBy.AutoSize = true;
            this.lblReturnShippingPaidBy.Location = new System.Drawing.Point(11, 132);
            this.lblReturnShippingPaidBy.Name = "lblReturnShippingPaidBy";
            this.lblReturnShippingPaidBy.Size = new System.Drawing.Size(150, 13);
            this.lblReturnShippingPaidBy.TabIndex = 6;
            this.lblReturnShippingPaidBy.Text = "Return shipping will be paid by";
            // 
            // cBoxRefundAs
            // 
            this.cBoxRefundAs.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "Refund", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cBoxRefundAs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxRefundAs.FormattingEnabled = true;
            this.cBoxRefundAs.Items.AddRange(new object[] {
            "Money Back",
            "Exchange",
            "Merchandise Credit"});
            this.cBoxRefundAs.Location = new System.Drawing.Point(167, 89);
            this.cBoxRefundAs.Name = "cBoxRefundAs";
            this.cBoxRefundAs.Size = new System.Drawing.Size(106, 21);
            this.cBoxRefundAs.TabIndex = 5;
            this.cBoxRefundAs.Text = global::eBayLister.UserSettings.Default.Refund;
            // 
            // lblRefundAs
            // 
            this.lblRefundAs.AutoSize = true;
            this.lblRefundAs.Location = new System.Drawing.Point(11, 91);
            this.lblRefundAs.Name = "lblRefundAs";
            this.lblRefundAs.Size = new System.Drawing.Size(117, 13);
            this.lblRefundAs.TabIndex = 4;
            this.lblRefundAs.Text = "Refund will be given as";
            // 
            // cBoxReturnsWithin
            // 
            this.cBoxReturnsWithin.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "returnsWithin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cBoxReturnsWithin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxReturnsWithin.FormattingEnabled = true;
            this.cBoxReturnsWithin.Items.AddRange(new object[] {
            "7 Days",
            "14 Days",
            "30 Days"});
            this.cBoxReturnsWithin.Location = new System.Drawing.Point(167, 48);
            this.cBoxReturnsWithin.Name = "cBoxReturnsWithin";
            this.cBoxReturnsWithin.Size = new System.Drawing.Size(106, 21);
            this.cBoxReturnsWithin.TabIndex = 3;
            this.cBoxReturnsWithin.Text = global::eBayLister.UserSettings.Default.returnsWithin;
            // 
            // lblReturnsWithin
            // 
            this.lblReturnsWithin.AutoSize = true;
            this.lblReturnsWithin.Location = new System.Drawing.Point(11, 51);
            this.lblReturnsWithin.Name = "lblReturnsWithin";
            this.lblReturnsWithin.Size = new System.Drawing.Size(139, 13);
            this.lblReturnsWithin.TabIndex = 1;
            this.lblReturnsWithin.Text = "Item must be returned within";
            // 
            // lblReturnsNotAccepted
            // 
            this.lblReturnsNotAccepted.Location = new System.Drawing.Point(18, 48);
            this.lblReturnsNotAccepted.Name = "lblReturnsNotAccepted";
            this.lblReturnsNotAccepted.Size = new System.Drawing.Size(341, 90);
            this.lblReturnsNotAccepted.TabIndex = 2;
            this.lblReturnsNotAccepted.Text = "It is OK to not accept returns, but do remember that you are obligated to describ" +
                "e your item accurately.";
            this.lblReturnsNotAccepted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReturnsNotAccepted.Visible = false;
            // 
            // lbleBayReturnPolicy
            // 
            this.lbleBayReturnPolicy.AutoSize = true;
            this.lbleBayReturnPolicy.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbleBayReturnPolicy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleBayReturnPolicy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbleBayReturnPolicy.Location = new System.Drawing.Point(14, 12);
            this.lbleBayReturnPolicy.MinimumSize = new System.Drawing.Size(376, 0);
            this.lbleBayReturnPolicy.Name = "lbleBayReturnPolicy";
            this.lbleBayReturnPolicy.Size = new System.Drawing.Size(376, 16);
            this.lbleBayReturnPolicy.TabIndex = 0;
            this.lbleBayReturnPolicy.Text = "eBay - Return Policy";
            this.lbleBayReturnPolicy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnleBayShippingDetails
            // 
            this.pnleBayShippingDetails.Controls.Add(this.groupBox1);
            this.pnleBayShippingDetails.Controls.Add(this.lbleBayShippingDetails);
            this.pnleBayShippingDetails.Location = new System.Drawing.Point(138, 14);
            this.pnleBayShippingDetails.Name = "pnleBayShippingDetails";
            this.pnleBayShippingDetails.Size = new System.Drawing.Size(408, 288);
            this.pnleBayShippingDetails.TabIndex = 5;
            this.pnleBayShippingDetails.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCityState);
            this.groupBox1.Controls.Add(this.txtPincode);
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.lblCityState);
            this.groupBox1.Controls.Add(this.lblPincode);
            this.groupBox1.Controls.Add(this.lblCountry);
            this.groupBox1.Controls.Add(this.lblItemLocation);
            this.groupBox1.Controls.Add(this.lblUSD);
            this.groupBox1.Controls.Add(this.txtShippingCost);
            this.groupBox1.Controls.Add(this.cBoxHandlingTime);
            this.groupBox1.Controls.Add(this.lblHandlingTime);
            this.groupBox1.Controls.Add(this.lblShippingCost);
            this.groupBox1.Location = new System.Drawing.Point(17, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 232);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtCityState
            // 
            this.txtCityState.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "itemCityState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCityState.Location = new System.Drawing.Point(103, 195);
            this.txtCityState.Name = "txtCityState";
            this.txtCityState.Size = new System.Drawing.Size(119, 20);
            this.txtCityState.TabIndex = 4;
            this.txtCityState.Text = global::eBayLister.UserSettings.Default.itemCityState;
            // 
            // txtPincode
            // 
            this.txtPincode.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "itemPincode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPincode.Location = new System.Drawing.Point(103, 167);
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.Size = new System.Drawing.Size(119, 20);
            this.txtPincode.TabIndex = 3;
            this.txtPincode.Text = global::eBayLister.UserSettings.Default.itemPincode;
            // 
            // txtCountry
            // 
            this.txtCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "itemCountry", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCountry.Location = new System.Drawing.Point(103, 137);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(119, 20);
            this.txtCountry.TabIndex = 2;
            this.txtCountry.Text = global::eBayLister.UserSettings.Default.itemCountry;
            // 
            // lblCityState
            // 
            this.lblCityState.AutoSize = true;
            this.lblCityState.Location = new System.Drawing.Point(15, 198);
            this.lblCityState.Name = "lblCityState";
            this.lblCityState.Size = new System.Drawing.Size(55, 13);
            this.lblCityState.TabIndex = 13;
            this.lblCityState.Text = "City, State";
            // 
            // lblPincode
            // 
            this.lblPincode.AutoSize = true;
            this.lblPincode.Location = new System.Drawing.Point(15, 170);
            this.lblPincode.Name = "lblPincode";
            this.lblPincode.Size = new System.Drawing.Size(46, 13);
            this.lblPincode.TabIndex = 12;
            this.lblPincode.Text = "Pincode";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(15, 140);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 11;
            this.lblCountry.Text = "Country";
            // 
            // lblItemLocation
            // 
            this.lblItemLocation.AutoSize = true;
            this.lblItemLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemLocation.Location = new System.Drawing.Point(15, 107);
            this.lblItemLocation.Name = "lblItemLocation";
            this.lblItemLocation.Size = new System.Drawing.Size(100, 16);
            this.lblItemLocation.TabIndex = 10;
            this.lblItemLocation.Text = "Item Location";
            // 
            // lblUSD
            // 
            this.lblUSD.AutoSize = true;
            this.lblUSD.Location = new System.Drawing.Point(131, 31);
            this.lblUSD.Name = "lblUSD";
            this.lblUSD.Size = new System.Drawing.Size(13, 13);
            this.lblUSD.TabIndex = 9;
            this.lblUSD.Text = "$";
            // 
            // txtShippingCost
            // 
            this.txtShippingCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "shippingCost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtShippingCost.Location = new System.Drawing.Point(103, 27);
            this.txtShippingCost.Name = "txtShippingCost";
            this.txtShippingCost.Size = new System.Drawing.Size(28, 20);
            this.txtShippingCost.TabIndex = 0;
            this.txtShippingCost.Text = global::eBayLister.UserSettings.Default.shippingCost;
            this.txtShippingCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cBoxHandlingTime
            // 
            this.cBoxHandlingTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "handlingTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cBoxHandlingTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxHandlingTime.FormattingEnabled = true;
            this.cBoxHandlingTime.Items.AddRange(new object[] {
            "1 business day",
            "2 business days",
            "3 business days",
            "4 business days",
            "5 business days",
            "10 business days",
            "15 business days",
            "20 business days",
            "30 business days"});
            this.cBoxHandlingTime.Location = new System.Drawing.Point(103, 64);
            this.cBoxHandlingTime.Name = "cBoxHandlingTime";
            this.cBoxHandlingTime.Size = new System.Drawing.Size(106, 21);
            this.cBoxHandlingTime.TabIndex = 1;
            this.cBoxHandlingTime.Text = global::eBayLister.UserSettings.Default.handlingTime;
            // 
            // lblHandlingTime
            // 
            this.lblHandlingTime.AutoSize = true;
            this.lblHandlingTime.Location = new System.Drawing.Point(15, 67);
            this.lblHandlingTime.Name = "lblHandlingTime";
            this.lblHandlingTime.Size = new System.Drawing.Size(75, 13);
            this.lblHandlingTime.TabIndex = 4;
            this.lblHandlingTime.Text = "Handling Time";
            // 
            // lblShippingCost
            // 
            this.lblShippingCost.AutoSize = true;
            this.lblShippingCost.Location = new System.Drawing.Point(15, 33);
            this.lblShippingCost.Name = "lblShippingCost";
            this.lblShippingCost.Size = new System.Drawing.Size(72, 13);
            this.lblShippingCost.TabIndex = 1;
            this.lblShippingCost.Text = "Shipping Cost";
            // 
            // lbleBayShippingDetails
            // 
            this.lbleBayShippingDetails.AutoSize = true;
            this.lbleBayShippingDetails.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbleBayShippingDetails.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleBayShippingDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbleBayShippingDetails.Location = new System.Drawing.Point(14, 12);
            this.lbleBayShippingDetails.MinimumSize = new System.Drawing.Size(376, 0);
            this.lbleBayShippingDetails.Name = "lbleBayShippingDetails";
            this.lbleBayShippingDetails.Size = new System.Drawing.Size(376, 16);
            this.lbleBayShippingDetails.TabIndex = 0;
            this.lbleBayShippingDetails.Text = "eBay - Shipping Details";
            this.lbleBayShippingDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnleBayMisc
            // 
            this.pnleBayMisc.Controls.Add(this.grpBoxeBayMisc);
            this.pnleBayMisc.Controls.Add(this.lbleBayMisc);
            this.pnleBayMisc.Location = new System.Drawing.Point(138, 14);
            this.pnleBayMisc.Name = "pnleBayMisc";
            this.pnleBayMisc.Size = new System.Drawing.Size(405, 288);
            this.pnleBayMisc.TabIndex = 5;
            this.pnleBayMisc.Visible = false;
            // 
            // grpBoxeBayMisc
            // 
            this.grpBoxeBayMisc.Controls.Add(this.rtxtPaymentInstructions);
            this.grpBoxeBayMisc.Controls.Add(this.cBoxListingDuration);
            this.grpBoxeBayMisc.Controls.Add(this.lblListingDuration);
            this.grpBoxeBayMisc.Controls.Add(this.lblPaymentInstructions);
            this.grpBoxeBayMisc.Location = new System.Drawing.Point(17, 31);
            this.grpBoxeBayMisc.Name = "grpBoxeBayMisc";
            this.grpBoxeBayMisc.Size = new System.Drawing.Size(376, 242);
            this.grpBoxeBayMisc.TabIndex = 3;
            this.grpBoxeBayMisc.TabStop = false;
            // 
            // rtxtPaymentInstructions
            // 
            this.rtxtPaymentInstructions.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "paymentInstructions", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rtxtPaymentInstructions.Location = new System.Drawing.Point(14, 107);
            this.rtxtPaymentInstructions.Name = "rtxtPaymentInstructions";
            this.rtxtPaymentInstructions.Size = new System.Drawing.Size(345, 99);
            this.rtxtPaymentInstructions.TabIndex = 6;
            this.rtxtPaymentInstructions.Text = global::eBayLister.UserSettings.Default.paymentInstructions;
            // 
            // cBoxListingDuration
            // 
            this.cBoxListingDuration.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "listingDuration", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cBoxListingDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxListingDuration.FormattingEnabled = true;
            this.cBoxListingDuration.Items.AddRange(new object[] {
            "3 Days",
            "5 Days",
            "7 Days",
            "10 Days (Rs. 2.00)",
            "30 Days (Rs. 3.00)"});
            this.cBoxListingDuration.Location = new System.Drawing.Point(103, 18);
            this.cBoxListingDuration.Name = "cBoxListingDuration";
            this.cBoxListingDuration.Size = new System.Drawing.Size(141, 21);
            this.cBoxListingDuration.TabIndex = 3;
            this.cBoxListingDuration.Text = global::eBayLister.UserSettings.Default.listingDuration;
            // 
            // lblListingDuration
            // 
            this.lblListingDuration.AutoSize = true;
            this.lblListingDuration.Location = new System.Drawing.Point(11, 21);
            this.lblListingDuration.Name = "lblListingDuration";
            this.lblListingDuration.Size = new System.Drawing.Size(80, 13);
            this.lblListingDuration.TabIndex = 3;
            this.lblListingDuration.Text = "Listing Duration";
            // 
            // lblPaymentInstructions
            // 
            this.lblPaymentInstructions.AutoSize = true;
            this.lblPaymentInstructions.Location = new System.Drawing.Point(11, 82);
            this.lblPaymentInstructions.Name = "lblPaymentInstructions";
            this.lblPaymentInstructions.Size = new System.Drawing.Size(104, 13);
            this.lblPaymentInstructions.TabIndex = 1;
            this.lblPaymentInstructions.Text = "Payment instructions";
            // 
            // lbleBayMisc
            // 
            this.lbleBayMisc.AutoSize = true;
            this.lbleBayMisc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbleBayMisc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleBayMisc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbleBayMisc.Location = new System.Drawing.Point(14, 12);
            this.lbleBayMisc.MinimumSize = new System.Drawing.Size(376, 0);
            this.lbleBayMisc.Name = "lbleBayMisc";
            this.lbleBayMisc.Size = new System.Drawing.Size(376, 16);
            this.lbleBayMisc.TabIndex = 0;
            this.lbleBayMisc.Text = "eBay - Miscellaneous";
            this.lbleBayMisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 372);
            this.Controls.Add(this.pnleBayGeneral);
            this.Controls.Add(this.pnlMySQL);
            this.Controls.Add(this.grpBoxApply);
            this.Controls.Add(this.treeViewConfig);
            this.Controls.Add(this.pnleBayReturnPolicy);
            this.Controls.Add(this.pnleBayShippingDetails);
            this.Controls.Add(this.pnleBay);
            this.Controls.Add(this.pnlFTP);
            this.Controls.Add(this.pnleBayMisc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.pnleBay.ResumeLayout(false);
            this.pnleBay.PerformLayout();
            this.grpBoxeBayAuth.ResumeLayout(false);
            this.grpBoxeBayAuth.PerformLayout();
            this.pnlMySQL.ResumeLayout(false);
            this.pnlMySQL.PerformLayout();
            this.grpBoxMySQL.ResumeLayout(false);
            this.grpBoxMySQL.PerformLayout();
            this.grpBoxApply.ResumeLayout(false);
            this.pnlFTP.ResumeLayout(false);
            this.pnlFTP.PerformLayout();
            this.grpBoxFTP.ResumeLayout(false);
            this.grpBoxFTP.PerformLayout();
            this.pnleBayGeneral.ResumeLayout(false);
            this.pnleBayGeneral.PerformLayout();
            this.grpBoxeBayGeneral.ResumeLayout(false);
            this.grpBoxeBayGeneral.PerformLayout();
            this.pnleBayReturnPolicy.ResumeLayout(false);
            this.pnleBayReturnPolicy.PerformLayout();
            this.grpBoxeBayReturnPolicy.ResumeLayout(false);
            this.grpBoxeBayReturnPolicy.PerformLayout();
            this.pnleBayShippingDetails.ResumeLayout(false);
            this.pnleBayShippingDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnleBayMisc.ResumeLayout(false);
            this.pnleBayMisc.PerformLayout();
            this.grpBoxeBayMisc.ResumeLayout(false);
            this.grpBoxeBayMisc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnleBay;
        private System.Windows.Forms.Label lbleBayAuthSettings;
        private System.Windows.Forms.Label lblAppId;
        private System.Windows.Forms.TextBox txtAppId;
        private System.Windows.Forms.TreeView treeViewConfig;
        private System.Windows.Forms.GroupBox grpBoxeBayAuth;
        private System.Windows.Forms.GroupBox grpBoxApply;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlMySQL;
        private System.Windows.Forms.GroupBox grpBoxMySQL;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblMySQL;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Button btnTestMySQLConnection;
        private System.Windows.Forms.TextBox txtDevId;
        private System.Windows.Forms.Label lblDevId;
        private System.Windows.Forms.TextBox txtCertId;
        private System.Windows.Forms.Label lblCertId;
        private System.Windows.Forms.Label lblUserToken;
        private System.Windows.Forms.Panel pnlFTP;
        private System.Windows.Forms.GroupBox grpBoxFTP;
        private System.Windows.Forms.Button btnTestFTPConnection;
        private System.Windows.Forms.TextBox txtFileExtn;
        private System.Windows.Forms.Label lblFileExtn;
        private System.Windows.Forms.Label lblFTPPassword;
        private System.Windows.Forms.TextBox txtFTPPassword;
        private System.Windows.Forms.TextBox txtFTPUser;
        private System.Windows.Forms.Label lblFTPUser;
        private System.Windows.Forms.Label lblFTPHost;
        private System.Windows.Forms.TextBox txtFTPHost;
        private System.Windows.Forms.Label lblFTP;
        private System.Windows.Forms.Panel pnleBayGeneral;
        private System.Windows.Forms.GroupBox grpBoxeBayGeneral;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.TextBox txtAPIServerURL;
        private System.Windows.Forms.Label lblAPIServerURL;
        private System.Windows.Forms.Label lblAPIVersion;
        private System.Windows.Forms.TextBox txtAPIVersion;
        private System.Windows.Forms.Label lbleBayGeneral;
        private System.Windows.Forms.ComboBox cBoxSite;
        private System.Windows.Forms.TextBox txtConversionRate;
        private System.Windows.Forms.Label lblConversionRate;
        private System.Windows.Forms.Button btnGetConversion;
        private System.Windows.Forms.RichTextBox rtxtBoxuserToken;
        private System.Windows.Forms.Panel pnleBayReturnPolicy;
        private System.Windows.Forms.GroupBox grpBoxeBayReturnPolicy;
        private System.Windows.Forms.Label lblReturnsWithin;
        private System.Windows.Forms.Label lbleBayReturnPolicy;
        private System.Windows.Forms.ComboBox cBoxReturns;
        private System.Windows.Forms.Label lblReturnsNotAccepted;
        private System.Windows.Forms.ComboBox cBoxReturnsWithin;
        private System.Windows.Forms.Label lblRefundAs;
        private System.Windows.Forms.ComboBox cBoxRefundAs;
        private System.Windows.Forms.Label lblReturnShippingPaidBy;
        private System.Windows.Forms.ComboBox cBoxShippingPaidBy;
        private System.Windows.Forms.Panel pnleBayShippingDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxHandlingTime;
        private System.Windows.Forms.Label lblHandlingTime;
        private System.Windows.Forms.Label lblShippingCost;
        private System.Windows.Forms.Label lbleBayShippingDetails;
        private System.Windows.Forms.Label lblUSD;
        private System.Windows.Forms.TextBox txtShippingCost;
        private System.Windows.Forms.Label lblItemLocation;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPincode;
        private System.Windows.Forms.Label lblCityState;
        private System.Windows.Forms.TextBox txtCityState;
        private System.Windows.Forms.TextBox txtPincode;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtFTPDirectory;
        private System.Windows.Forms.Label lblFTPDirectory;
        private System.Windows.Forms.Label lblFTPPollingInterval;
        private System.Windows.Forms.TextBox txtFTPPollingInterval;
        private System.Windows.Forms.Panel pnleBayMisc;
        private System.Windows.Forms.GroupBox grpBoxeBayMisc;
        private System.Windows.Forms.ComboBox cBoxListingDuration;
        private System.Windows.Forms.Label lblListingDuration;
        private System.Windows.Forms.Label lblPaymentInstructions;
        private System.Windows.Forms.Label lbleBayMisc;
        private System.Windows.Forms.RichTextBox rtxtPaymentInstructions;
    }
}