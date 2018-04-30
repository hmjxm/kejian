namespace Hotel
{
    partial class CashierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
            this.grbCashier = new System.Windows.Forms.GroupBox();
            this.rdoTodayGo = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtRoom_id = new System.Windows.Forms.TextBox();
            this.lblRoom_id = new System.Windows.Forms.Label();
            this.lvUptownHouse = new System.Windows.Forms.ListView();
            this.chG_GuestId = new System.Windows.Forms.ColumnHeader();
            this.R_id = new System.Windows.Forms.ColumnHeader();
            this.chUname = new System.Windows.Forms.ColumnHeader();
            this.chforegift = new System.Windows.Forms.ColumnHeader();
            this.chcomeDate = new System.Windows.Forms.ColumnHeader();
            this.chBookleave = new System.Windows.Forms.ColumnHeader();
            this.chFact = new System.Windows.Forms.ColumnHeader();
            this.chUCope = new System.Windows.Forms.ColumnHeader();
            this.chremark = new System.Windows.Forms.ColumnHeader();
            this.tbGo = new System.Windows.Forms.TabControl();
            this.tpGo = new System.Windows.Forms.TabPage();
            this.lvFitout = new System.Windows.Forms.ListView();
            this.chR_GuestId = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.chCope = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.tpDeal = new System.Windows.Forms.TabPage();
            this.lvConsume = new System.Windows.Forms.ListView();
            this.chWareName = new System.Windows.Forms.ColumnHeader();
            this.chWarePrice = new System.Windows.Forms.ColumnHeader();
            this.chC_type = new System.Windows.Forms.ColumnHeader();
            this.chWareCount = new System.Windows.Forms.ColumnHeader();
            this.dhDate = new System.Windows.Forms.ColumnHeader();
            this.chCOperator = new System.Windows.Forms.ColumnHeader();
            this.chCRemark = new System.Windows.Forms.ColumnHeader();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDeal2 = new System.Windows.Forms.Label();
            this.lblPaicl = new System.Windows.Forms.Label();
            this.lblSpare = new System.Windows.Forms.Label();
            this.txtPaicl = new System.Windows.Forms.TextBox();
            this.txtSpare = new System.Windows.Forms.Label();
            this.lblDeal = new System.Windows.Forms.Label();
            this.chkUnderwrite = new System.Windows.Forms.CheckBox();
            this.cboUnderwrite = new System.Windows.Forms.ComboBox();
            this.lblYaJin = new System.Windows.Forms.Label();
            this.lblYaJin1 = new System.Windows.Forms.Label();
            this.chkCust = new System.Windows.Forms.CheckBox();
            this.lblU_UserId = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbldiscount2 = new System.Windows.Forms.Label();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.grbCashier.SuspendLayout();
            this.tbGo.SuspendLayout();
            this.tpGo.SuspendLayout();
            this.tpDeal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCashier
            // 
            this.grbCashier.Controls.Add(this.rdoTodayGo);
            this.grbCashier.Controls.Add(this.rdoAll);
            this.grbCashier.Controls.Add(this.btnSearch);
            this.grbCashier.Controls.Add(this.txtRoom_id);
            this.grbCashier.Controls.Add(this.lblRoom_id);
            this.grbCashier.Controls.Add(this.lvUptownHouse);
            this.grbCashier.Location = new System.Drawing.Point(22, 23);
            this.grbCashier.Name = "grbCashier";
            this.grbCashier.Size = new System.Drawing.Size(587, 230);
            this.grbCashier.TabIndex = 0;
            this.grbCashier.TabStop = false;
            this.grbCashier.Text = "在住客房";
            // 
            // rdoTodayGo
            // 
            this.rdoTodayGo.AutoSize = true;
            this.rdoTodayGo.Location = new System.Drawing.Point(392, 21);
            this.rdoTodayGo.Name = "rdoTodayGo";
            this.rdoTodayGo.Size = new System.Drawing.Size(119, 16);
            this.rdoTodayGo.TabIndex = 5;
            this.rdoTodayGo.Text = "准备今日离店客人";
            this.rdoTodayGo.UseVisualStyleBackColor = true;
            this.rdoTodayGo.CheckedChanged += new System.EventHandler(this.rdoTodayGo_CheckedChanged);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Checked = true;
            this.rdoAll.Location = new System.Drawing.Point(267, 21);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(95, 16);
            this.rdoAll.TabIndex = 4;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "全部在住客人";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.rdoAll_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(202, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtRoom_id
            // 
            this.txtRoom_id.Location = new System.Drawing.Point(84, 14);
            this.txtRoom_id.Name = "txtRoom_id";
            this.txtRoom_id.Size = new System.Drawing.Size(100, 21);
            this.txtRoom_id.TabIndex = 2;
            this.txtRoom_id.TextChanged += new System.EventHandler(this.txtRoom_id_TextChanged);
            this.txtRoom_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoom_id_KeyPress);
            // 
            // lblRoom_id
            // 
            this.lblRoom_id.AutoSize = true;
            this.lblRoom_id.Location = new System.Drawing.Point(25, 17);
            this.lblRoom_id.Name = "lblRoom_id";
            this.lblRoom_id.Size = new System.Drawing.Size(53, 12);
            this.lblRoom_id.TabIndex = 1;
            this.lblRoom_id.Text = "客房号：";
            // 
            // lvUptownHouse
            // 
            this.lvUptownHouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chG_GuestId,
            this.R_id,
            this.chUname,
            this.chforegift,
            this.chcomeDate,
            this.chBookleave,
            this.chFact,
            this.chUCope,
            this.chremark});
            this.lvUptownHouse.FullRowSelect = true;
            this.lvUptownHouse.GridLines = true;
            this.lvUptownHouse.Location = new System.Drawing.Point(4, 47);
            this.lvUptownHouse.Name = "lvUptownHouse";
            this.lvUptownHouse.Size = new System.Drawing.Size(579, 166);
            this.lvUptownHouse.TabIndex = 0;
            this.lvUptownHouse.UseCompatibleStateImageBehavior = false;
            this.lvUptownHouse.View = System.Windows.Forms.View.Details;
            this.lvUptownHouse.SelectedIndexChanged += new System.EventHandler(this.lvUptownHouse_SelectedIndexChanged);
            this.lvUptownHouse.DoubleClick += new System.EventHandler(this.lvUptownHouse_DoubleClick);
            // 
            // chG_GuestId
            // 
            this.chG_GuestId.Text = "单号";
            // 
            // R_id
            // 
            this.R_id.Text = "房间号";
            this.R_id.Width = 53;
            // 
            // chUname
            // 
            this.chUname.Text = "姓名";
            // 
            // chforegift
            // 
            this.chforegift.Text = "押金";
            this.chforegift.Width = 56;
            // 
            // chcomeDate
            // 
            this.chcomeDate.Text = "入住时间";
            this.chcomeDate.Width = 79;
            // 
            // chBookleave
            // 
            this.chBookleave.Text = "预离时间";
            this.chBookleave.Width = 80;
            // 
            // chFact
            // 
            this.chFact.Text = "实住天数";
            this.chFact.Width = 67;
            // 
            // chUCope
            // 
            this.chUCope.Text = "应付";
            // 
            // chremark
            // 
            this.chremark.Text = "备注";
            this.chremark.Width = 58;
            // 
            // tbGo
            // 
            this.tbGo.Controls.Add(this.tpGo);
            this.tbGo.Controls.Add(this.tpDeal);
            this.tbGo.Location = new System.Drawing.Point(22, 270);
            this.tbGo.Name = "tbGo";
            this.tbGo.SelectedIndex = 0;
            this.tbGo.Size = new System.Drawing.Size(587, 186);
            this.tbGo.TabIndex = 1;
            // 
            // tpGo
            // 
            this.tpGo.Controls.Add(this.lvFitout);
            this.tpGo.Location = new System.Drawing.Point(4, 22);
            this.tpGo.Name = "tpGo";
            this.tpGo.Padding = new System.Windows.Forms.Padding(3);
            this.tpGo.Size = new System.Drawing.Size(579, 160);
            this.tpGo.TabIndex = 0;
            this.tpGo.Text = "准备退房的客人";
            this.tpGo.UseVisualStyleBackColor = true;
            // 
            // lvFitout
            // 
            this.lvFitout.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chR_GuestId,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.chCope,
            this.columnHeader8});
            this.lvFitout.FullRowSelect = true;
            this.lvFitout.GridLines = true;
            this.lvFitout.Location = new System.Drawing.Point(1, 0);
            this.lvFitout.Name = "lvFitout";
            this.lvFitout.Size = new System.Drawing.Size(575, 156);
            this.lvFitout.TabIndex = 1;
            this.lvFitout.UseCompatibleStateImageBehavior = false;
            this.lvFitout.View = System.Windows.Forms.View.Details;
            this.lvFitout.DoubleClick += new System.EventHandler(this.lvFitout_DoubleClick);
            // 
            // chR_GuestId
            // 
            this.chR_GuestId.Text = "单号";
            this.chR_GuestId.Width = 57;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "房间号";
            this.columnHeader1.Width = 51;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            this.columnHeader2.Width = 58;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "押金";
            this.columnHeader3.Width = 55;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "入住时间";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "预离时间";
            this.columnHeader5.Width = 91;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "实住天数";
            this.columnHeader6.Width = 64;
            // 
            // chCope
            // 
            this.chCope.Text = "应付";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "备注";
            this.columnHeader8.Width = 49;
            // 
            // tpDeal
            // 
            this.tpDeal.Controls.Add(this.lvConsume);
            this.tpDeal.Location = new System.Drawing.Point(4, 22);
            this.tpDeal.Name = "tpDeal";
            this.tpDeal.Size = new System.Drawing.Size(579, 160);
            this.tpDeal.TabIndex = 2;
            this.tpDeal.Text = "消费明细表";
            this.tpDeal.UseVisualStyleBackColor = true;
            // 
            // lvConsume
            // 
            this.lvConsume.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvConsume.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chWareName,
            this.chWarePrice,
            this.chC_type,
            this.chWareCount,
            this.dhDate,
            this.chCOperator,
            this.chCRemark});
            this.lvConsume.FullRowSelect = true;
            this.lvConsume.GridLines = true;
            this.lvConsume.Location = new System.Drawing.Point(4, 4);
            this.lvConsume.Name = "lvConsume";
            this.lvConsume.Size = new System.Drawing.Size(570, 154);
            this.lvConsume.TabIndex = 65;
            this.lvConsume.UseCompatibleStateImageBehavior = false;
            this.lvConsume.View = System.Windows.Forms.View.Details;
            // 
            // chWareName
            // 
            this.chWareName.Text = "消费名称";
            this.chWareName.Width = 75;
            // 
            // chWarePrice
            // 
            this.chWarePrice.Text = "商品价格";
            this.chWarePrice.Width = 87;
            // 
            // chC_type
            // 
            this.chC_type.Text = "消费类型";
            this.chC_type.Width = 77;
            // 
            // chWareCount
            // 
            this.chWareCount.Text = "数量";
            this.chWareCount.Width = 79;
            // 
            // dhDate
            // 
            this.dhDate.Text = "日期";
            this.dhDate.Width = 69;
            // 
            // chCOperator
            // 
            this.chCOperator.Text = "操作员";
            // 
            // chCRemark
            // 
            this.chCRemark.Text = "备注";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(420, 534);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "确 定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(525, 534);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "取 消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDeal2
            // 
            this.lblDeal2.AutoSize = true;
            this.lblDeal2.Location = new System.Drawing.Point(33, 507);
            this.lblDeal2.Name = "lblDeal2";
            this.lblDeal2.Size = new System.Drawing.Size(41, 12);
            this.lblDeal2.TabIndex = 4;
            this.lblDeal2.Text = "应付：";
            // 
            // lblPaicl
            // 
            this.lblPaicl.AutoSize = true;
            this.lblPaicl.Location = new System.Drawing.Point(314, 507);
            this.lblPaicl.Name = "lblPaicl";
            this.lblPaicl.Size = new System.Drawing.Size(41, 12);
            this.lblPaicl.TabIndex = 6;
            this.lblPaicl.Text = "实收：";
            // 
            // lblSpare
            // 
            this.lblSpare.AutoSize = true;
            this.lblSpare.Location = new System.Drawing.Point(454, 507);
            this.lblSpare.Name = "lblSpare";
            this.lblSpare.Size = new System.Drawing.Size(41, 12);
            this.lblSpare.TabIndex = 10;
            this.lblSpare.Text = "找零：";
            // 
            // txtPaicl
            // 
            this.txtPaicl.Location = new System.Drawing.Point(361, 498);
            this.txtPaicl.Name = "txtPaicl";
            this.txtPaicl.Size = new System.Drawing.Size(68, 21);
            this.txtPaicl.TabIndex = 12;
            this.txtPaicl.TextChanged += new System.EventHandler(this.txtPaicl_TextChanged);
            this.txtPaicl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaicl_KeyPress);
            // 
            // txtSpare
            // 
            this.txtSpare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtSpare.Location = new System.Drawing.Point(501, 499);
            this.txtSpare.Name = "txtSpare";
            this.txtSpare.Size = new System.Drawing.Size(68, 20);
            this.txtSpare.TabIndex = 13;
            // 
            // lblDeal
            // 
            this.lblDeal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeal.Location = new System.Drawing.Point(80, 499);
            this.lblDeal.Name = "lblDeal";
            this.lblDeal.Size = new System.Drawing.Size(68, 20);
            this.lblDeal.TabIndex = 15;
            // 
            // chkUnderwrite
            // 
            this.chkUnderwrite.AutoSize = true;
            this.chkUnderwrite.Location = new System.Drawing.Point(31, 466);
            this.chkUnderwrite.Name = "chkUnderwrite";
            this.chkUnderwrite.Size = new System.Drawing.Size(48, 16);
            this.chkUnderwrite.TabIndex = 16;
            this.chkUnderwrite.Text = "签单";
            this.chkUnderwrite.UseVisualStyleBackColor = true;
            this.chkUnderwrite.CheckedChanged += new System.EventHandler(this.chkUnderwrite_CheckedChanged);
            // 
            // cboUnderwrite
            // 
            this.cboUnderwrite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnderwrite.Enabled = false;
            this.cboUnderwrite.FormattingEnabled = true;
            this.cboUnderwrite.Location = new System.Drawing.Point(84, 463);
            this.cboUnderwrite.Name = "cboUnderwrite";
            this.cboUnderwrite.Size = new System.Drawing.Size(103, 20);
            this.cboUnderwrite.TabIndex = 26;
            // 
            // lblYaJin
            // 
            this.lblYaJin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblYaJin.Location = new System.Drawing.Point(222, 499);
            this.lblYaJin.Name = "lblYaJin";
            this.lblYaJin.Size = new System.Drawing.Size(68, 20);
            this.lblYaJin.TabIndex = 28;
            // 
            // lblYaJin1
            // 
            this.lblYaJin1.AutoSize = true;
            this.lblYaJin1.Location = new System.Drawing.Point(175, 507);
            this.lblYaJin1.Name = "lblYaJin1";
            this.lblYaJin1.Size = new System.Drawing.Size(41, 12);
            this.lblYaJin1.TabIndex = 27;
            this.lblYaJin1.Text = "押金：";
            // 
            // chkCust
            // 
            this.chkCust.AutoSize = true;
            this.chkCust.Location = new System.Drawing.Point(221, 467);
            this.chkCust.Name = "chkCust";
            this.chkCust.Size = new System.Drawing.Size(48, 16);
            this.chkCust.TabIndex = 29;
            this.chkCust.Text = "会员";
            this.chkCust.UseVisualStyleBackColor = true;
            this.chkCust.CheckedChanged += new System.EventHandler(this.chkCust_CheckedChanged);
            // 
            // lblU_UserId
            // 
            this.lblU_UserId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblU_UserId.Location = new System.Drawing.Point(275, 463);
            this.lblU_UserId.Name = "lblU_UserId";
            this.lblU_UserId.Size = new System.Drawing.Size(94, 23);
            this.lblU_UserId.TabIndex = 30;
            this.lblU_UserId.Visible = false;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(375, 465);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 21);
            this.txtPass.TabIndex = 31;
            this.txtPass.Visible = false;
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // lbldiscount2
            // 
            this.lbldiscount2.AutoSize = true;
            this.lbldiscount2.Location = new System.Drawing.Point(499, 468);
            this.lbldiscount2.Name = "lbldiscount2";
            this.lbldiscount2.Size = new System.Drawing.Size(65, 12);
            this.lbldiscount2.TabIndex = 32;
            this.lbldiscount2.Text = "会员折扣：";
            this.lbldiscount2.Visible = false;
            // 
            // lbldiscount
            // 
            this.lbldiscount.Location = new System.Drawing.Point(565, 466);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(39, 21);
            this.lbldiscount.TabIndex = 33;
            this.lbldiscount.Text = "label1";
            this.lbldiscount.Visible = false;
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 569);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.lbldiscount2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblU_UserId);
            this.Controls.Add(this.chkCust);
            this.Controls.Add(this.lblYaJin);
            this.Controls.Add(this.lblYaJin1);
            this.Controls.Add(this.cboUnderwrite);
            this.Controls.Add(this.chkUnderwrite);
            this.Controls.Add(this.lblDeal);
            this.Controls.Add(this.txtSpare);
            this.Controls.Add(this.txtPaicl);
            this.Controls.Add(this.lblSpare);
            this.Controls.Add(this.lblPaicl);
            this.Controls.Add(this.lblDeal2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbGo);
            this.Controls.Add(this.grbCashier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "结帐";
            this.Load += new System.EventHandler(this.CashierForm_Load);
            this.grbCashier.ResumeLayout(false);
            this.grbCashier.PerformLayout();
            this.tbGo.ResumeLayout(false);
            this.tpGo.ResumeLayout(false);
            this.tpDeal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCashier;
        private System.Windows.Forms.ListView lvUptownHouse;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtRoom_id;
        private System.Windows.Forms.Label lblRoom_id;
        private System.Windows.Forms.RadioButton rdoTodayGo;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.TabControl tbGo;
        private System.Windows.Forms.TabPage tpGo;
        private System.Windows.Forms.TabPage tpDeal;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDeal2;
        private System.Windows.Forms.Label lblPaicl;
        private System.Windows.Forms.Label lblSpare;
        private System.Windows.Forms.TextBox txtPaicl;
        private System.Windows.Forms.Label txtSpare;
        private System.Windows.Forms.ColumnHeader R_id;
        private System.Windows.Forms.ColumnHeader chUname;
        private System.Windows.Forms.ColumnHeader chforegift;
        private System.Windows.Forms.ColumnHeader chcomeDate;
        private System.Windows.Forms.ColumnHeader chremark;
        private System.Windows.Forms.Label lblDeal;
        private System.Windows.Forms.ColumnHeader chBookleave;
        private System.Windows.Forms.ColumnHeader chFact;
        private System.Windows.Forms.ListView lvFitout;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader chUCope;
        private System.Windows.Forms.ColumnHeader chCope;
        private System.Windows.Forms.ColumnHeader chG_GuestId;
        private System.Windows.Forms.ColumnHeader chR_GuestId;
        private System.Windows.Forms.CheckBox chkUnderwrite;
        private System.Windows.Forms.ComboBox cboUnderwrite;
        private System.Windows.Forms.Label lblYaJin;
        private System.Windows.Forms.Label lblYaJin1;
        private System.Windows.Forms.CheckBox chkCust;
        private System.Windows.Forms.Label lblU_UserId;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbldiscount2;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.ListView lvConsume;
        private System.Windows.Forms.ColumnHeader chWareName;
        private System.Windows.Forms.ColumnHeader chWarePrice;
        private System.Windows.Forms.ColumnHeader chC_type;
        private System.Windows.Forms.ColumnHeader chWareCount;
        private System.Windows.Forms.ColumnHeader dhDate;
        private System.Windows.Forms.ColumnHeader chCOperator;
        private System.Windows.Forms.ColumnHeader chCRemark;
    }
}