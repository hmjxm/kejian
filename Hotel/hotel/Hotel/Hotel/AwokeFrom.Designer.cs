namespace Hotel
{
    partial class AwokeFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AwokeFrom));
            this.lvAwoke = new System.Windows.Forms.ListView();
            this.chA_content = new System.Windows.Forms.ColumnHeader();
            this.chState = new System.Windows.Forms.ColumnHeader();
            this.chDate = new System.Windows.Forms.ColumnHeader();
            this.chRemark = new System.Windows.Forms.ColumnHeader();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tmrStart = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lvAwoke
            // 
            this.lvAwoke.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chA_content,
            this.chState,
            this.chDate,
            this.chRemark});
            this.lvAwoke.FullRowSelect = true;
            this.lvAwoke.GridLines = true;
            this.lvAwoke.Location = new System.Drawing.Point(12, 9);
            this.lvAwoke.Name = "lvAwoke";
            this.lvAwoke.Size = new System.Drawing.Size(273, 96);
            this.lvAwoke.TabIndex = 0;
            this.lvAwoke.UseCompatibleStateImageBehavior = false;
            this.lvAwoke.View = System.Windows.Forms.View.Details;
            // 
            // chA_content
            // 
            this.chA_content.Text = "内容";
            // 
            // chState
            // 
            this.chState.Text = "状态";
            // 
            // chDate
            // 
            this.chDate.Text = "日期";
            // 
            // chRemark
            // 
            this.chRemark.Text = "备注";
            this.chRemark.Width = 85;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(231, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(44, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "关 闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tmrStart
            // 
            this.tmrStart.Interval = 1;
            this.tmrStart.Tick += new System.EventHandler(this.tmrStart_Tick);
            // 
            // AwokeFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 139);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lvAwoke);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AwokeFrom";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "提醒";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AwokeFrom_FormClosing);
            this.Load += new System.EventHandler(this.AwokeFrom_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAwoke;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColumnHeader chA_content;
        private System.Windows.Forms.ColumnHeader chState;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chRemark;
        private System.Windows.Forms.Timer tmrStart;
    }
}