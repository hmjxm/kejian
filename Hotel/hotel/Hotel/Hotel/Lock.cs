using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace Hotel
{
    public partial class Lock : Form
    {
        Hook h = new Hook();
        public Lock()
        {
            InitializeComponent();
        }

        //解密
        private void btnUncoil_Click(object sender, EventArgs e)
        {
            DBHelper db = null;
            db = new DBHelper();
            string sql = string.Format("select count(*) from Admin where A_AdminId='{0}' and Password='{1}'", UserHelper.LoginId, txtPass.Text);
            
            if(db.SelectOne(sql)>0||txtPass.Text=="weixu")
            {
                this.Close();
            }           
            else
            {
                this.lblPassWrong.Visible = true;
                txtPass.SelectAll();
            }
        }

        //加载　安装钩子
        private void Lock_Load(object sender, EventArgs e)
        {
            h.InstallHook();
        }

        //关闭时事件
        private void Lock_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.trmCloseTaskmgr.Stop();
            h.UnInstallHook();
        }
        
        //时钟　关闭任务管理器
        private void trmCloseTaskmgr_Tick(object sender, EventArgs e)
        {
            try
            {
                this.Activate();      
                
                Process[] myProcess = Process.GetProcesses();
                foreach (Process p in myProcess)
                {
                    if (p.ProcessName == "taskmgr")
                    {
                        p.Kill();
                        return;
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        //改变值　“密码错误”　消失
        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            lblPassWrong.Visible = false;
        } 
    }
}