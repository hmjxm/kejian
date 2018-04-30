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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void ShowInfo()
        {            
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from LeaveWord");
                SqlDataReader sdr = db.SelectAll(sql);

                while (sdr.Read())
                {
                    ListViewItem lviHistory = new ListViewItem(sdr["L_LeaveWordId"].ToString());
                    string[] str ={ sdr["L_U_UsersId"].ToString(), sdr["L_content"].ToString(), sdr["Date"].ToString() };
                    lviHistory.SubItems.AddRange(str);
                    lvHistory.Items.Add(lviHistory);
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