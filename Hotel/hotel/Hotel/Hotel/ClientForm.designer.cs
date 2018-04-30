namespace Hotel
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.msOper = new System.Windows.Forms.MenuStrip();
            this.个人中心ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMyConsume = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFeedback = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbSelf = new System.Windows.Forms.RichTextBox();
            this.rtbAll = new System.Windows.Forms.RichTextBox();
            this.trmRead = new System.Windows.Forms.Timer(this.components);
            this.msOper.SuspendLayout();
            this.SuspendLayout();
            // 
            // msOper
            // 
            this.msOper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人中心ToolStripMenuItem,
            this.管理ToolStripMenuItem});
            this.msOper.Location = new System.Drawing.Point(0, 0);
            this.msOper.Name = "msOper";
            this.msOper.Size = new System.Drawing.Size(398, 24);
            this.msOper.TabIndex = 5;
            this.msOper.Text = "menuStrip1";
            // 
            // 个人中心ToolStripMenuItem
            // 
            this.个人中心ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMyConsume,
            this.tsmiScore,
            this.tsmiUpdate});
            this.个人中心ToolStripMenuItem.Name = "个人中心ToolStripMenuItem";
            this.个人中心ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.个人中心ToolStripMenuItem.Text = "个人中心(&C)";
            // 
            // tsmiMyConsume
            // 
            this.tsmiMyConsume.Name = "tsmiMyConsume";
            this.tsmiMyConsume.Size = new System.Drawing.Size(152, 22);
            this.tsmiMyConsume.Text = "消费记录(&A)";
            this.tsmiMyConsume.Click += new System.EventHandler(this.tsmiMyConsume_Click);
            // 
            // tsmiScore
            // 
            this.tsmiScore.Name = "tsmiScore";
            this.tsmiScore.Size = new System.Drawing.Size(152, 22);
            this.tsmiScore.Text = "我的余额(&S)";
            this.tsmiScore.Click += new System.EventHandler(this.tsmiScore_Click);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(152, 22);
            this.tsmiUpdate.Text = "修改资料(&U)";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // 管理ToolStripMenuItem
            // 
            this.管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFeedback});
            this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.管理ToolStripMenuItem.Text = "管理(&M)";
            // 
            // tsmiFeedback
            // 
            this.tsmiFeedback.Name = "tsmiFeedback";
            this.tsmiFeedback.Size = new System.Drawing.Size(112, 22);
            this.tsmiFeedback.Text = "反馈(&F)";
            this.tsmiFeedback.Click += new System.EventHandler(this.tsmiFeedback_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(328, 194);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(39, 23);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.Text = "酒水";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(296, 336);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(198, 336);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "发送(&S)";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbSelf
            // 
            this.rtbSelf.Location = new System.Drawing.Point(19, 223);
            this.rtbSelf.Name = "rtbSelf";
            this.rtbSelf.Size = new System.Drawing.Size(357, 96);
            this.rtbSelf.TabIndex = 7;
            this.rtbSelf.Text = "";
            // 
            // rtbAll
            // 
            this.rtbAll.BackColor = System.Drawing.Color.White;
            this.rtbAll.Location = new System.Drawing.Point(19, 27);
            this.rtbAll.Name = "rtbAll";
            this.rtbAll.ReadOnly = true;
            this.rtbAll.Size = new System.Drawing.Size(357, 160);
            this.rtbAll.TabIndex = 6;
            this.rtbAll.Text = "";
            // 
            // trmRead
            // 
            this.trmRead.Enabled = true;
            this.trmRead.Interval = 1000;
            this.trmRead.Tick += new System.EventHandler(this.trmRead_Tick);
            // 
            // ClientForm
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 378);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtbSelf);
            this.Controls.Add(this.rtbAll);
            this.Controls.Add(this.msOper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msOper;
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Userid";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.msOper.ResumeLayout(false);
            this.msOper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msOper;
        private System.Windows.Forms.ToolStripMenuItem 个人中心ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiMyConsume;
        private System.Windows.Forms.ToolStripMenuItem tsmiScore;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiFeedback;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbSelf;
        private System.Windows.Forms.RichTextBox rtbAll;
        private System.Windows.Forms.Timer trmRead;
    }
}