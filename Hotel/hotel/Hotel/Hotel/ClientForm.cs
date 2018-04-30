using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel
{
    public partial class ClientForm : Form
    {
        string Users;　　//传进来的用户名

        public ClientForm(string Users)
        {
            this.Users = Users;
            InitializeComponent();
        }

        //反馈信息
        private void tsmiFeedback_Click(object sender, EventArgs e)
        {
            FeedbackForm fbf = new FeedbackForm(Users);
            fbf.ShowDialog();
        }

        //close
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //菜单
        private void btnMenu_Click(object sender, EventArgs e)
        {
            AddConsume mf = new AddConsume(Users);
            mf.ShowDialog();
        }

        //显示我的消费

        private void tsmiMyConsume_Click(object sender, EventArgs e)
        {
            ConsumeForm cf = new ConsumeForm();
            cf.ShowDialog();
        }

        //修改个人资料
        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            List<string> listStr = new List<string>();

            DBHelper db = null;
            db = new DBHelper();
            string sql = string.Format("select * from Users where U_UsersId='{0}'", Users);
            SqlDataReader sdr = db.SelectAll(sql);
            if(sdr.Read())
            {
                for(int i=0;i<10;i++)
                {
                    listStr.Add(sdr[i].ToString());
                }                
            }

            AddCust ac = new AddCust(1);
            ac.acceptList(listStr);
            ac.ShowDialog();
        }

        //加载事件
        private void ClientForm_Load(object sender, EventArgs e)
        {
            this.Text = this.Users;
        }

        //发送按钮
        private void btnSend_Click(object sender, EventArgs e)
        {
            DBHelper db = null;
            try
            {
                AutoId ai = new AutoId();
                rtbAll.Text = rtbAll.Text +"\n"+ UserHelper.UserId + "  " + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "\n" + rtbSelf.Text;

                db = new DBHelper();
                string sql = string.Format("insert into Service values('{0}','{1}','{2}','{3}','{4}','{5}')",
                    ai.GetId("S_serviceId", "Service"), UserHelper.LoginId, Users, rtbSelf.Text, "未读", DateTime.Now.ToString("yyyy-MM-dd HH:mm")
                    );
                //MessageBox.Show(sql);
                if (db.UpdateDeleteAdd(sql) <= 0)
                {
                    MessageBox.Show("发送失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    rtbSelf.Text = "";
                }
                rtbSelf.Focus();
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

        //关闭事件
        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //时钟事件
        private void trmRead_Tick(object sender, EventArgs e)
        {
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from Service where toId='{2}' and State='{1}' and U_UsersId='{0}' ", UserHelper.LoginId, "未读", Users);
                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    rtbAll.Text = rtbAll.Text + "\n" + sdr["U_UsersId"].ToString() + "  " + sdr["Date"].ToString() + "\n" + sdr["S_content"].ToString()+"\n";
                    sql = string.Format("update Service set State='{1}' where toId='{2}' and U_UsersId='{0}' ",UserHelper.LoginId, "已读" ,Users);
                    db = new DBHelper();
                    db.UpdateDeleteAdd(sql);
                }
                sdr.Close();
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

        /// <summary>
        /// 积分查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiScore_Click(object sender, EventArgs e)
        {
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from Users where U_UsersId='{0}'", Users);
                SqlDataReader sdr = db.SelectAll(sql);
                double money=0;
                if(sdr.Read())
                {
                    money = Convert.ToDouble(sdr["U_money"]); 
                }
                MessageBox.Show("你的余额是" + money, "我的余额", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}