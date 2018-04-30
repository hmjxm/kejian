namespace Hotel
{
    partial class SoftWareSet
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftWareSet));
            this.grbBackDatabase = new System.Windows.Forms.GroupBox();
            this.lblAwork = new System.Windows.Forms.Label();
            this.panBack = new System.Windows.Forms.Panel();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.chkGoOutBak = new System.Windows.Forms.CheckBox();
            this.grbSoftSet = new System.Windows.Forms.GroupBox();
            this.cboDis = new System.Windows.Forms.ComboBox();
            this.lblDis = new System.Windows.Forms.Label();
            this.cboExceed = new System.Windows.Forms.ComboBox();
            this.cboIgnore = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.chkRefurbish = new System.Windows.Forms.CheckBox();
            this.chkForegiftSmall = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSameName = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbHotelInfo = new System.Windows.Forms.GroupBox();
            this.txtIntro = new System.Windows.Forms.TextBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.txtHotelName = new System.Windows.Forms.TextBox();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.grbRevert = new System.Windows.Forms.GroupBox();
            this.btnRevert = new System.Windows.Forms.Button();
            this.grbBackDatabase.SuspendLayout();
            this.panBack.SuspendLayout();
            this.grbSoftSet.SuspendLayout();
            this.grbHotelInfo.SuspendLayout();
            this.grbRevert.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBackDatabase
            // 
            this.grbBackDatabase.Controls.Add(this.lblAwork);
            this.grbBackDatabase.Controls.Add(this.panBack);
            this.grbBackDatabase.Controls.Add(this.btnBack);
            this.grbBackDatabase.Controls.Add(this.chkGoOutBak);
            this.grbBackDatabase.Location = new System.Drawing.Point(379, 138);
            this.grbBackDatabase.Name = "grbBackDatabase";
            this.grbBackDatabase.Size = new System.Drawing.Size(257, 133);
            this.grbBackDatabase.TabIndex = 4;
            this.grbBackDatabase.TabStop = false;
            this.grbBackDatabase.Text = "备份数据库";
            // 
            // lblAwork
            // 
            this.lblAwork.AutoSize = true;
            this.lblAwork.Location = new System.Drawing.Point(9, 83);
            this.lblAwork.Name = "lblAwork";
            this.lblAwork.Size = new System.Drawing.Size(149, 12);
            this.lblAwork.TabIndex = 12;
            this.lblAwork.Text = "注意：请确保路径一定正确";
            // 
            // panBack
            // 
            this.panBack.Controls.Add(this.txtPath);
            this.panBack.Controls.Add(this.lblPath);
            this.panBack.Controls.Add(this.btnPath);
            this.panBack.Location = new System.Drawing.Point(8, 42);
            this.panBack.Name = "panBack";
            this.panBack.Size = new System.Drawing.Size(245, 31);
            this.panBack.TabIndex = 11;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(48, 7);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(147, 21);
            this.txtPath.TabIndex = 13;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(1, 10);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(41, 12);
            this.lblPath.TabIndex = 12;
            this.lblPath.Text = "路径：";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(201, 5);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(31, 23);
            this.btnPath.TabIndex = 10;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(98, 103);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "备份";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chkGoOutBak
            // 
            this.chkGoOutBak.AutoSize = true;
            this.chkGoOutBak.Location = new System.Drawing.Point(16, 20);
            this.chkGoOutBak.Name = "chkGoOutBak";
            this.chkGoOutBak.Size = new System.Drawing.Size(144, 16);
            this.chkGoOutBak.TabIndex = 5;
            this.chkGoOutBak.Text = "退出时自动备份数据库";
            this.chkGoOutBak.UseVisualStyleBackColor = true;
            this.chkGoOutBak.CheckedChanged += new System.EventHandler(this.chkGoOutBak_CheckedChanged);
            // 
            // grbSoftSet
            // 
            this.grbSoftSet.Controls.Add(this.cboDis);
            this.grbSoftSet.Controls.Add(this.lblDis);
            this.grbSoftSet.Controls.Add(this.cboExceed);
            this.grbSoftSet.Controls.Add(this.cboIgnore);
            this.grbSoftSet.Controls.Add(this.label10);
            this.grbSoftSet.Controls.Add(this.cboTime);
            this.grbSoftSet.Controls.Add(this.chkRefurbish);
            this.grbSoftSet.Controls.Add(this.chkForegiftSmall);
            this.grbSoftSet.Controls.Add(this.label9);
            this.grbSoftSet.Controls.Add(this.label8);
            this.grbSoftSet.Controls.Add(this.label5);
            this.grbSoftSet.Controls.Add(this.label4);
            this.grbSoftSet.Controls.Add(this.chkSameName);
            this.grbSoftSet.Location = new System.Drawing.Point(22, 138);
            this.grbSoftSet.Name = "grbSoftSet";
            this.grbSoftSet.Size = new System.Drawing.Size(351, 245);
            this.grbSoftSet.TabIndex = 5;
            this.grbSoftSet.TabStop = false;
            this.grbSoftSet.Text = "设置";
            // 
            // cboDis
            // 
            this.cboDis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDis.FormattingEnabled = true;
            this.cboDis.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "1"});
            this.cboDis.Location = new System.Drawing.Point(95, 208);
            this.cboDis.Name = "cboDis";
            this.cboDis.Size = new System.Drawing.Size(87, 20);
            this.cboDis.TabIndex = 10;
            // 
            // lblDis
            // 
            this.lblDis.AutoSize = true;
            this.lblDis.Location = new System.Drawing.Point(10, 211);
            this.lblDis.Name = "lblDis";
            this.lblDis.Size = new System.Drawing.Size(65, 12);
            this.lblDis.TabIndex = 23;
            this.lblDis.Text = "会员折扣：";
            // 
            // cboExceed
            // 
            this.cboExceed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExceed.FormattingEnabled = true;
            this.cboExceed.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "24"});
            this.cboExceed.Location = new System.Drawing.Point(64, 172);
            this.cboExceed.Name = "cboExceed";
            this.cboExceed.Size = new System.Drawing.Size(50, 20);
            this.cboExceed.TabIndex = 22;
            // 
            // cboIgnore
            // 
            this.cboIgnore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIgnore.FormattingEnabled = true;
            this.cboIgnore.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "10",
            "60",
            "120",
            "600"});
            this.cboIgnore.Location = new System.Drawing.Point(38, 133);
            this.cboIgnore.Name = "cboIgnore";
            this.cboIgnore.Size = new System.Drawing.Size(50, 20);
            this.cboIgnore.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "秒，刷新数据";
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "10",
            "60",
            "120",
            "600"});
            this.cboTime.Location = new System.Drawing.Point(150, 92);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(50, 20);
            this.cboTime.TabIndex = 14;
            // 
            // chkRefurbish
            // 
            this.chkRefurbish.AutoSize = true;
            this.chkRefurbish.Location = new System.Drawing.Point(11, 96);
            this.chkRefurbish.Name = "chkRefurbish";
            this.chkRefurbish.Size = new System.Drawing.Size(132, 16);
            this.chkRefurbish.TabIndex = 13;
            this.chkRefurbish.Text = "自动刷新控制台数据";
            this.chkRefurbish.UseVisualStyleBackColor = true;
            this.chkRefurbish.CheckedChanged += new System.EventHandler(this.chkRefurbish_CheckedChanged);
            // 
            // chkForegiftSmall
            // 
            this.chkForegiftSmall.AutoSize = true;
            this.chkForegiftSmall.Location = new System.Drawing.Point(11, 57);
            this.chkForegiftSmall.Name = "chkForegiftSmall";
            this.chkForegiftSmall.Size = new System.Drawing.Size(156, 16);
            this.chkForegiftSmall.TabIndex = 12;
            this.chkForegiftSmall.Text = "押金不够房款，不能开房";
            this.chkForegiftSmall.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "预订超过";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "小时，没来办理手续，自动解除预订信息";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "分钟以内换房先前课款忽略不算";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "入住";
            // 
            // chkSameName
            // 
            this.chkSameName.AutoSize = true;
            this.chkSameName.Location = new System.Drawing.Point(11, 24);
            this.chkSameName.Name = "chkSameName";
            this.chkSameName.Size = new System.Drawing.Size(132, 16);
            this.chkSameName.TabIndex = 2;
            this.chkSameName.Text = "同姓名历史客人提醒";
            this.chkSameName.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(395, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(495, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grbHotelInfo
            // 
            this.grbHotelInfo.Controls.Add(this.txtIntro);
            this.grbHotelInfo.Controls.Add(this.lblIntro);
            this.grbHotelInfo.Controls.Add(this.txtHotelName);
            this.grbHotelInfo.Controls.Add(this.lblHotelName);
            this.grbHotelInfo.Location = new System.Drawing.Point(22, 12);
            this.grbHotelInfo.Name = "grbHotelInfo";
            this.grbHotelInfo.Size = new System.Drawing.Size(614, 120);
            this.grbHotelInfo.TabIndex = 8;
            this.grbHotelInfo.TabStop = false;
            this.grbHotelInfo.Text = "酒店信息";
            // 
            // txtIntro
            // 
            this.txtIntro.Location = new System.Drawing.Point(80, 38);
            this.txtIntro.Multiline = true;
            this.txtIntro.Name = "txtIntro";
            this.txtIntro.Size = new System.Drawing.Size(510, 76);
            this.txtIntro.TabIndex = 7;
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(9, 41);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(65, 12);
            this.lblIntro.TabIndex = 6;
            this.lblIntro.Text = "酒店简介：";
            // 
            // txtHotelName
            // 
            this.txtHotelName.Location = new System.Drawing.Point(80, 11);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(170, 21);
            this.txtHotelName.TabIndex = 5;
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Location = new System.Drawing.Point(9, 14);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(65, 12);
            this.lblHotelName.TabIndex = 4;
            this.lblHotelName.Text = "酒店名称：";
            // 
            // grbRevert
            // 
            this.grbRevert.Controls.Add(this.btnRevert);
            this.grbRevert.Location = new System.Drawing.Point(379, 289);
            this.grbRevert.Name = "grbRevert";
            this.grbRevert.Size = new System.Drawing.Size(257, 94);
            this.grbRevert.TabIndex = 9;
            this.grbRevert.TabStop = false;
            this.grbRevert.Text = "还原数据库";
            // 
            // btnRevert
            // 
            this.btnRevert.Location = new System.Drawing.Point(85, 40);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(75, 23);
            this.btnRevert.TabIndex = 9;
            this.btnRevert.Text = "还原";
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // SoftWareSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 457);
            this.Controls.Add(this.grbRevert);
            this.Controls.Add(this.grbHotelInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbSoftSet);
            this.Controls.Add(this.grbBackDatabase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SoftWareSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "软件设置";
            this.Load += new System.EventHandler(this.SoftWareSet_Load);
            this.grbBackDatabase.ResumeLayout(false);
            this.grbBackDatabase.PerformLayout();
            this.panBack.ResumeLayout(false);
            this.panBack.PerformLayout();
            this.grbSoftSet.ResumeLayout(false);
            this.grbSoftSet.PerformLayout();
            this.grbHotelInfo.ResumeLayout(false);
            this.grbHotelInfo.PerformLayout();
            this.grbRevert.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBackDatabase;
        private System.Windows.Forms.CheckBox chkGoOutBak;
        private System.Windows.Forms.GroupBox grbSoftSet;
        private System.Windows.Forms.CheckBox chkSameName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkForegiftSmall;
        private System.Windows.Forms.CheckBox chkRefurbish;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grbHotelInfo;
        private System.Windows.Forms.TextBox txtIntro;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.TextBox txtHotelName;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.GroupBox grbRevert;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.ComboBox cboExceed;
        private System.Windows.Forms.ComboBox cboIgnore;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panBack;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label lblAwork;
        private System.Windows.Forms.Label lblDis;
        private System.Windows.Forms.ComboBox cboDis;
    }
}