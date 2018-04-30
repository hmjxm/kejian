//download by http://www.codefans.net
namespace Hotel
{
    partial class PwdValidate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PwdValidate));
            this.lblid = new System.Windows.Forms.Label();
            this.lblpwd = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.group = new System.Windows.Forms.GroupBox();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(6, 23);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(41, 12);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "帐号：";
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.Location = new System.Drawing.Point(6, 56);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(41, 12);
            this.lblpwd.TabIndex = 1;
            this.lblpwd.Text = "密码：";
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(62, 53);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(123, 21);
            this.txtpwd.TabIndex = 2;
            this.txtpwd.UseSystemPasswordChar = true;
            this.txtpwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpwd_KeyDown);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(62, 20);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(123, 21);
            this.txtid.TabIndex = 3;
            // 
            // group
            // 
            this.group.Controls.Add(this.btnNo);
            this.group.Controls.Add(this.btnYes);
            this.group.Controls.Add(this.txtid);
            this.group.Controls.Add(this.lblpwd);
            this.group.Controls.Add(this.txtpwd);
            this.group.Controls.Add(this.lblid);
            this.group.Location = new System.Drawing.Point(9, 12);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(210, 114);
            this.group.TabIndex = 4;
            this.group.TabStop = false;
            this.group.Text = "密码验证";
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(121, 85);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(54, 23);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "取消";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(35, 85);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(54, 23);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "确定";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // PwdValidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 138);
            this.Controls.Add(this.group);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PwdValidate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码验证";
            this.Load += new System.EventHandler(this.PwdValidate_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblpwd;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
    }
}