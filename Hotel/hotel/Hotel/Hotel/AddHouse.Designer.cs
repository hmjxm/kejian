namespace Hotel
{
    partial class AddHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHouse));
            this.lblAdvanceForegift = new System.Windows.Forms.Label();
            this.lblComeDate = new System.Windows.Forms.Label();
            this.lblBookleave = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtAdvanceForegift = new System.Windows.Forms.TextBox();
            this.dtpBookleave = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.grbUserBaseInfo = new System.Windows.Forms.GroupBox();
            this.txtCust = new System.Windows.Forms.TextBox();
            this.lblCust = new System.Windows.Forms.Label();
            this.cboCertificate = new System.Windows.Forms.ComboBox();
            this.rdoWaman = new System.Windows.Forms.RadioButton();
            this.rdoMan = new System.Windows.Forms.RadioButton();
            this.txtCertificateId = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactTel = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblContactTel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCertificateType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grbHouseInfo = new System.Windows.Forms.GroupBox();
            this.cboHouseType = new System.Windows.Forms.ComboBox();
            this.lblHouseType = new System.Windows.Forms.Label();
            this.dtpComeDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkloadCertificate = new System.Windows.Forms.CheckBox();
            this.grbHollowHouse = new System.Windows.Forms.GroupBox();
            this.lvHollowHouse = new System.Windows.Forms.ListView();
            this.chR_RoomId = new System.Windows.Forms.ColumnHeader();
            this.chRoomType = new System.Windows.Forms.ColumnHeader();
            this.chPrice = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvSelectHouse = new System.Windows.Forms.ListView();
            this.chsR_RoomId = new System.Windows.Forms.ColumnHeader();
            this.chsRoomType = new System.Windows.Forms.ColumnHeader();
            this.chsPrice = new System.Windows.Forms.ColumnHeader();
            this.cboIsAwoke = new System.Windows.Forms.CheckBox();
            this.picCertificate = new System.Windows.Forms.PictureBox();
            this.grbUserBaseInfo.SuspendLayout();
            this.grbHouseInfo.SuspendLayout();
            this.grbHollowHouse.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCertificate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdvanceForegift
            // 
            this.lblAdvanceForegift.AutoSize = true;
            this.lblAdvanceForegift.Location = new System.Drawing.Point(42, 52);
            this.lblAdvanceForegift.Name = "lblAdvanceForegift";
            this.lblAdvanceForegift.Size = new System.Drawing.Size(41, 12);
            this.lblAdvanceForegift.TabIndex = 8;
            this.lblAdvanceForegift.Text = "押金：";
            // 
            // lblComeDate
            // 
            this.lblComeDate.AutoSize = true;
            this.lblComeDate.Location = new System.Drawing.Point(18, 83);
            this.lblComeDate.Name = "lblComeDate";
            this.lblComeDate.Size = new System.Drawing.Size(65, 12);
            this.lblComeDate.TabIndex = 10;
            this.lblComeDate.Text = "入住时间：";
            // 
            // lblBookleave
            // 
            this.lblBookleave.AutoSize = true;
            this.lblBookleave.Location = new System.Drawing.Point(18, 114);
            this.lblBookleave.Name = "lblBookleave";
            this.lblBookleave.Size = new System.Drawing.Size(65, 12);
            this.lblBookleave.TabIndex = 11;
            this.lblBookleave.Text = "预离时间：";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(42, 143);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(41, 12);
            this.lblRemark.TabIndex = 12;
            this.lblRemark.Text = "备注：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(93, 141);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(122, 21);
            this.txtRemark.TabIndex = 13;
            // 
            // txtAdvanceForegift
            // 
            this.txtAdvanceForegift.Location = new System.Drawing.Point(93, 49);
            this.txtAdvanceForegift.Name = "txtAdvanceForegift";
            this.txtAdvanceForegift.Size = new System.Drawing.Size(122, 21);
            this.txtAdvanceForegift.TabIndex = 10;
            this.txtAdvanceForegift.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdvanceForegift_KeyPress);
            this.txtAdvanceForegift.TextChanged += new System.EventHandler(this.txtAdvanceForegift_TextChanged);
            // 
            // dtpBookleave
            // 
            this.dtpBookleave.Checked = false;
            this.dtpBookleave.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpBookleave.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookleave.Location = new System.Drawing.Point(93, 111);
            this.dtpBookleave.Name = "dtpBookleave";
            this.dtpBookleave.Size = new System.Drawing.Size(122, 21);
            this.dtpBookleave.TabIndex = 12;
            this.dtpBookleave.Value = new System.DateTime(2008, 9, 30, 23, 54, 0, 0);
            this.dtpBookleave.CloseUp += new System.EventHandler(this.dtpBookleave_CloseUp);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(123, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "保 存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grbUserBaseInfo
            // 
            this.grbUserBaseInfo.BackColor = System.Drawing.Color.Transparent;
            this.grbUserBaseInfo.Controls.Add(this.txtCust);
            this.grbUserBaseInfo.Controls.Add(this.lblCust);
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
            this.grbUserBaseInfo.Location = new System.Drawing.Point(16, 12);
            this.grbUserBaseInfo.Name = "grbUserBaseInfo";
            this.grbUserBaseInfo.Size = new System.Drawing.Size(239, 210);
            this.grbUserBaseInfo.TabIndex = 29;
            this.grbUserBaseInfo.TabStop = false;
            this.grbUserBaseInfo.Text = "客户基本信息";
            // 
            // txtCust
            // 
            this.txtCust.Location = new System.Drawing.Point(92, 19);
            this.txtCust.Name = "txtCust";
            this.txtCust.Size = new System.Drawing.Size(123, 21);
            this.txtCust.TabIndex = 1;
            this.txtCust.Leave += new System.EventHandler(this.txtCust_Leave);
            this.txtCust.TextChanged += new System.EventHandler(this.txtCust_TextChanged);
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Location = new System.Drawing.Point(40, 22);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(41, 12);
            this.lblCust.TabIndex = 71;
            this.lblCust.Text = "会员：";
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
            this.cboCertificate.Location = new System.Drawing.Point(97, 97);
            this.cboCertificate.Name = "cboCertificate";
            this.cboCertificate.Size = new System.Drawing.Size(119, 20);
            this.cboCertificate.TabIndex = 5;
            // 
            // rdoWaman
            // 
            this.rdoWaman.AutoSize = true;
            this.rdoWaman.Location = new System.Drawing.Point(168, 76);
            this.rdoWaman.Name = "rdoWaman";
            this.rdoWaman.Size = new System.Drawing.Size(35, 16);
            this.rdoWaman.TabIndex = 4;
            this.rdoWaman.Text = "女";
            this.rdoWaman.UseVisualStyleBackColor = true;
            // 
            // rdoMan
            // 
            this.rdoMan.AutoSize = true;
            this.rdoMan.Checked = true;
            this.rdoMan.Location = new System.Drawing.Point(122, 76);
            this.rdoMan.Name = "rdoMan";
            this.rdoMan.Size = new System.Drawing.Size(35, 16);
            this.rdoMan.TabIndex = 3;
            this.rdoMan.TabStop = true;
            this.rdoMan.Text = "男";
            this.rdoMan.UseVisualStyleBackColor = true;
            // 
            // txtCertificateId
            // 
            this.txtCertificateId.Location = new System.Drawing.Point(97, 125);
            this.txtCertificateId.Name = "txtCertificateId";
            this.txtCertificateId.Size = new System.Drawing.Size(119, 21);
            this.txtCertificateId.TabIndex = 6;
            this.txtCertificateId.Leave += new System.EventHandler(this.txtCertificateId_Leave);
            this.txtCertificateId.TextChanged += new System.EventHandler(this.txtCertificateId_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(96, 180);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(119, 21);
            this.txtAddress.TabIndex = 8;
            // 
            // txtContactTel
            // 
            this.txtContactTel.Location = new System.Drawing.Point(97, 153);
            this.txtContactTel.Name = "txtContactTel";
            this.txtContactTel.Size = new System.Drawing.Size(119, 21);
            this.txtContactTel.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 21);
            this.txtName.TabIndex = 2;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(38, 183);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(41, 12);
            this.lblAddress.TabIndex = 34;
            this.lblAddress.Text = "地址：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(38, 76);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 33;
            this.lblSex.Text = "性别：";
            // 
            // lblContactTel
            // 
            this.lblContactTel.AutoSize = true;
            this.lblContactTel.Location = new System.Drawing.Point(14, 157);
            this.lblContactTel.Name = "lblContactTel";
            this.lblContactTel.Size = new System.Drawing.Size(65, 12);
            this.lblContactTel.TabIndex = 32;
            this.lblContactTel.Text = "联系方式：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "证件号码：";
            // 
            // lblCertificateType
            // 
            this.lblCertificateType.AutoSize = true;
            this.lblCertificateType.Location = new System.Drawing.Point(14, 101);
            this.lblCertificateType.Name = "lblCertificateType";
            this.lblCertificateType.Size = new System.Drawing.Size(65, 12);
            this.lblCertificateType.TabIndex = 30;
            this.lblCertificateType.Text = "证件类型：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(38, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "姓名：";
            // 
            // grbHouseInfo
            // 
            this.grbHouseInfo.BackColor = System.Drawing.Color.Transparent;
            this.grbHouseInfo.Controls.Add(this.cboHouseType);
            this.grbHouseInfo.Controls.Add(this.lblHouseType);
            this.grbHouseInfo.Controls.Add(this.dtpComeDate);
            this.grbHouseInfo.Controls.Add(this.txtAdvanceForegift);
            this.grbHouseInfo.Controls.Add(this.lblAdvanceForegift);
            this.grbHouseInfo.Controls.Add(this.lblComeDate);
            this.grbHouseInfo.Controls.Add(this.dtpBookleave);
            this.grbHouseInfo.Controls.Add(this.lblBookleave);
            this.grbHouseInfo.Controls.Add(this.lblRemark);
            this.grbHouseInfo.Controls.Add(this.txtRemark);
            this.grbHouseInfo.Location = new System.Drawing.Point(17, 228);
            this.grbHouseInfo.Name = "grbHouseInfo";
            this.grbHouseInfo.Size = new System.Drawing.Size(239, 175);
            this.grbHouseInfo.TabIndex = 30;
            this.grbHouseInfo.TabStop = false;
            this.grbHouseInfo.Text = "客房信息";
            // 
            // cboHouseType
            // 
            this.cboHouseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHouseType.FormattingEnabled = true;
            this.cboHouseType.Items.AddRange(new object[] {
            "标准单人间",
            "标准双人间",
            "豪华单人间",
            "豪华双人间",
            "商务套房",
            "总统套房",
            "会议厅"});
            this.cboHouseType.Location = new System.Drawing.Point(93, 20);
            this.cboHouseType.Name = "cboHouseType";
            this.cboHouseType.Size = new System.Drawing.Size(122, 20);
            this.cboHouseType.TabIndex = 9;
            this.cboHouseType.SelectedIndexChanged += new System.EventHandler(this.cboHouseType_SelectedIndexChanged);
            // 
            // lblHouseType
            // 
            this.lblHouseType.AutoSize = true;
            this.lblHouseType.Location = new System.Drawing.Point(18, 23);
            this.lblHouseType.Name = "lblHouseType";
            this.lblHouseType.Size = new System.Drawing.Size(65, 12);
            this.lblHouseType.TabIndex = 49;
            this.lblHouseType.Text = "房间类型：";
            // 
            // dtpComeDate
            // 
            this.dtpComeDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpComeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpComeDate.Location = new System.Drawing.Point(93, 79);
            this.dtpComeDate.Name = "dtpComeDate";
            this.dtpComeDate.Size = new System.Drawing.Size(122, 21);
            this.dtpComeDate.TabIndex = 11;
            this.dtpComeDate.CloseUp += new System.EventHandler(this.dtpComeDate_CloseUp);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(204, 471);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkloadCertificate
            // 
            this.chkloadCertificate.AutoSize = true;
            this.chkloadCertificate.Location = new System.Drawing.Point(173, 440);
            this.chkloadCertificate.Name = "chkloadCertificate";
            this.chkloadCertificate.Size = new System.Drawing.Size(108, 16);
            this.chkloadCertificate.TabIndex = 14;
            this.chkloadCertificate.Text = "加载证件或图片";
            this.chkloadCertificate.UseVisualStyleBackColor = true;
            this.chkloadCertificate.CheckedChanged += new System.EventHandler(this.chkloadCertificate_CheckedChanged);
            // 
            // grbHollowHouse
            // 
            this.grbHollowHouse.Controls.Add(this.lvHollowHouse);
            this.grbHollowHouse.Location = new System.Drawing.Point(275, 12);
            this.grbHollowHouse.Name = "grbHollowHouse";
            this.grbHollowHouse.Size = new System.Drawing.Size(253, 414);
            this.grbHollowHouse.TabIndex = 35;
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
            this.lvHollowHouse.Location = new System.Drawing.Point(21, 16);
            this.lvHollowHouse.MultiSelect = false;
            this.lvHollowHouse.Name = "lvHollowHouse";
            this.lvHollowHouse.Size = new System.Drawing.Size(208, 375);
            this.lvHollowHouse.TabIndex = 35;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvSelectHouse);
            this.groupBox1.Location = new System.Drawing.Point(552, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 414);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "已选客房";
            // 
            // lvSelectHouse
            // 
            this.lvSelectHouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chsR_RoomId,
            this.chsRoomType,
            this.chsPrice});
            this.lvSelectHouse.FullRowSelect = true;
            this.lvSelectHouse.GridLines = true;
            this.lvSelectHouse.Location = new System.Drawing.Point(23, 16);
            this.lvSelectHouse.MultiSelect = false;
            this.lvSelectHouse.Name = "lvSelectHouse";
            this.lvSelectHouse.Size = new System.Drawing.Size(208, 375);
            this.lvSelectHouse.TabIndex = 35;
            this.lvSelectHouse.UseCompatibleStateImageBehavior = false;
            this.lvSelectHouse.View = System.Windows.Forms.View.Details;
            this.lvSelectHouse.DoubleClick += new System.EventHandler(this.lvSelectHouse_DoubleClick);
            // 
            // chsR_RoomId
            // 
            this.chsR_RoomId.Text = "房间号";
            this.chsR_RoomId.Width = 51;
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
            // cboIsAwoke
            // 
            this.cboIsAwoke.AutoSize = true;
            this.cboIsAwoke.Location = new System.Drawing.Point(320, 440);
            this.cboIsAwoke.Name = "cboIsAwoke";
            this.cboIsAwoke.Size = new System.Drawing.Size(96, 16);
            this.cboIsAwoke.TabIndex = 15;
            this.cboIsAwoke.Text = "到期自动提醒";
            this.cboIsAwoke.UseVisualStyleBackColor = true;
            // 
            // picCertificate
            // 
            this.picCertificate.Location = new System.Drawing.Point(17, 432);
            this.picCertificate.Name = "picCertificate";
            this.picCertificate.Size = new System.Drawing.Size(78, 62);
            this.picCertificate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCertificate.TabIndex = 33;
            this.picCertificate.TabStop = false;
            this.picCertificate.Visible = false;
            // 
            // AddHouse
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(823, 516);
            this.Controls.Add(this.cboIsAwoke);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbHollowHouse);
            this.Controls.Add(this.picCertificate);
            this.Controls.Add(this.chkloadCertificate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grbHouseInfo);
            this.Controls.Add(this.grbUserBaseInfo);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "散客开单";
            this.Load += new System.EventHandler(this.AddHouse_Load);
            this.grbUserBaseInfo.ResumeLayout(false);
            this.grbUserBaseInfo.PerformLayout();
            this.grbHouseInfo.ResumeLayout(false);
            this.grbHouseInfo.PerformLayout();
            this.grbHollowHouse.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCertificate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdvanceForegift;
        private System.Windows.Forms.Label lblComeDate;
        private System.Windows.Forms.Label lblBookleave;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemark;
        public System.Windows.Forms.TextBox txtAdvanceForegift;
        private System.Windows.Forms.DateTimePicker dtpBookleave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grbUserBaseInfo;
        private System.Windows.Forms.GroupBox grbHouseInfo;
        public System.Windows.Forms.RadioButton rdoWaman;
        public System.Windows.Forms.RadioButton rdoMan;
        public System.Windows.Forms.TextBox txtCertificateId;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtContactTel;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblContactTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCertificateType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.ComboBox cboCertificate;
        private System.Windows.Forms.CheckBox chkloadCertificate;
        private System.Windows.Forms.PictureBox picCertificate;
        private System.Windows.Forms.GroupBox grbHollowHouse;
        private System.Windows.Forms.ListView lvHollowHouse;
        private System.Windows.Forms.ColumnHeader chR_RoomId;
        private System.Windows.Forms.ColumnHeader chRoomType;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvSelectHouse;
        private System.Windows.Forms.ColumnHeader chsR_RoomId;
        private System.Windows.Forms.ColumnHeader chsRoomType;
        private System.Windows.Forms.ColumnHeader chsPrice;
        private System.Windows.Forms.DateTimePicker dtpComeDate;
        private System.Windows.Forms.ComboBox cboHouseType;
        private System.Windows.Forms.Label lblHouseType;
        private System.Windows.Forms.CheckBox cboIsAwoke;
        public System.Windows.Forms.TextBox txtCust;
        private System.Windows.Forms.Label lblCust;
    }
}