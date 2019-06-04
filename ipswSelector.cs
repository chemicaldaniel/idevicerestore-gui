using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

using System.Diagnostics;
namespace IPSW_Restorer
{
    public partial class ipswSelector : Form
    {
        public ipswSelector()
        {
            InitializeComponent();
        }

        private void deviceList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deviceList_DoubleClick(object sender, EventArgs e)
        {
            if (deviceList.SelectedItems.Count == 1)
            {
                downloadFunction(deviceList.SelectedItems[0].Text);
            }
        }
        WebClient client = new WebClient();
        public void downloadFunction(string device)
        {
            string[] iDeviceList = new string[] { "iPhone XS and iPhone XS Max", "iPhone XR","iPhone X", "iPhone 8 and iPhone 7", "iPhone 8 Plus and iPhone 7 Plus", "iPhone 6s", "iPhone 6s Plus", "iPhone SE", "iPod Touch (7th Generation)", "iPad Pro (3rd Generation/2018)", "iPad Pro (2nd Generation/2017)", "iPad Pro 9.7 (1st Generation)", "iPad Pro 12.9 (1st Generation)", "iPad Mini (5th Generation)", "iPad Air (3rd Generation)", "iPad (6th Generation)", "iPad (5th Generation)", "iPad Air 2", "iPad Mini 4" };
            string[] ipswList = new string[] { "https://static.udidregistrations.com/betas/iPhone112iPhone116_13.0_17A5492t_Restore.ipsw", "https://static.udidregistrations.com/betas/iPhone118_13.0_17A5492t_Restore.ipsw", "https://static.udidregistrations.com/betas/iPhone103iPhone106_13.0_17A5492t_Restore.ipsw", "https://static.udidregistrations.com/betas/iPhone_4.7_P3_13.0_17A5492t_Restore.ipsw", "https://static.udidregistrations.com/betas/iPhone_5.5_P3_13.0_17A5492t_Restore.ipsw", "https://static.udidregistrations.com/betas/iPhone_4.7_13.0_17A5492t_Restore.ipsw", "https://static.udidregistrations.com/betas/iPhone_5.5_13.0_17A5492t_Restore.ipsw", "https://static.udidregistrations.com/betas/iPhone_4.0_64bit_13.0_17A5492t_Restore.ipsw", "https://static.udidregistrations.com/betas/iPodtouch_13.0_17A5492t_Restore.ipsw", "https://static.udidregistrations.com/betas/iPad_Fall_2018_13.0_17A5492t_Restore.ipsw", "https://static.udidregistrations.com/betas/iPad_Pro_HFR_13.0_17A5492t_Restore.ipsw", "https://static.udidregistrations.com/betas/iPadPro_9.7_13.0_17A5492t_Restore.ipsw", "https://static.udidregistrations.com/betas/iPadPro_12.9_13.0_17A5492t_Restore.ipsw", "https://static.udidregistrations.com/betas/iPad_Spring_2019_13.0_17A5492t_Restore.ipsw", "https://static.udidregistrations.com/betas/iPad_Spring_2019_13.0_17A5492t_Restore.ipsw", "https://static.udidregistrations.com/betas/iPad_64bit_TouchID_ASTC_13.0_17A5492t_Restore.ipsw", "https://static.udidregistrations.com/betas/iPad_64bit_TouchID_ASTC_13.0_17A5492t_Restore.ipsw", "https://static.udidregistrations.com/betas/iPad_64bit_TouchID_13.0_17A5492t_Restore.ipsw", "https://static.udidregistrations.com/betas/iPad_64bit_TouchID_13.0_17A5492t_Restore.ipsw" };
            int index = Array.IndexOf(iDeviceList, device);
            MessageBox.Show("Will start downloading iPSW for Device (" + iDeviceList[index] + ")" );
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
            client.DownloadFileAsync(new Uri(ipswList[index]), Application.StartupPath + @"\ipsw.ipsw");
            deviceList.Enabled = false;
            Application.UseWaitCursor = true;
        }

        void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                toolStripStatusLabel1.Text = "Cleaning up...";
                toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
                System.IO.File.Delete(Application.StartupPath + @"\ipsw.ipsw");
                client.Dispose();
                toolStripStatusLabel1.Text = "0 MB / 0 MB";
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
                Application.UseWaitCursor = false;
                MessageBox.Show("Download Cancelled.", "iDeviceRestore GUI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                deviceList.Enabled = true;
                return;
            }
            else
            {
                toolStripProgressBar1.Value = 0;
                toolStripStatusLabel1.Text = "0 MB / 0 MB";
                Application.UseWaitCursor = false;
                if (MessageBox.Show("Download has completed! Would you like to upgrade a device that is currently plugged in now? (Click NO if you want to fully restore or use custom arguments)", "iDeviceRestore GUI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    var process = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = "idevicerestore.exe",
                            Arguments = "-d " + (Application.StartupPath + @"\ipsw.ipsw")
                        }
                    };
                }
                else
                {
                    this.Close();
                }
                
            }
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Maximum = (int)((long)e.TotalBytesToReceive / 100);
            toolStripProgressBar1.Value = (int)((long)e.BytesReceived / 100);
            toolStripStatusLabel1.Text = (((long)e.BytesReceived/1024f/1024f).ToString("0000.00") + @" MB / " + ((long)e.TotalBytesToReceive / 1024f/1024f).ToString("0000.00") + " MB");
        }

        private void ipswSelector_Load(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to stop this download?","iDeviceRestore GUI",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                client.CancelAsync();
            }
        }
    }
}
