namespace Hotel
{
    partial class AddConsume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddConsume));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbAllWare = new System.Windows.Forms.GroupBox();
            this.lvAllWare = new System.Windows.Forms.ListView();
            this.chaName = new System.Windows.Forms.ColumnHeader();
            this.chaType = new System.Windows.Forms.ColumnHeader();
            this.chaPrice = new System.Windows.Forms.ColumnHeader();
            this.chaCount = new System.Windows.Forms.ColumnHeader();
            this.lblWareType = new System.Windows.Forms.Label();
            this.cboWareType = new System.Windows.Forms.ComboBox();
            this.lblRoomId = new System.Windows.Forms.Label();
            this.grbSelectWare = new System.Windows.Forms.GroupBox();
            this.lvSelect = new System.Windows.Forms.ListView();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chType = new System.Windows.Forms.ColumnHeader();
            this.chPrice = new System.Windows.Forms.ColumnHeader();
            this.chCount = new System.Windows.Forms.ColumnHeader();
            this.lblEasyName = new System.Windows.Forms.Label();
            this.txtEasyName = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.cboRoomId = new System.Windows.Forms.ComboBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grbAllWare.SuspendLayout();
            this.grbSelectWare.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(317, 410);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(451, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grbAllWare
            // 
            this.grbAllWare.Controls.Add(this.lvAllWare);
            this.grbAllWare.Location = new System.Drawing.Point(30, 68);
            this.grbAllWare.Name = "grbAllWare";
            this.grbAllWare.Size = new System.Drawing.Size(264, 310);
            this.grbAllWare.TabIndex = 4;
            this.grbAllWare.TabStop = false;
            this.grbAllWare.Text = "所有商品";
            // 
            // lvAllWare
            // 
            this.lvAllWare.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chaName,
            this.chaType,
            this.chaPrice,
            this.chaCount});
            this.lvAllWare.FullRowSelect = true;
            this.lvAllWare.GridLines = true;
            this.lvAllWare.Location = new System.Drawing.Point(6, 15);
            this.lvAllWare.Name = "lvAllWare";
            this.lvAllWare.Size = new System.Drawing.Size(252, 281);
            this.lvAllWare.TabIndex = 0;
            this.lvAllWare.UseCompatibleStateImageBehavior = false;
            this.lvAllWare.View = System.Windows.Forms.View.Details;
            this.lvAllWare.DoubleClick += new System.EventHandler(this.lvAllWare_DoubleClick);
            // 
            // chaName
            // 
            this.chaName.Text = "名称";
            // 
            // chaType
            // 
            this.chaType.Text = "类型";
            this.chaType.Width = 73;
            // 
            // chaPrice
            // 
            this.chaPrice.Text = "价格";
            this.chaPrice.Width = 54;
            // 
            // chaCount
            // 
            this.chaCount.Text = "数量";
            // 
            // lblWareType
            // 
            this.lblWareType.AutoSize = true;
            this.lblWareType.Location = new System.Drawing.Point(54, 30);
            this.lblWareType.Name = "lblWareType";
            this.lblWareType.Size = new System.Drawing.Size(65, 12);
            this.lblWareType.TabIndex = 5;
            this.lblWareType.Text = "商品类型：";
            // 
            // cboWareType
            // 
            this.cboWareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWareType.FormattingEnabled = true;
            this.cboWareType.Location = new System.Drawing.Point(122, 22);
            this.cboWareType.Name = "cboWareType";
            this.cboWareType.Size = new System.Drawing.Size(103, 20);
            this.cboWareType.TabIndex = 6;
            this.cboWareType.SelectedIndexChanged += new System.EventHandler(this.cboWareType_SelectedIndexChanged);
            // 
            // lblRoomId
            // 
            this.lblRoomId.AutoSize = true;
            this.lblRoomId.Location = new System.Drawing.Point(46, 392);
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Size = new System.Drawing.Size(53, 12);
            this.lblRoomId.TabIndex = 7;
            this.lblRoomId.Text = "房间号：";
            // 
            // grbSelectWare
            // 
            this.grbSelectWare.Controls.Add(this.lvSelect);
            this.grbSelectWare.Location = new System.Drawing.Point(360, 68);
            this.grbSelectWare.Name = "grbSelectWare";
            this.grbSelectWare.Size = new System.Drawing.Size(264, 310);
            this.grbSelectWare.TabIndex = 9;
            this.grbSelectWare.TabStop = false;
            this.grbSelectWare.Text = "所有商品";
            // 
            // lvSelect
            // 
            this.lvSelect.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chType,
            this.chPrice,
            this.chCount});
            this.lvSelect.FullRowSelect = true;
            this.lvSelect.GridLines = true;
            this.lvSelect.Location = new System.Drawing.Point(6, 15);
            this.lvSelect.Name = "lvSelect";
            this.lvSelect.Size = new System.Drawing.Size(252, 281);
            this.lvSelect.TabIndex = 0;
            this.lvSelect.UseCompatibleStateImageBehavior = false;
            this.lvSelect.View = System.Windows.Forms.View.Details;
            this.lvSelect.DoubleClick += new System.EventHandler(this.lvSelect_DoubleClick);
            // 
            // chName
            // 
            this.chName.Text = "名称";
            // 
            // chType
            // 
            this.chType.Text = "类型";
            this.chType.Width = 73;
            // 
            // chPrice
            // 
            this.chPrice.Text = "价格";
            this.chPrice.Width = 54;
            // 
            // chCount
            // 
            this.chCount.Text = "数量";
            // 
            // lblEasyName
            // 
            this.lblEasyName.AutoSize = true;
            this.lblEasyName.Location = new System.Drawing.Point(386, 30);
            this.lblEasyName.Name = "lblEasyName";
            this.lblEasyName.Size = new System.Drawing.Size(53, 12);
            this.lblEasyName.TabIndex = 10;
            this.lblEasyName.Text = "检索码：";
            // 
            // txtEasyName
            // 
            this.txtEasyName.Location = new System.Drawing.Point(458, 21);
            this.txtEasyName.Name = "txtEasyName";
            this.txtEasyName.Size = new System.Drawing.Size(100, 21);
            this.txtEasyName.TabIndex = 11;
            this.txtEasyName.TextChanged += new System.EventHandler(this.txtEasyName_TextChanged);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(310, 118);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(35, 21);
            this.txtCount.TabIndex = 12;
            this.txtCount.Text = "1";
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCount_KeyPress);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(308, 97);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(41, 12);
            this.lblCount.TabIndex = 13;
            this.lblCount.Text = "数量：";
            // 
            // cboRoomId
            // 
            this.cboRoomId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomId.FormattingEnabled = true;
            this.cboRoomId.Location = new System.Drawing.Point(105, 384);
            this.cboRoomId.Name = "cboRoomId";
            this.cboRoomId.Size = new System.Drawing.Size(103, 20);
            this.cboRoomId.TabIndex = 14;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(317, 165);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(23, 23);
            this.btnRight.TabIndex = 15;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(317, 217);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(23, 23);
            this.btnLeft.TabIndex = 16;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(309, 270);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "<<";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddConsume
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(636, 453);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.cboRoomId);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtEasyName);
            this.Controls.Add(this.lblEasyName);
            this.Controls.Add(this.grbSelectWare);
            this.Controls.Add(this.lblRoomId);
            this.Controls.Add(this.cboWareType);
            this.Controls.Add(this.lblWareType);
            this.Controls.Add(this.grbAllWare);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddConsume";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加消费";
            this.Shown += new System.EventHandler(this.AddConsume_Shown);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.grbAllWare.ResumeLayout(false);
            this.grbSelectWare.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grbAllWare;
        private System.Windows.Forms.ListView lvAllWare;
        private System.Windows.Forms.ColumnHeader chaName;
        private System.Windows.Forms.ColumnHeader chaType;
        private System.Windows.Forms.ColumnHeader chaPrice;
        private System.Windows.Forms.Label lblWareType;
        private System.Windows.Forms.ComboBox cboWareType;
        private System.Windows.Forms.Label lblRoomId;
        private System.Windows.Forms.ColumnHeader chaCount;
        private System.Windows.Forms.GroupBox grbSelectWare;
        private System.Windows.Forms.ListView lvSelect;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.ColumnHeader chCount;
        private System.Windows.Forms.Label lblEasyName;
        private System.Windows.Forms.TextBox txtEasyName;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ComboBox cboRoomId;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnClear;
    }
}