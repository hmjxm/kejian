namespace Hotel
{
    partial class UnitFillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitFillForm));
            this.grbUnitFill = new System.Windows.Forms.GroupBox();
            this.lvUnitFill = new System.Windows.Forms.ListView();
            this.chRoom_id = new System.Windows.Forms.ColumnHeader();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chComeDate = new System.Windows.Forms.ColumnHeader();
            this.chGoDate = new System.Windows.Forms.ColumnHeader();
            this.chPrice = new System.Windows.Forms.ColumnHeader();
            this.chRemark = new System.Windows.Forms.ColumnHeader();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboUnderwrite = new System.Windows.Forms.ComboBox();
            this.lblUnitFill = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUnitFill = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShiFu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZhaoLin = new System.Windows.Forms.TextBox();
            this.grbUnitFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUnitFill
            // 
            this.grbUnitFill.Controls.Add(this.lvUnitFill);
            this.grbUnitFill.Controls.Add(this.btnSearch);
            this.grbUnitFill.Controls.Add(this.cboUnderwrite);
            this.grbUnitFill.Controls.Add(this.lblUnitFill);
            this.grbUnitFill.Location = new System.Drawing.Point(22, 12);
            this.grbUnitFill.Name = "grbUnitFill";
            this.grbUnitFill.Size = new System.Drawing.Size(497, 314);
            this.grbUnitFill.TabIndex = 0;
            this.grbUnitFill.TabStop = false;
            this.grbUnitFill.Text = "单位补款";
            // 
            // lvUnitFill
            // 
            this.lvUnitFill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chRoom_id,
            this.chName,
            this.chComeDate,
            this.chGoDate,
            this.chPrice,
            this.chRemark});
            this.lvUnitFill.FullRowSelect = true;
            this.lvUnitFill.GridLines = true;
            this.lvUnitFill.Location = new System.Drawing.Point(17, 58);
            this.lvUnitFill.Name = "lvUnitFill";
            this.lvUnitFill.Size = new System.Drawing.Size(462, 240);
            this.lvUnitFill.TabIndex = 5;
            this.lvUnitFill.UseCompatibleStateImageBehavior = false;
            this.lvUnitFill.View = System.Windows.Forms.View.Details;
            this.lvUnitFill.Click += new System.EventHandler(this.lvUnitFill_Click);
            // 
            // chRoom_id
            // 
            this.chRoom_id.Text = "房间号";
            // 
            // chName
            // 
            this.chName.Text = "姓名";
            // 
            // chComeDate
            // 
            this.chComeDate.Text = "入住日期";
            this.chComeDate.Width = 79;
            // 
            // chGoDate
            // 
            this.chGoDate.Text = "离店日期";
            this.chGoDate.Width = 75;
            // 
            // chPrice
            // 
            this.chPrice.Text = "费用";
            this.chPrice.Width = 63;
            // 
            // chRemark
            // 
            this.chRemark.Text = "备注";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(234, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboUnderwrite
            // 
            this.cboUnderwrite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnderwrite.FormattingEnabled = true;
            this.cboUnderwrite.Location = new System.Drawing.Point(91, 20);
            this.cboUnderwrite.Name = "cboUnderwrite";
            this.cboUnderwrite.Size = new System.Drawing.Size(121, 20);
            this.cboUnderwrite.TabIndex = 1;
            // 
            // lblUnitFill
            // 
            this.lblUnitFill.AutoSize = true;
            this.lblUnitFill.Location = new System.Drawing.Point(20, 25);
            this.lblUnitFill.Name = "lblUnitFill";
            this.lblUnitFill.Size = new System.Drawing.Size(65, 12);
            this.lblUnitFill.TabIndex = 0;
            this.lblUnitFill.Text = "挂单单位：";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(421, 373);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUnitFill
            // 
            this.btnUnitFill.Location = new System.Drawing.Point(340, 374);
            this.btnUnitFill.Name = "btnUnitFill";
            this.btnUnitFill.Size = new System.Drawing.Size(75, 23);
            this.btnUnitFill.TabIndex = 3;
            this.btnUnitFill.Text = "补款";
            this.btnUnitFill.UseVisualStyleBackColor = true;
            this.btnUnitFill.Click += new System.EventHandler(this.btnUnitFill_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(74, 341);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(80, 21);
            this.txtPrice.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(27, 346);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 12);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "金额：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "实付：";
            // 
            // txtShiFu
            // 
            this.txtShiFu.Location = new System.Drawing.Point(239, 341);
            this.txtShiFu.Name = "txtShiFu";
            this.txtShiFu.Size = new System.Drawing.Size(80, 21);
            this.txtShiFu.TabIndex = 8;
            this.txtShiFu.TextChanged += new System.EventHandler(this.txtShiFu_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "找零：";
            // 
            // txtZhaoLin
            // 
            this.txtZhaoLin.Location = new System.Drawing.Point(406, 341);
            this.txtZhaoLin.Name = "txtZhaoLin";
            this.txtZhaoLin.ReadOnly = true;
            this.txtZhaoLin.Size = new System.Drawing.Size(80, 21);
            this.txtZhaoLin.TabIndex = 10;
            // 
            // UnitFillForm
            // 
            this.AcceptButton = this.btnUnitFill;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(552, 413);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtZhaoLin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShiFu);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.grbUnitFill);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnUnitFill);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UnitFillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "单位补款";
            this.Load += new System.EventHandler(this.UnitFillForm_Load);
            this.grbUnitFill.ResumeLayout(false);
            this.grbUnitFill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUnitFill;
        private System.Windows.Forms.Label lblUnitFill;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUnitFill;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboUnderwrite;
        private System.Windows.Forms.ListView lvUnitFill;
        private System.Windows.Forms.ColumnHeader chRoom_id;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chComeDate;
        private System.Windows.Forms.ColumnHeader chGoDate;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.ColumnHeader chRemark;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShiFu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZhaoLin;
    }
}