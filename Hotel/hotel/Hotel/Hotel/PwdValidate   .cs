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
    public partial class PwdValidate : Form
    {
        TextBox txtname = null;
        TextBox txtCertificateId = null;
        TextBox txtContactTel = null;
        TextBox txtAddress = null;
        TextBox txtRemark = null;
        RadioButton man = null;
        RadioButton wun = null;
        ComboBox cboCertificate = null;
        TextBox userid = null;
        TextBox txtAdvanceForegift = null;
        public PwdValidate()
        {
            InitializeComponent();
        }
        string id;
        public void fgetcid(string idone) 
        {
            //获取从别窗体传过来的值
            id = idone;
        }
        private void PwdValidate_Load(object sender, EventArgs e)
        {
            //讲获取来的值赋给控件
            txtid.Text = id;
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            //验证帐号密码是否正确
            string pwd = txtpwd.Text;
            string sql = string.Format("select count(*) from users where U_UsersId='{0}' and Pass='{1}'", id, pwd);
            DBHelper dx = new DBHelper();
            double count = dx.SelectOne(sql);

            //关闭数据库
            dx.GetClose();
            if (count > 0)
            {
                //查询用户的信息
                string sqlone = string.Format("select * from users where U_UsersId='{0}' and Pass='{1}'", id, pwd);
                DBHelper du = new DBHelper();
                SqlDataReader di = du.SelectAll(sqlone);
                //改变传进来的控件的值
                if (di.Read())
                {
                   string name = di["Uname"].ToString();
                   string sex = di["Usex"].ToString();
                   string CertificateType = di["CertificateType"].ToString();
                   string CertificateID = di["CertificateID"].ToString();
                   string contactTel = di["contactTel"].ToString();
                   string remark = di["remark"].ToString();
                   string Address = di["Address"].ToString();
                   txtname.Text = name;
                   txtCertificateId.Text = CertificateID;
                   txtContactTel.Text = contactTel;
                   txtAddress.Text = Address;
                   txtRemark.Text = Address;
                    if (sex == "男")
                    {
                        man.Checked = true;
                    }
                    else 
                    {
                        wun.Checked = true;
                    }
                    cboCertificate.Text = CertificateType;
                    
                }
            }
            else
            {
                MessageBox.Show("密码不正确~！");
                return;
            }

            //关闭数据库
            this.Close();
        }
        //接受传进来的控件并将它赋给声明的控件
        public void frm(TextBox TxtAdvanceForegift, TextBox Userid,TextBox TxtName, TextBox TxtCertificateId, TextBox TxtContactTel, TextBox TxtAddress, TextBox TxtRemark, RadioButton Man, RadioButton Wun, ComboBox CboCertificate)
        {
            txtAdvanceForegift = TxtAdvanceForegift;
            userid = Userid;
            txtname = TxtName;
            txtCertificateId = TxtCertificateId;
            txtContactTel = TxtContactTel;
            txtAddress = TxtAddress;
            txtRemark = TxtRemark;
            man = Man;
            wun = Wun;
            cboCertificate = CboCertificate;
        
        }

        private void txtpwd_KeyDown(object sender, KeyEventArgs e)
        {
            //设置按回车键的事件
            if (e.KeyCode == Keys.Enter)
            {
                //验证帐号密码是否正确
                string pwd = txtpwd.Text;
                string sql = string.Format("select count(*) from users where U_UsersId='{0}' and Pass='{1}'", id, pwd);
                DBHelper dx = new DBHelper();
                double count = dx.SelectOne(sql);

                //关闭数据库
                dx.GetClose();
                if (count > 0)
                {
                    string sqlone = string.Format("select * from users where U_UsersId='{0}' and Pass='{1}'", id, pwd);
                    DBHelper du = new DBHelper();
                    SqlDataReader di = du.SelectAll(sqlone);
                    //将传进来的控件赋值
                    if (di.Read())
                    {
                        string name = di["Uname"].ToString();
                        string sex = di["Usex"].ToString();
                        string CertificateType = di["CertificateType"].ToString();
                        string CertificateID = di["CertificateID"].ToString();
                        string contactTel = di["contactTel"].ToString();
                        string remark = di["remark"].ToString();
                        string Address = di["Address"].ToString();
                        txtname.Text = name;
                        txtCertificateId.Text = CertificateID;
                        txtContactTel.Text = contactTel;
                        txtAddress.Text = Address;
                        txtRemark.Text = Address;
                        if (sex == "男")
                        {
                            man.Checked = true;
                        }
                        else
                        {
                            wun.Checked = true;
                        }
                        cboCertificate.Text = CertificateType;
                    }

                    //关闭数据库
                    du.GetClose();
                }
                else
                {
                    MessageBox.Show("密码不正确~！");
                    return;
                }

                //关闭窗口
                this.Close();
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            //设置传进来的控件为空
            userid.Text = "";

            //关闭窗口
            this.Close();
        }
    }
}