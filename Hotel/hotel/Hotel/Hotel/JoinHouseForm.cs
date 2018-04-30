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
    public partial class JoinHouseForm : Form
    {
        public string guestIdOne;
        public string guestIdTwo;
        public JoinHouseForm()
        {
            InitializeComponent();
        }

        private void JoinHouseForm_Load(object sender, EventArgs e)
        {
            //显示空净房间信息
            ShowHouseInfo();
            //显示时间
            ShowTime();
            //添加下拉框可供房间
            ShowInfo();
            //显示可供房间信息
            ShowHouse();

            ShowOldHouseOne();
            
        }

        //显示旧房间信息
        private void ShowOldHouseTwo()
        {
            cboUnite.Items.Clear();
            DBHelper db = null;
            
            db = new DBHelper();
            string temp;
            try
            {
                string sql = string.Format("select R_RoomId from Room where State='{0}' and  R_RoomId !='{1}'", "待客",cboGuest.Text);
                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    temp = sdr["R_RoomId"].ToString();
                    cboUnite.Items.Add(temp);
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

        //显示可供房信息
        private void ShowOldHouseOne()
        {
            cboGuest.Items.Clear();
            HouseHelper hh = new HouseHelper();
            DBHelper db = null;
            db = new DBHelper();
            try
            {
                string sql = string.Format("select R_RoomId from Room where State='{0}'", "待客");
                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    cboGuest.Items.Add(sdr["R_RoomId"].ToString()); 
                }
                sdr.Close();

                db = new DBHelper();
                sql = string.Format("select G_GuestId from Guest where R_id='{0}' and Fact='{1}'",hh.GetR_id(cboGuest.Text),"");
                SqlDataReader sdr2 = db.SelectAll(sql); ;
                if(sdr2.Read())
                {
                    guestIdTwo = sdr["G_GuestId"].ToString();
                }
                sdr2.Close();
                
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

        //显示房间信息
        private void ShowHouse()
        {
            cboNewHouse.Items.Clear();
            string Room_id;
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from Room where State='{0}'", "待客");
                SqlDataReader sdr = db.SelectAll(sql);

                while (sdr.Read())
                {
                    Room_id = sdr["R_RoomId"].ToString();
                    cboNewHouse.Items.Add(Room_id);
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

        
        //显示待客
        private void ShowInfo()
        {
            string room_id;
            DBHelper db = null;
            db = new DBHelper();
            string sql = string.Format("select * from Room where State= '{0}'","待客");
            SqlDataReader sdr = db.SelectAll(sql);

            while(sdr.Read())
            {
                room_id = sdr["R_RoomId"].ToString();
                cboNewHouse.Items.Add(room_id);
            }
        }

        //显示预离时间
        private void ShowTime()
        {
            string temp = DateTime.Now.AddDays(1).ToString().Substring(0, dtpBookleave.Text.LastIndexOf(":") - 3) + " 12:00";
            //MessageBox.Show(temp);
            dtpBookleave.Text = temp;
        }

        //显示信息
        private void ShowHouseInfo()
        {
            lvHollowHouse.Items.Clear();
            lvSelectHouse.Items.Clear();
            string Room_id;
            string Type;
            string Price;
            HouseHelper hh = new HouseHelper();
            DBHelper db = null;
            try
            {
                string sql = string.Format("select * from Room where State='{0}'", "空净");

                db = new DBHelper();
                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    Room_id = sdr["R_RoomId"].ToString();
                    Type = hh.GetHouseType(sdr["RoomType"].ToString());
                    Price = sdr["price"].ToString();

                    ListViewItem lviHouse = new ListViewItem(Room_id);
                    string[] str ={Type,Price};
                    lviHouse.SubItems.AddRange(str);
                    lvHollowHouse.Items.Add(lviHouse);
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

        //合并事件
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //验证事件
            if (ValidateInput())
            {
                //合并
                Unite();
            }            
        }

        //合并
        private void Unite()
        {
            string roomId;
            
            string price;
            string G_GuestId;            

            DBHelper db = null;
            HouseHelper hh = new HouseHelper();
            AutoId ai = new AutoId();  //自动生成id类
            db = new DBHelper();
            string sql="";


            //大量申明
            string U_UserId = "";
            string Uname="";
            string Sex="";
            string CertificateType = "";
            string CertificateID = "";
            string CertificatePic = "";
            string Address = "";
            string contactTel = "";
            string Underwrite = "";
            string comeDate = "";
            string Bookleave = "";
            string faceDate = "";
            string Due="";
            string Fact="";
            string locate="";
            string Operator=UserHelper.LoginId;
            string remark="";

            string R_id = hh.GetR_id(cboNewHouse.Text);
            MessageBox.Show(R_id);
            sql = string.Format("select * from Guest where R_id = '{0}' and faceDate = '{1}' ", R_id, "");
            SqlDataReader sdr=db.SelectAll(sql);

            if(sdr.Read())
            {
                U_UserId = sdr["U_UserId"].ToString();
                 Uname = sdr["Uname"].ToString();
                 Sex = sdr["Sex"].ToString();
                 CertificateType=sdr["CertificateType"].ToString();
                 CertificateID=sdr["CertificateID"].ToString();
                 CertificatePic=sdr["CertificatePic"].ToString();
                 Address =sdr["Address"].ToString();
                 contactTel=sdr["contactTel"].ToString();
                 Underwrite=sdr["Underwrite"].ToString();
                 comeDate=dtpComeDate.Text;
                 Bookleave=dtpBookleave.Text;
                 faceDate = "";
            }

            sdr.Close();
            int rows = 0;
            for (int i = 0; i < lvSelectHouse.Items.Count;i++ )
            {
                G_GuestId = ai.GetId("G_GuestId", "Guest");
                roomId = hh.GetR_id(lvSelectHouse.Items[i].SubItems[0].Text);                
                price=lvSelectHouse.Items[i].SubItems[2].Text;

                //MessageBox.Show(Uname.ToString());
               
                sql = string.Format("insert into Guest values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}')",
                   G_GuestId, roomId,U_UserId, Uname, Sex, CertificateType, CertificateID, CertificatePic, Address, contactTel,txtAdvanceForegift.Text , Underwrite,
                   comeDate, Bookleave, faceDate, price, Due,Fact,locate,Operator,remark
                   );
                rows = db.UpdateDeleteAdd(sql);
                sql = string.Format("update Room set State='{0}' where R_id='{1}'","待客",hh.GetR_id(lvSelectHouse.Items[i].SubItems[0].Text));
                db.UpdateDeleteAdd(sql);
            }

            if (rows > 0)
            {
                MessageBox.Show("合并成功!", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else 
            {
                MessageBox.Show("合并失败!", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //双击事件
        private void lvHollowHouse_DoubleClick(object sender, EventArgs e)
        {
            //创建listviewItem项
            ListViewItem lviSelectHouse = new ListViewItem(lvHollowHouse.SelectedItems[0].SubItems[0].Text);
            string[] str ={ lvHollowHouse.SelectedItems[0].SubItems[1].Text, lvHollowHouse.SelectedItems[0].SubItems[2].Text};
            lviSelectHouse.SubItems.AddRange(str);
            lvSelectHouse.Items.Add(lviSelectHouse);

            this.lvHollowHouse.SelectedItems[0].Remove();
        }

        //双击事件
        private void lvSelectHouse_DoubleClick(object sender, EventArgs e)
        {
            //创建listviewItem项
            ListViewItem lviHouse = new ListViewItem(lvSelectHouse.SelectedItems[0].SubItems[0].Text);
            string[] str ={ lvSelectHouse.SelectedItems[0].SubItems[1].Text, lvSelectHouse.SelectedItems[0].SubItems[2].Text };
            lviHouse.SubItems.AddRange(str);
            lvHollowHouse.Items.Add(lviHouse);

            lvSelectHouse.SelectedItems[0].Remove();
        }

        //控制只能输入数字
        private void txtAdvanceForegift_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }


        private bool ValidateInput()
        {
            bool isOk = false;
            if (cboNewHouse.Text == "")
            {
                lblNewHouseNull.Visible = true;
            }
            else
            {
                isOk = true;
            }
            return isOk;
        }

        
        private void cboNewHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNewHouseNull.Visible = false;
        }

        private void btnCamcel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboGuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowOldHouseTwo();
            DBHelper db = null;
            HouseHelper hh = new HouseHelper();
            db = new DBHelper();
            string sql = string.Format("select G_GuestId from Guest where R_id='{0}' and Fact='{1}'", hh.GetR_id(cboGuest.Text), "");
           
            SqlDataReader sdr2 = db.SelectAll(sql);
            if (sdr2.Read())
            {
                guestIdOne = sdr2["G_GuestId"].ToString();
            }
            
            sdr2.Close();
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cboGuest.Text == "")
            {
                MessageBox.Show("客房不能为空"," 温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cboGuest.Focus();
                return;
            }
            else if(cboUnite.Text=="")
            {
                MessageBox.Show("并入客房不能为空","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cboUnite.Focus();
                return;
            }
            string uName = "";
            string sex = ""; 
            string CertificateType = "";
            string CertificateID = "";
            string CertificatePic = "";
            string Address = "";
            string contactTel = "";  

            DBHelper db = null;
            db = new DBHelper();
            string sql = string.Format("select * from Guest where G_GuestId='{0}'",guestIdTwo);

            SqlDataReader sdr = db.SelectAll(sql);
            if(sdr.Read())
            {
                uName = sdr["Uname"].ToString();
                sex = sdr["Sex"].ToString();
                CertificateType = sdr["CertificateType"].ToString();
                CertificateID = sdr["CertificateID"].ToString();
                CertificatePic = sdr["CertificatePic"].ToString();
                Address = sdr["Address"].ToString();
                contactTel = sdr["contactTel"].ToString();
            }
            sdr.Close();

            sql = string.Format("update Guest set Uname='{0}',sex='{1}',CertificateType='{2}',CertificateID='{3}',CertificatePic='{4}',Address='{5}',contactTel='{6}' where G_GuestId='{7}'",
                uName,sex,CertificateType,CertificateID,CertificatePic,Address,contactTel,guestIdOne
                );
            if (db.UpdateDeleteAdd(sql) > 0)
            {
                MessageBox.Show("联房成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("联房失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboUnite_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBHelper db = null;
            HouseHelper hh = new HouseHelper();
            db = new DBHelper();
            string sql = string.Format("select G_GuestId from Guest where R_id='{0}' and Fact='{1}'", hh.GetR_id(cboUnite.Text),"");

            SqlDataReader sdr2 = db.SelectAll(sql);
            if (sdr2.Read())
            {
                guestIdTwo = sdr2["G_GuestId"].ToString();
            }
            sdr2.Close();
           // MessageBox.Show(guestIdTwo);
        }      
    }
}