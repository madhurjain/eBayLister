namespace eBayLister
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnConfig = new System.Windows.Forms.Button();
            this.grpBoxStatus = new System.Windows.Forms.GroupBox();
            this.rtxtStatus = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip_log = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copy_item = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.btnGetDataFromFTP = new System.Windows.Forms.Button();
            this.btnStartListing = new System.Windows.Forms.Button();
            this.lblProgressBarStatus = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.backgroundWorkerMain = new System.ComponentModel.BackgroundWorker();
            this.pictureBoxeBayLogo = new System.Windows.Forms.PictureBox();
            this.btnRelistUnsold = new System.Windows.Forms.Button();
            this.cBoxListInCategory = new System.Windows.Forms.ComboBox();
            this.grpBoxStatus.SuspendLayout();
            this.contextMenuStrip_log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxeBayLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.Location = new System.Drawing.Point(537, 228);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(107, 24);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "&Configuration";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // grpBoxStatus
            // 
            this.grpBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxStatus.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxStatus.Controls.Add(this.rtxtStatus);
            this.grpBoxStatus.ForeColor = System.Drawing.Color.White;
            this.grpBoxStatus.Location = new System.Drawing.Point(12, 258);
            this.grpBoxStatus.Name = "grpBoxStatus";
            this.grpBoxStatus.Size = new System.Drawing.Size(650, 165);
            this.grpBoxStatus.TabIndex = 7;
            this.grpBoxStatus.TabStop = false;
            this.grpBoxStatus.Text = "Status";
            // 
            // rtxtStatus
            // 
            this.rtxtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtStatus.ContextMenuStrip = this.contextMenuStrip_log;
            this.rtxtStatus.Location = new System.Drawing.Point(18, 19);
            this.rtxtStatus.Name = "rtxtStatus";
            this.rtxtStatus.Size = new System.Drawing.Size(614, 131);
            this.rtxtStatus.TabIndex = 4;
            this.rtxtStatus.Text = "";
            // 
            // contextMenuStrip_log
            // 
            this.contextMenuStrip_log.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copy_item});
            this.contextMenuStrip_log.Name = "contextMenuStrip_log";
            this.contextMenuStrip_log.Size = new System.Drawing.Size(103, 26);
            // 
            // copy_item
            // 
            this.copy_item.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.copy_item.Name = "copy_item";
            this.copy_item.Size = new System.Drawing.Size(102, 22);
            this.copy_item.Text = "Copy";
            this.copy_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copy_item.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.copy_item.Click += new System.EventHandler(this.copy_item_Click);
            // 
            // progressBarMain
            // 
            this.progressBarMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarMain.Location = new System.Drawing.Point(30, 197);
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(614, 19);
            this.progressBarMain.Step = 1;
            this.progressBarMain.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarMain.TabIndex = 6;
            this.progressBarMain.Visible = false;
            // 
            // btnGetDataFromFTP
            // 
            this.btnGetDataFromFTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGetDataFromFTP.Location = new System.Drawing.Point(30, 143);
            this.btnGetDataFromFTP.Name = "btnGetDataFromFTP";
            this.btnGetDataFromFTP.Size = new System.Drawing.Size(114, 28);
            this.btnGetDataFromFTP.TabIndex = 0;
            this.btnGetDataFromFTP.Text = "&Get Data from FTP";
            this.btnGetDataFromFTP.UseVisualStyleBackColor = true;
            this.btnGetDataFromFTP.Click += new System.EventHandler(this.btnGetDataFromFTP_Click);
            // 
            // btnStartListing
            // 
            this.btnStartListing.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStartListing.Location = new System.Drawing.Point(170, 143);
            this.btnStartListing.Name = "btnStartListing";
            this.btnStartListing.Size = new System.Drawing.Size(114, 28);
            this.btnStartListing.TabIndex = 1;
            this.btnStartListing.Text = "&Start Listing";
            this.btnStartListing.UseVisualStyleBackColor = true;
            this.btnStartListing.Click += new System.EventHandler(this.btnStartListing_Click);
            // 
            // lblProgressBarStatus
            // 
            this.lblProgressBarStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProgressBarStatus.AutoSize = true;
            this.lblProgressBarStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblProgressBarStatus.ForeColor = System.Drawing.Color.White;
            this.lblProgressBarStatus.Location = new System.Drawing.Point(33, 181);
            this.lblProgressBarStatus.Name = "lblProgressBarStatus";
            this.lblProgressBarStatus.Size = new System.Drawing.Size(0, 13);
            this.lblProgressBarStatus.TabIndex = 8;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(313, 151);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(78, 13);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "List in category";
            // 
            // backgroundWorkerMain
            // 
            this.backgroundWorkerMain.WorkerReportsProgress = true;
            this.backgroundWorkerMain.WorkerSupportsCancellation = true;
            // 
            // pictureBoxeBayLogo
            // 
            this.pictureBoxeBayLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxeBayLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxeBayLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxeBayLogo.BackgroundImage")));
            this.pictureBoxeBayLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxeBayLogo.Location = new System.Drawing.Point(36, 12);
            this.pictureBoxeBayLogo.Name = "pictureBoxeBayLogo";
            this.pictureBoxeBayLogo.Size = new System.Drawing.Size(125, 75);
            this.pictureBoxeBayLogo.TabIndex = 3;
            this.pictureBoxeBayLogo.TabStop = false;
            // 
            // btnRelistUnsold
            // 
            this.btnRelistUnsold.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRelistUnsold.Location = new System.Drawing.Point(530, 143);
            this.btnRelistUnsold.Name = "btnRelistUnsold";
            this.btnRelistUnsold.Size = new System.Drawing.Size(114, 28);
            this.btnRelistUnsold.TabIndex = 9;
            this.btnRelistUnsold.Text = "Relist Unsold";
            this.btnRelistUnsold.UseVisualStyleBackColor = true;
            this.btnRelistUnsold.Click += new System.EventHandler(this.btnRelistUnsold_Click);
            // 
            // cBoxListInCategory
            // 
            this.cBoxListInCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cBoxListInCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eBayLister.UserSettings.Default, "ListInCategory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cBoxListInCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxListInCategory.FormattingEnabled = true;
            this.cBoxListInCategory.Items.AddRange(new object[] {
            "Other Books",
            "Test Auctions"});
            this.cBoxListInCategory.Location = new System.Drawing.Point(397, 148);
            this.cBoxListInCategory.Name = "cBoxListInCategory";
            this.cBoxListInCategory.Size = new System.Drawing.Size(107, 21);
            this.cBoxListInCategory.TabIndex = 2;
            this.cBoxListInCategory.Text = global::eBayLister.UserSettings.Default.ListInCategory;
            this.cBoxListInCategory.SelectedIndexChanged += new System.EventHandler(this.cBoxListInCategory_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 435);
            this.Controls.Add(this.cBoxListInCategory);
            this.Controls.Add(this.pictureBoxeBayLogo);
            this.Controls.Add(this.btnRelistUnsold);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblProgressBarStatus);
            this.Controls.Add(this.btnStartListing);
            this.Controls.Add(this.btnGetDataFromFTP);
            this.Controls.Add(this.progressBarMain);
            this.Controls.Add(this.grpBoxStatus);
            this.Controls.Add(this.btnConfig);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "eBay Lister";
            this.grpBoxStatus.ResumeLayout(false);
            this.contextMenuStrip_log.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxeBayLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.GroupBox grpBoxStatus;
        private System.Windows.Forms.RichTextBox rtxtStatus;
        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.Windows.Forms.Button btnGetDataFromFTP;
        private System.Windows.Forms.Button btnStartListing;
        private System.Windows.Forms.Label lblProgressBarStatus;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cBoxListInCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMain;
        private System.Windows.Forms.PictureBox pictureBoxeBayLogo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_log;
        private System.Windows.Forms.ToolStripMenuItem copy_item;
        private System.Windows.Forms.Button btnRelistUnsold;



    }
}

