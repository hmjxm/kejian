namespace Hotel
{
    partial class SameName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SameName));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvSameName = new System.Windows.Forms.ListView();
            this.chU_UserId = new System.Windows.Forms.ColumnHeader();
            this.chUname = new System.Windows.Forms.ColumnHeader();
            this.chSex = new System.Windows.Forms.ColumnHeader();
            this.chCertificateType = new System.Windows.Forms.ColumnHeader();
            this.chCertificateID = new System.Windows.Forms.ColumnHeader();
            this.chAddress = new System.Windows.Forms.ColumnHeader();
            this.chcontactTel = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvSameName);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "同姓名提醒";
            // 
            // lvSameName
            // 
            this.lvSameName.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chU_UserId,
            this.chUname,
            this.chSex,
            this.chCertificateType,
            this.chCertificateID,
            this.chAddress,
            this.chcontactTel});
            this.lvSameName.FullRowSelect = true;
            this.lvSameName.GridLines = true;
            this.lvSameName.Location = new System.Drawing.Point(19, 20);
            this.lvSameName.Name = "lvSameName";
            this.lvSameName.Size = new System.Drawing.Size(540, 224);
            this.lvSameName.TabIndex = 0;
            this.lvSameName.UseCompatibleStateImageBehavior = false;
            this.lvSameName.View = System.Windows.Forms.View.Details;
            this.lvSameName.DoubleClick += new System.EventHandler(this.lvSameName_DoubleClick);
            // 
            // chU_UserId
            // 
            this.chU_UserId.Text = "用户ID";
            // 
            // chUname
            // 
            this.chUname.Text = "姓名";
            // 
            // chSex
            // 
            this.chSex.Text = "性别";
            this.chSex.Width = 51;
            // 
            // chCertificateType
            // 
            this.chCertificateType.Text = "证件类型";
            this.chCertificateType.Width = 69;
            // 
            // chCertificateID
            // 
            this.chCertificateID.Text = "证件号码";
            this.chCertificateID.Width = 69;
            // 
            // chAddress
            // 
            this.chAddress.Text = "地址";
            // 
            // chcontactTel
            // 
            this.chcontactTel.Text = "联系方式";
            this.chcontactTel.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "如果有相同姓名，请根据证件号码！　　　　操作：双击选中的记录。";
            // 
            // SameName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SameName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "同姓名提醒";
            this.Load += new System.EventHandler(this.SameForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListView lvSameName;
        private System.Windows.Forms.ColumnHeader chU_UserId;
        private System.Windows.Forms.ColumnHeader chUname;
        private System.Windows.Forms.ColumnHeader chSex;
        private System.Windows.Forms.ColumnHeader chCertificateType;
        private System.Windows.Forms.ColumnHeader chCertificateID;
        private System.Windows.Forms.ColumnHeader chAddress;
        private System.Windows.Forms.ColumnHeader chcontactTel;
        private System.Windows.Forms.Label label1;
    }
}