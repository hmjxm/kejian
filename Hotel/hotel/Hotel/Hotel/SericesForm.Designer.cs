//download by http://www.codefans.net
namespace Hotel
{
    partial class SericesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SericesForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbSelf = new System.Windows.Forms.RichTextBox();
            this.rtbAll = new System.Windows.Forms.RichTextBox();
            this.trmRead = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(282, 314);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(191, 314);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "发送(&S)";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbSelf
            // 
            this.rtbSelf.Location = new System.Drawing.Point(12, 201);
            this.rtbSelf.Name = "rtbSelf";
            this.rtbSelf.Size = new System.Drawing.Size(368, 96);
            this.rtbSelf.TabIndex = 11;
            this.rtbSelf.Text = "";
            // 
            // rtbAll
            // 
            this.rtbAll.BackColor = System.Drawing.Color.White;
            this.rtbAll.Location = new System.Drawing.Point(12, 20);
            this.rtbAll.Name = "rtbAll";
            this.rtbAll.ReadOnly = true;
            this.rtbAll.Size = new System.Drawing.Size(368, 160);
            this.rtbAll.TabIndex = 10;
            this.rtbAll.Text = "";
            // 
            // trmRead
            // 
            this.trmRead.Enabled = true;
            this.trmRead.Interval = 1000;
            this.trmRead.Tick += new System.EventHandler(this.trmRead_Tick);
            // 
            // SericesForm
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 354);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtbSelf);
            this.Controls.Add(this.rtbAll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SericesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SericesForm";
            this.Load += new System.EventHandler(this.SericesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbSelf;
        private System.Windows.Forms.RichTextBox rtbAll;
        private System.Windows.Forms.Timer trmRead;

    }
}