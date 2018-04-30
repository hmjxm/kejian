namespace Hotel
{
    partial class AddWareForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWareForm));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbAdd = new System.Windows.Forms.GroupBox();
            this.cboWareUnit = new System.Windows.Forms.ComboBox();
            this.lblWareUnit = new System.Windows.Forms.Label();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.cboAuthorized = new System.Windows.Forms.ComboBox();
            this.txtGoPrice = new System.Windows.Forms.TextBox();
            this.lblGoPrice = new System.Windows.Forms.Label();
            this.txtWareEasyName = new System.Windows.Forms.TextBox();
            this.lblWareEasyName = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtComePrice = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblComePrice = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblcount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cbkBatch = new System.Windows.Forms.CheckBox();
            this.chkNewWare = new System.Windows.Forms.CheckBox();
            this.grbAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(134, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(225, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grbAdd
            // 
            this.grbAdd.Controls.Add(this.cboWareUnit);
            this.grbAdd.Controls.Add(this.lblWareUnit);
            this.grbAdd.Controls.Add(this.cboName);
            this.grbAdd.Controls.Add(this.cboAuthorized);
            this.grbAdd.Controls.Add(this.txtGoPrice);
            this.grbAdd.Controls.Add(this.lblGoPrice);
            this.grbAdd.Controls.Add(this.txtWareEasyName);
            this.grbAdd.Controls.Add(this.lblWareEasyName);
            this.grbAdd.Controls.Add(this.cboType);
            this.grbAdd.Controls.Add(this.lblType);
            this.grbAdd.Controls.Add(this.dtpDate);
            this.grbAdd.Controls.Add(this.txtComePrice);
            this.grbAdd.Controls.Add(this.txtCount);
            this.grbAdd.Controls.Add(this.lblAddress);
            this.grbAdd.Controls.Add(this.lblComePrice);
            this.grbAdd.Controls.Add(this.lblDate);
            this.grbAdd.Controls.Add(this.lblcount);
            this.grbAdd.Controls.Add(this.lblName);
            this.grbAdd.Location = new System.Drawing.Point(17, 36);
            this.grbAdd.Name = "grbAdd";
            this.grbAdd.Size = new System.Drawing.Size(406, 178);
            this.grbAdd.TabIndex = 12;
            this.grbAdd.TabStop = false;
            this.grbAdd.Text = "添加商品";
            // 
            // cboWareUnit
            // 
            this.cboWareUnit.FormattingEnabled = true;
            this.cboWareUnit.Items.AddRange(new object[] {
            "个",
            "条",
            "瓶",
            "包",
            "双"});
            this.cboWareUnit.Location = new System.Drawing.Point(90, 82);
            this.cboWareUnit.Name = "cboWareUnit";
            this.cboWareUnit.Size = new System.Drawing.Size(103, 20);
            this.cboWareUnit.TabIndex = 30;
            // 
            // lblWareUnit
            // 
            this.lblWareUnit.AutoSize = true;
            this.lblWareUnit.Location = new System.Drawing.Point(40, 87);
            this.lblWareUnit.Name = "lblWareUnit";
            this.lblWareUnit.Size = new System.Drawing.Size(41, 12);
            this.lblWareUnit.TabIndex = 29;
            this.lblWareUnit.Text = "单位：";
            // 
            // cboName
            // 
            this.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(89, 21);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(103, 20);
            this.cboName.TabIndex = 28;
            this.cboName.SelectedIndexChanged += new System.EventHandler(this.cboName_SelectedIndexChanged);
            this.cboName.TextChanged += new System.EventHandler(this.cboName_TextChanged);
            // 
            // cboAuthorized
            // 
            this.cboAuthorized.FormattingEnabled = true;
            this.cboAuthorized.Location = new System.Drawing.Point(284, 117);
            this.cboAuthorized.Name = "cboAuthorized";
            this.cboAuthorized.Size = new System.Drawing.Size(104, 20);
            this.cboAuthorized.TabIndex = 27;
            this.cboAuthorized.TextChanged += new System.EventHandler(this.cboAuthorized_TextChanged);
            // 
            // txtGoPrice
            // 
            this.txtGoPrice.Location = new System.Drawing.Point(284, 87);
            this.txtGoPrice.Name = "txtGoPrice";
            this.txtGoPrice.Size = new System.Drawing.Size(103, 21);
            this.txtGoPrice.TabIndex = 26;
            this.txtGoPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoPrice_KeyPress);
            this.txtGoPrice.TextChanged += new System.EventHandler(this.txtGoPrice_TextChanged);
            // 
            // lblGoPrice
            // 
            this.lblGoPrice.AutoSize = true;
            this.lblGoPrice.Location = new System.Drawing.Point(217, 90);
            this.lblGoPrice.Name = "lblGoPrice";
            this.lblGoPrice.Size = new System.Drawing.Size(65, 12);
            this.lblGoPrice.TabIndex = 25;
            this.lblGoPrice.Text = "预售单价：";
            // 
            // txtWareEasyName
            // 
            this.txtWareEasyName.Location = new System.Drawing.Point(89, 111);
            this.txtWareEasyName.Name = "txtWareEasyName";
            this.txtWareEasyName.Size = new System.Drawing.Size(104, 21);
            this.txtWareEasyName.TabIndex = 24;
            this.txtWareEasyName.TextChanged += new System.EventHandler(this.txtWareEasyName_TextChanged);
            // 
            // lblWareEasyName
            // 
            this.lblWareEasyName.AutoSize = true;
            this.lblWareEasyName.Location = new System.Drawing.Point(40, 114);
            this.lblWareEasyName.Name = "lblWareEasyName";
            this.lblWareEasyName.Size = new System.Drawing.Size(47, 12);
            this.lblWareEasyName.TabIndex = 23;
            this.lblWareEasyName.Text = "检索码:";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(90, 140);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(103, 20);
            this.cboType.TabIndex = 22;
            this.cboType.TextChanged += new System.EventHandler(this.cboType_TextChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(23, 143);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(65, 12);
            this.lblType.TabIndex = 21;
            this.lblType.Text = "商品类型：";
            // 
            // dtpDate
            // 
            this.dtpDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDate.Location = new System.Drawing.Point(283, 20);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(104, 21);
            this.dtpDate.TabIndex = 20;
            // 
            // txtComePrice
            // 
            this.txtComePrice.Location = new System.Drawing.Point(284, 58);
            this.txtComePrice.Name = "txtComePrice";
            this.txtComePrice.Size = new System.Drawing.Size(103, 21);
            this.txtComePrice.TabIndex = 18;
            this.txtComePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComePrice_KeyPress);
            this.txtComePrice.TextChanged += new System.EventHandler(this.txtComePrice_TextChanged);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(89, 51);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(104, 21);
            this.txtCount.TabIndex = 16;
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCount_KeyPress);
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(224, 120);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(53, 12);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "经销商：";
            // 
            // lblComePrice
            // 
            this.lblComePrice.AutoSize = true;
            this.lblComePrice.Location = new System.Drawing.Point(217, 61);
            this.lblComePrice.Name = "lblComePrice";
            this.lblComePrice.Size = new System.Drawing.Size(65, 12);
            this.lblComePrice.TabIndex = 13;
            this.lblComePrice.Text = "进货单价：";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(217, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 12);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "进货时间：";
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Location = new System.Drawing.Point(22, 57);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(65, 12);
            this.lblcount.TabIndex = 11;
            this.lblcount.Text = "商品数量：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "商品名称：";
            // 
            // cbkBatch
            // 
            this.cbkBatch.AutoSize = true;
            this.cbkBatch.Location = new System.Drawing.Point(80, 14);
            this.cbkBatch.Name = "cbkBatch";
            this.cbkBatch.Size = new System.Drawing.Size(96, 16);
            this.cbkBatch.TabIndex = 13;
            this.cbkBatch.Text = "我要批量添加";
            this.cbkBatch.UseVisualStyleBackColor = true;
            // 
            // chkNewWare
            // 
            this.chkNewWare.AutoSize = true;
            this.chkNewWare.Location = new System.Drawing.Point(221, 14);
            this.chkNewWare.Name = "chkNewWare";
            this.chkNewWare.Size = new System.Drawing.Size(60, 16);
            this.chkNewWare.TabIndex = 14;
            this.chkNewWare.Text = "新商品";
            this.chkNewWare.UseVisualStyleBackColor = true;
            this.chkNewWare.CheckedChanged += new System.EventHandler(this.chkNewWare_CheckedChanged);
            // 
            // AddWareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 264);
            this.Controls.Add(this.chkNewWare);
            this.Controls.Add(this.cbkBatch);
            this.Controls.Add(this.grbAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddWareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加商品";
            this.Shown += new System.EventHandler(this.AddWareForm_Shown);
            this.Load += new System.EventHandler(this.AddWareForm_Load);
            this.grbAdd.ResumeLayout(false);
            this.grbAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grbAdd;
        private System.Windows.Forms.TextBox txtComePrice;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblComePrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtWareEasyName;
        private System.Windows.Forms.Label lblWareEasyName;
        private System.Windows.Forms.TextBox txtGoPrice;
        private System.Windows.Forms.Label lblGoPrice;
        private System.Windows.Forms.ComboBox cboAuthorized;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.CheckBox cbkBatch;
        private System.Windows.Forms.Label lblWareUnit;
        private System.Windows.Forms.ComboBox cboWareUnit;
        private System.Windows.Forms.CheckBox chkNewWare;

    }
}