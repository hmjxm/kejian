namespace Hotel
{
    partial class BusinessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessForm));
            this.grpmerchandise = new System.Windows.Forms.GroupBox();
            this.btnEasyName = new System.Windows.Forms.Button();
            this.txtEasyName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnNameSelect = new System.Windows.Forms.Button();
            this.lvWare = new System.Windows.Forms.ListView();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chComePrice = new System.Windows.Forms.ColumnHeader();
            this.chGoPrice = new System.Windows.Forms.ColumnHeader();
            this.chtype = new System.Windows.Forms.ColumnHeader();
            this.chcount = new System.Windows.Forms.ColumnHeader();
            this.chWareUnit = new System.Windows.Forms.ColumnHeader();
            this.chEasyName = new System.Windows.Forms.ColumnHeader();
            this.chtime = new System.Windows.Forms.ColumnHeader();
            this.chauthorized = new System.Windows.Forms.ColumnHeader();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpmerchandise.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpmerchandise
            // 
            this.grpmerchandise.Controls.Add(this.btnEasyName);
            this.grpmerchandise.Controls.Add(this.txtEasyName);
            this.grpmerchandise.Controls.Add(this.lblType);
            this.grpmerchandise.Controls.Add(this.cboType);
            this.grpmerchandise.Controls.Add(this.txtName);
            this.grpmerchandise.Controls.Add(this.btnNameSelect);
            this.grpmerchandise.Controls.Add(this.lvWare);
            this.grpmerchandise.Controls.Add(this.btnDelete);
            this.grpmerchandise.Controls.Add(this.btnUpdate);
            this.grpmerchandise.Controls.Add(this.btnAdd);
            this.grpmerchandise.Location = new System.Drawing.Point(12, 12);
            this.grpmerchandise.Name = "grpmerchandise";
            this.grpmerchandise.Size = new System.Drawing.Size(629, 364);
            this.grpmerchandise.TabIndex = 10;
            this.grpmerchandise.TabStop = false;
            this.grpmerchandise.Text = "商品管理";
            // 
            // btnEasyName
            // 
            this.btnEasyName.Location = new System.Drawing.Point(337, 18);
            this.btnEasyName.Name = "btnEasyName";
            this.btnEasyName.Size = new System.Drawing.Size(75, 23);
            this.btnEasyName.TabIndex = 11;
            this.btnEasyName.Text = "简索码查询";
            this.btnEasyName.UseVisualStyleBackColor = true;
            // 
            // txtEasyName
            // 
            this.txtEasyName.Location = new System.Drawing.Point(256, 19);
            this.txtEasyName.Name = "txtEasyName";
            this.txtEasyName.Size = new System.Drawing.Size(75, 21);
            this.txtEasyName.TabIndex = 10;
            this.txtEasyName.TextChanged += new System.EventHandler(this.txtEasyName_TextChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(448, 25);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(65, 12);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "类型查询：";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "全部",
            "烟酒",
            "日用品",
            "熟食",
            "饮料",
            "其它"});
            this.cboType.Location = new System.Drawing.Point(519, 20);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(90, 20);
            this.cboType.TabIndex = 8;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectionChangeCommitted);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(24, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(81, 21);
            this.txtName.TabIndex = 6;
            // 
            // btnNameSelect
            // 
            this.btnNameSelect.Location = new System.Drawing.Point(111, 18);
            this.btnNameSelect.Name = "btnNameSelect";
            this.btnNameSelect.Size = new System.Drawing.Size(75, 23);
            this.btnNameSelect.TabIndex = 5;
            this.btnNameSelect.Text = "名称查询";
            this.btnNameSelect.UseVisualStyleBackColor = true;
            this.btnNameSelect.Click += new System.EventHandler(this.btnNameSelect_Click);
            // 
            // lvWare
            // 
            this.lvWare.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chComePrice,
            this.chGoPrice,
            this.chtype,
            this.chcount,
            this.chWareUnit,
            this.chEasyName,
            this.chtime,
            this.chauthorized});
            this.lvWare.FullRowSelect = true;
            this.lvWare.GridLines = true;
            this.lvWare.Location = new System.Drawing.Point(24, 66);
            this.lvWare.Name = "lvWare";
            this.lvWare.Size = new System.Drawing.Size(585, 238);
            this.lvWare.TabIndex = 4;
            this.lvWare.UseCompatibleStateImageBehavior = false;
            this.lvWare.View = System.Windows.Forms.View.Details;
            this.lvWare.DoubleClick += new System.EventHandler(this.btnUpdate_Click);
            // 
            // chName
            // 
            this.chName.Text = "名称";
            // 
            // chComePrice
            // 
            this.chComePrice.Text = "进货单价";
            this.chComePrice.Width = 72;
            // 
            // chGoPrice
            // 
            this.chGoPrice.Text = "预售单价";
            this.chGoPrice.Width = 71;
            // 
            // chtype
            // 
            this.chtype.Text = "类型";
            // 
            // chcount
            // 
            this.chcount.Text = "数量";
            // 
            // chWareUnit
            // 
            this.chWareUnit.Text = "单位";
            // 
            // chEasyName
            // 
            this.chEasyName.Text = "检索码";
            // 
            // chtime
            // 
            this.chtime.Text = "日期";
            // 
            // chauthorized
            // 
            this.chauthorized.Text = "供销商";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(415, 318);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(287, 318);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(166, 318);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BusinessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 394);
            this.Controls.Add(this.grpmerchandise);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BusinessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品管理";
            this.Activated += new System.EventHandler(this.BusinessForm_Activated);
            this.Load += new System.EventHandler(this.BusinessForm_Load);
            this.grpmerchandise.ResumeLayout(false);
            this.grpmerchandise.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpmerchandise;
        private System.Windows.Forms.ListView lvWare;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chComePrice;
        private System.Windows.Forms.ColumnHeader chGoPrice;
        private System.Windows.Forms.ColumnHeader chtype;
        private System.Windows.Forms.ColumnHeader chcount;
        private System.Windows.Forms.ColumnHeader chWareUnit;
        private System.Windows.Forms.ColumnHeader chEasyName;
        private System.Windows.Forms.ColumnHeader chtime;
        private System.Windows.Forms.ColumnHeader chauthorized;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnNameSelect;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtEasyName;
        private System.Windows.Forms.Button btnEasyName;



    }
}