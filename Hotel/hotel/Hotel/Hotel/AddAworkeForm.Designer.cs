namespace Hotel
{
    partial class AddAworkeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAworkeForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbAddAwoke = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtA_content = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblA_content = new System.Windows.Forms.Label();
            this.grbAddAwoke.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(147, 214);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(54, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbAddAwoke
            // 
            this.grbAddAwoke.Controls.Add(this.dtpDate);
            this.grbAddAwoke.Controls.Add(this.cboState);
            this.grbAddAwoke.Controls.Add(this.txtRemark);
            this.grbAddAwoke.Controls.Add(this.txtA_content);
            this.grbAddAwoke.Controls.Add(this.lblRemark);
            this.grbAddAwoke.Controls.Add(this.lblDate);
            this.grbAddAwoke.Controls.Add(this.lblState);
            this.grbAddAwoke.Controls.Add(this.lblA_content);
            this.grbAddAwoke.Location = new System.Drawing.Point(17, 12);
            this.grbAddAwoke.Name = "grbAddAwoke";
            this.grbAddAwoke.Size = new System.Drawing.Size(233, 193);
            this.grbAddAwoke.TabIndex = 3;
            this.grbAddAwoke.TabStop = false;
            this.grbAddAwoke.Text = "添加房间";
            this.grbAddAwoke.Enter += new System.EventHandler(this.grbAddAwoke_Enter);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(78, 130);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(138, 21);
            this.dtpDate.TabIndex = 10;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.Enabled = false;
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "未读",
            "已读"});
            this.cboState.Location = new System.Drawing.Point(78, 101);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(138, 20);
            this.cboState.TabIndex = 9;
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(78, 160);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(138, 21);
            this.txtRemark.TabIndex = 7;
            this.txtRemark.TextChanged += new System.EventHandler(this.txtRemark_TextChanged);
            // 
            // txtA_content
            // 
            this.txtA_content.Location = new System.Drawing.Point(78, 14);
            this.txtA_content.Multiline = true;
            this.txtA_content.Name = "txtA_content";
            this.txtA_content.Size = new System.Drawing.Size(138, 81);
            this.txtA_content.TabIndex = 5;
            this.txtA_content.TextChanged += new System.EventHandler(this.txtA_content_TextChanged);
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(18, 163);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(41, 12);
            this.lblRemark.TabIndex = 4;
            this.lblRemark.Text = "备注：";
            this.lblRemark.Click += new System.EventHandler(this.lblRemark_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(18, 136);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 12);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "日期：";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(18, 104);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(41, 12);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "状态：";
            this.lblState.Click += new System.EventHandler(this.lblState_Click);
            // 
            // lblA_content
            // 
            this.lblA_content.AutoSize = true;
            this.lblA_content.Location = new System.Drawing.Point(18, 17);
            this.lblA_content.Name = "lblA_content";
            this.lblA_content.Size = new System.Drawing.Size(41, 12);
            this.lblA_content.TabIndex = 0;
            this.lblA_content.Text = "内容：";
            this.lblA_content.Click += new System.EventHandler(this.lblA_content_Click);
            // 
            // AddAworkeForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(286, 272);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbAddAwoke);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAworkeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加提醒";
            this.Load += new System.EventHandler(this.AddAworkeForm_Load);
            this.grbAddAwoke.ResumeLayout(false);
            this.grbAddAwoke.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbAddAwoke;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtA_content;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblA_content;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}