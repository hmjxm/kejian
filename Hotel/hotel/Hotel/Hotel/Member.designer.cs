namespace Hotel
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            this.grbList = new System.Windows.Forms.GroupBox();
            this.lvCust = new System.Windows.Forms.ListView();
            this.chId = new System.Windows.Forms.ColumnHeader();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chScore = new System.Windows.Forms.ColumnHeader();
            this.chU_money = new System.Windows.Forms.ColumnHeader();
            this.chIDType = new System.Windows.Forms.ColumnHeader();
            this.chSId = new System.Windows.Forms.ColumnHeader();
            this.chAddress = new System.Windows.Forms.ColumnHeader();
            this.chSex = new System.Windows.Forms.ColumnHeader();
            this.chtel = new System.Windows.Forms.ColumnHeader();
            this.chRemark = new System.Windows.Forms.ColumnHeader();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpater = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtU_UsersId = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsCustOper = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlusMoney = new System.Windows.Forms.Button();
            this.grbList.SuspendLayout();
            this.cmsCustOper.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.lvCust);
            this.grbList.Location = new System.Drawing.Point(12, 56);
            this.grbList.Name = "grbList";
            this.grbList.Size = new System.Drawing.Size(748, 239);
            this.grbList.TabIndex = 6;
            this.grbList.TabStop = false;
            this.grbList.Text = "会员记录";
            // 
            // lvCust
            // 
            this.lvCust.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chName,
            this.chScore,
            this.chU_money,
            this.chIDType,
            this.chSId,
            this.chAddress,
            this.chSex,
            this.chtel,
            this.chRemark});
            this.lvCust.FullRowSelect = true;
            this.lvCust.GridLines = true;
            this.lvCust.Location = new System.Drawing.Point(22, 20);
            this.lvCust.Name = "lvCust";
            this.lvCust.Size = new System.Drawing.Size(706, 197);
            this.lvCust.TabIndex = 0;
            this.lvCust.UseCompatibleStateImageBehavior = false;
            this.lvCust.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 72;
            // 
            // chName
            // 
            this.chName.Text = "名字";
            this.chName.Width = 64;
            // 
            // chScore
            // 
            this.chScore.Text = "积分";
            this.chScore.Width = 53;
            // 
            // chU_money
            // 
            this.chU_money.Text = "余额";
            // 
            // chIDType
            // 
            this.chIDType.Text = "证件类型";
            this.chIDType.Width = 70;
            // 
            // chSId
            // 
            this.chSId.Text = "证件";
            // 
            // chAddress
            // 
            this.chAddress.Text = "地址";
            // 
            // chSex
            // 
            this.chSex.Text = "性别";
            // 
            // chtel
            // 
            this.chtel.Text = "联系方式";
            this.chtel.Width = 91;
            // 
            // chRemark
            // 
            this.chRemark.Text = "备注";
            this.chRemark.Width = 106;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(256, 314);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpater
            // 
            this.btnUpater.Location = new System.Drawing.Point(348, 314);
            this.btnUpater.Name = "btnUpater";
            this.btnUpater.Size = new System.Drawing.Size(75, 23);
            this.btnUpater.TabIndex = 8;
            this.btnUpater.Text = "修改";
            this.btnUpater.UseVisualStyleBackColor = true;
            this.btnUpater.Click += new System.EventHandler(this.btnUpater_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(527, 314);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtU_UsersId
            // 
            this.txtU_UsersId.Location = new System.Drawing.Point(131, 26);
            this.txtU_UsersId.Name = "txtU_UsersId";
            this.txtU_UsersId.Size = new System.Drawing.Size(105, 21);
            this.txtU_UsersId.TabIndex = 10;
            this.txtU_UsersId.TextChanged += new System.EventHandler(this.txtU_UsersId_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(242, 24);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "查找";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "会员ID：";
            // 
            // cmsCustOper
            // 
            this.cmsCustOper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd,
            this.tsmiUpdate,
            this.tsmiDelete});
            this.cmsCustOper.Name = "cmsCustOper";
            this.cmsCustOper.Size = new System.Drawing.Size(95, 70);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(94, 22);
            this.tsmiAdd.Text = "添加";
            this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(94, 22);
            this.tsmiUpdate.Text = "修改";
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(94, 22);
            this.tsmiDelete.Text = "删除";
            // 
            // btnPlusMoney
            // 
            this.btnPlusMoney.Location = new System.Drawing.Point(437, 314);
            this.btnPlusMoney.Name = "btnPlusMoney";
            this.btnPlusMoney.Size = new System.Drawing.Size(75, 23);
            this.btnPlusMoney.TabIndex = 13;
            this.btnPlusMoney.Text = "充值";
            this.btnPlusMoney.UseVisualStyleBackColor = true;
            this.btnPlusMoney.Click += new System.EventHandler(this.btnPlusMoney_Click);
            // 
            // Member
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 353);
            this.Controls.Add(this.btnPlusMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.grbList);
            this.Controls.Add(this.btnUpater);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtU_UsersId);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员管理";
            this.Activated += new System.EventHandler(this.Member_Activated);
            this.Load += new System.EventHandler(this.frmMember_Load);
            this.grbList.ResumeLayout(false);
            this.cmsCustOper.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbList;
        private System.Windows.Forms.ListView lvCust;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpater;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtU_UsersId;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chSId;
        private System.Windows.Forms.ColumnHeader chtel;
        private System.Windows.Forms.ColumnHeader chRemark;
        private System.Windows.Forms.ContextMenuStrip cmsCustOper;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ColumnHeader chScore;
        private System.Windows.Forms.ColumnHeader chIDType;
        private System.Windows.Forms.ColumnHeader chAddress;
        private System.Windows.Forms.ColumnHeader chSex;
        private System.Windows.Forms.ColumnHeader chU_money;
        private System.Windows.Forms.Button btnPlusMoney;

    }
}