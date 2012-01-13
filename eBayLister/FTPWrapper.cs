using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace eBayLister
{
    class FTPWrapper
    {
        private event dChangeStatus changeStatus;
        private event dChangeStatus addLogStatus;
        public FTPWrapper() {
            this.changeStatus += new dChangeStatus(eBayLister.Program.mainForm.changeStatus);
            this.addLogStatus += new dChangeStatus(eBayLister.Program.mainForm.addLogStatus);
        }

        public static void testFTP(string host,string username,string password,string dir){
            StringBuilder result = new StringBuilder();
            FtpWebRequest reqFTP;
            FtpWebResponse response = null;
            try {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + host + "/" + dir));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(username, password);
                reqFTP.Method = WebRequestMethods.Ftp.PrintWorkingDirectory;
                reqFTP.KeepAlive = false;
                response = (FtpWebResponse)reqFTP.GetResponse();
                if (response.StatusDescription.Contains(dir))
                    MessageBox.Show("Connection Test Succeeded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                response.Close();
            }
            catch (WebException ex) {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                    MessageBox.Show("Error establishing connection\r\nPlease check Username/Password and Directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadDataFromFTP() {
            string[] fileList = null;
            MySQLWrapper s;
            try
            {
                fileList = getFileList();
                if (fileList != null)
                {
                    s = new MySQLWrapper();
                    foreach (String fileName in fileList)
                    {
                        downloadFile(fileName);
                        deleteFile(fileName);
                        s.loadDataFromFile(fileName);
                    }
                    s.destroy();
                    changeStatus("Done!");
                    addLogStatus("Done!");
                }
                else {
                    addLogStatus("No valid files found at FTP!");
                }
            }
            catch (Exception ex)
            {
                addLogStatus("ERROR : " + ex.Message);
            }
        }

        private string[] getFileList() {
            StringBuilder result = new StringBuilder();
            string[] fileList = null;
            FtpWebRequest reqFTP;
            FtpWebResponse response = null;
            try
            {
                changeStatus("Connecting to " + eBayLister.UserSettings.Default.FTPHost + " ...");
                addLogStatus("Connecting to " + eBayLister.UserSettings.Default.FTPHost + " ...");
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + 
                                        eBayLister.UserSettings.Default.FTPHost +
                                        "/" + eBayLister.UserSettings.Default.FTPDir + "/"));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(eBayLister.UserSettings.Default.FTPUsername
                                                        , eBayLister.UserSettings.Default.FTPPassword);
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                reqFTP.KeepAlive = false;
                response = (FtpWebResponse)reqFTP.GetResponse();
                changeStatus("Retrieving file list ...");
                addLogStatus("Retrieving file list ...");
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string line = reader.ReadLine();                
                while (line != null)
                {
                    if (line.Contains(eBayLister.UserSettings.Default.FTPFileExt))
                    {
                        result.Append(line);
                        result.Append("\n");
                    }
                    line = reader.ReadLine();
                }              
                reader.Close();
                response.Close();
                if (result.Length != 0)
                {
                    result.Remove(result.ToString().LastIndexOf('\n'), 1);
                    fileList = result.ToString().Split('\n');
                    addLogStatus("File(s) retrieved : " + String.Join(", ",fileList));
                }               
                return fileList;
            }
            catch (WebException ex) {
                string[] nullString = null;
                if (ex.Status == WebExceptionStatus.ProtocolError)
                    addLogStatus("ERROR : Error establishing connection");
                else
                    addLogStatus("ERROR : " + ex.Message);
                return nullString;
            }
        }

       

        private void downloadFile(string fileName)
        {
            FtpWebRequest reqFTP;
            try
            {
                changeStatus("Downloading file " + fileName + " ...");
                addLogStatus("Downloading file " + fileName + " ...");
                if (!Directory.Exists("./eBayDataFiles/"))
                    Directory.CreateDirectory("./eBayDataFiles/");
                FileStream outputStream = new FileStream("./eBayDataFiles/" + fileName, FileMode.Create);
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" +
                                        eBayLister.UserSettings.Default.FTPHost +
                                        "/" + eBayLister.UserSettings.Default.FTPDir + "/" + fileName));
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(eBayLister.UserSettings.Default.FTPUsername
                                                        , eBayLister.UserSettings.Default.FTPPassword);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];

                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }
                ftpStream.Close();
                outputStream.Close();
                response.Close();
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                    addLogStatus("ERROR : Error establishing connection");
                else
                    addLogStatus("ERROR : " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteFile(string fileName)
        {
            FtpWebRequest reqFTP;
            try
            {
                changeStatus("Deleting file " + fileName + " from FTP...");
                addLogStatus("Deleting file " + fileName + " from FTP...");
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" +
                                        eBayLister.UserSettings.Default.FTPHost +
                                        "/" + eBayLister.UserSettings.Default.FTPDir + "/" + fileName));
                reqFTP.Method = WebRequestMethods.Ftp.DeleteFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(eBayLister.UserSettings.Default.FTPUsername
                                                        , eBayLister.UserSettings.Default.FTPPassword);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                addLogStatus("Delete file status : " + response.StatusDescription.TrimEnd('\n'));
                response.Close();
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                    addLogStatus("ERROR : Error establishing connection");
                else
                    addLogStatus("ERROR : " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}