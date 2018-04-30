namespace Hotel
{
    partial class JoinHouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinHouseForm));
            this.btnCamcel = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNewHouseNull = new System.Windows.Forms.Label();
            this.grbOldHouse = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblUnite = new System.Windows.Forms.Label();
            this.cboUnite = new System.Windows.Forms.ComboBox();
            this.lblGuest = new System.Windows.Forms.Label();
            this.cboGuest = new System.Windows.Forms.ComboBox();
            this.cboNewHouse = new System.Windows.Forms.ComboBox();
            this.lblNewHouse = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdvanceForegift = new System.Windows.Forms.TextBox();
            this.lblAdvanceForegift = new System.Windows.Forms.Label();
            this.lblComeDate = new System.Windows.Forms.Label();
            this.dtpBookleave = new System.Windows.Forms.DateTimePicker();
            this.lblBookleave = new System.Windows.Forms.Label();
            this.dtpComeDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvSelectHouse = new System.Windows.Forms.ListView();
            this.chsR_RoomId = new System.Windows.Forms.ColumnHeader();
            this.chsRoomType = new System.Windows.Forms.ColumnHeader();
            this.chsPrice = new System.Windows.Forms.ColumnHeader();
            this.grbHollowHouse = new System.Windows.Forms.GroupBox();
            this.lvHollowHouse = new System.Windows.Forms.ListView();
            this.chR_RoomId = new System.Windows.Forms.ColumnHeader();
            this.chRoomType = new System.Windows.Forms.ColumnHeader();
            this.chPrice = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.grbOldHouse.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbHollowHouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCamcel
            // 
            this.btnCamcel.Location = new System.Drawing.Point(347, 497);
            this.btnCamcel.Name = "btnCamcel";
            this.btnCamcel.Size = new System.Drawing.Size(75, 23);
            this.btnCamcel.TabIndex = 17;
            this.btnCamcel.Text = "取消";
            this.btnCamcel.UseVisualStyleBackColor = true;
            this.btnCamcel.Click += new System.EventHandler(this.btnCamcel_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(228, 497);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 16;
            this.btnEnter.Text = "确定";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNewHouseNull);
            this.groupBox1.Controls.Add(this.grbOldHouse);
            this.groupBox1.Controls.Add(this.cboNewHouse);
            this.groupBox1.Controls.Add(this.lblNewHouse);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAdvanceForegift);
            this.groupBox1.Controls.Add(this.lblAdvanceForegift);
            this.groupBox1.Controls.Add(this.lblComeDate);
            this.groupBox1.Controls.Add(this.dtpBookleave);
            this.groupBox1.Controls.Add(this.lblBookleave);
            this.groupBox1.Controls.Add(this.dtpComeDate);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.grbHollowHouse);
            this.groupBox1.Location = new System.Drawing.Point(24, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 465);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "客房合并";
            // 
            // lblNewHouseNull
            // 
            this.lblNewHouseNull.AutoSize = true;
            this.lblNewHouseNull.ForeColor = System.Drawing.Color.Red;
            this.lblNewHouseNull.Location = new System.Drawing.Point(242, 321);
            this.lblNewHouseNull.Name = "lblNewHouseNull";
            this.lblNewHouseNull.Size = new System.Drawing.Size(53, 12);
            this.lblNewHouseNull.TabIndex = 66;
            this.lblNewHouseNull.Text = "不能为空";
            this.lblNewHouseNull.Visible = false;
            // 
            // grbOldHouse
            // 
            this.grbOldHouse.Controls.Add(this.btnOk);
            this.grbOldHouse.Controls.Add(this.lblUnite);
            this.grbOldHouse.Controls.Add(this.cboUnite);
            this.grbOldHouse.Controls.Add(this.lblGuest);
            this.grbOldHouse.Controls.Add(this.cboGuest);
            this.grbOldHouse.Location = new System.Drawing.Point(318, 292);
            this.grbOldHouse.Name = "grbOldHouse";
            this.grbOldHouse.Size = new System.Drawing.Size(200, 162);
            this.grbOldHouse.TabIndex = 65;
            this.grbOldHouse.TabStop = false;
            this.grbOldHouse.Text = "老客房并入";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(73, 119);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblUnite
            // 
            this.lblUnite.AutoSize = true;
            this.lblUnite.Location = new System.Drawing.Point(2, 77);
            this.lblUnite.Name = "lblUnite";
            this.lblUnite.Size = new System.Drawing.Size(65, 12);
            this.lblUnite.TabIndex = 3;
            this.lblUnite.Text = "合并入住：";
            // 
            // cboUnite
            // 
            this.cboUnite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnite.FormattingEnabled = true;
            this.cboUnite.Location = new System.Drawing.Point(73, 74);
            this.cboUnite.Name = "cboUnite";
            this.cboUnite.Size = new System.Drawing.Size(121, 20);
            this.cboUnite.TabIndex = 2;
            this.cboUnite.SelectedIndexChanged += new System.EventHandler(this.cboUnite_SelectedIndexChanged);
            // 
            // lblGuest
            // 
            this.lblGuest.AutoSize = true;
            this.lblGuest.Location = new System.Drawing.Point(26, 37);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(41, 12);
            this.lblGuest.TabIndex = 1;
            this.lblGuest.Text = "客房：";
            // 
            // cboGuest
            // 
            this.cboGuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGuest.FormattingEnabled = true;
            this.cboGuest.Location = new System.Drawing.Point(73, 29);
            this.cboGuest.Name = "cboGuest";
            this.cboGuest.Size = new System.Drawing.Size(121, 20);
            this.cboGuest.TabIndex = 0;
            this.cboGuest.SelectedIndexChanged += new System.EventHandler(this.cboGuest_SelectedIndexChanged);
            // 
            // cboNewHouse
            // 
            this.cboNewHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewHouse.FormattingEnabled = true;
            this.cboNewHouse.Location = new System.Drawing.Point(114, 314);
            this.cboNewHouse.Name = "cboNewHouse";
            this.cboNewHouse.Size = new System.Drawing.Size(122, 20);
            this.cboNewHouse.TabIndex = 62;
            this.cboNewHouse.SelectedIndexChanged += new System.EventHandler(this.cboNewHouse_SelectedIndexChanged);
            // 
            // lblNewHouse
            // 
            this.lblNewHouse.AutoSize = true;
            this.lblNewHouse.Location = new System.Drawing.Point(26, 317);
            this.lblNewHouse.Name = "lblNewHouse";
            this.lblNewHouse.Size = new System.Drawing.Size(77, 12);
            this.lblNewHouse.TabIndex = 61;
            this.lblNewHouse.Text = "新客房并入：";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "全日房",
            "钟点房"});
            this.comboBox3.Location = new System.Drawing.Point(443, -39);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(122, 20);
            this.comboBox3.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, -36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 59;
            this.label3.Text = "新客房并入：";
            // 
            // txtAdvanceForegift
            // 
            this.txtAdvanceForegift.Location = new System.Drawing.Point(113, 351);
            this.txtAdvanceForegift.Name = "txtAdvanceForegift";
            this.txtAdvanceForegift.Size = new System.Drawing.Size(122, 21);
            this.txtAdvanceForegift.TabIndex = 54;
            this.txtAdvanceForegift.Text = "0";
            this.txtAdvanceForegift.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdvanceForegift_KeyPress);
            // 
            // lblAdvanceForegift
            // 
            this.lblAdvanceForegift.AutoSize = true;
            this.lblAdvanceForegift.Location = new System.Drawing.Point(38, 354);
            this.lblAdvanceForegift.Name = "lblAdvanceForegift";
            this.lblAdvanceForegift.Size = new System.Drawing.Size(65, 12);
            this.lblAdvanceForegift.TabIndex = 51;
            this.lblAdvanceForegift.Text = "续交押金：";
            // 
            // lblComeDate
            // 
            this.lblComeDate.AutoSize = true;
            this.lblComeDate.Location = new System.Drawing.Point(38, 390);
            this.lblComeDate.Name = "lblComeDate";
            this.lblComeDate.Size = new System.Drawing.Size(65, 12);
            this.lblComeDate.TabIndex = 52;
            this.lblComeDate.Text = "入住时间：";
            // 
            // dtpBookleave
            // 
            this.dtpBookleave.Checked = false;
            this.dtpBookleave.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpBookleave.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookleave.Location = new System.Drawing.Point(113, 416);
            this.dtpBookleave.Name = "dtpBookleave";
            this.dtpBookleave.Size = new System.Drawing.Size(122, 21);
            this.dtpBookleave.TabIndex = 56;
            // 
            // lblBookleave
            // 
            this.lblBookleave.AutoSize = true;
            this.lblBookleave.Location = new System.Drawing.Point(38, 425);
            this.lblBookleave.Name = "lblBookleave";
            this.lblBookleave.Size = new System.Drawing.Size(65, 12);
            this.lblBookleave.TabIndex = 53;
            this.lblBookleave.Text = "预离时间：";
            // 
            // dtpComeDate
            // 
            this.dtpComeDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpComeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpComeDate.Location = new System.Drawing.Point(113, 386);
            this.dtpComeDate.Name = "dtpComeDate";
            this.dtpComeDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpComeDate.Size = new System.Drawing.Size(122, 21);
            this.dtpComeDate.TabIndex = 55;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvSelectHouse);
            this.groupBox2.Location = new System.Drawing.Point(291, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 256);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "已选客房";
            // 
            // lvSelectHouse
            // 
            this.lvSelectHouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chsR_RoomId,
            this.chsRoomType,
            this.chsPrice});
            this.lvSelectHouse.FullRowSelect = true;
            this.lvSelectHouse.GridLines = true;
            this.lvSelectHouse.Location = new System.Drawing.Point(23, 16);
            this.lvSelectHouse.MultiSelect = false;
            this.lvSelectHouse.Name = "lvSelectHouse";
            this.lvSelectHouse.Size = new System.Drawing.Size(208, 218);
            this.lvSelectHouse.TabIndex = 35;
            this.lvSelectHouse.UseCompatibleStateImageBehavior = false;
            this.lvSelectHouse.View = System.Windows.Forms.View.Details;
            this.lvSelectHouse.DoubleClick += new System.EventHandler(this.lvSelectHouse_DoubleClick);
            // 
            // chsR_RoomId
            // 
            this.chsR_RoomId.Text = "房间号";
            this.chsR_RoomId.Width = 51;
            // 
            // chsRoomType
            // 
            this.chsRoomType.Text = "类型";
            this.chsRoomType.Width = 88;
            // 
            // chsPrice
            // 
            this.chsPrice.Text = "价格";
            this.chsPrice.Width = 65;
            // 
            // grbHollowHouse
            // 
            this.grbHollowHouse.Controls.Add(this.lvHollowHouse);
            this.grbHollowHouse.Location = new System.Drawing.Point(14, 26);
            this.grbHollowHouse.Name = "grbHollowHouse";
            this.grbHollowHouse.Size = new System.Drawing.Size(253, 256);
            this.grbHollowHouse.TabIndex = 49;
            this.grbHollowHouse.TabStop = false;
            this.grbHollowHouse.Text = "空净房";
            // 
            // lvHollowHouse
            // 
            this.lvHollowHouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chR_RoomId,
            this.chRoomType,
            this.chPrice});
            this.lvHollowHouse.FullRowSelect = true;
            this.lvHollowHouse.GridLines = true;
            this.lvHollowHouse.Location = new System.Drawing.Point(21, 16);
            this.lvHollowHouse.MultiSelect = false;
            this.lvHollowHouse.Name = "lvHollowHouse";
            this.lvHollowHouse.Size = new System.Drawing.Size(208, 218);
            this.lvHollowHouse.TabIndex = 35;
            this.lvHollowHouse.UseCompatibleStateImageBehavior = false;
            this.lvHollowHouse.View = System.Windows.Forms.View.Details;
            this.lvHollowHouse.DoubleClick += new System.EventHandler(this.lvHollowHouse_DoubleClick);
            // 
            // chR_RoomId
            // 
            this.chR_RoomId.Text = "房间号";
            this.chR_RoomId.Width = 51;
            // 
            // chRoomType
            // 
            this.chRoomType.Text = "类型";
            this.chRoomType.Width = 88;
            // 
            // chPrice
            // 
            this.chPrice.Text = "价格";
            this.chPrice.Width = 65;
            // 
            // JoinHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 541);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCamcel);
            this.Controls.Add(this.btnEnter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JoinHouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客房合并";
            this.Load += new System.EventHandler(this.JoinHouseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbOldHouse.ResumeLayout(false);
            this.grbOldHouse.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grbHollowHouse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCamcel;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvSelectHouse;
        private System.Windows.Forms.ColumnHeader chsR_RoomId;
        private System.Windows.Forms.ColumnHeader chsRoomType;
        private System.Windows.Forms.ColumnHeader chsPrice;
        private System.Windows.Forms.GroupBox grbHollowHouse;
        private System.Windows.Forms.ListView lvHollowHouse;
        private System.Windows.Forms.ColumnHeader chR_RoomId;
        private System.Windows.Forms.ColumnHeader chRoomType;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.GroupBox grbOldHouse;
        private System.Windows.Forms.Label lblUnite;
        private System.Windows.Forms.ComboBox cboUnite;
        private System.Windows.Forms.Label lblGuest;
        private System.Windows.Forms.ComboBox cboGuest;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblNewHouseNull;
        private System.Windows.Forms.ComboBox cboNewHouse;
        private System.Windows.Forms.Label lblNewHouse;
        private System.Windows.Forms.TextBox txtAdvanceForegift;
        private System.Windows.Forms.Label lblAdvanceForegift;
        private System.Windows.Forms.Label lblComeDate;
        private System.Windows.Forms.DateTimePicker dtpBookleave;
        private System.Windows.Forms.Label lblBookleave;
        private System.Windows.Forms.DateTimePicker dtpComeDate;
    }
}