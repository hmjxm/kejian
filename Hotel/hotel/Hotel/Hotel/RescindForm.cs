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
    public partial class RescindForm : Form
    {
        public RescindForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            // 判断待解除预定的listview清空
            int count=lvUnchainBook.Items.Count;
            if(count>0)
            {
                MessageBox.Show("如果要取消请把待解除预订客房清空");
                return;

            }

            //关闭窗口
            this.Close();
        }

        private void RescindForm_Load(object sender, EventArgs e)
        {

            //查询预定表中的预定的记录
            string sql = "select * from book where state='预订' ";
            DBHelper dx = new DBHelper();
            SqlDataReader eq = dx.SelectAll(sql);
            //循环将记录添加到listview中
            while (eq.Read())
            {
                
                string roomid = eq["room_id"].ToString();
                string comeDate = eq["comeDate"].ToString();
                string Bookleave = eq["Bookleave"].ToString();
                string name = eq["Uname"].ToString();
                string sex = eq["Usex"].ToString();
                string Operator = eq["Operator"].ToString();
                string remark = eq["remark"].ToString();
                ListViewItem list = new ListViewItem();
                list.Tag = eq["AdvanceForegift"].ToString();
                list.Text = roomid;
                string[] room ={ comeDate, Bookleave, name, sex, Operator, remark };
                list.SubItems.AddRange(room);
                this.lvBookHouse.Items.Add(list);
            }
            //关闭数据库
            dx.GetClose();
        }

        private void lvBookHouse_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                //双击已预定的房间 跳到解除预定中 并更改数据库 
                ListViewItem list = this.lvBookHouse.SelectedItems[0];
                string listone = list.SubItems[0].Text;
                string money = list.Tag.ToString();

                DBHelper db = null;
                db = new DBHelper();
                AutoId ai = new AutoId();
                string sql = string.Format("insert into Consume values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", ai.GetId("C_ConsumeId", "Consume"), 0000, "房间费用", money, 1, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "房间费用", UserHelper.LoginId,"");
                //string sql = string.Format("insert into Consume values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", ai.GetId("C_ConsumeId",));

                db.UpdateDeleteAdd(sql);

                sql = string.Format("update room set state='空净' where r_roomid='{0}'", listone);
                string sqlone = string.Format("update book set state='解除预订' where room_id='{0}'", listone);
                DBHelper dx = new DBHelper();
                dx.UpdateDeleteAdd(sql);

                //关闭数据库
                dx.GetClose();
                DBHelper dr = new DBHelper();
                dr.UpdateDeleteAdd(sqlone);

                //关闭数据库
                dr.GetClose();
                this.lvBookHouse.Items.Remove(list);
                lvUnchainBook.Items.Add(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void lvUnchainBook_DoubleClick(object sender, EventArgs e)
        {

            //双击待解除预定的房间 跳到已预定中 并更改数据库
            ListViewItem list = this.lvUnchainBook.SelectedItems[0];
            string listone = list.SubItems[0].Text;
            string sql = string.Format("update room set state='预订' where r_roomid='{0}'", listone);
            string sqlone = string.Format("update book set state='预订' where room_id='{0}'", listone);
            DBHelper dx = new DBHelper();
            dx.UpdateDeleteAdd(sql);

            //关闭数据库
            dx.GetClose();
            DBHelper dr = new DBHelper();
            dr.UpdateDeleteAdd(sqlone);

            //关闭数据库
            dr.GetClose();
            this.lvUnchainBook.Items.Remove(list);
            this.lvBookHouse.Items.Add(list);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            //关闭窗口
            this.Close();
        }
    }
}