using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel
{
    public partial class FeedbackForm : Form
    {
        string userId;
        
        //传入用户名
        public FeedbackForm(string userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        //提交
        private void btnRefer_Click(object sender, EventArgs e)
        {
            Feedback();
            if(rtbContent.Text!="")
            {
                MessageBox.Show("您的宝贵建议是对我们的支持！","提交成功",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }           
        }

        //插入方法
        private void Feedback()
        {
            AutoId ai = new AutoId();
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("insert into LeaveWord values('{0}','{1}','{2}','{3}','{4}')",
                    ai.GetId("L_LeaveWordId", "LeaveWord"), txtName.Text, rtbContent.Text, "", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                int rows = db.UpdateDeleteAdd(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.GetClose();
            }
        }

        //加载事件
        private void FeedbackForm_Load(object sender, EventArgs e)
        {
            this.txtName.Text = userId;
        }

        //取消按钮
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //历史记录
        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm hf = new HistoryForm();
            hf.ShowDialog();
        }
    }
}