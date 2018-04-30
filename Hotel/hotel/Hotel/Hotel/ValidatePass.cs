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
    public partial class ValidatePass : Form
    {
        public string U_UsersId;
        int type;
        public ValidatePass(string U_UsersId,int type)
        {
            this.type = type;
            this.U_UsersId = U_UsersId;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (type == 0)
            {
                ah.txtCust.Text = "";
                ah.txtAdvanceForegift.Enabled = true;
            }
            else if(type==1)
            {
                ga.txtCust.Text = "";
                ga.txtAdvanceForegift.Enabled = true;
            }
            
            
            this.Close();
        }

        private void ValidatePass_Load(object sender, EventArgs e)
        {
            this.txtU_UsersId.Text = U_UsersId;
        }

        private void ValidatePass_Shown(object sender, EventArgs e)
        {
            txtPass.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DBHelper db = null;
            db = new DBHelper();
            string sql = string.Format("select count(*) from Users where U_UsersId='{0}' and Pass ='{1}'",txtU_UsersId.Text,txtPass.Text);
            int count = (int) db.SelectOne(sql);
            if (count > 0)
            {
                
                sql = string.Format("select * from Users where U_UsersId='{0}'", txtU_UsersId.Text);
                SqlDataReader sdr = db.SelectAll(sql);
                if(sdr.Read())
                {
                    if (type == 0)
                    {
                        ah.txtName.Text = sdr["Uname"].ToString();
                        if (sdr["Usex"].ToString() == "男")
                        {
                            ah.rdoMan.Checked = true;
                        }
                        ah.cboCertificate.Text = sdr["CertificateType"].ToString();
                        ah.txtCertificateId.Text = sdr["CertificateID"].ToString();
                        ah.txtContactTel.Text = sdr["contactTel"].ToString();
                        ah.txtAddress.Text = sdr["Address"].ToString();
                        ah.txtAdvanceForegift.Text = "0";
                        ah.txtAdvanceForegift.Enabled = false;
                    }
                    else
                    {
                        ga.txtName.Text = sdr["Uname"].ToString();
                        if(sdr["Usex"].ToString()=="男")
                        {
                            ga.rdoMan.Checked = true;
                        }
                        ga.cboCertificate.Text = sdr["CertificateType"].ToString();
                        ga.txtCertificateId.Text = sdr["CertificateID"].ToString();
                        ga.txtContactTel.Text = sdr["contactTel"].ToString();
                        ga.txtAddress.Text = sdr["Address"].ToString();
                        ga.txtAdvanceForegift.Text = "0";
                        ga.txtAdvanceForegift.Enabled = false;
                    }
                }


                UserHelper.isValidate = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("密码错误！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtPass.SelectAll();
            }
        }

        public AddHouse ah = null;
        public void incept(AddHouse ah2)
        {
            ah = ah2;
        }


        public GroupAddHouseForm ga = null;


        public void GroupIncept(GroupAddHouseForm ga2)
        {
            this.ga = ga2;
        }
    }
}