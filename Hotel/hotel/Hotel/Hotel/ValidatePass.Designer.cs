namespace Hotel
{
    partial class ValidatePass
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
            this.lblU_UsersId = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtU_UsersId = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblU_UsersId
            // 
            this.lblU_UsersId.AutoSize = true;
            this.lblU_UsersId.Location = new System.Drawing.Point(14, 17);
            this.lblU_UsersId.Name = "lblU_UsersId";
            this.lblU_UsersId.Size = new System.Drawing.Size(53, 12);
            this.lblU_UsersId.TabIndex = 0;
            this.lblU_UsersId.Text = "用户名：";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(20, 45);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(47, 12);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "密 码：";
            // 
            // txtU_UsersId
            // 
            this.txtU_UsersId.BackColor = System.Drawing.SystemColors.Control;
            this.txtU_UsersId.Location = new System.Drawing.Point(79, 10);
            this.txtU_UsersId.Name = "txtU_UsersId";
            this.txtU_UsersId.ReadOnly = true;
            this.txtU_UsersId.Size = new System.Drawing.Size(110, 21);
            this.txtU_UsersId.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(79, 42);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(110, 21);
            this.txtPass.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(39, 80);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(70, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(120, 79);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ValidatePass
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(216, 117);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtU_UsersId);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblU_UsersId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ValidatePass";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "验证密码";
            this.Shown += new System.EventHandler(this.ValidatePass_Shown);
            this.Load += new System.EventHandler(this.ValidatePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblU_UsersId;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtU_UsersId;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}