namespace AwsRemoteDesktopManager
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstEc2Instances = new System.Windows.Forms.ListBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPrivateIP = new System.Windows.Forms.Label();
            this.btnLaunchRsc = new System.Windows.Forms.Button();
            this.txtPrivateIpAddress = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtHowto = new System.Windows.Forms.TextBox();
            this.lblHowto = new System.Windows.Forms.Label();
            this.lnkHowto = new System.Windows.Forms.LinkLabel();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.lblAccessKey = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.txtAccessKey = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lstProfileList = new System.Windows.Forms.ComboBox();
            this.lblProfileList = new System.Windows.Forms.Label();
            this.btnAddProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 121);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstEc2Instances);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblPassword);
            this.splitContainer1.Panel2.Controls.Add(this.lblPrivateIP);
            this.splitContainer1.Panel2.Controls.Add(this.btnLaunchRsc);
            this.splitContainer1.Panel2.Controls.Add(this.txtPrivateIpAddress);
            this.splitContainer1.Panel2.Controls.Add(this.txtPassword);
            this.splitContainer1.Size = new System.Drawing.Size(477, 203);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstEc2Instances
            // 
            this.lstEc2Instances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEc2Instances.FormattingEnabled = true;
            this.lstEc2Instances.ItemHeight = 12;
            this.lstEc2Instances.Location = new System.Drawing.Point(0, 0);
            this.lstEc2Instances.Name = "lstEc2Instances";
            this.lstEc2Instances.Size = new System.Drawing.Size(232, 203);
            this.lstEc2Instances.TabIndex = 0;
            this.lstEc2Instances.SelectedIndexChanged += new System.EventHandler(this.lstEc2Instances_SelectedIndexChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 37);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(54, 12);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblPrivateIP
            // 
            this.lblPrivateIP.AutoSize = true;
            this.lblPrivateIP.Location = new System.Drawing.Point(10, 12);
            this.lblPrivateIP.Name = "lblPrivateIP";
            this.lblPrivateIP.Size = new System.Drawing.Size(51, 12);
            this.lblPrivateIP.TabIndex = 2;
            this.lblPrivateIP.Text = "PrivateIP";
            // 
            // btnLaunchRsc
            // 
            this.btnLaunchRsc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLaunchRsc.Location = new System.Drawing.Point(157, 59);
            this.btnLaunchRsc.Name = "btnLaunchRsc";
            this.btnLaunchRsc.Size = new System.Drawing.Size(75, 23);
            this.btnLaunchRsc.TabIndex = 1;
            this.btnLaunchRsc.Text = "実行";
            this.btnLaunchRsc.UseVisualStyleBackColor = true;
            this.btnLaunchRsc.Click += new System.EventHandler(this.btnLaunchRsc_Click);
            // 
            // txtPrivateIpAddress
            // 
            this.txtPrivateIpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrivateIpAddress.Location = new System.Drawing.Point(69, 9);
            this.txtPrivateIpAddress.Name = "txtPrivateIpAddress";
            this.txtPrivateIpAddress.ReadOnly = true;
            this.txtPrivateIpAddress.Size = new System.Drawing.Size(163, 19);
            this.txtPrivateIpAddress.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(69, 34);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(163, 19);
            this.txtPassword.TabIndex = 0;
            // 
            // txtHowto
            // 
            this.txtHowto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHowto.Location = new System.Drawing.Point(0, 351);
            this.txtHowto.Multiline = true;
            this.txtHowto.Name = "txtHowto";
            this.txtHowto.ReadOnly = true;
            this.txtHowto.Size = new System.Drawing.Size(477, 32);
            this.txtHowto.TabIndex = 1;
            this.txtHowto.Text = "Set-AWSCredentials –AccessKey {accessKey} –SecretKey {secretKey}\r\nSet-DefaultAWSR" +
    "egion -Region ap-northeast-1";
            // 
            // lblHowto
            // 
            this.lblHowto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHowto.AutoSize = true;
            this.lblHowto.Location = new System.Drawing.Point(0, 336);
            this.lblHowto.Name = "lblHowto";
            this.lblHowto.Size = new System.Drawing.Size(197, 12);
            this.lblHowto.TabIndex = 2;
            this.lblHowto.Text = "Default Profile の初期化（PowerShell）";
            // 
            // lnkHowto
            // 
            this.lnkHowto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkHowto.AutoSize = true;
            this.lnkHowto.Location = new System.Drawing.Point(0, 384);
            this.lnkHowto.Name = "lnkHowto";
            this.lnkHowto.Size = new System.Drawing.Size(191, 12);
            this.lnkHowto.TabIndex = 3;
            this.lnkHowto.TabStop = true;
            this.lnkHowto.Text = "AWS Tools for Windows PowerShell ";
            this.lnkHowto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Location = new System.Drawing.Point(0, 58);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(67, 12);
            this.lblProfileName.TabIndex = 2;
            this.lblProfileName.Text = "ProfileName";
            // 
            // lblAccessKey
            // 
            this.lblAccessKey.AutoSize = true;
            this.lblAccessKey.Location = new System.Drawing.Point(0, 100);
            this.lblAccessKey.Name = "lblAccessKey";
            this.lblAccessKey.Size = new System.Drawing.Size(62, 12);
            this.lblAccessKey.TabIndex = 2;
            this.lblAccessKey.Text = "AccessKey";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(0, 79);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(40, 12);
            this.lblRegion.TabIndex = 2;
            this.lblRegion.Text = "Region";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(73, 55);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.ReadOnly = true;
            this.txtProfileName.Size = new System.Drawing.Size(168, 19);
            this.txtProfileName.TabIndex = 0;
            // 
            // txtAccessKey
            // 
            this.txtAccessKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccessKey.Location = new System.Drawing.Point(73, 97);
            this.txtAccessKey.Name = "txtAccessKey";
            this.txtAccessKey.ReadOnly = true;
            this.txtAccessKey.Size = new System.Drawing.Size(399, 19);
            this.txtAccessKey.TabIndex = 0;
            // 
            // txtRegion
            // 
            this.txtRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegion.Location = new System.Drawing.Point(73, 76);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.ReadOnly = true;
            this.txtRegion.Size = new System.Drawing.Size(398, 19);
            this.txtRegion.TabIndex = 0;
            // 
            // lstProfileList
            // 
            this.lstProfileList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstProfileList.FormattingEnabled = true;
            this.lstProfileList.Location = new System.Drawing.Point(73, 12);
            this.lstProfileList.Name = "lstProfileList";
            this.lstProfileList.Size = new System.Drawing.Size(168, 20);
            this.lstProfileList.TabIndex = 4;
            this.lstProfileList.SelectedIndexChanged += new System.EventHandler(this.lstProfileList_SelectedIndexChanged);
            // 
            // lblProfileList
            // 
            this.lblProfileList.AutoSize = true;
            this.lblProfileList.Location = new System.Drawing.Point(0, 15);
            this.lblProfileList.Name = "lblProfileList";
            this.lblProfileList.Size = new System.Drawing.Size(53, 12);
            this.lblProfileList.TabIndex = 2;
            this.lblProfileList.Text = "ProlieList";
            // 
            // btnAddProfile
            // 
            this.btnAddProfile.Location = new System.Drawing.Point(247, 10);
            this.btnAddProfile.Name = "btnAddProfile";
            this.btnAddProfile.Size = new System.Drawing.Size(75, 23);
            this.btnAddProfile.TabIndex = 5;
            this.btnAddProfile.Text = "AddProfile";
            this.btnAddProfile.UseVisualStyleBackColor = true;
            this.btnAddProfile.Click += new System.EventHandler(this.btnAddProfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 397);
            this.Controls.Add(this.btnAddProfile);
            this.Controls.Add(this.lstProfileList);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblAccessKey);
            this.Controls.Add(this.lnkHowto);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtAccessKey);
            this.Controls.Add(this.txtProfileName);
            this.Controls.Add(this.lblProfileList);
            this.Controls.Add(this.lblProfileName);
            this.Controls.Add(this.lblHowto);
            this.Controls.Add(this.txtHowto);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = " ";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstEc2Instances;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLaunchRsc;
        private System.Windows.Forms.Label lblPrivateIP;
        private System.Windows.Forms.TextBox txtPrivateIpAddress;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtHowto;
        private System.Windows.Forms.Label lblHowto;
        private System.Windows.Forms.LinkLabel lnkHowto;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Label lblAccessKey;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.TextBox txtAccessKey;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.ComboBox lstProfileList;
        private System.Windows.Forms.Label lblProfileList;
        private System.Windows.Forms.Button btnAddProfile;
    }
}

