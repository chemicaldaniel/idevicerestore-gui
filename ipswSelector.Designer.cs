namespace IPSW_Restorer
{
    partial class ipswSelector
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
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("iPhone XS and iPhone XS Max", "XS.png");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("iPhone XR", "XR.png");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("iPhone X", "X.png");
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("iPhone 8 and iPhone 7", "7.png");
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("iPhone 8 Plus and iPhone 7 Plus", "8.png");
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("iPhone 6s", "6s.png");
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem("iPhone 6s Plus", 4);
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem("iPhone SE", "se.png");
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem("iPod Touch (7th Generation)", "ipod.png");
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem("iPad Pro (3rd Generation/2018)", "pro3.png");
            System.Windows.Forms.ListViewItem listViewItem30 = new System.Windows.Forms.ListViewItem("iPad Pro (2nd Generation/2017)", "pro2.png");
            System.Windows.Forms.ListViewItem listViewItem31 = new System.Windows.Forms.ListViewItem("iPad Pro 9.7 (1st Generation)", "pro.png");
            System.Windows.Forms.ListViewItem listViewItem32 = new System.Windows.Forms.ListViewItem("iPad Pro 12.9 (1st Generation)", "pro.png");
            System.Windows.Forms.ListViewItem listViewItem33 = new System.Windows.Forms.ListViewItem("iPad Mini (5th Generation)", "mini.png");
            System.Windows.Forms.ListViewItem listViewItem34 = new System.Windows.Forms.ListViewItem("iPad Air (3rd Generation)", "air.png");
            System.Windows.Forms.ListViewItem listViewItem35 = new System.Windows.Forms.ListViewItem("iPad (6th Generation)", "ipad.png");
            System.Windows.Forms.ListViewItem listViewItem36 = new System.Windows.Forms.ListViewItem("iPad (5th Generation)", "ipad.png");
            System.Windows.Forms.ListViewItem listViewItem37 = new System.Windows.Forms.ListViewItem("iPad Mini 4", "mini.png");
            System.Windows.Forms.ListViewItem listViewItem38 = new System.Windows.Forms.ListViewItem("iPad Air 2", "air.png");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ipswSelector));
            this.deviceList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iOSDevices = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceList
            // 
            this.deviceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.deviceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceList.HideSelection = false;
            listViewItem29.Tag = "";
            this.deviceList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24,
            listViewItem25,
            listViewItem26,
            listViewItem27,
            listViewItem28,
            listViewItem29,
            listViewItem30,
            listViewItem31,
            listViewItem32,
            listViewItem33,
            listViewItem34,
            listViewItem35,
            listViewItem36,
            listViewItem37,
            listViewItem38});
            this.deviceList.LargeImageList = this.iOSDevices;
            this.deviceList.Location = new System.Drawing.Point(0, 0);
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(628, 704);
            this.deviceList.TabIndex = 0;
            this.deviceList.UseCompatibleStateImageBehavior = false;
            this.deviceList.SelectedIndexChanged += new System.EventHandler(this.deviceList_SelectedIndexChanged);
            this.deviceList.DoubleClick += new System.EventHandler(this.deviceList_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 497;
            // 
            // iOSDevices
            // 
            this.iOSDevices.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iOSDevices.ImageStream")));
            this.iOSDevices.TransparentColor = System.Drawing.Color.Transparent;
            this.iOSDevices.Images.SetKeyName(0, "mini.png");
            this.iOSDevices.Images.SetKeyName(1, "pro.png");
            this.iOSDevices.Images.SetKeyName(2, "pro2.png");
            this.iOSDevices.Images.SetKeyName(3, "pro3.png");
            this.iOSDevices.Images.SetKeyName(4, "6s.png");
            this.iOSDevices.Images.SetKeyName(5, "se.png");
            this.iOSDevices.Images.SetKeyName(6, "ipod.png");
            this.iOSDevices.Images.SetKeyName(7, "air.png");
            this.iOSDevices.Images.SetKeyName(8, "ipad.png");
            this.iOSDevices.Images.SetKeyName(9, "X.png");
            this.iOSDevices.Images.SetKeyName(10, "XR.png");
            this.iOSDevices.Images.SetKeyName(11, "XS.png");
            this.iOSDevices.Images.SetKeyName(12, "8.png");
            this.iOSDevices.Images.SetKeyName(13, "7.png");
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 674);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(628, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 24);
            this.toolStripProgressBar1.Click += new System.EventHandler(this.toolStripProgressBar1_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(111, 25);
            this.toolStripStatusLabel1.Text = "0 MB / 0 MB";
            // 
            // ipswSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 704);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.deviceList);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ipswSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select your Device";
            this.Load += new System.EventHandler(this.ipswSelector_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView deviceList;
        private System.Windows.Forms.ImageList iOSDevices;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}