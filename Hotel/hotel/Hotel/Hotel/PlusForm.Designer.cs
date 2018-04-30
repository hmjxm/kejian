//download by http://www.codefans.net
namespace Hotel
{
    partial class PlusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlusForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtU_UsersId = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblU_UsersId = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(123, 117);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(42, 118);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(70, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(91, 46);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(110, 21);
            this.txtPass.TabIndex = 9;
            // 
            // txtU_UsersId
            // 
            this.txtU_UsersId.Location = new System.Drawing.Point(91, 14);
            this.txtU_UsersId.Name = "txtU_UsersId";
            this.txtU_UsersId.Size = new System.Drawing.Size(110, 21);
            this.txtU_UsersId.TabIndex = 8;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(32, 49);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(47, 12);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "密 码：";
            // 
            // lblU_UsersId
            // 
            this.lblU_UsersId.AutoSize = true;
            this.lblU_UsersId.Location = new System.Drawing.Point(26, 21);
            this.lblU_UsersId.Name = "lblU_UsersId";
            this.lblU_UsersId.Size = new System.Drawing.Size(53, 12);
            this.lblU_UsersId.TabIndex = 6;
            this.lblU_UsersId.Text = "用户名：";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(14, 78);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(65, 12);
            this.lblMoney.TabIndex = 13;
            this.lblMoney.Text = "充值金额：";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(90, 75);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(110, 21);
            this.txtMoney.TabIndex = 12;
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
            // 
            // PlusForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(233, 158);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtU_UsersId);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblU_UsersId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员充值";
            this.Load += new System.EventHandler(this.PlusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtU_UsersId;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblU_UsersId;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.TextBox txtMoney;
    }
}