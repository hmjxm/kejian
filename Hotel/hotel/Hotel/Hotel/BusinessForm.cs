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
    public partial class BusinessForm : Form
    {
        public BusinessForm()
        {
            InitializeComponent();
        }
       
        //添加按钮
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddWareForm awf = new AddWareForm(0);
            awf.ShowDialog();
        }

        //加载事件
        private void BusinessForm_Load(object sender, EventArgs e)
        {
            ShowWareInfo();
            ShowWareType();
        }

        //显示商品
        private void ShowWareType()
        {
            cboType.Items.Clear();
            string WareType;
            DBHelper db = null;
            try
            {
                cboType.Items.Add("全部");
                db = new DBHelper();
                string sql = string.Format("select WareTypeName from WareType");
                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    WareType = sdr["WareTypeName"].ToString();
                    cboType.Items.Add(WareType);
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

        //显示商品
        private void ShowWareInfo()
        {
            lvWare.Items.Clear();
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from Ware");

                SqlDataReader sdr = db.SelectAll(sql);

                while (sdr.Read())
                {
                    
                    ListViewItem lviWare = new ListViewItem(sdr["WareName"].ToString());
                    if (Convert.ToInt32(sdr["WareCount"]) < 10)
                    {
                        lviWare.BackColor = Color.Red;
                        lviWare.ForeColor = Color.White;
                    }
                    string[] str ={ sdr["WareComePrice"].ToString(), sdr["WareGoPrice"].ToString(), sdr["WareType"].ToString(), sdr["WareCount"].ToString(), sdr["WareUnit"].ToString(), sdr["WareEasyName"].ToString(), sdr["Date"].ToString(), sdr["authorized"].ToString() };
                    lviWare.SubItems.AddRange(str);
                    lvWare.Items.Add(lviWare);
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

        //当窗体激活时
        private void BusinessForm_Activated(object sender, EventArgs e)
        {
            ShowWareInfo();
        }

        //删除按钮
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string WareName;
            if (lvWare.SelectedItems.Count <= 0)
            {
                return;
            }
            WareName = lvWare.SelectedItems[0].SubItems[0].Text;
            DialogResult result = MessageBox.Show("是否删除?", "删除提示！", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DBHelper db = null;
                db = new DBHelper();
                string sql = string.Format("delete Ware where WareName='{0}'", WareName);
                int rows = db.UpdateDeleteAdd(sql);
                if (rows > 0)
                {
                    MessageBox.Show("删除成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("删除失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
       

       
        //根据名字查询
        private void btnNameSelect_Click(object sender, EventArgs e)
        {
            lvWare.Items.Clear();
            string Name = txtName.Text.Trim();

            DBHelper db = null;

            string sql;
            if (Name == "")
            {
                sql = string.Format("select * from Ware");
            }
            else
            {
                sql = string.Format("select * from Ware where WareName like '%{0}%'",Name);
            }
            db = new DBHelper();

            SqlDataReader sdr = db.SelectAll(sql);

            while (sdr.Read())
            {
                ListViewItem lviWare = new ListViewItem(sdr["WareName"].ToString());
                string[] str ={ sdr["WareComePrice"].ToString(), sdr["WareGoPrice"].ToString(), sdr["WareType"].ToString(), sdr["WareCount"].ToString(), sdr["WareUnit"].ToString(), sdr["WareEasyName"].ToString(), sdr["Date"].ToString(), sdr["authorized"].ToString() };
                lviWare.SubItems.AddRange(str);
                lvWare.Items.Add(lviWare);
            }
            txtName.Text = "";
            sdr.Close();
            db.GetClose();
        }

       
        //修改按钮
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvWare.SelectedItems.Count <= 0)
            {
                return;
            }
            int temp = lvWare.SelectedItems[0].SubItems.Count;
            
            List<string> liststr = new List<string>();
            //将选中的信息循环添加到list中集合中
            for (int i = 0; i < temp; i++)
            {
                liststr.Add(lvWare.SelectedItems[0].SubItems[i].Text);
            }

            AddWareForm awf = new AddWareForm(1);
            awf.accept(liststr);
            awf.ShowDialog();
        }

        //根据类型查询
        private void cbType_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            DBHelper db = null;
            try
            {
                lvWare.Items.Clear();
                string WareType = cboType.Text.Trim();
                db = new DBHelper();
                string sql;
                if (WareType == "全部")
                {
                    sql = string.Format("select * from Ware");
                }
                else
                {
                    sql = string.Format("select * from Ware where WareType like '{0}'", WareType);
                }


                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    ListViewItem lviWare = new ListViewItem(sdr["WareName"].ToString());
                    string[] str ={ sdr["WareComePrice"].ToString(), sdr["WareGoPrice"].ToString(), sdr["WareType"].ToString(), sdr["WareCount"].ToString(), sdr["WareUnit"].ToString(), sdr["WareEasyName"].ToString(), sdr["Date"].ToString(), sdr["authorized"].ToString() };
                    lviWare.SubItems.AddRange(str);
                    lvWare.Items.Add(lviWare);
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

        //根据简索码查询
        private void txtEasyName_TextChanged(object sender, EventArgs e)
        {
            EasySearch(txtEasyName.Text);
        }

        //根据简索码查询
        private void EasySearch(string EasyName)
        {
            lvWare.Items.Clear();
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = "";

                sql = string.Format("select * from Ware where WareEasyName like '{0}%'", EasyName);
                SqlDataReader sdr = db.SelectAll(sql);

                while (sdr.Read())
                {
                    ListViewItem lviWare = new ListViewItem(sdr["WareName"].ToString());
                    string[] str ={ sdr["WareType"].ToString(), sdr["WareGoPrice"].ToString(), sdr["WareCount"].ToString() };
                    lviWare.SubItems.AddRange(str);
                    lvWare.Items.Add(lviWare);
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
}