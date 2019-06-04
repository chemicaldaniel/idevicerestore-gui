using System;
using System.Text;
using System.Diagnostics;

using System.Windows.Forms;

namespace IPSW_Restorer
{
    public partial class MainWindow : Form
    {
        private string ipswFilePath;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            openIPSW.Filter = "IPSW files|*.ipsw;*.zip";
            if(openIPSW.ShowDialog() == DialogResult.OK)
            {
                ipswFilePath = openIPSW.FileName;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder cmd = new StringBuilder();
            // cmd.Append("idevicrestore.exe ");

            // Step 1
            if (ipswFilePath == null)
            {
                MessageBox.Show("No IPSW files selected!", "idevicerestore-gui", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 2


            if(fullyRestore.Checked)
            {
                cmd.Append("-e ");
            }
            cmd.Append("-d ");
            if(ipswFilePath != null)
            {
                cmd.Append(" \"" + ipswFilePath + "\" ");
            }
            if(textBox1.Enabled == true)
            {
                cmd.Append(" " + textBox1.Text);
            }
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "idevicerestore.exe",
                    Arguments = cmd.ToString()
                }
            };
            process.Start();
            process.WaitForExit();

            MessageBox.Show("Process Completed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/BananaProject/idevicerestore-gui/");
        }

        private void btnDwnldIPSW_Click(object sender, EventArgs e)
        {
            ipswSelector ipswSelector = new ipswSelector();
            ipswSelector.ShowDialog();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }
    }
}
