using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace eBayLister
{   
    public partial class frmMain : Form
    {
        private int totaleBayItems;
        public bool listingContinue = true;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfig frmConfig = new frmConfig();
            frmConfig.ShowDialog();
        }

        private void btnGetDataFromFTP_Click(object sender, EventArgs e)
        {
            rtxtStatus.Clear();
            progressBarMain.Style = ProgressBarStyle.Marquee;
            progressBarMain.Visible = true;
            setStatus("=================================================================");
            backgroundWorkerMain.DoWork += new DoWorkEventHandler(backgroundWorkerMain_getDataFromFTP);
            backgroundWorkerMain.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorkerMain_getDataFromFTPCompleted);
            backgroundWorkerMain.RunWorkerAsync();

        }

        void backgroundWorkerMain_getDataFromFTP(object sender, DoWorkEventArgs e)
        {
            FTPWrapper f = new FTPWrapper();
            f.loadDataFromFTP();
        }

        void backgroundWorkerMain_getDataFromFTPCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorkerMain.DoWork -= new DoWorkEventHandler(backgroundWorkerMain_getDataFromFTP);
            backgroundWorkerMain.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(backgroundWorkerMain_getDataFromFTPCompleted);
            progressBarMain.Visible = false;
            lblProgressBarStatus.Text = "";
            setStatus("=================================================================");
        }

        private void btnStartListing_Click(object sender, EventArgs e)
        {
            if (btnStartListing.Text == "&Start Listing")
            {
                listingContinue = true;
                btnStartListing.Text = "&Stop!";
                rtxtStatus.Clear();
                progressBarMain.Value = 0;
                progressBarMain.Style = ProgressBarStyle.Blocks;
                progressBarMain.Visible = true;
                setStatus("=================================================================");
                backgroundWorkerMain.DoWork += new DoWorkEventHandler(backgroundWorkerMain_startListing);
                backgroundWorkerMain.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorkerMain_listingCompleted);
                backgroundWorkerMain.RunWorkerAsync();
            }
            else {
                listingContinue = false;
                btnStartListing.Text = "&Start Listing";
                setStatus("Terminated by user");
            }
        }

        void backgroundWorkerMain_startListing(object sender, DoWorkEventArgs e)
        {
            eBayWrapper eBayWrap = new eBayWrapper();
            eBayWrap.startListing();
        }

        void backgroundWorkerMain_listingCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorkerMain.DoWork -= new DoWorkEventHandler(backgroundWorkerMain_startListing);
            backgroundWorkerMain.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(backgroundWorkerMain_listingCompleted);
            progressBarMain.Visible = false;
            lblProgressBarStatus.Text = "";
            setStatus("=================================================================");
            btnStartListing.Text = "&Start Listing";
        }

        public void progressChanged(string currentItemNo) {
            dChangeStatus d_updateProgress = new dChangeStatus(updateProgress);
            this.Invoke(d_updateProgress, new object[] { currentItemNo });
        }

        private void updateProgress(string currentItemNo) {
            setProgressBarStatus("Processing item " + currentItemNo + "/" + totaleBayItems + "...");
            progressBarMain.Value = (int)(((double)Int32.Parse(currentItemNo) / totaleBayItems) * 100); 
        }

        public void totalItems(string totalNoofItems){
            dChangeStatus d_setTotalItems = new dChangeStatus(setTotalItems);
            this.Invoke(d_setTotalItems, new object[] { totalNoofItems });
        }

        private void setTotalItems(string totalNoofItems) {
            totaleBayItems = Convert.ToInt32(totalNoofItems);
        }

        public void changeStatus(string status) {
            dChangeStatus d_setProgressBarStatus = new dChangeStatus(setProgressBarStatus);
            this.Invoke(d_setProgressBarStatus, new object[] { status });
        }

        private void setProgressBarStatus(string status)
        {
            lblProgressBarStatus.Text = status;
        }

        public void addLogStatus(string status)
        {
            dChangeStatus d_setStatus = new dChangeStatus(setStatus);
            this.Invoke(d_setStatus, new object[] { status });
        }

        private void setStatus(string status)
        {
            status += "\n";
            rtxtStatus.AppendText(status);
        }

        private void cBoxListInCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            eBayLister.UserSettings.Default.Save();
        }

        private void copy_item_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtxtStatus.Text);
        }

        private void btnRelistUnsold_Click(object sender, EventArgs e)
        {
            rtxtStatus.Clear();
            progressBarMain.Style = ProgressBarStyle.Marquee;
            progressBarMain.Visible = true;
            setStatus("=================================================================");
            backgroundWorkerMain.DoWork += new DoWorkEventHandler(backgroundWorkerMain_startRelisting);
            backgroundWorkerMain.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorkerMain_relistingCompleted);
            backgroundWorkerMain.RunWorkerAsync();
        }
       

        void backgroundWorkerMain_startRelisting(object sender, DoWorkEventArgs e)
        {
            eBayWrapper eBayWrap = new eBayWrapper();
            eBayWrap.relistItems();
        }

        void backgroundWorkerMain_relistingCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorkerMain.DoWork -= new DoWorkEventHandler(backgroundWorkerMain_startRelisting);
            backgroundWorkerMain.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(backgroundWorkerMain_relistingCompleted);
            progressBarMain.Visible = false;
            lblProgressBarStatus.Text = "";
            setStatus("=================================================================");
        }
    }
}
