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
    public partial class BookHouse : Form
    {
        public BookHouse()
        {
            InitializeComponent();
          //  skinEngine1.SkinFile = "DeepGreen.ssk";
        }
        
       
        private void txtAdvanceForegift_KeyPress(object sender, KeyPressEventArgs e)
        {

            //控制控件只能输入数字退格
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
            {               
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
                string name = txtName.Text;
                string sex;
                string userid = txtuserid.Text;
                if (userid == "")
                {
                    userid = "";
                }
                if (rdoMan.Checked == true)
                {
                    sex = "男";
                }
                else
                {
                    sex = "女";
                }
                object certificate = cboCertificate.SelectedItem;
                string certificateid = txtCertificateId.Text;
                string linkman = txtContactTel.Text;
                string address = txtAddress.Text;
                string AdvanceForegift = txtAdvanceForegift.Text;
                string comedate = Convert.ToDateTime(dtpComeDate.Text).ToString("yyyy-MM-dd HH:mm");
                string bookleave = dtpBookleave.Text;
                string remark = txtRemark.Text;
                int a = lvSelectHouse.Items.Count;
                string Operator = UserHelper.LoginId;
        

            //验证数据库是否为空
            if(!ValidateInput())
            {
                return;
            }
           
            certificate=certificate.ToString();

            //循环添加数据到预定表
           
                while (a > 0)
                {

                    //预定多个房间的时候 钱全放在第一个房间里面` 其余的都为0
                    if (a == 1)
                    {
                        AdvanceForegift = txtAdvanceForegift.Text;
                    }
                    else
                    {
                        AdvanceForegift = "0.000";
                    }
                    AutoId dx = new AutoId();
                    string id = dx.GetId("B_bookid", "book");
                    ListViewItem list = lvSelectHouse.Items[a - 1];
                    string listone = list.SubItems[0].Text;

                    //通过房间号找房间编号
                    string sqlont = string.Format("select r_id from room where room.R_RoomId={0}", listone);
                    DBHelper dr = new DBHelper();
                    SqlDataReader data = dr.SelectAll(sqlont);
                    data.Read();
                    int rid = int.Parse(data[0].ToString());

                    //关闭数据库
                    dr.GetClose();
                    DBHelper du = new DBHelper();

                    //添加一条数据到预定表
                    string sql = string.Format("insert into  book (B_BookId,r_id,Room_id,State,comeDate,Bookleave,Operator,Uname,CertificateType,CertificateID,Address,Usex,contactTel,remark,AdvanceForegift,U_UserId) values ('{0}',{1},'{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", id, rid, listone, "预订", comedate, bookleave, Operator, name, certificate, certificateid, address, sex, linkman, remark, AdvanceForegift, userid);
                    du.UpdateDeleteAdd(sql);

                    //关闭数据库
                    du.GetClose();
                    a--;

                
            }
            
          
                MessageBox.Show("预定成功~！");
                //关闭窗口
                this.Close();
            
        }

        //判断必填又未填的控件背景为红色
        private bool ValidateInput()
        {
            bool isOk = true;
            if(txtName.Text=="")
            {
                txtName.BackColor = Color.Red;
                txtName.Focus();
                isOk = false;
            }
            if(txtCertificateId.Text=="")
            {
                txtCertificateId.BackColor = Color.Red;
                txtCertificateId.Focus();
                isOk = false;
            }
            if(txtAdvanceForegift.Text=="")
            {
                txtAdvanceForegift.BackColor = Color.Red;
                txtAdvanceForegift.Focus();
                isOk = false;
            }
            return isOk;
        }

        private void BookHouse_Load(object sender, EventArgs e)
        {
            cboCertificate.Text = "身份证";
            dtpComeDate.Text = DateTime.Now.AddDays(1).ToString();
            dtpBookleave.Text = DateTime.Now.AddDays(2).ToShortDateString()+" 12:00:00";
            DBHelper dx = new DBHelper();

            //查询房间表里的预订的房间
            string sql = "select a.R_RoomId , b.R_Type,a.price from room as a ,roomtype as b where a.roomtype=b.R_RoomId and a.state='空净' ";
            SqlDataReader eq = dx.SelectAll(sql);

            //循环录入到listview中
            while (eq.Read()) 
            {
                string roomid = eq[0].ToString();
                string roomtype = eq[1].ToString();
                string price = eq[2].ToString();
                ListViewItem list = new ListViewItem();
                list.Text = roomid;
                string[] room ={roomtype,price.ToString()};
                list.SubItems.AddRange(room);
                this.lvHollowHouse.Items.Add(list);    
            }
            //关闭数据库
            dx.GetClose();
        }

        private void lvHollowHouse_DoubleClick(object sender, EventArgs e)
        {
           //双击未预定的房间中的listview 跳到已预定的listview  并将数据库更改
            ListViewItem list = this.lvHollowHouse.SelectedItems[0];
            string listone=list.SubItems[0].Text;
            string sql =string.Format( "update room set state='预订' where r_roomid='{0}'",listone);
            DBHelper dx = new DBHelper();
            dx.UpdateDeleteAdd(sql);

            //关闭数据库
            dx.GetClose();
            this.lvHollowHouse.Items.Remove(list);
            lvSelectHouse.Items.Add(list);
        }

        private void lvSelectHouse_DoubleClick(object sender, EventArgs e)
        {
            //双击已预定的房间中的listview 跳到未预定的listview  并将数据库更改
            ListViewItem list = this.lvSelectHouse.SelectedItems[0];
            string listone = list.SubItems[0].Text;
            string sql = string.Format("update room set state='空净' where r_roomid='{0}' ", listone);
            DBHelper dx = new DBHelper();
            dx.UpdateDeleteAdd(sql);
            
            //关闭数据库
            dx.GetClose();
            this.lvSelectHouse.Items.Remove(list);
            lvHollowHouse.Items.Add(list);
        }
       

        private void cboRoomType_SelectionChangeCommitted(object sender, EventArgs e)
        {

            //用房间类型来决定listview中的房间
            lvHollowHouse.Items.Clear();
            string type = cboRoomType.SelectedItem.ToString();
            string sql;
            if (type == "全部")
            {
                sql = "select a.R_RoomId,b.r_type,a.price from room as a,roomtype as b where a.RoomType=b.r_roomid and a.state='空净' ";
            }
            else
            {
               sql =string.Format( "select a.R_RoomId , b.R_Type,a.price from room as a ,roomtype as b where a.roomtype=b.R_RoomId and a.state='空净' and b.r_type='{0}' ",type);
            }
            DBHelper dx = new DBHelper(); 
            SqlDataReader eq = dx.SelectAll(sql);
            
            //讲数据循环添加到listview中
            while (eq.Read())
            {
                string roomid = eq[0].ToString();
                string roomtype = eq[1].ToString();
                string price = eq[2].ToString();
                ListViewItem list = new ListViewItem();
                list.Text = roomid;
                string[] room ={ roomtype, price };
                list.SubItems.AddRange(room);
                this.lvHollowHouse.Items.Add(list);

            }

            dx.GetClose();
        }

        private void dtpBookleave_CloseUp(object sender, EventArgs e)
        {
            //判断预离时间必须大于入住时间
            string comedate = dtpComeDate.Text;
            string bookleave = dtpBookleave.Text;
            if (Convert.ToDateTime(comedate.Substring(0, 10)) >= Convert.ToDateTime(bookleave.Substring(0, 10)))
            {
                MessageBox.Show("预离时间必须大于入住时间");
                dtpBookleave.Text = DateTime.Now.AddDays(1).ToShortDateString() + " 12:00:00";
                return;
            }
            
        }

        private void dtpComeDate_CloseUp(object sender, EventArgs e)
        {
            //判断预定只能提前三天预定
            DateTime date = Convert.ToDateTime(DateTime.Now.AddDays(3).ToString());
            DateTime dateone = Convert.ToDateTime(dtpComeDate.Text.Substring(0,10));
            if (dateone > date)
            {
                MessageBox.Show("最多只能提前三天预定");
                dtpComeDate.Text = DateTime.Now.ToString();
                return;
            }

            //判断入住时间不得小于当前时间
            if (dateone < Convert.ToDateTime(DateTime.Now.ToString().Substring(0,10)))
            {
                MessageBox.Show("入住时间不得小于当前时刻");
                dtpComeDate.Text = DateTime.Now.ToString();
                return;
            }
        }        

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //设置txtname控件背景为白色
            txtName.BackColor = Color.White;
        }

        private void txtCertificateId_TextChanged(object sender, EventArgs e)
        {
            //设置txtCertificateId控件背景为白色
            txtCertificateId.BackColor = Color.White;


        }

        private void txtAdvanceForegift_TextChanged(object sender, EventArgs e)
        {
            //设置txtAdvanceForegift控件背景为白色
            txtAdvanceForegift.BackColor = Color.White;
        }

        private void txtuserid_Leave(object sender, EventArgs e)
        {
            //在txtid中按回车建可以打开密码验证窗口  并讲传输传送过去
           
            string id = txtuserid.Text;
            PwdValidate frm = new PwdValidate();
            frm.fgetcid(id);

            frm.frm(txtAdvanceForegift, txtuserid, txtName, txtCertificateId, txtContactTel, txtAddress, txtRemark, rdoMan, rdoWaman, cboCertificate);
            frm.ShowDialog();
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
             //判断已预定的房间是否为空
            int count = lvSelectHouse.Items.Count;
            if (count > 0)
            {
                DialogResult result = MessageBox.Show("如果要取消请把已预订的房间清空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //if (result == DialogResult.OK)
                //{
                //    //return;
                //}               
            }
            else
            {
                //关闭窗口
                this.Close();
            }        
        }

        private void txtCertificateId_Leave(object sender, EventArgs e)
        {
            if(cboCertificate.Text=="身份证")
            {
                if (txtCertificateId.Text.Length != 18 && txtCertificateId.Text.Length != 0 && txtCertificateId.Text.Length != 15)
                {
                    MessageBox.Show("身份证只能是18位或15位！", "温馨", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCertificateId.Focus();
                    txtCertificateId.SelectAll();
                }
            }
        }       
    }
}