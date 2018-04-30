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
    public partial class DefrayForm : Form
    {
        public DefrayForm()
        {
            InitializeComponent();
        }

        //ok按钮
        private void btnOk_Click(object sender, EventArgs e)
        {
            //验证输入是否为空
            if(!ValidateInput())
            {
                return;
            }

            //验证总和当中是否有这么多金额 
            if(!haveMoney())
            {
                MessageBox.Show("金额小于支出", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AutoId ai = new AutoId();

            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("insert into defray values('{0}','{1}','{2}','{3}','{4}','{5}')",ai.GetId("D_defrayId", "defray"),(0 - Math.Abs(Convert.ToDouble(txtPrice.Text))), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),txtC_type.Text, UserHelper.LoginId,"");
                //MessageBox.Show(sql);
                int rows = db.UpdateDeleteAdd(sql);
                if (rows > 0)
                {
                    MessageBox.Show("支出成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("支出失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        //查询还有多少钱
        private bool haveMoney()
        {
            DBHelper db = null;
           
            db = new DBHelper();
            string sql = string.Format("select * from CashManage");
            SqlDataReader sdr = db.SelectAll(sql);
            double haveMoney = 0;
            if (sdr.Read())
            {
                haveMoney = Convert.ToDouble((sdr["C_sum"]));
            }
            if (haveMoney < Convert.ToDouble(txtPrice.Text))
            {
                return false;
                db.GetClose();
            }
            else
            {
                return true;
                db.GetClose();
            }           
        }

        //验证
        private bool ValidateInput()
        {
            bool isOk = false;
            if(txtPrice.Text=="")
            {
                MessageBox.Show("支出金额不能为空！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (Convert.ToDouble(txtPrice.Text) <= 0)
            {
                MessageBox.Show("支出不能等于或小于0！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtC_type.Text == "")
            {
                MessageBox.Show("支出项目不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
            else
            {
                isOk = true;
            }
            return isOk;
        }

        //控制只能输入小数点回车数字
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        //关闭事件
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DefrayForm_Load(object sender, EventArgs e)
        {

        }       
    }
}