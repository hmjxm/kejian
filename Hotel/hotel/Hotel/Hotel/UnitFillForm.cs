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
    public partial class UnitFillForm : Form
    {
        public UnitFillForm()
        {
            InitializeComponent();
        }

        private void UnitFillForm_Load(object sender, EventArgs e)
        {
            ShowUnderwrite();
        }

        //显示签单
        private void ShowUnderwrite()
        {
            string Underwrite;
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from Underwrite");
                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    Underwrite = sdr["Underwrite"].ToString();
                    cboUnderwrite.Items.Add(Underwrite);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lvUnitFill.Items.Clear();
            string G_GuestId;
            string Room_id;
            string name;            
            string comeDate;
            string leaveDate;
            string money;
            string remark;

            DBHelper db = null;
            db = new DBHelper();
            string sql = string.Format("select * from UnderwriteAnnal where Underwrite='{0}' and State='{1}' ",cboUnderwrite.Text,"未付");

            SqlDataReader sdr = db.SelectAll(sql);
            
            while(sdr.Read())
            {
                G_GuestId = sdr["G_GuestId"].ToString();
                //MessageBox.Show(G_GuestId);
                sql = string.Format("select * from Guest where G_GuestId='{0}'", G_GuestId);

                DBHelper db2 = new DBHelper();
                SqlDataReader sdr2=db2.SelectAll(sql);

                if (sdr2.Read())
                {
                    Room_id = sdr["Room_id"].ToString();
                    name = sdr2["Uname"].ToString();
                    comeDate = sdr2["comeDate"].ToString();
                    leaveDate = sdr2["faceDate"].ToString();
                    money = sdr["U_money"].ToString();
                    remark = sdr["remark"].ToString();

                    ListViewItem lviUnderwrite = new ListViewItem(Room_id);
                    lviUnderwrite.Tag = sdr["A_Id"].ToString();
                    //MessageBox.Show(lviUnderwrite.Tag.ToString());
                    string[] str ={ name, comeDate, leaveDate, money, remark };
                    lviUnderwrite.SubItems.AddRange(str);
                    lvUnitFill.Items.Add(lviUnderwrite);
                    sdr2.Close();
                }
            }
            sdr.Close();
        }

        private void lvUnitFill_Click(object sender, EventArgs e)
        {
            double money = 0;
            for (int i = 0; i < lvUnitFill.SelectedItems.Count; i++)
            {
                money += Convert.ToDouble(lvUnitFill.SelectedItems[i].SubItems[4].Text);
            }
            txtPrice.Text = money.ToString();            
        }

        private void btnUnitFill_Click(object sender, EventArgs e)
        {
            int rowCount = lvUnitFill.SelectedItems.Count;

            DBHelper db = null;
            try
            {
                db = new DBHelper();

                int rows = 0;
                for (int i = 0; i < rowCount; i++)
                {
                    string sql = string.Format("update UnderwriteAnnal set U_money='{0}',shifu='{0}',State='{1}' where A_Id='{2}'", lvUnitFill.Items[i].SubItems[4].Text, "已付", lvUnitFill.Items[i].Tag);
                    MessageBox.Show(sql);
                    rows = db.UpdateDeleteAdd(sql);
                }
                if (rows > 0)
                {
                    MessageBox.Show("操作成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtShiFu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtZhaoLin.Text = Convert.ToString(Convert.ToDouble(txtShiFu.Text) - Convert.ToDouble(txtPrice.Text));
            }
            catch (Exception)
            {

            }
        }          
    }
}