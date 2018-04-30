namespace Hotel
{
    partial class RescindForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RescindForm));
            this.grbUnchain = new System.Windows.Forms.GroupBox();
            this.lvUnchainBook = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.grbBookHouse = new System.Windows.Forms.GroupBox();
            this.lvBookHouse = new System.Windows.Forms.ListView();
            this.chroomid = new System.Windows.Forms.ColumnHeader();
            this.chdateone = new System.Windows.Forms.ColumnHeader();
            this.chdatetwo = new System.Windows.Forms.ColumnHeader();
            this.chname = new System.Windows.Forms.ColumnHeader();
            this.chsex = new System.Windows.Forms.ColumnHeader();
            this.choper = new System.Windows.Forms.ColumnHeader();
            this.chremm = new System.Windows.Forms.ColumnHeader();
            this.grbUnchain.SuspendLayout();
            this.grbBookHouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUnchain
            // 
            this.grbUnchain.Controls.Add(this.lvUnchainBook);
            this.grbUnchain.Location = new System.Drawing.Point(23, 270);
            this.grbUnchain.Name = "grbUnchain";
            this.grbUnchain.Size = new System.Drawing.Size(633, 244);
            this.grbUnchain.TabIndex = 5;
            this.grbUnchain.TabStop = false;
            this.grbUnchain.Text = "待解除预订客房";
            // 
            // lvUnchainBook
            // 
            this.lvUnchainBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvUnchainBook.FullRowSelect = true;
            this.lvUnchainBook.GridLines = true;
            this.lvUnchainBook.Location = new System.Drawing.Point(28, 17);
            this.lvUnchainBook.Name = "lvUnchainBook";
            this.lvUnchainBook.Size = new System.Drawing.Size(576, 210);
            this.lvUnchainBook.TabIndex = 3;
            this.lvUnchainBook.UseCompatibleStateImageBehavior = false;
            this.lvUnchainBook.View = System.Windows.Forms.View.Details;
            this.lvUnchainBook.DoubleClick += new System.EventHandler(this.lvUnchainBook_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "房间号";
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
            this.columnHeader4.Text = "姓名";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "性别";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "操作员";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "备注";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(557, 530);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(454, 528);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grbBookHouse
            // 
            this.grbBookHouse.Controls.Add(this.lvBookHouse);
            this.grbBookHouse.Location = new System.Drawing.Point(23, 15);
            this.grbBookHouse.Name = "grbBookHouse";
            this.grbBookHouse.Size = new System.Drawing.Size(633, 244);
            this.grbBookHouse.TabIndex = 8;
            this.grbBookHouse.TabStop = false;
            this.grbBookHouse.Text = "已预订客房";
            // 
            // lvBookHouse
            // 
            this.lvBookHouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chroomid,
            this.chdateone,
            this.chdatetwo,
            this.chname,
            this.chsex,
            this.choper,
            this.chremm});
            this.lvBookHouse.FullRowSelect = true;
            this.lvBookHouse.GridLines = true;
            this.lvBookHouse.Location = new System.Drawing.Point(28, 17);
            this.lvBookHouse.Name = "lvBookHouse";
            this.lvBookHouse.Size = new System.Drawing.Size(576, 210);
            this.lvBookHouse.TabIndex = 2;
            this.lvBookHouse.UseCompatibleStateImageBehavior = false;
            this.lvBookHouse.View = System.Windows.Forms.View.Details;
            this.lvBookHouse.DoubleClick += new System.EventHandler(this.lvBookHouse_DoubleClick);
            // 
            // chroomid
            // 
            this.chroomid.Text = "房间号";
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
            // RescindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 572);
            this.Controls.Add(this.grbBookHouse);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grbUnchain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RescindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "解除预订";
            this.Load += new System.EventHandler(this.RescindForm_Load);
            this.grbUnchain.ResumeLayout(false);
            this.grbBookHouse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUnchain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox grbBookHouse;
        private System.Windows.Forms.ListView lvUnchainBook;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView lvBookHouse;
        private System.Windows.Forms.ColumnHeader chroomid;
        private System.Windows.Forms.ColumnHeader chdateone;
        private System.Windows.Forms.ColumnHeader chdatetwo;
        private System.Windows.Forms.ColumnHeader chname;
        private System.Windows.Forms.ColumnHeader chsex;
        private System.Windows.Forms.ColumnHeader choper;
        private System.Windows.Forms.ColumnHeader chremm;
    }
}