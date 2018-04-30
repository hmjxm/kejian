namespace Hotel
{
    partial class DefrayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefrayForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.txtC_type = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblC_type = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTime);
            this.groupBox1.Controls.Add(this.txtC_type);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.lblC_type);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "支出";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpTime.Enabled = false;
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(84, 95);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(139, 21);
            this.dtpTime.TabIndex = 15;
            // 
            // txtC_type
            // 
            this.txtC_type.Location = new System.Drawing.Point(86, 59);
            this.txtC_type.Name = "txtC_type";
            this.txtC_type.Size = new System.Drawing.Size(137, 21);
            this.txtC_type.TabIndex = 13;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(86, 24);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(137, 21);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(37, 98);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(41, 12);
            this.lbldate.TabIndex = 11;
            this.lbldate.Text = "日期：";
            // 
            // lblC_type
            // 
            this.lblC_type.AutoSize = true;
            this.lblC_type.Location = new System.Drawing.Point(15, 62);
            this.lblC_type.Name = "lblC_type";
            this.lblC_type.Size = new System.Drawing.Size(65, 12);
            this.lblC_type.TabIndex = 9;
            this.lblC_type.Text = "支出项目：";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(15, 27);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(65, 12);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "支出费用：";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(63, 176);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(170, 176);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DefrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 212);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefrayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "支出";
            this.Load += new System.EventHandler(this.DefrayForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.TextBox txtC_type;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblC_type;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;

    }
}