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
    public partial class PlusForm : Form
    {
        string cust;
        public PlusForm(string custId)
        {
            this.cust = custId;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(ValidateInput())
            {
                if(!IsRight())
                {
                    MessageBox.Show("密码错误！","温馨提示！",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtPass.Focus();
                    txtPass.SelectAll();
                    return;
                }
                DBHelper db = null;
                try
                {
                    db = new DBHelper();
                    string sql = string.Format("update Users set U_money = U_money + '{0}' where U_UsersId = '{1}'", txtMoney.Text, txtU_UsersId.Text);
                    if (db.UpdateDeleteAdd(sql) > 0)
                    {
                        MessageBox.Show("充值成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("充值失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private bool IsRight()
        {
            DBHelper db = null;
            db = new DBHelper();
            string sql = string.Format("select count(*) from Users where U_UsersId = '{0}' and Pass = '{1}'", txtU_UsersId.Text, txtPass.Text);
            if ((int)db.SelectOne(sql) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateInput()
        {
            bool isOk = true;
            if(txtU_UsersId.Text=="")
            {
                txtU_UsersId.BackColor = Color.Red;
                txtU_UsersId.Focus();
                isOk = false;
            }
            if(txtPass.Text=="")
            {
                txtPass.BackColor = Color.Red;
                txtPass.Focus();
                isOk = false;
            }
            if(txtMoney.Text=="")
            {
                txtMoney.BackColor = Color.Red;
                txtMoney.Focus();
                isOk = false;
            }           

            return isOk;
        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void PlusForm_Load(object sender, EventArgs e)
        {
            this.txtU_UsersId.Text = cust;
            this.txtU_UsersId.Enabled = false;
        }
    }
}