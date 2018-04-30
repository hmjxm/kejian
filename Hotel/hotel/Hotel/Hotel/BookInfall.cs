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

    
    public partial class BookInfall : Form
    {
        public BookInfall()
        {
            InitializeComponent();
        }
        private void BookInfall_Load(object sender, EventArgs e)
        {
            //在预定表中添加以预定的数据

            string sql = "select * from book where state='预订' ";
            DBHelper dx = new DBHelper();
            SqlDataReader eq = dx.SelectAll(sql);
            //循环录入到listview中
            while (eq.Read())
            {
                string bookid = eq["B_BookId"].ToString();
                string roomid = eq["room_id"].ToString();
                string comeDate = eq["comeDate"].ToString();
                string Bookleave = eq["Bookleave"].ToString();
                string name = eq["Uname"].ToString();
                string sex = eq["Usex"].ToString();
                string Operator = eq["Operator"].ToString();
                string remark = eq["remark"].ToString();
                string AdvanceForegift = eq["AdvanceForegift"].ToString();
                ListViewItem list = new ListViewItem();
                list.Tag = bookid;
                list.Text = roomid;
                string[] room ={ comeDate, Bookleave, AdvanceForegift,name, sex, Operator, remark };
                list.SubItems.AddRange(room);
                this.lvBookHouse.Items.Add(list);
            }
            //关闭数据库
            dx.GetClose();
        }

        private void lvBookHouse_DoubleClick(object sender, EventArgs e)
        {
            //双击要预定的房间 跳到以预定房间   并将数据库改变

            ListViewItem list = this.lvBookHouse.SelectedItems[0];
            string listone = list.SubItems[0].Text;
            string bookid = list.Tag.ToString();
            string sql = string.Format("update room set state='待客' where R_RoomId='{0}'", listone);
            string sqlone = string.Format("update book set state='待客' where b_bookid='{0}'", bookid);
            
            DBHelper dx = new DBHelper();
            dx.UpdateDeleteAdd(sql);
            
            //关闭数据库
            dx.GetClose();
            DBHelper dr=new DBHelper();
            dr.UpdateDeleteAdd(sqlone);

            //关闭数据库
            dr.GetClose();
            this.lvBookHouse.Items.Remove(list);
            lvFitoutHouse.Items.Add(list);
        }

        private void lvFitoutHouse_DoubleClick(object sender, EventArgs e)
        {

            //双击以预定的房间 跳到要预定的房间   并将数据库改变

            ListViewItem list = this.lvFitoutHouse.SelectedItems[0];
            string listone = list.SubItems[0].Text;
            string bookid = list.Tag.ToString();
            string sql = string.Format("update room set state='预订' where R_RoomId='{0}'", listone);
            string sqlone = string.Format("update book set state='预订' where b_bookid='{0}'", bookid);
       
            DBHelper dx = new DBHelper();
            dx.UpdateDeleteAdd(sql);

            //关闭数据库
            dx.GetClose();
            DBHelper dr = new DBHelper();
            dr.UpdateDeleteAdd(sqlone);

            //关闭数据库
            dr.GetClose();
            this.lvFitoutHouse.Items.Remove(list);
            this.lvBookHouse.Items.Add(list);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            //判断取消要清空已选定的客房

            int count = lvFitoutHouse.Items.Count;
            if(count>0)
            {
                MessageBox.Show("如果要取消请把已选定客房清空~!");
                return;
            }

            //关闭窗口
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //循环将数据添加到数据库中
            try
            {
                for (int i = 0; i < lvFitoutHouse.Items.Count; i++)
                {
                    AutoId dd = new AutoId();
                    string id = dd.GetId("G_GuestId", "guest");
                    string jk = lvFitoutHouse.Items[i].SubItems[0].Text;
                    string bookid = lvFitoutHouse.Items[i].Tag.ToString();
                    //通过预定的编号查找登陆的id
                    string sqltwo = string.Format("select U_UserId from book where B_BookId='{0}'",bookid);
                    DBHelper dk = new DBHelper();
                    SqlDataReader dl= dk.SelectAll(sqltwo);
                    string userid="";
                    if (dl.Read()) 
                    {
                       userid = dl["U_UserId"].ToString();
                    }

                    //关闭数据库
                    dk.GetClose();

                    //通过房间号查找房间编号
                    string sql = string.Format("select r_id from room where r_roomid='{0}'", jk);
                    DBHelper dx = new DBHelper();
                    SqlDataReader dr = dx.SelectAll(sql);
                    dr.Read();
                    string rid = dr[0].ToString();

                    //关闭数据库
                    dx.GetClose();
                    string name = lvFitoutHouse.Items[i].SubItems[4].Text;
                    string sex = lvFitoutHouse.Items[i].SubItems[5].Text;
                    string comeDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string Bookleave = lvFitoutHouse.Items[i].SubItems[2].Text;
                    string AdvanceForegift = lvFitoutHouse.Items[i].SubItems[3].Text;

                    //将数据添加到入住表中
                    string sqlone = string.Format("insert into guest ( G_GuestId,R_id,Uname,Sex,comeDate,Bookleave,AdvanceForegift,U_UserId) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", id, rid, name, sex, comeDate, Convert.ToDateTime(Bookleave).ToString("yyyy-MM-dd HH:mm:ss"), AdvanceForegift,userid);
                    DBHelper dp = new DBHelper();
                    dp.UpdateDeleteAdd(sqlone);

                    //关闭数据库
                    dp.GetClose();
                }
                MessageBox.Show("入住成功~！");
            }
            catch(Exception ex)
            {
                //MessageBox.Show("添加数据出错~！");
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                //关闭窗口
                this.Close();
            }
        }        
    }
}