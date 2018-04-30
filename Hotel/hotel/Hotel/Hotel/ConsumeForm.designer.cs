namespace Hotel
{
    partial class ConsumeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsumeForm));
            this.grbConsume = new System.Windows.Forms.GroupBox();
            this.lvBookHouse = new System.Windows.Forms.ListView();
            this.chR_id = new System.Windows.Forms.ColumnHeader();
            this.chUnderwrite = new System.Windows.Forms.ColumnHeader();
            this.chcomeDate = new System.Windows.Forms.ColumnHeader();
            this.chBookleave = new System.Windows.Forms.ColumnHeader();
            this.chUname = new System.Windows.Forms.ColumnHeader();
            this.chOperator = new System.Windows.Forms.ColumnHeader();
            this.chremark = new System.Windows.Forms.ColumnHeader();
            this.btnClose = new System.Windows.Forms.Button();
            this.grbConsume.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbConsume
            // 
            this.grbConsume.Controls.Add(this.lvBookHouse);
            this.grbConsume.Location = new System.Drawing.Point(21, 21);
            this.grbConsume.Name = "grbConsume";
            this.grbConsume.Size = new System.Drawing.Size(505, 250);
            this.grbConsume.TabIndex = 0;
            this.grbConsume.TabStop = false;
            this.grbConsume.Text = "我的消费记录";
            // 
            // lvBookHouse
            // 
            this.lvBookHouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chR_id,
            this.chUnderwrite,
            this.chcomeDate,
            this.chBookleave,
            this.chUname,
            this.chOperator,
            this.chremark});
            this.lvBookHouse.FullRowSelect = true;
            this.lvBookHouse.GridLines = true;
            this.lvBookHouse.Location = new System.Drawing.Point(19, 20);
            this.lvBookHouse.Name = "lvBookHouse";
            this.lvBookHouse.Size = new System.Drawing.Size(466, 206);
            this.lvBookHouse.TabIndex = 2;
            this.lvBookHouse.UseCompatibleStateImageBehavior = false;
            this.lvBookHouse.View = System.Windows.Forms.View.Details;
            // 
            // chR_id
            // 
            this.chR_id.Text = "房间号";
            // 
            // chUnderwrite
            // 
            this.chUnderwrite.Text = "签单";
            // 
            // chcomeDate
            // 
            this.chcomeDate.Text = "入住时间";
            this.chcomeDate.Width = 66;
            // 
            // chBookleave
            // 
            this.chBookleave.Text = "预离时间";
            this.chBookleave.Width = 73;
            // 
            // chUname
            // 
            this.chUname.Text = "姓名";
            // 
            // chOperator
            // 
            this.chOperator.Text = "操作员";
            // 
            // chremark
            // 
            this.chremark.Text = "备注";
            this.chremark.Width = 76;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(400, 283);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ConsumeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 318);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grbConsume);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsumeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的消费记录";
            this.Load += new System.EventHandler(this.ConsumeForm_Load_1);
            this.grbConsume.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbConsume;
        private System.Windows.Forms.ListView lvBookHouse;
        private System.Windows.Forms.ColumnHeader chR_id;
        private System.Windows.Forms.ColumnHeader chUnderwrite;
        private System.Windows.Forms.ColumnHeader chcomeDate;
        private System.Windows.Forms.ColumnHeader chBookleave;
        private System.Windows.Forms.ColumnHeader chUname;
        private System.Windows.Forms.ColumnHeader chOperator;
        private System.Windows.Forms.ColumnHeader chremark;
        private System.Windows.Forms.Button btnClose;
    }
}