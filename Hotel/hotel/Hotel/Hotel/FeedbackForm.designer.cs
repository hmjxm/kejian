namespace Hotel
{
    partial class FeedbackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedbackForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVote = new System.Windows.Forms.Label();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnRefer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVote);
            this.groupBox1.Controls.Add(this.rtbContent);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户反馈";
            // 
            // lblVote
            // 
            this.lblVote.AutoSize = true;
            this.lblVote.Location = new System.Drawing.Point(27, 57);
            this.lblVote.Name = "lblVote";
            this.lblVote.Size = new System.Drawing.Size(41, 12);
            this.lblVote.TabIndex = 4;
            this.lblVote.Text = "内容：";
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(84, 54);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(167, 106);
            this.rtbContent.TabIndex = 3;
            this.rtbContent.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 20);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "用户名：";
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(32, 212);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(61, 23);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "历史记录";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnRefer
            // 
            this.btnRefer.Location = new System.Drawing.Point(119, 212);
            this.btnRefer.Name = "btnRefer";
            this.btnRefer.Size = new System.Drawing.Size(61, 23);
            this.btnRefer.TabIndex = 6;
            this.btnRefer.Text = "提交";
            this.btnRefer.UseVisualStyleBackColor = true;
            this.btnRefer.Click += new System.EventHandler(this.btnRefer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(205, 212);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(61, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 252);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRefer);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FeedbackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户反馈";
            this.Load += new System.EventHandler(this.FeedbackForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblVote;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnRefer;
        private System.Windows.Forms.Button btnCancel;

    }
}