namespace Hotel
{
    partial class DepositManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositManage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvDeposit = new System.Windows.Forms.ListView();
            this.chR_id = new System.Windows.Forms.ColumnHeader();
            this.chUName = new System.Windows.Forms.ColumnHeader();
            this.chforegift = new System.Windows.Forms.ColumnHeader();
            this.txtRoom_id = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblRoom_id = new System.Windows.Forms.Label();
            this.rdoComeDeposit = new System.Windows.Forms.RadioButton();
            this.rdoGoDeposit = new System.Windows.Forms.RadioButton();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRoomid = new System.Windows.Forms.Label();
            this.lblroom = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvDeposit);
            this.groupBox1.Controls.Add(this.txtRoom_id);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblRoom_id);
            this.groupBox1.Location = new System.Drawing.Point(25, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "收退管理";
            // 
            // lvDeposit
            // 
            this.lvDeposit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chR_id,
            this.chUName,
            this.chforegift});
            this.lvDeposit.FullRowSelect = true;
            this.lvDeposit.GridLines = true;
            this.lvDeposit.Location = new System.Drawing.Point(25, 48);
            this.lvDeposit.MultiSelect = false;
            this.lvDeposit.Name = "lvDeposit";
            this.lvDeposit.Size = new System.Drawing.Size(248, 205);
            this.lvDeposit.TabIndex = 3;
            this.lvDeposit.UseCompatibleStateImageBehavior = false;
            this.lvDeposit.View = System.Windows.Forms.View.Details;
            this.lvDeposit.Click += new System.EventHandler(this.lvDeposit_Click);
            // 
            // chR_id
            // 
            this.chR_id.Text = "房间号";
            this.chR_id.Width = 67;
            // 
            // chUName
            // 
            this.chUName.Text = "姓名";
            this.chUName.Width = 74;
            // 
            // chforegift
            // 
            this.chforegift.Text = "押金";
            this.chforegift.Width = 102;
            // 
            // txtRoom_id
            // 
            this.txtRoom_id.Location = new System.Drawing.Point(107, 19);
            this.txtRoom_id.Name = "txtRoom_id";
            this.txtRoom_id.Size = new System.Drawing.Size(84, 21);
            this.txtRoom_id.TabIndex = 2;
            this.txtRoom_id.TextChanged += new System.EventHandler(this.txtRoom_id_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(210, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "定位";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblRoom_id
            // 
            this.lblRoom_id.AutoSize = true;
            this.lblRoom_id.Location = new System.Drawing.Point(36, 24);
            this.lblRoom_id.Name = "lblRoom_id";
            this.lblRoom_id.Size = new System.Drawing.Size(53, 12);
            this.lblRoom_id.TabIndex = 0;
            this.lblRoom_id.Text = "客房号：";
            // 
            // rdoComeDeposit
            // 
            this.rdoComeDeposit.AutoSize = true;
            this.rdoComeDeposit.Checked = true;
            this.rdoComeDeposit.Location = new System.Drawing.Point(25, 307);
            this.rdoComeDeposit.Name = "rdoComeDeposit";
            this.rdoComeDeposit.Size = new System.Drawing.Size(83, 16);
            this.rdoComeDeposit.TabIndex = 1;
            this.rdoComeDeposit.TabStop = true;
            this.rdoComeDeposit.Text = "收客人押金";
            this.rdoComeDeposit.UseVisualStyleBackColor = true;
            this.rdoComeDeposit.CheckedChanged += new System.EventHandler(this.rdoComeDeposit_CheckedChanged);
            // 
            // rdoGoDeposit
            // 
            this.rdoGoDeposit.AutoSize = true;
            this.rdoGoDeposit.Location = new System.Drawing.Point(25, 333);
            this.rdoGoDeposit.Name = "rdoGoDeposit";
            this.rdoGoDeposit.Size = new System.Drawing.Size(83, 16);
            this.rdoGoDeposit.TabIndex = 2;
            this.rdoGoDeposit.Text = "退客人押金";
            this.rdoGoDeposit.UseVisualStyleBackColor = true;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(162, 337);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(65, 12);
            this.lblDeposit.TabIndex = 3;
            this.lblDeposit.Text = "补交押金：";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(233, 329);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(82, 21);
            this.txtDeposit.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(73, 395);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(23, 362);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(41, 12);
            this.lblRemark.TabIndex = 7;
            this.lblRemark.Text = "备注：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(70, 358);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(245, 21);
            this.txtRemark.TabIndex = 8;
            // 
            // lblRoomid
            // 
            this.lblRoomid.AutoSize = true;
            this.lblRoomid.Location = new System.Drawing.Point(174, 307);
            this.lblRoomid.Name = "lblRoomid";
            this.lblRoomid.Size = new System.Drawing.Size(53, 12);
            this.lblRoomid.TabIndex = 9;
            this.lblRoomid.Text = "房间号：";
            // 
            // lblroom
            // 
            this.lblroom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblroom.Location = new System.Drawing.Point(233, 305);
            this.lblroom.Name = "lblroom";
            this.lblroom.Size = new System.Drawing.Size(82, 19);
            this.lblroom.TabIndex = 10;
            this.lblroom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DepositManage
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 430);
            this.Controls.Add(this.lblroom);
            this.Controls.Add(this.lblRoomid);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.rdoGoDeposit);
            this.Controls.Add(this.rdoComeDeposit);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DepositManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收退管理";
            this.Load += new System.EventHandler(this.DepositManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRoom_id;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblRoom_id;
        private System.Windows.Forms.ListView lvDeposit;
        private System.Windows.Forms.RadioButton rdoComeDeposit;
        private System.Windows.Forms.RadioButton rdoGoDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColumnHeader chR_id;
        private System.Windows.Forms.ColumnHeader chUName;
        private System.Windows.Forms.ColumnHeader chforegift;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRoomid;
        private System.Windows.Forms.Label lblroom;
    }
}