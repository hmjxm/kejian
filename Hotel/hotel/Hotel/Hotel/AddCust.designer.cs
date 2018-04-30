namespace Hotel
{
    partial class AddCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCust));
            this.btnCustAdd = new System.Windows.Forms.Button();
            this.CustCancel = new System.Windows.Forms.Button();
            this.grbAddCust = new System.Windows.Forms.GroupBox();
            this.txtPassAgain = new System.Windows.Forms.TextBox();
            this.lblPassAgain = new System.Windows.Forms.Label();
            this.cboPaper = new System.Windows.Forms.ComboBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.TxtcontactTel = new System.Windows.Forms.TextBox();
            this.CustcontactTel = new System.Windows.Forms.Label();
            this.rdoWoman = new System.Windows.Forms.RadioButton();
            this.rdoMan = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtpaperID = new System.Windows.Forms.TextBox();
            this.CustpaperID = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Custpaper = new System.Windows.Forms.Label();
            this.CustOrigin = new System.Windows.Forms.Label();
            this.Txtpwd = new System.Windows.Forms.TextBox();
            this.Custpwd = new System.Windows.Forms.Label();
            this.Txtname = new System.Windows.Forms.TextBox();
            this.CustName = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.CustID = new System.Windows.Forms.Label();
            this.grbAddCust.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustAdd
            // 
            this.btnCustAdd.Location = new System.Drawing.Point(75, 429);
            this.btnCustAdd.Name = "btnCustAdd";
            this.btnCustAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCustAdd.TabIndex = 25;
            this.btnCustAdd.Text = "添加";
            this.btnCustAdd.UseVisualStyleBackColor = true;
            this.btnCustAdd.Click += new System.EventHandler(this.btnCustAdd_Click);
            // 
            // CustCancel
            // 
            this.CustCancel.Location = new System.Drawing.Point(190, 429);
            this.CustCancel.Name = "CustCancel";
            this.CustCancel.Size = new System.Drawing.Size(75, 23);
            this.CustCancel.TabIndex = 26;
            this.CustCancel.Text = "取消";
            this.CustCancel.UseVisualStyleBackColor = true;
            this.CustCancel.Click += new System.EventHandler(this.CustCancel_Click);
            // 
            // grbAddCust
            // 
            this.grbAddCust.Controls.Add(this.txtPassAgain);
            this.grbAddCust.Controls.Add(this.lblPassAgain);
            this.grbAddCust.Controls.Add(this.cboPaper);
            this.grbAddCust.Controls.Add(this.txtRemark);
            this.grbAddCust.Controls.Add(this.lblRemark);
            this.grbAddCust.Controls.Add(this.TxtcontactTel);
            this.grbAddCust.Controls.Add(this.CustcontactTel);
            this.grbAddCust.Controls.Add(this.rdoWoman);
            this.grbAddCust.Controls.Add(this.rdoMan);
            this.grbAddCust.Controls.Add(this.label1);
            this.grbAddCust.Controls.Add(this.TxtpaperID);
            this.grbAddCust.Controls.Add(this.CustpaperID);
            this.grbAddCust.Controls.Add(this.txtAddress);
            this.grbAddCust.Controls.Add(this.Custpaper);
            this.grbAddCust.Controls.Add(this.CustOrigin);
            this.grbAddCust.Controls.Add(this.Txtpwd);
            this.grbAddCust.Controls.Add(this.Custpwd);
            this.grbAddCust.Controls.Add(this.Txtname);
            this.grbAddCust.Controls.Add(this.CustName);
            this.grbAddCust.Controls.Add(this.TxtID);
            this.grbAddCust.Controls.Add(this.CustID);
            this.grbAddCust.Location = new System.Drawing.Point(25, 12);
            this.grbAddCust.Name = "grbAddCust";
            this.grbAddCust.Size = new System.Drawing.Size(270, 401);
            this.grbAddCust.TabIndex = 27;
            this.grbAddCust.TabStop = false;
            this.grbAddCust.Text = "添加会员";
            // 
            // txtPassAgain
            // 
            this.txtPassAgain.Location = new System.Drawing.Point(72, 124);
            this.txtPassAgain.Name = "txtPassAgain";
            this.txtPassAgain.PasswordChar = '*';
            this.txtPassAgain.Size = new System.Drawing.Size(129, 21);
            this.txtPassAgain.TabIndex = 48;
            this.txtPassAgain.TextChanged += new System.EventHandler(this.txtPassAgain_TextChanged);
            // 
            // lblPassAgain
            // 
            this.lblPassAgain.AutoSize = true;
            this.lblPassAgain.Location = new System.Drawing.Point(4, 127);
            this.lblPassAgain.Name = "lblPassAgain";
            this.lblPassAgain.Size = new System.Drawing.Size(53, 12);
            this.lblPassAgain.TabIndex = 47;
            this.lblPassAgain.Text = "确认密码";
            // 
            // cboPaper
            // 
            this.cboPaper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaper.FormattingEnabled = true;
            this.cboPaper.Items.AddRange(new object[] {
            "身份证",
            "学生证",
            "军官证",
            "其他"});
            this.cboPaper.Location = new System.Drawing.Point(72, 183);
            this.cboPaper.Name = "cboPaper";
            this.cboPaper.Size = new System.Drawing.Size(129, 20);
            this.cboPaper.TabIndex = 46;
            this.cboPaper.SelectedIndexChanged += new System.EventHandler(this.cboPaper_SelectedIndexChanged);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(72, 276);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(181, 111);
            this.txtRemark.TabIndex = 45;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(28, 279);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(29, 12);
            this.lblRemark.TabIndex = 44;
            this.lblRemark.Text = "备注";
            // 
            // TxtcontactTel
            // 
            this.TxtcontactTel.Location = new System.Drawing.Point(72, 246);
            this.TxtcontactTel.Name = "TxtcontactTel";
            this.TxtcontactTel.Size = new System.Drawing.Size(129, 21);
            this.TxtcontactTel.TabIndex = 43;
            this.TxtcontactTel.TextChanged += new System.EventHandler(this.TxtcontactTel_TextChanged);
            // 
            // CustcontactTel
            // 
            this.CustcontactTel.AutoSize = true;
            this.CustcontactTel.Location = new System.Drawing.Point(4, 249);
            this.CustcontactTel.Name = "CustcontactTel";
            this.CustcontactTel.Size = new System.Drawing.Size(53, 12);
            this.CustcontactTel.TabIndex = 42;
            this.CustcontactTel.Text = "联系方式";
            // 
            // rdoWoman
            // 
            this.rdoWoman.AutoSize = true;
            this.rdoWoman.Location = new System.Drawing.Point(157, 73);
            this.rdoWoman.Name = "rdoWoman";
            this.rdoWoman.Size = new System.Drawing.Size(35, 16);
            this.rdoWoman.TabIndex = 41;
            this.rdoWoman.Text = "女";
            this.rdoWoman.UseVisualStyleBackColor = true;
            // 
            // rdoMan
            // 
            this.rdoMan.AutoSize = true;
            this.rdoMan.Checked = true;
            this.rdoMan.Location = new System.Drawing.Point(99, 73);
            this.rdoMan.Name = "rdoMan";
            this.rdoMan.Size = new System.Drawing.Size(35, 16);
            this.rdoMan.TabIndex = 40;
            this.rdoMan.TabStop = true;
            this.rdoMan.Text = "男";
            this.rdoMan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 39;
            this.label1.Text = "性别";
            // 
            // TxtpaperID
            // 
            this.TxtpaperID.Location = new System.Drawing.Point(72, 215);
            this.TxtpaperID.Name = "TxtpaperID";
            this.TxtpaperID.Size = new System.Drawing.Size(129, 21);
            this.TxtpaperID.TabIndex = 38;
            this.TxtpaperID.Leave += new System.EventHandler(this.TxtpaperID_Leave);
            this.TxtpaperID.TextChanged += new System.EventHandler(this.TxtpaperID_TextChanged);
            // 
            // CustpaperID
            // 
            this.CustpaperID.AutoSize = true;
            this.CustpaperID.Location = new System.Drawing.Point(16, 218);
            this.CustpaperID.Name = "CustpaperID";
            this.CustpaperID.Size = new System.Drawing.Size(41, 12);
            this.CustpaperID.TabIndex = 37;
            this.CustpaperID.Text = "证件ID";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(72, 153);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(129, 21);
            this.txtAddress.TabIndex = 36;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // Custpaper
            // 
            this.Custpaper.AutoSize = true;
            this.Custpaper.Location = new System.Drawing.Point(4, 188);
            this.Custpaper.Name = "Custpaper";
            this.Custpaper.Size = new System.Drawing.Size(53, 12);
            this.Custpaper.TabIndex = 35;
            this.Custpaper.Text = "证件类型";
            // 
            // CustOrigin
            // 
            this.CustOrigin.AutoSize = true;
            this.CustOrigin.Location = new System.Drawing.Point(28, 156);
            this.CustOrigin.Name = "CustOrigin";
            this.CustOrigin.Size = new System.Drawing.Size(29, 12);
            this.CustOrigin.TabIndex = 34;
            this.CustOrigin.Text = "地址";
            // 
            // Txtpwd
            // 
            this.Txtpwd.Location = new System.Drawing.Point(72, 97);
            this.Txtpwd.Name = "Txtpwd";
            this.Txtpwd.PasswordChar = '*';
            this.Txtpwd.Size = new System.Drawing.Size(129, 21);
            this.Txtpwd.TabIndex = 33;
            this.Txtpwd.TextChanged += new System.EventHandler(this.Txtpwd_TextChanged);
            // 
            // Custpwd
            // 
            this.Custpwd.AutoSize = true;
            this.Custpwd.Location = new System.Drawing.Point(28, 100);
            this.Custpwd.Name = "Custpwd";
            this.Custpwd.Size = new System.Drawing.Size(29, 12);
            this.Custpwd.TabIndex = 32;
            this.Custpwd.Text = "密码";
            // 
            // Txtname
            // 
            this.Txtname.Location = new System.Drawing.Point(72, 44);
            this.Txtname.Name = "Txtname";
            this.Txtname.Size = new System.Drawing.Size(129, 21);
            this.Txtname.TabIndex = 31;
            this.Txtname.TextChanged += new System.EventHandler(this.Txtname_TextChanged);
            // 
            // CustName
            // 
            this.CustName.AutoSize = true;
            this.CustName.Location = new System.Drawing.Point(28, 47);
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(29, 12);
            this.CustName.TabIndex = 30;
            this.CustName.Text = "姓名";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(72, 13);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(129, 21);
            this.TxtID.TabIndex = 29;
            this.TxtID.Leave += new System.EventHandler(this.TxtID_Leave);
            this.TxtID.TextChanged += new System.EventHandler(this.TxtID_TextChanged);
            // 
            // CustID
            // 
            this.CustID.AutoSize = true;
            this.CustID.Location = new System.Drawing.Point(16, 19);
            this.CustID.Name = "CustID";
            this.CustID.Size = new System.Drawing.Size(41, 12);
            this.CustID.TabIndex = 28;
            this.CustID.Text = "用户名";
            // 
            // AddCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(321, 464);
            this.Controls.Add(this.grbAddCust);
            this.Controls.Add(this.CustCancel);
            this.Controls.Add(this.btnCustAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加会员";
            this.Load += new System.EventHandler(this.AddCust_Load);
            this.grbAddCust.ResumeLayout(false);
            this.grbAddCust.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustAdd;
        private System.Windows.Forms.Button CustCancel;
        private System.Windows.Forms.GroupBox grbAddCust;
        private System.Windows.Forms.ComboBox cboPaper;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox TxtcontactTel;
        private System.Windows.Forms.Label CustcontactTel;
        private System.Windows.Forms.RadioButton rdoWoman;
        private System.Windows.Forms.RadioButton rdoMan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtpaperID;
        private System.Windows.Forms.Label CustpaperID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label Custpaper;
        private System.Windows.Forms.Label CustOrigin;
        private System.Windows.Forms.TextBox Txtpwd;
        private System.Windows.Forms.Label Custpwd;
        private System.Windows.Forms.TextBox Txtname;
        private System.Windows.Forms.Label CustName;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label CustID;
        private System.Windows.Forms.TextBox txtPassAgain;
        private System.Windows.Forms.Label lblPassAgain;
    }
}