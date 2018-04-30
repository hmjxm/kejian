namespace Hotel
{
    partial class BookHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookHouse));
            this.lblContactTel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCertificateType = new System.Windows.Forms.Label();
            this.grbHouseInfo = new System.Windows.Forms.GroupBox();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtAdvanceForegift = new System.Windows.Forms.TextBox();
            this.lblAdvanceForegift = new System.Windows.Forms.Label();
            this.lblComeDate = new System.Windows.Forms.Label();
            this.dtpBookleave = new System.Windows.Forms.DateTimePicker();
            this.lblBookleave = new System.Windows.Forms.Label();
            this.dtpComeDate = new System.Windows.Forms.DateTimePicker();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.chsR_RoomId = new System.Windows.Forms.ColumnHeader();
            this.lvSelectHouse = new System.Windows.Forms.ListView();
            this.chsRoomType = new System.Windows.Forms.ColumnHeader();
            this.chsPrice = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbHollowHouse = new System.Windows.Forms.GroupBox();
            this.lvHollowHouse = new System.Windows.Forms.ListView();
            this.chR_RoomId = new System.Windows.Forms.ColumnHeader();
            this.chRoomType = new System.Windows.Forms.ColumnHeader();
            this.chPrice = new System.Windows.Forms.ColumnHeader();
            this.cboCertificate = new System.Windows.Forms.ComboBox();
            this.rdoWaman = new System.Windows.Forms.RadioButton();
            this.grbUserBaseInfo = new System.Windows.Forms.GroupBox();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.lbluserid = new System.Windows.Forms.Label();
            this.rdoMan = new System.Windows.Forms.RadioButton();
            this.txtCertificateId = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactTel = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbHouseInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbHollowHouse.SuspendLayout();
            this.grbUserBaseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContactTel
            // 
            this.lblContactTel.AutoSize = true;
            this.lblContactTel.Location = new System.Drawing.Point(29, 159);
            this.lblContactTel.Name = "lblContactTel";
            this.lblContactTel.Size = new System.Drawing.Size(65, 12);
            this.lblContactTel.TabIndex = 32;
            this.lblContactTel.Text = "联系方式：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "证件号码：";
            // 
            // lblCertificateType
            // 
            this.lblCertificateType.AutoSize = true;
            this.lblCertificateType.Location = new System.Drawing.Point(29, 103);
            this.lblCertificateType.Name = "lblCertificateType";
            this.lblCertificateType.Size = new System.Drawing.Size(65, 12);
            this.lblCertificateType.TabIndex = 30;
            this.lblCertificateType.Text = "证件类型：";
            // 
            // grbHouseInfo
            // 
            this.grbHouseInfo.BackColor = System.Drawing.Color.Transparent;
            this.grbHouseInfo.Controls.Add(this.cboRoomType);
            this.grbHouseInfo.Controls.Add(this.lblRoomType);
            this.grbHouseInfo.Controls.Add(this.txtAdvanceForegift);
            this.grbHouseInfo.Controls.Add(this.lblAdvanceForegift);
            this.grbHouseInfo.Controls.Add(this.lblComeDate);
            this.grbHouseInfo.Controls.Add(this.dtpBookleave);
            this.grbHouseInfo.Controls.Add(this.lblBookleave);
            this.grbHouseInfo.Controls.Add(this.dtpComeDate);
            this.grbHouseInfo.Controls.Add(this.lblRemark);
            this.grbHouseInfo.Controls.Add(this.txtRemark);
            this.grbHouseInfo.Location = new System.Drawing.Point(12, 242);
            this.grbHouseInfo.Name = "grbHouseInfo";
            this.grbHouseInfo.Size = new System.Drawing.Size(257, 194);
            this.grbHouseInfo.TabIndex = 39;
            this.grbHouseInfo.TabStop = false;
            this.grbHouseInfo.Text = "客房信息";
            // 
            // cboRoomType
            // 
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Items.AddRange(new object[] {
            "标准单人间",
            "标准双人间",
            "豪华单人间",
            "豪华双人间",
            "商务套房",
            "总统套房",
            "会议厅",
            "全部"});
            this.cboRoomType.Location = new System.Drawing.Point(104, 26);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(123, 20);
            this.cboRoomType.TabIndex = 48;
            this.cboRoomType.Text = "全部";
            this.cboRoomType.SelectionChangeCommitted += new System.EventHandler(this.cboRoomType_SelectionChangeCommitted);
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(29, 29);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(65, 12);
            this.lblRoomType.TabIndex = 47;
            this.lblRoomType.Text = "房间类型：";
            // 
            // txtAdvanceForegift
            // 
            this.txtAdvanceForegift.Location = new System.Drawing.Point(104, 60);
            this.txtAdvanceForegift.Name = "txtAdvanceForegift";
            this.txtAdvanceForegift.Size = new System.Drawing.Size(122, 21);
            this.txtAdvanceForegift.TabIndex = 16;
            this.txtAdvanceForegift.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdvanceForegift_KeyPress);
            this.txtAdvanceForegift.TextChanged += new System.EventHandler(this.txtAdvanceForegift_TextChanged);
            // 
            // lblAdvanceForegift
            // 
            this.lblAdvanceForegift.AutoSize = true;
            this.lblAdvanceForegift.Location = new System.Drawing.Point(52, 63);
            this.lblAdvanceForegift.Name = "lblAdvanceForegift";
            this.lblAdvanceForegift.Size = new System.Drawing.Size(41, 12);
            this.lblAdvanceForegift.TabIndex = 8;
            this.lblAdvanceForegift.Text = "押金：";
            // 
            // lblComeDate
            // 
            this.lblComeDate.AutoSize = true;
            this.lblComeDate.Location = new System.Drawing.Point(29, 98);
            this.lblComeDate.Name = "lblComeDate";
            this.lblComeDate.Size = new System.Drawing.Size(65, 12);
            this.lblComeDate.TabIndex = 10;
            this.lblComeDate.Text = "入住时间：";
            // 
            // dtpBookleave
            // 
            this.dtpBookleave.Checked = false;
            this.dtpBookleave.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpBookleave.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookleave.Location = new System.Drawing.Point(104, 130);
            this.dtpBookleave.Name = "dtpBookleave";
            this.dtpBookleave.Size = new System.Drawing.Size(122, 21);
            this.dtpBookleave.TabIndex = 24;
            this.dtpBookleave.Value = new System.DateTime(2008, 9, 25, 0, 0, 0, 0);
            this.dtpBookleave.CloseUp += new System.EventHandler(this.dtpBookleave_CloseUp);
            // 
            // lblBookleave
            // 
            this.lblBookleave.AutoSize = true;
            this.lblBookleave.Location = new System.Drawing.Point(29, 134);
            this.lblBookleave.Name = "lblBookleave";
            this.lblBookleave.Size = new System.Drawing.Size(65, 12);
            this.lblBookleave.TabIndex = 11;
            this.lblBookleave.Text = "预离时间：";
            // 
            // dtpComeDate
            // 
            this.dtpComeDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpComeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpComeDate.Location = new System.Drawing.Point(104, 94);
            this.dtpComeDate.Name = "dtpComeDate";
            this.dtpComeDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpComeDate.Size = new System.Drawing.Size(122, 21);
            this.dtpComeDate.TabIndex = 23;
            this.dtpComeDate.CloseUp += new System.EventHandler(this.dtpComeDate_CloseUp);
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(53, 169);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(41, 12);
            this.lblRemark.TabIndex = 12;
            this.lblRemark.Text = "备注：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(107, 166);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(122, 21);
            this.txtRemark.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(52, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "姓名：";
            // 
            // chsR_RoomId
            // 
            this.chsR_RoomId.Text = "房间号";
            this.chsR_RoomId.Width = 51;
            // 
            // lvSelectHouse
            // 
            this.lvSelectHouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chsR_RoomId,
            this.chsRoomType,
            this.chsPrice});
            this.lvSelectHouse.FullRowSelect = true;
            this.lvSelectHouse.GridLines = true;
            this.lvSelectHouse.Location = new System.Drawing.Point(19, 19);
            this.lvSelectHouse.MultiSelect = false;
            this.lvSelectHouse.Name = "lvSelectHouse";
            this.lvSelectHouse.Size = new System.Drawing.Size(230, 388);
            this.lvSelectHouse.TabIndex = 35;
            this.lvSelectHouse.UseCompatibleStateImageBehavior = false;
            this.lvSelectHouse.View = System.Windows.Forms.View.Details;
            this.lvSelectHouse.DoubleClick += new System.EventHandler(this.lvSelectHouse_DoubleClick);
            // 
            // chsRoomType
            // 
            this.chsRoomType.Text = "类型";
            this.chsRoomType.Width = 88;
            // 
            // chsPrice
            // 
            this.chsPrice.Text = "价格";
            this.chsPrice.Width = 65;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvSelectHouse);
            this.groupBox1.Location = new System.Drawing.Point(555, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 414);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "已选客房";
            // 
            // grbHollowHouse
            // 
            this.grbHollowHouse.Controls.Add(this.lvHollowHouse);
            this.grbHollowHouse.Location = new System.Drawing.Point(286, 22);
            this.grbHollowHouse.Name = "grbHollowHouse";
            this.grbHollowHouse.Size = new System.Drawing.Size(263, 414);
            this.grbHollowHouse.TabIndex = 43;
            this.grbHollowHouse.TabStop = false;
            this.grbHollowHouse.Text = "空净房";
            // 
            // lvHollowHouse
            // 
            this.lvHollowHouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chR_RoomId,
            this.chRoomType,
            this.chPrice});
            this.lvHollowHouse.FullRowSelect = true;
            this.lvHollowHouse.GridLines = true;
            this.lvHollowHouse.Location = new System.Drawing.Point(18, 20);
            this.lvHollowHouse.MultiSelect = false;
            this.lvHollowHouse.Name = "lvHollowHouse";
            this.lvHollowHouse.Size = new System.Drawing.Size(239, 375);
            this.lvHollowHouse.TabIndex = 36;
            this.lvHollowHouse.UseCompatibleStateImageBehavior = false;
            this.lvHollowHouse.View = System.Windows.Forms.View.Details;
            this.lvHollowHouse.DoubleClick += new System.EventHandler(this.lvHollowHouse_DoubleClick);
            // 
            // chR_RoomId
            // 
            this.chR_RoomId.Text = "房间号";
            this.chR_RoomId.Width = 51;
            // 
            // chRoomType
            // 
            this.chRoomType.Text = "类型";
            this.chRoomType.Width = 88;
            // 
            // chPrice
            // 
            this.chPrice.Text = "价格";
            this.chPrice.Width = 65;
            // 
            // cboCertificate
            // 
            this.cboCertificate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCertificate.FormattingEnabled = true;
            this.cboCertificate.Items.AddRange(new object[] {
            "身份证",
            "学生证",
            "军官证",
            "其他"});
            this.cboCertificate.Location = new System.Drawing.Point(102, 100);
            this.cboCertificate.Name = "cboCertificate";
            this.cboCertificate.Size = new System.Drawing.Size(123, 20);
            this.cboCertificate.TabIndex = 44;
            // 
            // rdoWaman
            // 
            this.rdoWaman.AutoSize = true;
            this.rdoWaman.Location = new System.Drawing.Point(173, 79);
            this.rdoWaman.Name = "rdoWaman";
            this.rdoWaman.Size = new System.Drawing.Size(35, 16);
            this.rdoWaman.TabIndex = 42;
            this.rdoWaman.Text = "女";
            this.rdoWaman.UseVisualStyleBackColor = true;
            // 
            // grbUserBaseInfo
            // 
            this.grbUserBaseInfo.BackColor = System.Drawing.Color.Transparent;
            this.grbUserBaseInfo.Controls.Add(this.txtuserid);
            this.grbUserBaseInfo.Controls.Add(this.lbluserid);
            this.grbUserBaseInfo.Controls.Add(this.cboCertificate);
            this.grbUserBaseInfo.Controls.Add(this.rdoWaman);
            this.grbUserBaseInfo.Controls.Add(this.rdoMan);
            this.grbUserBaseInfo.Controls.Add(this.txtCertificateId);
            this.grbUserBaseInfo.Controls.Add(this.txtAddress);
            this.grbUserBaseInfo.Controls.Add(this.txtContactTel);
            this.grbUserBaseInfo.Controls.Add(this.txtName);
            this.grbUserBaseInfo.Controls.Add(this.lblAddress);
            this.grbUserBaseInfo.Controls.Add(this.lblSex);
            this.grbUserBaseInfo.Controls.Add(this.lblContactTel);
            this.grbUserBaseInfo.Controls.Add(this.label4);
            this.grbUserBaseInfo.Controls.Add(this.lblCertificateType);
            this.grbUserBaseInfo.Controls.Add(this.lblName);
            this.grbUserBaseInfo.Location = new System.Drawing.Point(12, 22);
            this.grbUserBaseInfo.Name = "grbUserBaseInfo";
            this.grbUserBaseInfo.Size = new System.Drawing.Size(257, 214);
            this.grbUserBaseInfo.TabIndex = 38;
            this.grbUserBaseInfo.TabStop = false;
            this.grbUserBaseInfo.Text = "客户基本信息";
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(102, 20);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(123, 21);
            this.txtuserid.TabIndex = 46;
            this.txtuserid.Leave += new System.EventHandler(this.txtuserid_Leave);
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.Location = new System.Drawing.Point(29, 24);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(65, 12);
            this.lbluserid.TabIndex = 45;
            this.lbluserid.Text = "会员帐号：";
            // 
            // rdoMan
            // 
            this.rdoMan.AutoSize = true;
            this.rdoMan.Checked = true;
            this.rdoMan.Location = new System.Drawing.Point(131, 79);
            this.rdoMan.Name = "rdoMan";
            this.rdoMan.Size = new System.Drawing.Size(35, 16);
            this.rdoMan.TabIndex = 41;
            this.rdoMan.TabStop = true;
            this.rdoMan.Text = "男";
            this.rdoMan.UseVisualStyleBackColor = true;
            // 
            // txtCertificateId
            // 
            this.txtCertificateId.Location = new System.Drawing.Point(102, 128);
            this.txtCertificateId.Name = "txtCertificateId";
            this.txtCertificateId.Size = new System.Drawing.Size(123, 21);
            this.txtCertificateId.TabIndex = 38;
            this.txtCertificateId.Leave += new System.EventHandler(this.txtCertificateId_Leave);
            this.txtCertificateId.TextChanged += new System.EventHandler(this.txtCertificateId_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(101, 183);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(123, 21);
            this.txtAddress.TabIndex = 37;
            // 
            // txtContactTel
            // 
            this.txtContactTel.Location = new System.Drawing.Point(102, 156);
            this.txtContactTel.Name = "txtContactTel";
            this.txtContactTel.Size = new System.Drawing.Size(123, 21);
            this.txtContactTel.TabIndex = 36;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 21);
            this.txtName.TabIndex = 35;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(52, 186);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(41, 12);
            this.lblAddress.TabIndex = 34;
            this.lblAddress.Text = "地址：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(52, 81);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 33;
            this.lblSex.Text = "性别：";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(223, 463);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "保 存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(375, 462);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BookHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 507);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grbHouseInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbHollowHouse);
            this.Controls.Add(this.grbUserBaseInfo);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预订房间";
            this.Load += new System.EventHandler(this.BookHouse_Load);
            this.grbHouseInfo.ResumeLayout(false);
            this.grbHouseInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grbHollowHouse.ResumeLayout(false);
            this.grbUserBaseInfo.ResumeLayout(false);
            this.grbUserBaseInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblContactTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCertificateType;
        private System.Windows.Forms.GroupBox grbHouseInfo;
        private System.Windows.Forms.TextBox txtAdvanceForegift;
        private System.Windows.Forms.Label lblAdvanceForegift;
        private System.Windows.Forms.Label lblComeDate;
        private System.Windows.Forms.DateTimePicker dtpBookleave;
        private System.Windows.Forms.Label lblBookleave;
        private System.Windows.Forms.DateTimePicker dtpComeDate;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ColumnHeader chsR_RoomId;
        private System.Windows.Forms.ListView lvSelectHouse;
        private System.Windows.Forms.ColumnHeader chsRoomType;
        private System.Windows.Forms.ColumnHeader chsPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbHollowHouse;
        private System.Windows.Forms.ComboBox cboCertificate;
        private System.Windows.Forms.RadioButton rdoWaman;
        private System.Windows.Forms.GroupBox grbUserBaseInfo;
        private System.Windows.Forms.RadioButton rdoMan;
        private System.Windows.Forms.TextBox txtCertificateId;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactTel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.ListView lvHollowHouse;
        private System.Windows.Forms.ColumnHeader chR_RoomId;
        private System.Windows.Forms.ColumnHeader chRoomType;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.Button btnCancel;
      //  private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}