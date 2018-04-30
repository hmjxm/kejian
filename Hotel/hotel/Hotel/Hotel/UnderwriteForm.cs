using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel
{
    public partial class UnderwriteForm : Form
    {
        int type;
        public List<string> listStr = new List<string>();
        public UnderwriteForm(int type)
        {
            this.type = type;
            InitializeComponent();
        }

        private void UnderwriteForm_Load(object sender, EventArgs e)
        {
            if (type == 0)
            {

            }
            else
            {
                this.btnAdd.Text = "保存";
                this.grbAddUnderwrite.Text = "修改";
                chkBatch.Visible = false;

                txtUnderwrite.Text = listStr[1];
                txtRemark.Text = listStr[2];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(ValidateInput())
            {
                Underwrite();
            }
        }

        private void Underwrite()
        {
            AutoId ai = new AutoId ();
            DBHelper db = null;
            string sql;
            try
            {
                db = new DBHelper();
                if (type == 0)
                {
                    sql = string.Format("insert into Underwrite values('{0}','{1}','{2}')",
                         ai.GetId("U_Id", "Underwrite"), txtUnderwrite.Text, txtRemark.Text);
                }
                else
                {
                    sql = string.Format("update Underwrite set Underwrite='{0}',Remark='{1}' where U_Id='{2}'", txtUnderwrite.Text, txtRemark.Text, listStr[0]);
                }
                if (db.UpdateDeleteAdd(sql) > 0)
                {
                    if (chkBatch.Checked)
                    {
                        txtUnderwrite.Text = "";
                        txtRemark.Text = "";
                        txtUnderwrite.Focus();
                    }
                    else
                    {
                        MessageBox.Show("操作成功!", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("添操作失败!", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private bool ValidateInput()
        {
            bool isOk = true;
            if(txtUnderwrite.Text=="")
            {
                txtUnderwrite.BackColor = Color.Red;
                txtUnderwrite.Focus();
                isOk = false;
            }           
            return isOk;
        }

        private void txtUnderwrite_TextChanged(object sender, EventArgs e)
        {
            txtUnderwrite.BackColor = Color.White;
        }

        private void txtUnderwrite_Leave(object sender, EventArgs e)
        {
            if(type==0)
            {
                DBHelper db = null;
                db = new DBHelper();
                string sql = string.Format("select count(*) from Underwrite where Underwrite='{0}'", txtUnderwrite.Text);
                if((int)db.SelectOne(sql)>0)
                {
                    MessageBox.Show("已存在相同的名字!","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtUnderwrite.Focus();
                    txtUnderwrite.SelectAll();
                }
            }           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}