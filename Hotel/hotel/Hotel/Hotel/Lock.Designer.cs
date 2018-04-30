namespace Hotel
{
    partial class Lock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lock));
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnUncoil = new System.Windows.Forms.Button();
            this.trmCloseTaskmgr = new System.Windows.Forms.Timer(this.components);
            this.ttPass = new System.Windows.Forms.ToolTip(this.components);
            this.lblPassWrong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Location = new System.Drawing.Point(546, 438);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 21);
            this.txtPass.TabIndex = 0;
            this.ttPass.SetToolTip(this.txtPass, "请输入密码");
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // btnUncoil
            // 
            this.btnUncoil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUncoil.Location = new System.Drawing.Point(557, 465);
            this.btnUncoil.Name = "btnUncoil";
            this.btnUncoil.Size = new System.Drawing.Size(75, 23);
            this.btnUncoil.TabIndex = 1;
            this.btnUncoil.Text = "解 锁";
            this.btnUncoil.UseVisualStyleBackColor = true;
            this.btnUncoil.Click += new System.EventHandler(this.btnUncoil_Click);
            // 
            // trmCloseTaskmgr
            // 
            this.trmCloseTaskmgr.Enabled = true;
            this.trmCloseTaskmgr.Tick += new System.EventHandler(this.trmCloseTaskmgr_Tick);
            // 
            // ttPass
            // 
            this.ttPass.AutoPopDelay = 5000;
            this.ttPass.InitialDelay = 100;
            this.ttPass.IsBalloon = true;
            this.ttPass.ReshowDelay = 100;
            // 
            // lblPassWrong
            // 
            this.lblPassWrong.BackColor = System.Drawing.Color.Transparent;
            this.lblPassWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.lblPassWrong.Location = new System.Drawing.Point(287, 403);
            this.lblPassWrong.Name = "lblPassWrong";
            this.lblPassWrong.Size = new System.Drawing.Size(400, 105);
            this.lblPassWrong.TabIndex = 2;
            this.lblPassWrong.Text = "密码错误！";
            this.lblPassWrong.Visible = false;
            // 
            // Lock
            // 
            this.AcceptButton = this.btnUncoil;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 500);
            this.Controls.Add(this.lblPassWrong);
            this.Controls.Add(this.btnUncoil);
            this.Controls.Add(this.txtPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lock";
            this.Opacity = 0.8;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lock";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lock_FormClosing);
            this.Load += new System.EventHandler(this.Lock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnUncoil;
        private System.Windows.Forms.Timer trmCloseTaskmgr;
        private System.Windows.Forms.ToolTip ttPass;
        private System.Windows.Forms.Label lblPassWrong;
    }
}