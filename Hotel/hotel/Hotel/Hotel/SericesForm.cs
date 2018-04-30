using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//download by http://www.codefans.net
namespace Hotel
{
    public partial class SericesForm : Form
    {
        string U_UsersId;
        public SericesForm(string Roomid)
        {
            this.U_UsersId = Roomid;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SericesForm_Load(object sender, EventArgs e)
        {
            this.Text = U_UsersId;
        }

        private void trmRead_Tick(object sender, EventArgs e)
        {
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from Service where U_UsersId='{0}' and State='{1}' and toId='{2}'", U_UsersId, "未读",UserHelper.LoginId);
                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    rtbAll.Text = rtbAll.Text + "\n" + sdr["U_UsersId"].ToString() + "  " + sdr["Date"].ToString() + "\n" + sdr["S_content"].ToString();
                    sql = string.Format("update Service set State='{1}' where U_UsersId ='{0}' and toId='{2}'",  U_UsersId,"已读",UserHelper.LoginId);
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

        private void btnSend_Click(object sender, EventArgs e)
        { 
            DBHelper db = null;
            try
            {
                AutoId ai = new AutoId();
                rtbAll.Text = rtbAll.Text +"\n" + UserHelper.LoginId + "  " + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "\n" + rtbSelf.Text;

                db = new DBHelper();
                string sql = string.Format("insert into Service values('{0}','{1}','{2}','{3}','{4}','{5}')",
                    ai.GetId("S_serviceId", "Service"), U_UsersId, UserHelper.LoginId, rtbSelf.Text, "未读", DateTime.Now.ToString("yyyy-MM-dd HH:mm")
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
    }
}