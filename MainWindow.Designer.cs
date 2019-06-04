namespace IPSW_Restorer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.stepOneLabel = new System.Windows.Forms.Label();
            this.fileButton = new System.Windows.Forms.Button();
            this.labelStepTwo = new System.Windows.Forms.Label();
            this.fullyRestore = new System.Windows.Forms.CheckBox();
            this.stepThreeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.openIPSW = new System.Windows.Forms.OpenFileDialog();
            this.btnDwnldIPSW = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // stepOneLabel
            // 
            this.stepOneLabel.AutoSize = true;
            this.stepOneLabel.Location = new System.Drawing.Point(18, 22);
            this.stepOneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stepOneLabel.Name = "stepOneLabel";
            this.stepOneLabel.Size = new System.Drawing.Size(178, 20);
            this.stepOneLabel.TabIndex = 0;
            this.stepOneLabel.Text = "1. Select your .IPSW file";
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(20, 46);
            this.fileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(442, 78);
            this.fileButton.TabIndex = 1;
            this.fileButton.Text = "Open";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // labelStepTwo
            // 
            this.labelStepTwo.AutoSize = true;
            this.labelStepTwo.Location = new System.Drawing.Point(15, 183);
            this.labelStepTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStepTwo.Name = "labelStepTwo";
            this.labelStepTwo.Size = new System.Drawing.Size(127, 20);
            this.labelStepTwo.TabIndex = 2;
            this.labelStepTwo.Text = "2. Select options";
            // 
            // fullyRestore
            // 
            this.fullyRestore.AutoSize = true;
            this.fullyRestore.Location = new System.Drawing.Point(22, 208);
            this.fullyRestore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fullyRestore.Name = "fullyRestore";
            this.fullyRestore.Size = new System.Drawing.Size(387, 24);
            this.fullyRestore.TabIndex = 8;
            this.fullyRestore.Text = "Restore Phone (This will completely erase all data)";
            this.fullyRestore.UseVisualStyleBackColor = true;
            // 
            // stepThreeLabel
            // 
            this.stepThreeLabel.AutoSize = true;
            this.stepThreeLabel.Location = new System.Drawing.Point(16, 299);
            this.stepThreeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stepThreeLabel.Name = "stepThreeLabel";
            this.stepThreeLabel.Size = new System.Drawing.Size(129, 20);
            this.stepThreeLabel.TabIndex = 9;
            this.stepThreeLabel.Text = "3. Perform action";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 324);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(442, 78);
            this.button1.TabIndex = 10;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(289, 407);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(172, 20);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Visit the original project";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnDwnldIPSW
            // 
            this.btnDwnldIPSW.Location = new System.Drawing.Point(19, 134);
            this.btnDwnldIPSW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDwnldIPSW.Name = "btnDwnldIPSW";
            this.btnDwnldIPSW.Size = new System.Drawing.Size(442, 44);
            this.btnDwnldIPSW.TabIndex = 12;
            this.btnDwnldIPSW.Text = "Download IPSW";
            this.btnDwnldIPSW.UseVisualStyleBackColor = true;
            this.btnDwnldIPSW.Click += new System.EventHandler(this.btnDwnldIPSW_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(15, 407);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(191, 20);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Visit the new project page";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 240);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(187, 24);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Additional Arguments";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(22, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 26);
            this.textBox1.TabIndex = 15;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 434);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.btnDwnldIPSW);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stepThreeLabel);
            this.Controls.Add(this.fullyRestore);
            this.Controls.Add(this.labelStepTwo);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.stepOneLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "iDeviceRestore GUI";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stepOneLabel;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Label labelStepTwo;
        private System.Windows.Forms.CheckBox fullyRestore;
        private System.Windows.Forms.Label stepThreeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.OpenFileDialog openIPSW;
        private System.Windows.Forms.Button btnDwnldIPSW;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

