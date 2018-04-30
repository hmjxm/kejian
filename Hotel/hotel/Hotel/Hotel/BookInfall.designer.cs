namespace Hotel
{
    partial class BookInfall
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
            System.Windows.Forms.ColumnHeader chroomid;
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookInfall));
            this.grbBook = new System.Windows.Forms.GroupBox();
            this.lvBookHouse = new System.Windows.Forms.ListView();
            this.chdateone = new System.Windows.Forms.ColumnHeader();
            this.chdatetwo = new System.Windows.Forms.ColumnHeader();
            this.chmoney = new System.Windows.Forms.ColumnHeader();
            this.chname = new System.Windows.Forms.ColumnHeader();
            this.chsex = new System.Windows.Forms.ColumnHeader();
            this.choper = new System.Windows.Forms.ColumnHeader();
            this.chremm = new System.Windows.Forms.ColumnHeader();
            this.grbHouse = new System.Windows.Forms.GroupBox();
            this.lvFitoutHouse = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            chroomid = new System.Windows.Forms.ColumnHeader();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.grbBook.SuspendLayout();
            this.grbHouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // chroomid
            // 
            chroomid.Text = "房间号";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "房间号";
            // 
            // grbBook
            // 
            this.grbBook.Controls.Add(this.lvBookHouse);
            this.grbBook.Location = new System.Drawing.Point(12, 2);
            this.grbBook.Name = "grbBook";
            this.grbBook.Size = new System.Drawing.Size(633, 244);
            this.grbBook.TabIndex = 2;
            this.grbBook.TabStop = false;
            this.grbBook.Text = "已预订客房";
            // 
            // lvBookHouse
            // 
            this.lvBookHouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            chroomid,
            this.chdateone,
            this.chdatetwo,
            this.chmoney,
            this.chname,
            this.chsex,
            this.choper,
            this.chremm});
            this.lvBookHouse.FullRowSelect = true;
            this.lvBookHouse.GridLines = true;
            this.lvBookHouse.Location = new System.Drawing.Point(29, 20);
            this.lvBookHouse.Name = "lvBookHouse";
            this.lvBookHouse.Size = new System.Drawing.Size(576, 210);
            this.lvBookHouse.TabIndex = 1;
            this.lvBookHouse.UseCompatibleStateImageBehavior = false;
            this.lvBookHouse.View = System.Windows.Forms.View.Details;
            this.lvBookHouse.DoubleClick += new System.EventHandler(this.lvBookHouse_DoubleClick);
            // 
            // chdateone
            // 
            this.chdateone.Text = "入住时间";
            this.chdateone.Width = 65;
            // 
            // chdatetwo
            // 
            this.chdatetwo.Text = "预离时间";
            this.chdatetwo.Width = 70;
            // 
            // chmoney
            // 
            this.chmoney.Text = "押金";
            // 
            // chname
            // 
            this.chname.Text = "姓名";
            // 
            // chsex
            // 
            this.chsex.Text = "性别";
            // 
            // choper
            // 
            this.choper.Text = "操作员";
            // 
            // chremm
            // 
            this.chremm.Text = "备注";
            // 
            // grbHouse
            // 
            this.grbHouse.Controls.Add(this.lvFitoutHouse);
            this.grbHouse.Location = new System.Drawing.Point(12, 260);
            this.grbHouse.Name = "grbHouse";
            this.grbHouse.Size = new System.Drawing.Size(633, 244);
            this.grbHouse.TabIndex = 3;
            this.grbHouse.TabStop = false;
            this.grbHouse.Text = "已选客房";
            // 
            // lvFitoutHouse
            // 
            this.lvFitoutHouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvFitoutHouse.FullRowSelect = true;
            this.lvFitoutHouse.GridLines = true;
            this.lvFitoutHouse.Location = new System.Drawing.Point(28, 17);
            this.lvFitoutHouse.Name = "lvFitoutHouse";
            this.lvFitoutHouse.Size = new System.Drawing.Size(576, 210);
            this.lvFitoutHouse.TabIndex = 2;
            this.lvFitoutHouse.UseCompatibleStateImageBehavior = false;
            this.lvFitoutHouse.View = System.Windows.Forms.View.Details;
            this.lvFitoutHouse.DoubleClick += new System.EventHandler(this.lvFitoutHouse_DoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "入住时间";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "预离时间";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "押金";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "姓名";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "性别";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "操作员";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "备注";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(446, 516);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(549, 516);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BookInfall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 548);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grbHouse);
            this.Controls.Add(this.grbBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookInfall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预订入住";
            this.Load += new System.EventHandler(this.BookInfall_Load);
            this.grbBook.ResumeLayout(false);
            this.grbHouse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBook;
        private System.Windows.Forms.GroupBox grbHouse;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lvBookHouse;
        private System.Windows.Forms.ColumnHeader chdateone;
        private System.Windows.Forms.ColumnHeader chdatetwo;
        private System.Windows.Forms.ColumnHeader chname;
        private System.Windows.Forms.ColumnHeader chsex;
        private System.Windows.Forms.ColumnHeader choper;
        private System.Windows.Forms.ColumnHeader chremm;
        private System.Windows.Forms.ColumnHeader chmoney;
        private System.Windows.Forms.ListView lvFitoutHouse;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}