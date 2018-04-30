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
    public partial class UpdatePriceForm : Form
    {
        public UpdatePriceForm()
        {
            InitializeComponent();
        }
        

        private void txtbd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //8为空格，13为回车，IsDigit为十进数
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }            
        }

        private void txtbs_KeyPress(object sender, KeyPressEventArgs e)
        {
            //8为空格，13为回车，IsDigit为十进数
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }            
        }

        private void txthd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //8为空格，13为回车，IsDigit为十进数
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }            
        }

        private void txths_KeyPress(object sender, KeyPressEventArgs e)
        {
            //8为空格，13为回车，IsDigit为十进数
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }            
        }

        private void txtsw_KeyPress(object sender, KeyPressEventArgs e)
        {
            //8为空格，13为回车，IsDigit为十进数
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }            
        }

        private void txtzt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //8为空格，13为回车，IsDigit为十进数
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }            
        }

        private void txthyt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //8为空格，13为回车，IsDigit为十进数
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(ValidateInput())
            {
                UpdatePrice();
            }            
        }

        private bool ValidateInput()
        {
            bool isOk = true;
            if (txtbd.Text=="")
            {
                txtbd.BackColor = Color.Red;
                txtbd.Focus();
                isOk = false;
            }
            if (txtbs.Text == "")
            {
                txtbs.BackColor = Color.Red;
                txtbs.Focus();
                isOk = false;
            }
            if (txthd.Text == "")
            {
                txthd.BackColor = Color.Red;
                txthd.Focus();
                isOk = false;
            }
            if (txths.Text == "")
            {
                txths.BackColor = Color.Red;
                txths.Focus();
                isOk = false;
            }
            if (txtsw.Text == "")
            {
                txtsw.BackColor = Color.Red;
                txtsw.Focus();
                isOk = false;
            }
            if (txtzt.Text == "")
            {
                txtzt.BackColor = Color.Red;
                txtzt.Focus();
                isOk = false;
            }
            if (txthyt.Text == "")
            {
                txthyt.BackColor = Color.Red;
                txthyt.Focus();
                isOk = false;
            }
            return isOk;
        }

        private void UpdatePrice()
        {
            DBHelper db = null;
            try
            {
                List<string> listStr = new List<string>();
                listStr.Add(txtbd.Text);
                listStr.Add(txtbs.Text);
                listStr.Add(txthd.Text);
                listStr.Add(txths.Text);
                listStr.Add(txtsw.Text);
                listStr.Add(txtzt.Text);
                listStr.Add(txthyt.Text);
                db = new DBHelper();
                int rows = 0;
                string sql;
                for (int i = 1; i < 8; i++)
                {
                    sql = string.Format("update Room set price='{0}' where RoomType='{1}'", listStr[i-1], i);
                    rows = db.UpdateDeleteAdd(sql);
                }
                if (rows > 0)
                {
                    MessageBox.Show("修改成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {

                    MessageBox.Show("修改失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdatePriceForm_Load(object sender, EventArgs e)
        {
            ShowPrice();
        }

        private void ShowPrice()
        {
            List<string> listStr = new List<string>();
            DBHelper db = null;
            string price = "";
            string sql;
            for (int i = 1; i < 8;i++ )
            {
                sql = string.Format("select price from Room where RoomType='{0}'",i);
                db = new DBHelper();
                SqlDataReader sdr=db.SelectAll(sql);
                if (sdr.Read())
                {
                    price = sdr["price"].ToString();
                }
                else
                {
                    price = "0.0";
                }
                listStr.Add(price);
            }

            txtbd.Text = listStr[0];
            txtbs.Text= listStr[1];
            txthd.Text= listStr[2];
            txths.Text= listStr[3];
            txtsw.Text= listStr[4];
            txtzt.Text= listStr[5];
            txthyt.Text = listStr[6];
        }       
    }
}