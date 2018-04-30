namespace Hotel
{
    partial class AddHouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHouseForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtfixing = new System.Windows.Forms.TextBox();
            this.txtFloot = new System.Windows.Forms.TextBox();
            this.txtRoom_id = new System.Windows.Forms.TextBox();
            this.lblfixing = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblFloot = new System.Windows.Forms.Label();
            this.lblRoom_id = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.cboRoomType);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtfixing);
            this.groupBox1.Controls.Add(this.txtFloot);
            this.groupBox1.Controls.Add(this.txtRoom_id);
            this.groupBox1.Controls.Add(this.lblfixing);
            this.groupBox1.Controls.Add(this.lblprice);
            this.groupBox1.Controls.Add(this.lblRoomType);
            this.groupBox1.Controls.Add(this.lblFloot);
            this.groupBox1.Controls.Add(this.lblRoom_id);
            this.groupBox1.Location = new System.Drawing.Point(28, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加房间";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Location = new System.Drawing.Point(174, 113);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(39, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboRoomType
            // 
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Location = new System.Drawing.Point(70, 83);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(100, 20);
            this.cboRoomType.TabIndex = 9;
            this.cboRoomType.SelectedIndexChanged += new System.EventHandler(this.cboRoomType_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(70, 113);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.Click += new System.EventHandler(this.txtPrice_Click);
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtfixing
            // 
            this.txtfixing.Location = new System.Drawing.Point(70, 142);
            this.txtfixing.Name = "txtfixing";
            this.txtfixing.Size = new System.Drawing.Size(100, 21);
            this.txtfixing.TabIndex = 7;
            // 
            // txtFloot
            // 
            this.txtFloot.Location = new System.Drawing.Point(70, 52);
            this.txtFloot.Name = "txtFloot";
            this.txtFloot.Size = new System.Drawing.Size(100, 21);
            this.txtFloot.TabIndex = 6;
            this.txtFloot.TextChanged += new System.EventHandler(this.txtFloot_TextChanged);
            // 
            // txtRoom_id
            // 
            this.txtRoom_id.Location = new System.Drawing.Point(70, 25);
            this.txtRoom_id.Name = "txtRoom_id";
            this.txtRoom_id.Size = new System.Drawing.Size(100, 21);
            this.txtRoom_id.TabIndex = 5;
            this.txtRoom_id.Leave += new System.EventHandler(this.txtRoom_id_Leave);
            this.txtRoom_id.TextChanged += new System.EventHandler(this.txtRoom_id_TextChanged);
            // 
            // lblfixing
            // 
            this.lblfixing.AutoSize = true;
            this.lblfixing.Location = new System.Drawing.Point(21, 145);
            this.lblfixing.Name = "lblfixing";
            this.lblfixing.Size = new System.Drawing.Size(41, 12);
            this.lblfixing.TabIndex = 4;
            this.lblfixing.Text = "设备：";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(21, 116);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(41, 12);
            this.lblprice.TabIndex = 3;
            this.lblprice.Text = "价格：";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(21, 86);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(41, 12);
            this.lblRoomType.TabIndex = 2;
            this.lblRoomType.Text = "类型：";
            // 
            // lblFloot
            // 
            this.lblFloot.AutoSize = true;
            this.lblFloot.Location = new System.Drawing.Point(21, 55);
            this.lblFloot.Name = "lblFloot";
            this.lblFloot.Size = new System.Drawing.Size(41, 12);
            this.lblFloot.TabIndex = 1;
            this.lblFloot.Text = "楼层：";
            // 
            // lblRoom_id
            // 
            this.lblRoom_id.AutoSize = true;
            this.lblRoom_id.Location = new System.Drawing.Point(21, 28);
            this.lblRoom_id.Name = "lblRoom_id";
            this.lblRoom_id.Size = new System.Drawing.Size(41, 12);
            this.lblRoom_id.TabIndex = 0;
            this.lblRoom_id.Text = "房号：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(51, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(144, 212);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 253);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddHouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加房间";
            this.Activated += new System.EventHandler(this.AddHouseForm_Activated);
            this.Load += new System.EventHandler(this.AddHouseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblfixing;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblFloot;
        private System.Windows.Forms.Label lblRoom_id;
        private System.Windows.Forms.TextBox txtfixing;
        private System.Windows.Forms.TextBox txtFloot;
        private System.Windows.Forms.TextBox txtRoom_id;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
    }
}