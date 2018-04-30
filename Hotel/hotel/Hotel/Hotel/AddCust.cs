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
    public partial class AddCust : Form
    {
        List<string> listStr = new List<string>();　　//申明list 

        int type = 0;   //判断类型
        public AddCust(int type)
        {
            this.type = type;
            InitializeComponent();
        }

        public void acceptList(List<string> list)
        {
            this.listStr = list;
        }

        private void AddCust_Load(object sender, EventArgs e)
        {
            //加载将传过来的list值 赋给相应的文本框
            cboPaper.Text = "身份证";           
            if(type==1)
            {
                 this.Text = "修改";
                 this.TxtID.Enabled = false;                 
                 this.grbAddCust.Text = "修改";
                 this.btnCustAdd.Text = "保存";

                 this.TxtID.Text = listStr[0];
                 this.Txtname.Text = listStr[1];
                 if (listStr[6] == "男")
                 {
                     rdoMan.Checked = true;
                 }
                 else
                 {
                     rdoWoman.Checked = true;
                 }

                 this.Txtpwd.Text = GetPass(TxtID.Text);
                 txtPassAgain.Text = this.Txtpwd.Text;
                cboPaper.Text=listStr[3];
                TxtpaperID.Text=listStr[4];
                txtAddress.Text=listStr[5];
                TxtcontactTel.Text=listStr[7];
                txtRemark.Text=listStr[8];
            }
        }

        //查询用户名的密码
        private string GetPass(string p)
        {
            string pass = "";
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                
                string sql = string.Format("select Pass from Users where U_UsersId='{0}'", p);

                SqlDataReader sdr = db.SelectAll(sql);

                if (sdr.Read())
                {
                    pass = sdr["Pass"].ToString();
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
            return pass;
        }

        //添加会员
        private void btnCustAdd_Click(object sender, EventArgs e)
        {
            //验证是否为空
            if(ValidateInput())
            {
                //长度必须大于6
                if (Txtpwd.Text.Length < 6)
                {
                    MessageBox.Show("密码长度必须大于六位！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txtpwd.Focus();
                    return;
                }
                else if(Txtpwd.Text!=txtPassAgain.Text)
                {
                    MessageBox.Show("两次密码不一至！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txtpwd.Focus();
                    return;
                }
                //写入方法
                InsertCust();
            }
        }

        //验证是否为空
        private bool ValidateInput()
        {
            bool isOk = true;
            if (TxtID.Text == "")
            {
                TxtID.BackColor = Color.Red;
                TxtID.Focus();
                isOk = false;
            }
            if (Txtname.Text == "")
            {
                Txtname.BackColor = Color.Red;
                Txtname.Focus();
                isOk = false;
            }
            if (Txtpwd.Text == "")
            {
                Txtpwd.BackColor = Color.Red;
                Txtpwd.Focus();
                isOk = false;
            }
            if (txtAddress.Text == "")
            {
                txtAddress.BackColor = Color.Red;
                txtAddress.Focus();
                isOk = false;
            }
            if (TxtpaperID.Text == "")
            {
                TxtpaperID.BackColor = Color.Red;
                TxtpaperID.Focus();
                isOk = false;
            }
            if (TxtcontactTel.Text == "")
            {
                TxtcontactTel.BackColor = Color.Red;
                TxtcontactTel.Focus();
                isOk = false;
            }
           
            return isOk;  //返回结果 
        }

        //写入数据库方法
        private void InsertCust()
        {
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = "";

                string sex;
                if (rdoMan.Checked)
                {
                    sex = "男";
                }
                else
                {
                    sex = "女";
                }

                if (type == 0)
                {

                    sql = string.Format("insert into Users values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                        TxtID.Text, Txtname.Text, Txtpwd.Text, 0, cboPaper.Text, TxtpaperID.Text, txtAddress.Text,sex, TxtcontactTel.Text,0, txtRemark.Text
                        );
                }
                else
                {
                    sql = string.Format("update Users set Uname = '{0}',Pass = '{1}',CertificateType ='{2}',CertificateID = '{3}',Address = '{4}',Usex = '{5}',contactTel= '{6}',remark = '{7}' where U_UsersId='{8}'",
                        Txtname.Text, Txtpwd.Text,  cboPaper.Text, TxtpaperID.Text, txtAddress.Text, sex, TxtcontactTel.Text, txtRemark.Text,TxtID.Text
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
        }

       

        //文本框的值改变时，改变背景颜色 
        private void TxtID_TextChanged(object sender, EventArgs e)
        {
            TxtID.BackColor = Color.White;
        }

        private void Txtname_TextChanged(object sender, EventArgs e)
        {
            Txtname.BackColor = Color.White;
        }

        private void Txtpwd_TextChanged(object sender, EventArgs e)
        {
            Txtpwd.BackColor = Color.White;
        }

        private void txtPassAgain_TextChanged(object sender, EventArgs e)
        {
            txtPassAgain.BackColor = Color.White;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            txtAddress.BackColor = Color.White;
        }

        private void cboPaper_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPaper.BackColor = Color.White;
        }

        private void TxtpaperID_TextChanged(object sender, EventArgs e)
        {
            TxtpaperID.BackColor = Color.White;
        }

        private void TxtcontactTel_TextChanged(object sender, EventArgs e)
        {
            TxtcontactTel.BackColor = Color.White;
        }

        //当移出会员框，判断是否有重名
        private void TxtID_Leave(object sender, EventArgs e)
        {
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select count(*) from users where U_UsersId='{0}'", TxtID.Text);
                if ((int)db.SelectOne(sql) > 0)
                {
                    MessageBox.Show("已有相同的用户名！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtID.Focus();
                    TxtID.SelectAll();
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

        private void CustCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtpaperID_Leave(object sender, EventArgs e)
        {
            if (cboPaper.Text == "身份证")
            {
                if (TxtpaperID.Text.Length != 18 && TxtpaperID.Text.Length != 0 && TxtpaperID.Text.Length != 15)
                {
                    MessageBox.Show("身份证只能是18位或15位！", "温馨", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtpaperID.Focus();
                    TxtpaperID.SelectAll();
                }
            }
        }         
    }
}