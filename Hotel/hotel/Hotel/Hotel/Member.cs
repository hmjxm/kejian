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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCust add = new AddCust(0);
            add.Show();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            ShowCustInfo("");
        }

        private void ShowCustInfo(string type)
        {
            SearchCust(type);
        }

        private void SearchCust(string type)
        {
            lvCust.Items.Clear();
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql;
                if (type == "")
                {
                    sql = string.Format("select * from Users");
                }
                else
                {
                    sql = string.Format("select * from Users where U_UsersId like '%{0}%'", type);
                }
                
                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    ListViewItem lviCust = new ListViewItem(sdr["U_UsersId"].ToString());
                    string[] str ={ sdr["Uname"].ToString(), sdr["Score"].ToString(), sdr["U_money"].ToString(), sdr["CertificateType"].ToString(), sdr["CertificateID"].ToString(), sdr["Address"].ToString(), sdr["Usex"].ToString(), sdr["contactTel"].ToString(), sdr["remark"].ToString() };
                    lviCust.SubItems.AddRange(str);
                    lvCust.Items.Add(lviCust);
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            ShowCustInfo(txtU_UsersId.Text);
        }

        private void btnUpater_Click(object sender, EventArgs e)
        {
            if(lvCust.SelectedItems.Count<=0)
            {
                return;
            }
            List<string> listStr = new List<string>();

            for (int i = 0; i < lvCust.SelectedItems[0].SubItems.Count;i++ )
            {
                listStr.Add(lvCust.SelectedItems[0].SubItems[i].Text);
            }
            AddCust ac = new AddCust(1);
            ac.acceptList(listStr);
            ac.ShowDialog();
        }

        private void Member_Activated(object sender, EventArgs e)
        {
            ShowCustInfo("");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lvCust.SelectedItems.Count<=0)
            {
                return;
            }
            string CustId = lvCust.SelectedItems[0].SubItems[0].Text;
            DialogResult result = MessageBox.Show("真的删除？","删除提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            
            if(result==DialogResult.Yes)
            {
                DBHelper db = null;
                db = new DBHelper();
                try
                {
                    string sql = string.Format("delete Users where U_UsersId ='{0}'", CustId);
                    if (db.UpdateDeleteAdd(sql)>0)
                    {
                        MessageBox.Show("删除成功！", "删除提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("删除失败！", "删除提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtU_UsersId_TextChanged(object sender, EventArgs e)
        {
            ShowCustInfo(txtU_UsersId.Text);
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnPlusMoney_Click(object sender, EventArgs e)
        {
            if (lvCust.SelectedItems.Count <= 0)
            {
                return;
            }

            string CustId = lvCust.SelectedItems[0].SubItems[0].Text;

            PlusForm pf = new PlusForm(CustId);
            pf.ShowDialog();
        }            
    }
}