//download by http://www.codefans.net
namespace Hotel
{
    partial class MoneySelsct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoneySelsct));
            this.tcmoney = new System.Windows.Forms.TabControl();
            this.tpEarningMoney = new System.Windows.Forms.TabPage();
            this.groupBoxone = new System.Windows.Forms.GroupBox();
            this.listone = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.dtpDatetwo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateone = new System.Windows.Forms.DateTimePicker();
            this.cboTypeone = new System.Windows.Forms.ComboBox();
            this.lblEarningDate = new System.Windows.Forms.Label();
            this.lblEarningType = new System.Windows.Forms.Label();
            this.tpDefrayMoney = new System.Windows.Forms.TabPage();
            this.groupBoxtwo = new System.Windows.Forms.GroupBox();
            this.listtwo = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.dtpDatefrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpdatethree = new System.Windows.Forms.DateTimePicker();
            this.cboTypetwo = new System.Windows.Forms.ComboBox();
            this.lblDefrayDate = new System.Windows.Forms.Label();
            this.lblDefrayType = new System.Windows.Forms.Label();
            this.tcmoney.SuspendLayout();
            this.tpEarningMoney.SuspendLayout();
            this.groupBoxone.SuspendLayout();
            this.tpDefrayMoney.SuspendLayout();
            this.groupBoxtwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcmoney
            // 
            this.tcmoney.Controls.Add(this.tpEarningMoney);
            this.tcmoney.Controls.Add(this.tpDefrayMoney);
            this.tcmoney.Location = new System.Drawing.Point(12, 12);
            this.tcmoney.Name = "tcmoney";
            this.tcmoney.SelectedIndex = 0;
            this.tcmoney.Size = new System.Drawing.Size(730, 409);
            this.tcmoney.TabIndex = 9;
            // 
            // tpEarningMoney
            // 
            this.tpEarningMoney.Controls.Add(this.groupBoxone);
            this.tpEarningMoney.Location = new System.Drawing.Point(4, 21);
            this.tpEarningMoney.Name = "tpEarningMoney";
            this.tpEarningMoney.Padding = new System.Windows.Forms.Padding(3);
            this.tpEarningMoney.Size = new System.Drawing.Size(722, 384);
            this.tpEarningMoney.TabIndex = 0;
            this.tpEarningMoney.Text = "收入金额";
            this.tpEarningMoney.UseVisualStyleBackColor = true;
            // 
            // groupBoxone
            // 
            this.groupBoxone.Controls.Add(this.listone);
            this.groupBoxone.Controls.Add(this.dtpDatetwo);
            this.groupBoxone.Controls.Add(this.label3);
            this.groupBoxone.Controls.Add(this.dtpDateone);
            this.groupBoxone.Controls.Add(this.cboTypeone);
            this.groupBoxone.Controls.Add(this.lblEarningDate);
            this.groupBoxone.Controls.Add(this.lblEarningType);
            this.groupBoxone.Location = new System.Drawing.Point(26, 9);
            this.groupBoxone.Name = "groupBoxone";
            this.groupBoxone.Size = new System.Drawing.Size(671, 366);
            this.groupBoxone.TabIndex = 9;
            this.groupBoxone.TabStop = false;
            this.groupBoxone.Text = "收入额查询";
            // 
            // listone
            // 
            this.listone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listone.GridLines = true;
            this.listone.Location = new System.Drawing.Point(30, 49);
            this.listone.Name = "listone";
            this.listone.Size = new System.Drawing.Size(612, 295);
            this.listone.TabIndex = 14;
            this.listone.UseCompatibleStateImageBehavior = false;
            this.listone.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "收入类型";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "收入金额";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "收入时间";
            this.columnHeader4.Width = 127;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "备注";
            this.columnHeader5.Width = 181;
            // 
            // dtpDatetwo
            // 
            this.dtpDatetwo.Location = new System.Drawing.Point(507, 23);
            this.dtpDatetwo.Name = "dtpDatetwo";
            this.dtpDatetwo.Size = new System.Drawing.Size(114, 21);
            this.dtpDatetwo.TabIndex = 13;
            this.dtpDatetwo.CloseUp += new System.EventHandler(this.dtpDatetwo_CloseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "至";
            // 
            // dtpDateone
            // 
            this.dtpDateone.Location = new System.Drawing.Point(340, 22);
            this.dtpDateone.Name = "dtpDateone";
            this.dtpDateone.Size = new System.Drawing.Size(114, 21);
            this.dtpDateone.TabIndex = 11;
            this.dtpDateone.CloseUp += new System.EventHandler(this.dtpDateone_CloseUp);
            // 
            // cboTypeone
            // 
            this.cboTypeone.FormattingEnabled = true;
            this.cboTypeone.Items.AddRange(new object[] {
            "房间消费",
            "商品消费",
            "全部"});
            this.cboTypeone.Location = new System.Drawing.Point(119, 23);
            this.cboTypeone.Name = "cboTypeone";
            this.cboTypeone.Size = new System.Drawing.Size(114, 20);
            this.cboTypeone.TabIndex = 10;
            this.cboTypeone.Text = "全部";
            this.cboTypeone.SelectionChangeCommitted += new System.EventHandler(this.cboTypeone_SelectionChangeCommitted);
            // 
            // lblEarningDate
            // 
            this.lblEarningDate.AutoSize = true;
            this.lblEarningDate.Location = new System.Drawing.Point(269, 26);
            this.lblEarningDate.Name = "lblEarningDate";
            this.lblEarningDate.Size = new System.Drawing.Size(65, 12);
            this.lblEarningDate.TabIndex = 9;
            this.lblEarningDate.Text = "收入时间：";
            // 
            // lblEarningType
            // 
            this.lblEarningType.AutoSize = true;
            this.lblEarningType.Location = new System.Drawing.Point(28, 26);
            this.lblEarningType.Name = "lblEarningType";
            this.lblEarningType.Size = new System.Drawing.Size(65, 12);
            this.lblEarningType.TabIndex = 8;
            this.lblEarningType.Text = "收入类型：";
            // 
            // tpDefrayMoney
            // 
            this.tpDefrayMoney.Controls.Add(this.groupBoxtwo);
            this.tpDefrayMoney.Location = new System.Drawing.Point(4, 21);
            this.tpDefrayMoney.Name = "tpDefrayMoney";
            this.tpDefrayMoney.Padding = new System.Windows.Forms.Padding(3);
            this.tpDefrayMoney.Size = new System.Drawing.Size(722, 384);
            this.tpDefrayMoney.TabIndex = 1;
            this.tpDefrayMoney.Text = "支出金额";
            this.tpDefrayMoney.UseVisualStyleBackColor = true;
            // 
            // groupBoxtwo
            // 
            this.groupBoxtwo.Controls.Add(this.listtwo);
            this.groupBoxtwo.Controls.Add(this.dtpDatefrom);
            this.groupBoxtwo.Controls.Add(this.label4);
            this.groupBoxtwo.Controls.Add(this.dtpdatethree);
            this.groupBoxtwo.Controls.Add(this.cboTypetwo);
            this.groupBoxtwo.Controls.Add(this.lblDefrayDate);
            this.groupBoxtwo.Controls.Add(this.lblDefrayType);
            this.groupBoxtwo.Location = new System.Drawing.Point(27, 12);
            this.groupBoxtwo.Name = "groupBoxtwo";
            this.groupBoxtwo.Size = new System.Drawing.Size(671, 366);
            this.groupBoxtwo.TabIndex = 10;
            this.groupBoxtwo.TabStop = false;
            this.groupBoxtwo.Text = "支出额查询";
            // 
            // listtwo
            // 
            this.listtwo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listtwo.GridLines = true;
            this.listtwo.Location = new System.Drawing.Point(30, 49);
            this.listtwo.Name = "listtwo";
            this.listtwo.Size = new System.Drawing.Size(612, 295);
            this.listtwo.TabIndex = 14;
            this.listtwo.UseCompatibleStateImageBehavior = false;
            this.listtwo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "编号";
            this.columnHeader6.Width = 87;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "支出类型";
            this.columnHeader7.Width = 79;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "支出金额";
            this.columnHeader8.Width = 130;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "支出时间";
            this.columnHeader9.Width = 127;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "备注";
            this.columnHeader10.Width = 181;
            // 
            // dtpDatefrom
            // 
            this.dtpDatefrom.Location = new System.Drawing.Point(507, 23);
            this.dtpDatefrom.Name = "dtpDatefrom";
            this.dtpDatefrom.Size = new System.Drawing.Size(114, 21);
            this.dtpDatefrom.TabIndex = 13;
            this.dtpDatefrom.CloseUp += new System.EventHandler(this.dtpDatefrom_CloseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "至";
            // 
            // dtpdatethree
            // 
            this.dtpdatethree.Location = new System.Drawing.Point(340, 22);
            this.dtpdatethree.Name = "dtpdatethree";
            this.dtpdatethree.Size = new System.Drawing.Size(114, 21);
            this.dtpdatethree.TabIndex = 11;
            this.dtpdatethree.CloseUp += new System.EventHandler(this.dtpdatethree_CloseUp);
            // 
            // cboTypetwo
            // 
            this.cboTypetwo.FormattingEnabled = true;
            this.cboTypetwo.Items.AddRange(new object[] {
            "住宿",
            "商品消费",
            "全部"});
            this.cboTypetwo.Location = new System.Drawing.Point(119, 23);
            this.cboTypetwo.Name = "cboTypetwo";
            this.cboTypetwo.Size = new System.Drawing.Size(114, 20);
            this.cboTypetwo.TabIndex = 10;
            this.cboTypetwo.Text = "全部";
            this.cboTypetwo.SelectionChangeCommitted += new System.EventHandler(this.cboTypetwo_SelectionChangeCommitted);
            // 
            // lblDefrayDate
            // 
            this.lblDefrayDate.AutoSize = true;
            this.lblDefrayDate.Location = new System.Drawing.Point(269, 26);
            this.lblDefrayDate.Name = "lblDefrayDate";
            this.lblDefrayDate.Size = new System.Drawing.Size(65, 12);
            this.lblDefrayDate.TabIndex = 9;
            this.lblDefrayDate.Text = "支出时间：";
            // 
            // lblDefrayType
            // 
            this.lblDefrayType.AutoSize = true;
            this.lblDefrayType.Location = new System.Drawing.Point(28, 26);
            this.lblDefrayType.Name = "lblDefrayType";
            this.lblDefrayType.Size = new System.Drawing.Size(65, 12);
            this.lblDefrayType.TabIndex = 8;
            this.lblDefrayType.Text = "支出类型：";
            // 
            // MoneySelsct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 433);
            this.Controls.Add(this.tcmoney);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoneySelsct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "营业额管理";
            this.Load += new System.EventHandler(this.MoneySelsct_Load);
            this.tcmoney.ResumeLayout(false);
            this.tpEarningMoney.ResumeLayout(false);
            this.groupBoxone.ResumeLayout(false);
            this.groupBoxone.PerformLayout();
            this.tpDefrayMoney.ResumeLayout(false);
            this.groupBoxtwo.ResumeLayout(false);
            this.groupBoxtwo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcmoney;
        private System.Windows.Forms.TabPage tpEarningMoney;
        private System.Windows.Forms.GroupBox groupBoxone;
        private System.Windows.Forms.ListView listone;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.DateTimePicker dtpDatetwo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateone;
        private System.Windows.Forms.ComboBox cboTypeone;
        private System.Windows.Forms.Label lblEarningDate;
        private System.Windows.Forms.Label lblEarningType;
        private System.Windows.Forms.TabPage tpDefrayMoney;
        private System.Windows.Forms.GroupBox groupBoxtwo;
        private System.Windows.Forms.ListView listtwo;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.DateTimePicker dtpDatefrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpdatethree;
        private System.Windows.Forms.ComboBox cboTypetwo;
        private System.Windows.Forms.Label lblDefrayDate;
        private System.Windows.Forms.Label lblDefrayType;


    }
}