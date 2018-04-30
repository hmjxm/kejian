namespace Hotel
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbAddEmp = new System.Windows.Forms.GroupBox();
            this.txtPassAgain = new System.Windows.Forms.TextBox();
            this.lblPassAgain = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtA_AdminId = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblA_AdminId = new System.Windows.Forms.Label();
            this.grbAddEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(150, 207);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(57, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbAddEmp
            // 
            this.grbAddEmp.Controls.Add(this.txtPassAgain);
            this.grbAddEmp.Controls.Add(this.lblPassAgain);
            this.grbAddEmp.Controls.Add(this.cboType);
            this.grbAddEmp.Controls.Add(this.txtName);
            this.grbAddEmp.Controls.Add(this.txtPass);
            this.grbAddEmp.Controls.Add(this.txtA_AdminId);
            this.grbAddEmp.Controls.Add(this.lblprice);
            this.grbAddEmp.Controls.Add(this.lblName);
            this.grbAddEmp.Controls.Add(this.lblPass);
            this.grbAddEmp.Controls.Add(this.lblA_AdminId);
            this.grbAddEmp.Location = new System.Drawing.Point(29, 23);
            this.grbAddEmp.Name = "grbAddEmp";
            this.grbAddEmp.Size = new System.Drawing.Size(209, 168);
            this.grbAddEmp.TabIndex = 3;
            this.grbAddEmp.TabStop = false;
            this.grbAddEmp.Text = "添加员工";
            this.grbAddEmp.Enter += new System.EventHandler(this.grbAddEmp_Enter);
            // 
            // txtPassAgain
            // 
            this.txtPassAgain.Location = new System.Drawing.Point(83, 73);
            this.txtPassAgain.Name = "txtPassAgain";
            this.txtPassAgain.PasswordChar = '*';
            this.txtPassAgain.Size = new System.Drawing.Size(100, 21);
            this.txtPassAgain.TabIndex = 7;
            this.txtPassAgain.TextChanged += new System.EventHandler(this.txtPassAgain_TextChanged);
            // 
            // lblPassAgain
            // 
            this.lblPassAgain.AutoSize = true;
            this.lblPassAgain.Location = new System.Drawing.Point(9, 76);
            this.lblPassAgain.Name = "lblPassAgain";
            this.lblPassAgain.Size = new System.Drawing.Size(65, 12);
            this.lblPassAgain.TabIndex = 10;
            this.lblPassAgain.Text = "确认密码：";
            this.lblPassAgain.Click += new System.EventHandler(this.lblPassAgain_Click);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.ItemHeight = 12;
            this.cboType.Items.AddRange(new object[] {
            "管理员",
            "服务员"});
            this.cboType.Location = new System.Drawing.Point(83, 134);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(100, 20);
            this.cboType.TabIndex = 9;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(83, 46);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 21);
            this.txtPass.TabIndex = 6;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtA_AdminId
            // 
            this.txtA_AdminId.Location = new System.Drawing.Point(83, 19);
            this.txtA_AdminId.Name = "txtA_AdminId";
            this.txtA_AdminId.Size = new System.Drawing.Size(100, 21);
            this.txtA_AdminId.TabIndex = 5;
            this.txtA_AdminId.TextChanged += new System.EventHandler(this.txtA_AdminId_TextChanged);
            this.txtA_AdminId.Leave += new System.EventHandler(this.txtA_AdminId_Leave);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(33, 136);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(41, 12);
            this.lblprice.TabIndex = 3;
            this.lblprice.Text = "类型：";
            this.lblprice.Click += new System.EventHandler(this.lblprice_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "姓名：";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(33, 52);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(41, 12);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "密码：";
            this.lblPass.Click += new System.EventHandler(this.lblPass_Click);
            // 
            // lblA_AdminId
            // 
            this.lblA_AdminId.AutoSize = true;
            this.lblA_AdminId.Location = new System.Drawing.Point(21, 25);
            this.lblA_AdminId.Name = "lblA_AdminId";
            this.lblA_AdminId.Size = new System.Drawing.Size(53, 12);
            this.lblA_AdminId.TabIndex = 0;
            this.lblA_AdminId.Text = "用户名：";
            this.lblA_AdminId.Click += new System.EventHandler(this.lblA_AdminId_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 253);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbAddEmp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加员工";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.grbAddEmp.ResumeLayout(false);
            this.grbAddEmp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbAddEmp;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtA_AdminId;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblA_AdminId;
        private System.Windows.Forms.TextBox txtPassAgain;
        private System.Windows.Forms.Label lblPassAgain;
    }
}