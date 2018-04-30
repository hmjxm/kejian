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
    public partial class SwapHouseForm : Form
    {
        
        HouseHelper hh = new HouseHelper();
        public SwapHouseForm()
        {
            InitializeComponent();
        }      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnsure_Click(object sender, EventArgs e)
        {
            AutoId ai = new AutoId();
            if(ValidateInput())
            {
                string sql;
                DBHelper db = null;
                try
                {
                    db = new DBHelper();
                    string Room_id = cboNewHouse.Text.Substring(0, cboNewHouse.Text.IndexOf(" "));
                    string R_id = hh.GetR_id(Room_id);
                    sql = string.Format("Update Guest set R_id='{0}',Bookleave='{1}',comeDate='{3}' where G_GuestId='{2}'", R_id, dtpBookLeave.Text, lblOldDate.Tag, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    
                    if (db.UpdateDeleteAdd(sql) > 0)
                    {                       
                        if (hh.IshaveBook(cboOldHouse.Text))
                        {
                            sql = string.Format("update Room set State ='{0}' where R_id='{1}'", "预订", hh.GetR_id(cboOldHouse.Text));
                        }
                        else
                        {
                            sql = string.Format("update Room set State ='{0}' where R_id='{1}'", "空净", hh.GetR_id(cboOldHouse.Text));
                        }
                        db.UpdateDeleteAdd(sql);

                        sql = string.Format("update Room set State='{0}' where R_id='{1}'", "待客", R_id);
                        db.UpdateDeleteAdd(sql);


                        sql = string.Format("insert into Consume values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                        ai.GetId("C_ConsumeId", "Consume"), lblOldDate.Tag, "换房消费", lblOldPrice.Text, 1, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "房间消费", UserHelper.LoginId, txtRemark.Text
                        );
                        db.UpdateDeleteAdd(sql);
                       
                        MessageBox.Show("换房成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("换房失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private bool ValidateInput()
        {
            bool isOk = false;
            if(cboOldHouse.Text=="")
            {
                MessageBox.Show("原客房不能为空！","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (cboNewHouse.Text == "")
            {
                MessageBox.Show("新客房不能为空！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
            else
            {
                isOk = true;
            }
            return isOk;
        }

        private void SwapHouseForm_Load(object sender, EventArgs e)
        {
            ShowHouseInfo();
            ShowNewHouse();
            
        }

        private void ShowBookLeave()
        {
            DBHelper db = null;
            db = new DBHelper();
            try
            {
                string sql = string.Format("select Bookleave from Guest where G_GuestId='{0}'", lblOldDate.Tag);
                
                SqlDataReader sdr = db.SelectAll(sql);
                if (sdr.Read())
                {
                    this.dtpBookLeave.Text = sdr["Bookleave"].ToString();
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

        private void ShowNewHouse()
        {
           
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from room where State='{0}'", "空净");
                SqlDataReader sdr = db.SelectAll(sql);

                while (sdr.Read())
                {
                    cboNewHouse.Items.Add(sdr["R_RoomId"].ToString() + " " + hh.GetHouseType(sdr["RoomType"].ToString()));
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

        private void ShowHouseInfo()
        {
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
                    cboOldHouse.Items.Add(Room_id);
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

        private void cboOldHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string room_id = this.cboOldHouse.Text;
            ShowInfo(room_id,0);
            ShowWareInfo();
            ShowBookLeave();            
        }

        //显示价格等信息
        private void ShowInfo(string room_id,int type)
        {
            string price="";            
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from Room where R_RoomId='{0}'", room_id);
                SqlDataReader sdr = db.SelectAll(sql);

                if (sdr.Read())
                {
                    if (type == 0)
                    {
                        price = sdr["price"].ToString();
                        this.lblOldPrice.Text = price;
                    }
                    else
                    {
                        lblNewHouse.Text = sdr["price"].ToString();
                    }
                }
                sdr.Close();                

                HouseHelper hh = new HouseHelper();
                string R_id = hh.GetR_id(room_id);

                sql = string.Format("select comeDate,G_GuestId from Guest where R_id='{0}' and faceDate='{1}'", R_id, "");
                sdr = db.SelectAll(sql);
                
                if (sdr.Read())
                {
                    if (type == 0)
                    {
                        lblOldDate.Text = sdr["comeDate"].ToString();
                        lblOldDate.Tag = sdr["G_GuestId"].ToString();
                    }                   
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
               

        //显示消费信息
        private void ShowWareInfo()
        {
            double money = 0;
            lblMoney.Text = "0";
            //lblOldPrice.Text = "0";
            SqlDataReader sdr = null;            
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                //MessageBox.Show(this.lblOldDate.Tag.ToString());

                string sql = string.Format("select * from Consume where G_GuestId = '{0}'", this.lblOldDate.Tag);

                sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    money += Convert.ToDouble(sdr["Price"].ToString()) * Convert.ToDouble(sdr["C_Count"].ToString());
                }
                this.lblMoney.Text = money.ToString();

                //计算相差的时间，如果大于忽略时间，则写入消费列表中
               // MessageBox.Show(lblOldDate.Text);
                db = new DBHelper();
                sql = string.Format("select * from guest where G_GuestId = '{0}'", lblOldDate.Tag);
                sdr=db.SelectAll(sql);
                string oldDate = "";
                if(sdr.Read())
                {
                    oldDate = sdr["comeDate"].ToString();
                }

                TimeSpan ts = DateTime.Now - Convert.ToDateTime(oldDate);
                int min = Convert.ToInt32(ts.TotalMinutes);



                AutoId ai=new AutoId();
                if (IsAwoke.IgnoreTime < min)
                {
                    string morn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    string mornHouse = DateTime.Now.ToString("HH:mm:ss");

                    ts = Convert.ToDateTime(morn) - Convert.ToDateTime(Convert.ToDateTime(lblOldDate.Text).ToString("yyyy-MM-dd HH:mm:ss"));
                    //MessageBox.Show(ts.Days.ToString());
                    double temp = 0;
                    if (ts.Days <= 0)
                    {
                        temp++;
                    }
                    else if (Convert.ToDateTime(mornHouse) > Convert.ToDateTime("12:00:00"))
                    {
                        temp = temp + ts.Days + 1;

                    }
                    if (Convert.ToDateTime(mornHouse) <= Convert.ToDateTime("12:00:00"))
                    {
                        temp = temp + ts.Days;   //相差天数                                        

                    }



                    money += Convert.ToDouble(lblOldPrice.Text) * temp;
                    
                }
                sdr.Close();
                this.lblMoney.Text = money.ToString();
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

        private void cboNewHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Room_id=cboNewHouse.Text.Substring(0,cboNewHouse.Text.IndexOf(" "));            
            ShowInfo(Room_id,1);
        }

    }
}