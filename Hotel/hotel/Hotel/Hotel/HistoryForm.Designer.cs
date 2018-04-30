namespace Hotel
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.lvHistory = new System.Windows.Forms.ListView();
            this.chL_LeaveWordId = new System.Windows.Forms.ColumnHeader();
            this.chL_U_UsersId = new System.Windows.Forms.ColumnHeader();
            this.chL_content = new System.Windows.Forms.ColumnHeader();
            this.chDate = new System.Windows.Forms.ColumnHeader();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvHistory
            // 
            this.lvHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chL_LeaveWordId,
            this.chL_U_UsersId,
            this.chL_content,
            this.chDate});
            this.lvHistory.FullRowSelect = true;
            this.lvHistory.GridLines = true;
            this.lvHistory.Location = new System.Drawing.Point(36, 26);
            this.lvHistory.Name = "lvHistory";
            this.lvHistory.Size = new System.Drawing.Size(446, 191);
            this.lvHistory.TabIndex = 0;
            this.lvHistory.UseCompatibleStateImageBehavior = false;
            this.lvHistory.View = System.Windows.Forms.View.Details;
            // 
            // chL_LeaveWordId
            // 
            this.chL_LeaveWordId.Text = "ID";
            this.chL_LeaveWordId.Width = 81;
            // 
            // chL_U_UsersId
            // 
            this.chL_U_UsersId.Text = "用户";
            this.chL_U_UsersId.Width = 79;
            // 
            // chL_content
            // 
            this.chL_content.Text = "内容";
            this.chL_content.Width = 139;
            // 
            // chDate
            // 
            this.chDate.Text = "日期";
            this.chDate.Width = 125;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(296, 234);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 271);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lvHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "历史记录";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvHistory;
        private System.Windows.Forms.ColumnHeader chL_LeaveWordId;
        private System.Windows.Forms.ColumnHeader chL_U_UsersId;
        private System.Windows.Forms.ColumnHeader chL_content;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.Button btnClose;


    }
}