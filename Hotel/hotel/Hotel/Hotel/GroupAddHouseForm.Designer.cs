//download by http://www.codefans.net
namespace Hotel
{
    partial class GroupAddHouseForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupAddHouseForm));
            this.grbUserBaseInfo = new System.Windows.Forms.GroupBox();
            this.txtCust = new System.Windows.Forms.TextBox();
            this.lblCust = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtAdvanceForegift = new System.Windows.Forms.TextBox();
            this.lblAdvanceForegift = new System.Windows.Forms.Label();
            this.lblComeDate = new System.Windows.Forms.Label();
            this.txtMainHouse = new System.Windows.Forms.TextBox();
            this.dtpComeDate = new System.Windows.Forms.DateTimePicker();
            this.lblMainHouse = new System.Windows.Forms.Label();
            this.lblBookleave = new System.Windows.Forms.Label();
            this.dtpBookleave = new System.Windows.Forms.DateTimePicker();
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
            this.grbAlreadyHouse = new System.Windows.Forms.GroupBox();
            this.lvNeedHouse = new System.Windows.Forms.ListView();
            this.chRoom_id = new System.Windows.Forms.ColumnHeader();
            this.chHouseType = new System.Windows.Forms.ColumnHeader();
            this.chPrice = new System.Windows.Forms.ColumnHeader();
            this.grbHouse = new System.Windows.Forms.GroupBox();
            this.tbHouse = new System.Windows.Forms.TabControl();
            this.tpHouse = new System.Windows.Forms.TabPage();
            this.tvHouse = new System.Windows.Forms.TreeView();
            this.ilTree = new System.Windows.Forms.ImageList(this.components);
            this.btnTransact = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkloadCertificate = new System.Windows.Forms.CheckBox();
            this.cboIsAwoke = new System.Windows.Forms.CheckBox();
            this.picCertificate = new System.Windows.Forms.PictureBox();
            this.grbUserBaseInfo.SuspendLayout();
            this.grbAlreadyHouse.SuspendLayout();
            this.grbHouse.SuspendLayout();
            this.tbHouse.SuspendLayout();
            this.tpHouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCertificate)).BeginInit();
            this.SuspendLayout();
            // 
            // grbUserBaseInfo
            // 
            this.grbUserBaseInfo.BackColor = System.Drawing.Color.Transparent;
            this.grbUserBaseInfo.Controls.Add(this.txtCust);
            this.grbUserBaseInfo.Controls.Add(this.lblCust);
            this.grbUserBaseInfo.Controls.Add(this.txtRemark);
            this.grbUserBaseInfo.Controls.Add(this.lblRemark);
            this.grbUserBaseInfo.Controls.Add(this.txtAdvanceForegift);
            this.grbUserBaseInfo.Controls.Add(this.lblAdvanceForegift);
            this.grbUserBaseInfo.Controls.Add(this.lblComeDate);
            this.grbUserBaseInfo.Controls.Add(this.txtMainHouse);
            this.grbUserBaseInfo.Controls.Add(this.dtpComeDate);
            this.grbUserBaseInfo.Controls.Add(this.lblMainHouse);
            this.grbUserBaseInfo.Controls.Add(this.lblBookleave);
            this.grbUserBaseInfo.Controls.Add(this.dtpBookleave);
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
            this.grbUserBaseInfo.Location = new System.Drawing.Point(25, 296);
            this.grbUserBaseInfo.Name = "grbUserBaseInfo";
            this.grbUserBaseInfo.Size = new System.Drawing.Size(593, 221);
            this.grbUserBaseInfo.TabIndex = 31;
            this.grbUserBaseInfo.TabStop = false;
            this.grbUserBaseInfo.Text = "客户基本信息";
            // 
            // txtCust
            // 
            this.txtCust.Location = new System.Drawing.Point(84, 14);
            this.txtCust.Name = "txtCust";
            this.txtCust.Size = new System.Drawing.Size(137, 21);
            this.txtCust.TabIndex = 1;
            this.txtCust.Leave += new System.EventHandler(this.txtCust_Leave);
            this.txtCust.TextChanged += new System.EventHandler(this.txtCust_TextChanged);
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Location = new System.Drawing.Point(43, 17);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(41, 12);
            this.lblCust.TabIndex = 73;
            this.lblCust.Text = "会员：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(84, 188);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(434, 21);
            this.txtRemark.TabIndex = 12;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(45, 191);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(41, 12);
            this.lblRemark.TabIndex = 55;
            this.lblRemark.Text = "备注：";
            // 
            // txtAdvanceForegift
            // 
            this.txtAdvanceForegift.Location = new System.Drawing.Point(380, 85);
            this.txtAdvanceForegift.Name = "txtAdvanceForegift";
            this.txtAdvanceForegift.Size = new System.Drawing.Size(137, 21);
            this.txtAdvanceForegift.TabIndex = 10;
            this.txtAdvanceForegift.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdvanceForegift_KeyPress);
            this.txtAdvanceForegift.TextChanged += new System.EventHandler(this.txtAdvanceForegift_TextChanged);
            // 
            // lblAdvanceForegift
            // 
            this.lblAdvanceForegift.AutoSize = true;
            this.lblAdvanceForegift.Location = new System.Drawing.Point(327, 88);
            this.lblAdvanceForegift.Name = "lblAdvanceForegift";
            this.lblAdvanceForegift.Size = new System.Drawing.Size(41, 12);
            this.lblAdvanceForegift.TabIndex = 53;
            this.lblAdvanceForegift.Text = "押金：";
            // 
            // lblComeDate
            // 
            this.lblComeDate.AutoSize = true;
            this.lblComeDate.Location = new System.Drawing.Point(304, 18);
            this.lblComeDate.Name = "lblComeDate";
            this.lblComeDate.Size = new System.Drawing.Size(65, 12);
            this.lblComeDate.TabIndex = 46;
            this.lblComeDate.Text = "入住时间：";
            // 
            // txtMainHouse
            // 
            this.txtMainHouse.Location = new System.Drawing.Point(381, 121);
            this.txtMainHouse.Name = "txtMainHouse";
            this.txtMainHouse.ReadOnly = true;
            this.txtMainHouse.Size = new System.Drawing.Size(136, 21);
            this.txtMainHouse.TabIndex = 52;
            // 
            // dtpComeDate
            // 
            this.dtpComeDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpComeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpComeDate.Location = new System.Drawing.Point(381, 14);
            this.dtpComeDate.Name = "dtpComeDate";
            this.dtpComeDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpComeDate.Size = new System.Drawing.Size(137, 21);
            this.dtpComeDate.TabIndex = 8;
            this.dtpComeDate.CloseUp += new System.EventHandler(this.dtpComeDate_CloseUp);
            // 
            // lblMainHouse
            // 
            this.lblMainHouse.AutoSize = true;
            this.lblMainHouse.Location = new System.Drawing.Point(317, 126);
            this.lblMainHouse.Name = "lblMainHouse";
            this.lblMainHouse.Size = new System.Drawing.Size(53, 12);
            this.lblMainHouse.TabIndex = 51;
            this.lblMainHouse.Text = "主客房：";
            // 
            // lblBookleave
            // 
            this.lblBookleave.AutoSize = true;
            this.lblBookleave.Location = new System.Drawing.Point(304, 55);
            this.lblBookleave.Name = "lblBookleave";
            this.lblBookleave.Size = new System.Drawing.Size(65, 12);
            this.lblBookleave.TabIndex = 47;
            this.lblBookleave.Text = "预离时间：";
            // 
            // dtpBookleave
            // 
            this.dtpBookleave.Checked = false;
            this.dtpBookleave.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpBookleave.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookleave.Location = new System.Drawing.Point(381, 49);
            this.dtpBookleave.Name = "dtpBookleave";
            this.dtpBookleave.Size = new System.Drawing.Size(137, 21);
            this.dtpBookleave.TabIndex = 9;
            this.dtpBookleave.CloseUp += new System.EventHandler(this.dtpBookleave_CloseUp);
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
            this.cboCertificate.Location = new System.Drawing.Point(84, 93);
            this.cboCertificate.Name = "cboCertificate";
            this.cboCertificate.Size = new System.Drawing.Size(137, 20);
            this.cboCertificate.TabIndex = 5;
            // 
            // rdoWaman
            // 
            this.rdoWaman.AutoSize = true;
            this.rdoWaman.Location = new System.Drawing.Point(165, 71);
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
            this.rdoMan.Location = new System.Drawing.Point(100, 71);
            this.rdoMan.Name = "rdoMan";
            this.rdoMan.Size = new System.Drawing.Size(35, 16);
            this.rdoMan.TabIndex = 3;
            this.rdoMan.TabStop = true;
            this.rdoMan.Text = "男";
            this.rdoMan.UseVisualStyleBackColor = true;
            // 
            // txtCertificateId
            // 
            this.txtCertificateId.Location = new System.Drawing.Point(84, 125);
            this.txtCertificateId.Name = "txtCertificateId";
            this.txtCertificateId.Size = new System.Drawing.Size(137, 21);
            this.txtCertificateId.TabIndex = 6;
            this.txtCertificateId.Leave += new System.EventHandler(this.txtCertificateId_Leave);
            this.txtCertificateId.TextChanged += new System.EventHandler(this.txtCertificateId_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(381, 153);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(137, 21);
            this.txtAddress.TabIndex = 11;
            // 
            // txtContactTel
            // 
            this.txtContactTel.Location = new System.Drawing.Point(84, 158);
            this.txtContactTel.Name = "txtContactTel";
            this.txtContactTel.Size = new System.Drawing.Size(137, 21);
            this.txtContactTel.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 21);
            this.txtName.TabIndex = 2;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(327, 158);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(41, 12);
            this.lblAddress.TabIndex = 34;
            this.lblAddress.Text = "地址：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(43, 72);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 33;
            this.lblSex.Text = "性别：";
            // 
            // lblContactTel
            // 
            this.lblContactTel.AutoSize = true;
            this.lblContactTel.Location = new System.Drawing.Point(20, 157);
            this.lblContactTel.Name = "lblContactTel";
            this.lblContactTel.Size = new System.Drawing.Size(65, 12);
            this.lblContactTel.TabIndex = 32;
            this.lblContactTel.Text = "联系方式：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "证件号码：";
            // 
            // lblCertificateType
            // 
            this.lblCertificateType.AutoSize = true;
            this.lblCertificateType.Location = new System.Drawing.Point(19, 97);
            this.lblCertificateType.Name = "lblCertificateType";
            this.lblCertificateType.Size = new System.Drawing.Size(65, 12);
            this.lblCertificateType.TabIndex = 30;
            this.lblCertificateType.Text = "证件类型：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "姓名：";
            // 
            // grbAlreadyHouse
            // 
            this.grbAlreadyHouse.Controls.Add(this.lvNeedHouse);
            this.grbAlreadyHouse.Location = new System.Drawing.Point(331, 13);
            this.grbAlreadyHouse.Name = "grbAlreadyHouse";
            this.grbAlreadyHouse.Size = new System.Drawing.Size(287, 277);
            this.grbAlreadyHouse.TabIndex = 33;
            this.grbAlreadyHouse.TabStop = false;
            this.grbAlreadyHouse.Text = "已选定客房";
            // 
            // lvNeedHouse
            // 
            this.lvNeedHouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chRoom_id,
            this.chHouseType,
            this.chPrice});
            this.lvNeedHouse.FullRowSelect = true;
            this.lvNeedHouse.GridLines = true;
            this.lvNeedHouse.HoverSelection = true;
            this.lvNeedHouse.Location = new System.Drawing.Point(13, 20);
            this.lvNeedHouse.MultiSelect = false;
            this.lvNeedHouse.Name = "lvNeedHouse";
            this.lvNeedHouse.Size = new System.Drawing.Size(258, 234);
            this.lvNeedHouse.TabIndex = 0;
            this.lvNeedHouse.UseCompatibleStateImageBehavior = false;
            this.lvNeedHouse.View = System.Windows.Forms.View.Details;
            this.lvNeedHouse.DoubleClick += new System.EventHandler(this.lvNeedHouse_DoubleClick);
            // 
            // chRoom_id
            // 
            this.chRoom_id.Text = "房间号";
            this.chRoom_id.Width = 52;
            // 
            // chHouseType
            // 
            this.chHouseType.Text = "房间类型";
            this.chHouseType.Width = 78;
            // 
            // chPrice
            // 
            this.chPrice.Text = "价格";
            this.chPrice.Width = 54;
            // 
            // grbHouse
            // 
            this.grbHouse.Controls.Add(this.tbHouse);
            this.grbHouse.Location = new System.Drawing.Point(25, 13);
            this.grbHouse.Name = "grbHouse";
            this.grbHouse.Size = new System.Drawing.Size(287, 277);
            this.grbHouse.TabIndex = 32;
            this.grbHouse.TabStop = false;
            this.grbHouse.Text = "可供房间";
            // 
            // tbHouse
            // 
            this.tbHouse.Controls.Add(this.tpHouse);
            this.tbHouse.Location = new System.Drawing.Point(23, 20);
            this.tbHouse.Name = "tbHouse";
            this.tbHouse.SelectedIndex = 0;
            this.tbHouse.Size = new System.Drawing.Size(243, 234);
            this.tbHouse.TabIndex = 9;
            // 
            // tpHouse
            // 
            this.tpHouse.Controls.Add(this.tvHouse);
            this.tpHouse.Location = new System.Drawing.Point(4, 21);
            this.tpHouse.Name = "tpHouse";
            this.tpHouse.Padding = new System.Windows.Forms.Padding(3);
            this.tpHouse.Size = new System.Drawing.Size(235, 209);
            this.tpHouse.TabIndex = 0;
            this.tpHouse.Text = "可供房间";
            this.tpHouse.UseVisualStyleBackColor = true;
            // 
            // tvHouse
            // 
            this.tvHouse.ImageIndex = 0;
            this.tvHouse.ImageList = this.ilTree;
            this.tvHouse.Location = new System.Drawing.Point(6, 6);
            this.tvHouse.Name = "tvHouse";
            this.tvHouse.SelectedImageIndex = 1;
            this.tvHouse.Size = new System.Drawing.Size(223, 197);
            this.tvHouse.TabIndex = 0;
            this.tvHouse.DoubleClick += new System.EventHandler(this.tvHouse_DoubleClick);
            // 
            // ilTree
            // 
            this.ilTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTree.ImageStream")));
            this.ilTree.TransparentColor = System.Drawing.Color.Transparent;
            this.ilTree.Images.SetKeyName(0, "up.png");
            this.ilTree.Images.SetKeyName(1, "right.png");
            // 
            // btnTransact
            // 
            this.btnTransact.Location = new System.Drawing.Point(396, 548);
            this.btnTransact.Name = "btnTransact";
            this.btnTransact.Size = new System.Drawing.Size(75, 23);
            this.btnTransact.TabIndex = 15;
            this.btnTransact.Text = "确 定";
            this.btnTransact.UseVisualStyleBackColor = true;
            this.btnTransact.Click += new System.EventHandler(this.btnTransact_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(527, 548);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "取 消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkloadCertificate
            // 
            this.chkloadCertificate.AutoSize = true;
            this.chkloadCertificate.Location = new System.Drawing.Point(160, 530);
            this.chkloadCertificate.Name = "chkloadCertificate";
            this.chkloadCertificate.Size = new System.Drawing.Size(108, 16);
            this.chkloadCertificate.TabIndex = 13;
            this.chkloadCertificate.Text = "加载证件或图片";
            this.chkloadCertificate.UseVisualStyleBackColor = true;
            this.chkloadCertificate.CheckedChanged += new System.EventHandler(this.chkloadCertificate_CheckedChanged);
            // 
            // cboIsAwoke
            // 
            this.cboIsAwoke.AutoSize = true;
            this.cboIsAwoke.Location = new System.Drawing.Point(274, 530);
            this.cboIsAwoke.Name = "cboIsAwoke";
            this.cboIsAwoke.Size = new System.Drawing.Size(96, 16);
            this.cboIsAwoke.TabIndex = 14;
            this.cboIsAwoke.Text = "到期自动提醒";
            this.cboIsAwoke.UseVisualStyleBackColor = true;
            // 
            // picCertificate
            // 
            this.picCertificate.Location = new System.Drawing.Point(47, 523);
            this.picCertificate.Name = "picCertificate";
            this.picCertificate.Size = new System.Drawing.Size(78, 62);
            this.picCertificate.TabIndex = 56;
            this.picCertificate.TabStop = false;
            this.picCertificate.Visible = false;
            // 
            // GroupAddHouseForm
            // 
            this.AcceptButton = this.btnTransact;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(641, 597);
            this.Controls.Add(this.cboIsAwoke);
            this.Controls.Add(this.picCertificate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkloadCertificate);
            this.Controls.Add(this.btnTransact);
            this.Controls.Add(this.grbAlreadyHouse);
            this.Controls.Add(this.grbHouse);
            this.Controls.Add(this.grbUserBaseInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GroupAddHouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "团体开单";
            this.Load += new System.EventHandler(this.GroupAddHouseForm_Load);
            this.grbUserBaseInfo.ResumeLayout(false);
            this.grbUserBaseInfo.PerformLayout();
            this.grbAlreadyHouse.ResumeLayout(false);
            this.grbHouse.ResumeLayout(false);
            this.tbHouse.ResumeLayout(false);
            this.tpHouse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCertificate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUserBaseInfo;
        public System.Windows.Forms.ComboBox cboCertificate;
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
        private System.Windows.Forms.GroupBox grbAlreadyHouse;
        private System.Windows.Forms.ListView lvNeedHouse;
        private System.Windows.Forms.GroupBox grbHouse;
        private System.Windows.Forms.TabControl tbHouse;
        private System.Windows.Forms.TabPage tpHouse;
        private System.Windows.Forms.TreeView tvHouse;
        private System.Windows.Forms.Label lblComeDate;
        private System.Windows.Forms.DateTimePicker dtpBookleave;
        private System.Windows.Forms.Label lblBookleave;
        private System.Windows.Forms.DateTimePicker dtpComeDate;
        private System.Windows.Forms.Label lblMainHouse;
        private System.Windows.Forms.TextBox txtMainHouse;
        private System.Windows.Forms.Button btnTransact;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader chRoom_id;
        private System.Windows.Forms.ColumnHeader chHouseType;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.ImageList ilTree;
        public System.Windows.Forms.TextBox txtAdvanceForegift;
        private System.Windows.Forms.Label lblAdvanceForegift;
        private System.Windows.Forms.PictureBox picCertificate;
        private System.Windows.Forms.CheckBox chkloadCertificate;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.CheckBox cboIsAwoke;
        public System.Windows.Forms.TextBox txtCust;
        private System.Windows.Forms.Label lblCust;


    }
}