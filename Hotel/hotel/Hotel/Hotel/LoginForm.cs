using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Hotel
{
    public partial class LoginForm : Form
    {
        string A_AdminId;
        string Password;
        
        //传入用户名和密码
        public LoginForm( string A_AdminId,string Password)
        {
            this.A_AdminId = A_AdminId;
            this.Password = Password;
            InitializeComponent();
        }

        //登录按钮
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //验证是否为空
            if (ValidateInput())
            {
                ValidateRight();
            }            
        }

        //验证是否为空
        private bool ValidateInput()
        {
            bool isok = true;           
            if(txtLoginPwd.Text=="")
            {
                txtLoginPwd.BackColor = Color.Red;
                txtLoginPwd.Focus();
                isok = false;
            }
            if (txtLoginId.Text == "")
            {
                txtLoginId.BackColor = Color.Red;
                txtLoginId.Focus();
                isok = false;
            }
            return isok;
        }

        //验证是否正确
        private void ValidateRight()
        {  

            DBHelper db = null;
            string sql = "";
            try
            {
                int count=0;
                db = new DBHelper();
                if (cboLoginType.Text == "管理员")
                {
                    sql = string.Format("select Password from Admin where A_AdminId='{0}' and A_Type ='{1}'", txtLoginId.Text.Trim(), "管理员");
                }
                else if (cboLoginType.Text == "服务员")
                {
                    sql = string.Format("select Password from Admin where A_AdminId='{0}' and A_Type ='{1}'", txtLoginId.Text.Trim(), "服务员");
                }
                else
                {
                    sql = string.Format("select count(*) from Users where U_UsersId='{0}' and Pass='{1}'", txtLoginId.Text.Trim(), txtLoginPwd.Text);
                    count = (int)db.SelectOne(sql);
                }               
                
                SqlDataReader sdr = db.SelectAll(sql);

                string tempPass = "";
                if(sdr.Read())
                {
                    tempPass = sdr["Password"].ToString();
                }
                if (tempPass == txtLoginPwd.Text)
                {
                    count = 1;
                }
               
                if (count > 0)
                {                    
                    this.Hide();
                    if (cboLoginType.Text == "客户")
                    {
                        UserHelper.UserId = txtLoginId.Text.Trim();
                        
                        ClientForm cf = new ClientForm(txtLoginId.Text);
                        cf.Show();
                    }
                    else
                    {
                        UserHelper.LoginId = txtLoginId.Text.Trim();
                        UserHelper.LoginType = cboLoginType.Text;
                        AnnalLog();
                        MainForm mf = new MainForm();
                        mf.Show();
                    }         
                }
                else
                {
                    MessageBox.Show("用户名或密码错误!", "登录提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //ClientForm cf = new ClientForm();
                //cf.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //db.GetClose();
            }
        }

        //记录日志
        private void AnnalLog()
        {
            AutoId ai = new AutoId();
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string L_LoginLogId = ai.GetId("L_LoginLogId", "LoginLog");
                UserHelper.L_LoginLogId = L_LoginLogId;
                string sql = string.Format("insert into LoginLog (L_LoginLogId,L_AdminId,LoginDate) values('{0}','{1}','{2}')",
                    L_LoginLogId, txtLoginId.Text.Trim(), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    );
                db.UpdateDeleteAdd(sql);
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

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtLoginId.Text = A_AdminId;
            txtLoginPwd.Text = Password;

            if (!IsProgram())
            {
                MessageBox.Show("您已经启动程序！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            IsAwoke.isAwork();
            cboLoginType.Text = "管理员";

        }

        //判断内存中是否有hotel程序 如果有则提示，只能启动一个应用程序
        private bool IsProgram()
        {            
            int count=0;
            Process[] MyProcess = Process.GetProcesses();
            foreach(Process p in MyProcess)
            {                
                if(p.ProcessName=="Hotel")
                {
                    count++;                    
                    //break;
                }
            }
            if (count > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //内容改变 改变文杠框背景颜色
        private void txtLoginId_TextChanged(object sender, EventArgs e)
        {
            txtLoginId.BackColor = Color.White;
        }

        //内容改变 改变文杠框背景颜色
        private void txtLoginPwd_TextChanged(object sender, EventArgs e)
        {
            txtLoginPwd.BackColor = Color.White;
        }

        //第一次加载 光标移入用户名
        private void LoginForm_Shown(object sender, EventArgs e)
        {
            txtLoginId.Focus();
        }

        //控制不能输入单引号！！！
        private void txtLoginId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 39)
            {
                MessageBox.Show("难道你输入的是单引号?", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }       
    }
}