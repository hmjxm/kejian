namespace Hotel
{
    partial class UnderwriteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnderwriteForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbAddUnderwrite = new System.Windows.Forms.GroupBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtUnderwrite = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblA_AdminId = new System.Windows.Forms.Label();
            this.chkBatch = new System.Windows.Forms.CheckBox();
            this.grbAddUnderwrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(135, 155);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(42, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbAddUnderwrite
            // 
            this.grbAddUnderwrite.Controls.Add(this.txtRemark);
            this.grbAddUnderwrite.Controls.Add(this.txtUnderwrite);
            this.grbAddUnderwrite.Controls.Add(this.lblPass);
            this.grbAddUnderwrite.Controls.Add(this.lblA_AdminId);
            this.grbAddUnderwrite.Location = new System.Drawing.Point(17, 48);
            this.grbAddUnderwrite.Name = "grbAddUnderwrite";
            this.grbAddUnderwrite.Size = new System.Drawing.Size(209, 90);
            this.grbAddUnderwrite.TabIndex = 12;
            this.grbAddUnderwrite.TabStop = false;
            this.grbAddUnderwrite.Text = "添加签单";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(83, 46);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.PasswordChar = '*';
            this.txtRemark.Size = new System.Drawing.Size(100, 21);
            this.txtRemark.TabIndex = 6;
            // 
            // txtUnderwrite
            // 
            this.txtUnderwrite.Location = new System.Drawing.Point(83, 19);
            this.txtUnderwrite.Name = "txtUnderwrite";
            this.txtUnderwrite.Size = new System.Drawing.Size(100, 21);
            this.txtUnderwrite.TabIndex = 5;
            this.txtUnderwrite.Leave += new System.EventHandler(this.txtUnderwrite_Leave);
            this.txtUnderwrite.TextChanged += new System.EventHandler(this.txtUnderwrite_TextChanged);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(36, 49);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(41, 12);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "备注：";
            // 
            // lblA_AdminId
            // 
            this.lblA_AdminId.AutoSize = true;
            this.lblA_AdminId.Location = new System.Drawing.Point(12, 22);
            this.lblA_AdminId.Name = "lblA_AdminId";
            this.lblA_AdminId.Size = new System.Drawing.Size(65, 12);
            this.lblA_AdminId.TabIndex = 0;
            this.lblA_AdminId.Text = "签单单位：";
            // 
            // chkBatch
            // 
            this.chkBatch.AutoSize = true;
            this.chkBatch.Location = new System.Drawing.Point(42, 13);
            this.chkBatch.Name = "chkBatch";
            this.chkBatch.Size = new System.Drawing.Size(72, 16);
            this.chkBatch.TabIndex = 15;
            this.chkBatch.Text = "批量添加";
            this.chkBatch.UseVisualStyleBackColor = true;
            // 
            // UnderwriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 197);
            this.Controls.Add(this.chkBatch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbAddUnderwrite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnderwriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理签单";
            this.Load += new System.EventHandler(this.UnderwriteForm_Load);
            this.grbAddUnderwrite.ResumeLayout(false);
            this.grbAddUnderwrite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbAddUnderwrite;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtUnderwrite;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblA_AdminId;
        private System.Windows.Forms.CheckBox chkBatch;
    }
}