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
    public partial class ConsumeForm : Form
    {
        public ConsumeForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        //加载事件
        private void ConsumeForm_Load_1(object sender, EventArgs e)
        {
            string sql = string.Format("select * from guest where U_UserId='{0}'",UserHelper.UserId);
            DBHelper dx = new DBHelper();
            SqlDataReader eq = dx.SelectAll(sql);
            
            while (eq.Read())
            {
                string rid = eq["r_id"].ToString();
                string sqlone = string.Format("select r_roomid from room where r_id='{0}'", rid);
                DBHelper du = new DBHelper();
                SqlDataReader dr = du.SelectAll(sqlone);
                dr.Read();
                string roomid = dr["r_roomid"].ToString();
              
                string Underwrite = eq["Underwrite"].ToString();
                string comeDate = eq["comeDate"].ToString();
                string Bookleave = eq["Bookleave"].ToString();
                string name = eq["Uname"].ToString();
                string Operator = eq["Operator"].ToString();
                string remark = eq["remark"].ToString();
                ListViewItem list = new ListViewItem();
                list.Text = roomid;
                string[] room ={ Underwrite, comeDate, Bookleave, name, Operator, remark };
                list.SubItems.AddRange(room);
                this.lvBookHouse.Items.Add(list);
            }
            dx.GetClose();
        }
    }
}