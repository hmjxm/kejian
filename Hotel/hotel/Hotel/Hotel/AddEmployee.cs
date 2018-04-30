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
    public partial class AddEmployee : Form
    {
        string type;　　//判断类型，是添加操作还是修改操作
        public AddEmployee(string type)
        {
            this.type = type;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //验证
            if(ValidateInput())
            {
                //添加房子
                AddHouse();
                InsertPurview();
            }
        }


        private void InsertPurview()
        {
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("insert into purview values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}')"
                    ,txtA_AdminId.Text , 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1
                    );
                int rows = db.UpdateDeleteAdd(sql);
                MessageBox.Show(rows.ToString());
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

        //验证是否为空
        private bool ValidateInput()
        {
            bool isOk = true;
            if(txtA_AdminId.Text=="")
            {
                txtA_AdminId.BackColor = Color.Red;
                txtA_AdminId.Focus();
                isOk = false;
            }
            if (txtName.Text == "")
            {
                txtName.BackColor = Color.Red;
                txtName.Focus();
                isOk = false;
            }
            if (txtPass.Text == "")
            {
                txtPass.BackColor = Color.Red;
                txtPass.Focus();
                isOk = false;
            }
            if (cboType.Text == "")
            {
                cboType.BackColor = Color.Red;
                cboType.Focus();
                isOk = false;
            }
            if (txtPass.Text != txtPassAgain.Text)
            {
                txtPassAgain.BackColor = Color.Red;
                txtPassAgain.Focus();
                isOk = false;
            }
            return isOk;

        }

        //添加方法
        private void AddHouse()
        {
            DBHelper db = null;
            string sql = "";
            try
            {
                db = new DBHelper();

                //根据传值，来判断是插入操作，还是修改操作
                if (type == "")
                {
                    sql = string.Format("insert into Admin values('{0}','{1}','{2}','{3}')",
                     txtA_AdminId.Text, txtName.Text, txtPass.Text, cboType.Text
                    );
                }
                else
                {
                    sql = string.Format("update Admin set A_AdminId='{0}',A_Name='{1}',Password='{2}',A_Type='{3}' where A_AdminId='{4}'",
                      txtA_AdminId.Text, txtName.Text, txtPass.Text, cboType.Text,type
                       );
                }



                if (db.UpdateDeleteAdd(sql) > 0)
                {
                    MessageBox.Show("操作成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("操作失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //文本框的值改变时，改变背景颜色 
        private void txtA_AdminId_TextChanged(object sender, EventArgs e)
        {
            txtA_AdminId.BackColor = Color.White;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.White;
        }

        private void txtPassAgain_TextChanged(object sender, EventArgs e)
        {
            txtPassAgain.BackColor = Color.White;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboType.BackColor = Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //加载事件
        private void AddEmployee_Load(object sender, EventArgs e)
        {       
            //根据传值，还判断是添加还是修改操作
            if(type!="")
            {
                btnAdd.Text = "保存";
                this.Text = "修改";
                DBHelper db = null;
                try
                {
                    db = new DBHelper();
                    string sql = string.Format("select * from Admin where A_AdminId='{0}'", type);
                    SqlDataReader sdr = db.SelectAll(sql);
                    if (sdr.Read())
                    {
                        txtA_AdminId.Text = type;                       
                        txtName.Text = sdr["A_Name"].ToString();
                        txtPass.Text = sdr["Password"].ToString();
                        cboType.Text = sdr["A_Type"].ToString();
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
        }

        private void txtA_AdminId_Leave(object sender, EventArgs e)
        {
            if (type != "")
            {
                return;
            }
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select count(*) from Admin where A_AdminId = '{0}'", txtA_AdminId.Text);
                if ((int)db.SelectOne(sql) > 0)
                {
                    MessageBox.Show("已有相同的用户名！", "温馨提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtA_AdminId.Focus();
                    txtA_AdminId.SelectAll();
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

        private void grbAddEmp_Enter(object sender, EventArgs e)
        {

        }

        private void lblPassAgain_Click(object sender, EventArgs e)
        {

        }

        private void lblprice_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void lblA_AdminId_Click(object sender, EventArgs e)
        {

        }
    }
}