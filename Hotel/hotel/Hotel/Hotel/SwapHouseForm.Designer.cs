namespace Hotel
{
    partial class SwapHouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwapHouseForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblOldHousePrice = new System.Windows.Forms.Label();
            this.lblOldPrice = new System.Windows.Forms.Label();
            this.lblOldMoney = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEnsure = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboOldHouse = new System.Windows.Forms.ComboBox();
            this.cboNewHouse = new System.Windows.Forms.ComboBox();
            this.lblNewHouse = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblAdvert = new System.Windows.Forms.Label();
            this.lblOldDate = new System.Windows.Forms.Label();
            this.lblOldDate1 = new System.Windows.Forms.Label();
            this.lblremark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.dtpBookLeave = new System.Windows.Forms.DateTimePicker();
            this.lblBookLeave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原来客房：";
            // 
            // lblOldHousePrice
            // 
            this.lblOldHousePrice.AutoSize = true;
            this.lblOldHousePrice.Location = new System.Drawing.Point(40, 66);
            this.lblOldHousePrice.Name = "lblOldHousePrice";
            this.lblOldHousePrice.Size = new System.Drawing.Size(89, 12);
            this.lblOldHousePrice.TabIndex = 1;
            this.lblOldHousePrice.Text = "原客房的单价：";
            // 
            // lblOldPrice
            // 
            this.lblOldPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOldPrice.Location = new System.Drawing.Point(138, 60);
            this.lblOldPrice.Name = "lblOldPrice";
            this.lblOldPrice.Size = new System.Drawing.Size(141, 24);
            this.lblOldPrice.TabIndex = 3;
            // 
            // lblOldMoney
            // 
            this.lblOldMoney.AutoSize = true;
            this.lblOldMoney.Location = new System.Drawing.Point(28, 140);
            this.lblOldMoney.Name = "lblOldMoney";
            this.lblOldMoney.Size = new System.Drawing.Size(101, 12);
            this.lblOldMoney.TabIndex = 7;
            this.lblOldMoney.Text = "原客房产生费用：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "新客房价格：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(303, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "换到新客房：";
            // 
            // btnEnsure
            // 
            this.btnEnsure.Location = new System.Drawing.Point(171, 213);
            this.btnEnsure.Name = "btnEnsure";
            this.btnEnsure.Size = new System.Drawing.Size(75, 23);
            this.btnEnsure.TabIndex = 14;
            this.btnEnsure.Text = "确定";
            this.btnEnsure.UseVisualStyleBackColor = true;
            this.btnEnsure.Click += new System.EventHandler(this.btnEnsure_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboOldHouse
            // 
            this.cboOldHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOldHouse.FormattingEnabled = true;
            this.cboOldHouse.Location = new System.Drawing.Point(140, 24);
            this.cboOldHouse.Name = "cboOldHouse";
            this.cboOldHouse.Size = new System.Drawing.Size(139, 20);
            this.cboOldHouse.TabIndex = 16;
            this.cboOldHouse.SelectedIndexChanged += new System.EventHandler(this.cboOldHouse_SelectedIndexChanged);
            // 
            // cboNewHouse
            // 
            this.cboNewHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewHouse.FormattingEnabled = true;
            this.cboNewHouse.Location = new System.Drawing.Point(387, 24);
            this.cboNewHouse.Name = "cboNewHouse";
            this.cboNewHouse.Size = new System.Drawing.Size(129, 20);
            this.cboNewHouse.TabIndex = 17;
            this.cboNewHouse.SelectedIndexChanged += new System.EventHandler(this.cboNewHouse_SelectedIndexChanged);
            // 
            // lblNewHouse
            // 
            this.lblNewHouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNewHouse.Location = new System.Drawing.Point(387, 64);
            this.lblNewHouse.Name = "lblNewHouse";
            this.lblNewHouse.Size = new System.Drawing.Size(129, 24);
            this.lblNewHouse.TabIndex = 20;
            // 
            // lblMoney
            // 
            this.lblMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMoney.ForeColor = System.Drawing.Color.Red;
            this.lblMoney.Location = new System.Drawing.Point(138, 136);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(141, 24);
            this.lblMoney.TabIndex = 21;
            // 
            // lblAdvert
            // 
            this.lblAdvert.AutoSize = true;
            this.lblAdvert.Location = new System.Drawing.Point(28, 177);
            this.lblAdvert.Name = "lblAdvert";
            this.lblAdvert.Size = new System.Drawing.Size(209, 12);
            this.lblAdvert.TabIndex = 22;
            this.lblAdvert.Text = "注意：原客房产生费用将移入新可房中";
            // 
            // lblOldDate
            // 
            this.lblOldDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOldDate.ForeColor = System.Drawing.Color.Red;
            this.lblOldDate.Location = new System.Drawing.Point(138, 102);
            this.lblOldDate.Name = "lblOldDate";
            this.lblOldDate.Size = new System.Drawing.Size(141, 24);
            this.lblOldDate.TabIndex = 24;
            // 
            // lblOldDate1
            // 
            this.lblOldDate1.AutoSize = true;
            this.lblOldDate1.Location = new System.Drawing.Point(28, 107);
            this.lblOldDate1.Name = "lblOldDate1";
            this.lblOldDate1.Size = new System.Drawing.Size(101, 12);
            this.lblOldDate1.TabIndex = 23;
            this.lblOldDate1.Text = "原客房入住日期：";
            // 
            // lblremark
            // 
            this.lblremark.AutoSize = true;
            this.lblremark.Location = new System.Drawing.Point(338, 142);
            this.lblremark.Name = "lblremark";
            this.lblremark.Size = new System.Drawing.Size(41, 12);
            this.lblremark.TabIndex = 25;
            this.lblremark.Text = "备注：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(387, 139);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(129, 21);
            this.txtRemark.TabIndex = 26;
            // 
            // dtpBookLeave
            // 
            this.dtpBookLeave.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpBookLeave.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookLeave.Location = new System.Drawing.Point(387, 105);
            this.dtpBookLeave.Name = "dtpBookLeave";
            this.dtpBookLeave.Size = new System.Drawing.Size(129, 21);
            this.dtpBookLeave.TabIndex = 27;
            // 
            // lblBookLeave
            // 
            this.lblBookLeave.AutoSize = true;
            this.lblBookLeave.Location = new System.Drawing.Point(314, 109);
            this.lblBookLeave.Name = "lblBookLeave";
            this.lblBookLeave.Size = new System.Drawing.Size(65, 12);
            this.lblBookLeave.TabIndex = 28;
            this.lblBookLeave.Text = "预离时间：";
            // 
            // SwapHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 245);
            this.Controls.Add(this.lblBookLeave);
            this.Controls.Add(this.dtpBookLeave);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblremark);
            this.Controls.Add(this.lblOldDate);
            this.Controls.Add(this.lblOldDate1);
            this.Controls.Add(this.lblAdvert);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblNewHouse);
            this.Controls.Add(this.cboNewHouse);
            this.Controls.Add(this.cboOldHouse);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnsure);
            this.Controls.Add(this.lblOldMoney);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblOldPrice);
            this.Controls.Add(this.lblOldHousePrice);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SwapHouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "换房";
            this.Load += new System.EventHandler(this.SwapHouseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOldHousePrice;
        private System.Windows.Forms.Label lblOldPrice;
        private System.Windows.Forms.Label lblOldMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEnsure;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboOldHouse;
        private System.Windows.Forms.ComboBox cboNewHouse;
        private System.Windows.Forms.Label lblNewHouse;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblAdvert;
        private System.Windows.Forms.Label lblOldDate;
        private System.Windows.Forms.Label lblOldDate1;
        private System.Windows.Forms.Label lblremark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.DateTimePicker dtpBookLeave;
        private System.Windows.Forms.Label lblBookLeave;
    }
}