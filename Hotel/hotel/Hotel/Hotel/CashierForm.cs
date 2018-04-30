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
    public partial class CashierForm : Form
    {
        bool Underwrite = false;　　　//签单
        public CashierForm()
        {
            InitializeComponent();
        }

        //装载时间
        private void CashierForm_Load(object sender, EventArgs e)
        {
            //显示房间信息
            ShowHouseInfo(1);
            //显示签单
            ShowUnderwrite();
            //计算钱
            CountMoney();
            //显示折扣
            ShowDiscount();
        }

        //显示折扣
        private void ShowDiscount()
        {
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select discount from SoftWareSet");
                SqlDataReader sdr = db.SelectAll(sql);
                if (sdr.Read())
                {
                    if (sdr["discount"].ToString() == "1")
                    {
                        lbldiscount.Text = "无";
                    }
                    else
                    {
                        lbldiscount.Text = sdr["discount"].ToString() + "折";
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
            SqlDataReader sdr = null;
            lvConsume.Items.Clear();
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                for (int i = 0; i < lvFitout.Items.Count;i++ )
                {                    
                    string sql = string.Format("select * from Consume where G_GuestId = '{0}'", lvFitout.Items[i].SubItems[0].Text);

                    sdr = db.SelectAll(sql);
                    while (sdr.Read())
                    {                       
                        ListViewItem lviFitout = new ListViewItem(sdr["C_Name"].ToString());
                        string[] str ={ sdr["Price"].ToString(), sdr["C_type"].ToString(), sdr["C_Count"].ToString(), sdr["date"].ToString(), sdr["Operator"].ToString(), sdr["Remark"].ToString() };
                        lviFitout.SubItems.AddRange(str);
                        lvConsume.Items.Add(lviFitout);
                    }
                    sdr.Close();
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

        //显示房子信息
        private void ShowHouseInfo(int type)
        {
            lvUptownHouse.Items.Clear();
            string G_GuestId;
            string room_id;
            string name;
            string AdvanceForegift;
            string comeDate;
            string Bookleave;
            string cope;
            string remark;            
            
            DBHelper db = null;
            try
            {
                string sql="";
                db = new DBHelper();
                if (type == 1)
                {
                    sql = string.Format("select * from Room,Guest where State='{0}' and (faceDate = '{1}' or faceDate is null ) and Room.R_id=Guest.R_id ", "待客", "");
                }
                else if(type == 0)
                {
                    string nowTime = DateTime.Now.ToString().Substring(0,DateTime.Now.ToString().LastIndexOf(":")-5)+"12:00:00";

                    sql = string.Format("select * from Room,Guest where State='{0}' and Bookleave='{1}' and faceDate = '{2}' and Room.R_id=Guest.R_id ", "待客", nowTime,"");
                   
                }
                
                SqlDataReader sdr = db.SelectAll(sql);

                while (sdr.Read())
                {
                    G_GuestId = sdr["G_GuestId"].ToString();
                    room_id = sdr["R_RoomId"].ToString();
                    name = sdr["Uname"].ToString();
                    AdvanceForegift = sdr["AdvanceForegift"].ToString();
                    comeDate = sdr["comeDate"].ToString();
                    Bookleave = sdr["Bookleave"].ToString();
                    
                    remark = sdr["remark"].ToString();

                    string morn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    string mornHouse = DateTime.Now.ToString("HH:mm:ss");                   

                    TimeSpan ts = Convert.ToDateTime(morn) - Convert.ToDateTime(comeDate);
                    //MessageBox.Show(ts.Days.ToString());
                    double temp=0;
                    if (ts.Days <= 0)
                    {
                        temp++;
                    }
                    else if (Convert.ToDateTime(mornHouse) > Convert.ToDateTime("12:00:00"))
                    {
                         temp = temp + ts.Days + 1;
                        
                    }
                    if(Convert.ToDateTime(mornHouse) <= Convert.ToDateTime("12:00:00"))
                    {
                        temp = temp + ts.Days;   //相差天数                                        
                        
                    }
                    
                    cope = Convert.ToString(Convert.ToDouble(GetPrice(sdr["R_id"].ToString())) * temp);

                    ListViewItem lviuptown = new ListViewItem(G_GuestId);
                    lviuptown.Tag = sdr["CertificateID"].ToString();
                    string[] str ={room_id, name, AdvanceForegift, comeDate, Bookleave,temp.ToString(),cope,remark };


                    lviuptown.SubItems[0].Tag = sdr["R_id"].ToString();
                    
                    lviuptown.SubItems.AddRange(str);
                    lvUptownHouse.Items.Add(lviuptown);
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

        //获得价格
        private string GetPrice(string p)
        {
            DBHelper db = null;
            string price = "";
            try
            {
                db = new DBHelper();
                
                string sql = string.Format("select price from Room where R_id='{0}'", p);
                SqlDataReader sdr = db.SelectAll(sql);
                if (sdr.Read())
                {
                    price = sdr["price"].ToString();
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
            return price;
        }

        //定位按钮
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string room_id = txtRoom_id.Text;

            for (int i = 0; i < lvUptownHouse.Items.Count; i++)
            {
                lvUptownHouse.Items[i].ForeColor = Color.Black;
                lvUptownHouse.Items[i].BackColor = Color.White;
            }

            for (int i = 0; i < lvUptownHouse.Items.Count; i++)
            {
                if (lvUptownHouse.Items[i].SubItems[1].Text == txtRoom_id.Text)
                {
                    lvUptownHouse.Items[i].Selected = true;
                    lvUptownHouse.Items[i].ForeColor = Color.White;
                    lvUptownHouse.Items[i].BackColor = Color.Blue;
                    //lblroom.Text = lvDeposit.SelectedItems[0].SubItems[0].Text;
                    break;
                }
            }

            
        }

        //计算应付Money
        private void CountMoney()
        {
            try
            {
                double money = 0;
                if (lvFitout.Items.Count > 0)
                {
                    for (int i = 0; i < lvFitout.Items.Count; i++)
                    {
                        money += Convert.ToDouble(lvFitout.Items[i].SubItems[7].Text);
                    }
                    for (int i = 0; i < lvConsume.Items.Count; i++)
                    {
                        money += Convert.ToDouble(lvConsume.Items[i].SubItems[1].Text) * Convert.ToDouble(lvConsume.Items[i].SubItems[3].Text);
                    }
                    lblDeal.Text = money.ToString();

                    double temp = 0;
                    for (int i = 0; i < lvFitout.Items.Count; i++)
                    {
                        temp += Convert.ToDouble(lvFitout.Items[i].SubItems[3].Text);
                    }
                    lblYaJin.Text = temp.ToString();
                    ShowCust();

                    if (Convert.ToDouble(lblDeal.Text) <= Convert.ToDouble(lblYaJin.Text))
                    {
                        chkUnderwrite.Enabled = false;
                    }
                    else
                    {
                        chkUnderwrite.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
        }

        //显示会员
        private bool ShowCust()
        {
            string U_UserId = "";
            DBHelper db = null;
            db = new DBHelper();
            if(lvFitout.Items.Count<=0)
            {
                return false;
            }
            string sql = string.Format("select * from Guest where G_GuestId='{0}'", lvFitout.Items[0].SubItems[0].Text);
            SqlDataReader sdr = db.SelectAll(sql);
           
            if(sdr.Read())
            {
                U_UserId = sdr["U_UserId"].ToString();
            }

            if (U_UserId != "")
            {
                
                chkCust.Visible = true;
                chkCust.Checked = true;
                chkCust.Enabled = true;
                lblU_UserId.Visible = true;
                txtPass.Visible = true;
                lblU_UserId.Text = U_UserId;
                return true;
            }
            else
            {
                chkCust.Checked = false;
                chkCust.Enabled = false;

                return false;
            }
        }

        //双击在住客房表
        private void lvUptownHouse_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lviUptownHouse = new ListViewItem(lvUptownHouse.SelectedItems[0].SubItems[0].Text);
            lviUptownHouse.Tag = lvUptownHouse.SelectedItems[0].Tag;
            string[] str ={ lvUptownHouse.SelectedItems[0].SubItems[1].Text, lvUptownHouse.SelectedItems[0].SubItems[2].Text, lvUptownHouse.SelectedItems[0].SubItems[3].Text, lvUptownHouse.SelectedItems[0].SubItems[4].Text, lvUptownHouse.SelectedItems[0].SubItems[5].Text, lvUptownHouse.SelectedItems[0].SubItems[6].Text, lvUptownHouse.SelectedItems[0].SubItems[7].Text };
           
            lviUptownHouse.SubItems[0].Tag = lvUptownHouse.SelectedItems[0].SubItems[0].Tag;
           
            if (lvFitout.Items.Count > 0)
            {
                //MessageBox.Show(lvUptownHouse.SelectedItems[0].Tag + "\n" + lvFitout.Items[0].Tag+"   0");
                if (lvFitout.Items[0].SubItems[2].Text == lvUptownHouse.SelectedItems[0].SubItems[2].Text)
                {
                    string temp1 = lvUptownHouse.SelectedItems[0].Tag.ToString();
                    string temp2 = lvFitout.Items[0].Tag.ToString();
                    //MessageBox.Show(temp1+" "+temp2);
                    if (temp1 != temp2)
                    {
                        MessageBox.Show("不是同一客人，不能一起结账！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }                   
                }
                else
                {
                    MessageBox.Show("不是同一客人，不能一起结账！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            
            lviUptownHouse.SubItems.AddRange(str);
            lvFitout.Items.Add(lviUptownHouse);
            lvUptownHouse.SelectedItems[0].Remove();

          
            ShowWareInfo();
            CountMoney();
                 
        }

        //双击准备退房表
        private void lvFitout_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lviFitout = new ListViewItem(lvFitout.SelectedItems[0].Text);
            lviFitout.Tag = lvFitout.SelectedItems[0].Tag;
            string[] str ={ lvFitout.SelectedItems[0].SubItems[1].Text, lvFitout.SelectedItems[0].SubItems[2].Text, lvFitout.SelectedItems[0].SubItems[3].Text, lvFitout.SelectedItems[0].SubItems[4].Text, lvFitout.SelectedItems[0].SubItems[5].Text, lvFitout.SelectedItems[0].SubItems[6].Text, lvFitout.SelectedItems[0].SubItems[7].Text };
            
            lviFitout.SubItems[0].Tag = lvFitout.SelectedItems[0].SubItems[0].Tag;
            
            lviFitout.SubItems.AddRange(str);

            lvUptownHouse.Items.Add(lviFitout);
            lvFitout.SelectedItems[0].Remove();

            if (lvFitout.Items.Count <= 0)
            {
                lvConsume.Items.Clear();
            }
            ShowWareInfo();
            CountMoney();
        }

        //关闭按钮
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }        

        //查询全部或当天准备离店的客人
        private void rdoTodayGo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAll.Checked)
            {
                ShowHouseInfo(1);  
            }
            else
            {
                ShowHouseInfo(0);  
            }
        }

        //退房按钮
        private void btnOk_Click(object sender, EventArgs e)
        {
            if(chkUnderwrite.Checked)
            {
                Underwrite = true;
            }
            ExitHouse();
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



        //退房方法
        private void ExitHouse()
        {
           
            //判断是否签单
            if (!Underwrite&&chkCust.Checked==false)
            {
                if (txtSpare.Text == "")
                {
                    MessageBox.Show("金额不能为空！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //金额不足不能退房
                if (Convert.ToDouble(txtSpare.Text) < 0)
                {
                    MessageBox.Show("金额不足！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPaicl.SelectAll();
                    txtPaicl.Focus();
                    return;
                }
            }

            if (chkCust.Checked == false)
            {
                if(cboUnderwrite.Text==""&&chkUnderwrite.Checked==true)
                {
                    MessageBox.Show("签单单位不能为空！","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
            }

            if (!isHaveMoney() && chkUnderwrite.Checked == false && chkCust.Checked == true)
            {
                MessageBox.Show("会员余额不足本次消费！请充值！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (chkCust.Checked == true && txtPass.Text == "")
            {
                txtPass.Focus();
                return;
            }           
           
            //辅助类实例化
            HouseHelper hh = new HouseHelper();
           
            int rows = 0;    //受影响的行数
            DBHelper db = null;
            db = new DBHelper();
            string sql;
            
             //循环修改入住状态为空净
            for (int i = 0; i < lvFitout.Items.Count;i++ )
            {
                //获得房间的R_Id
                string R_id = lvFitout.Items[i].SubItems[0].Tag.ToString();
                string time = DateTime.Now.ToString();

                if (hh.IshaveBook(R_id))
                {
                    sql = string.Format("update Room set State ='{0}' where R_id='{1}'", "预订", R_id);
                }
                else
                {
                    sql = string.Format("update Room set State ='{0}' where R_id='{1}'", "整理", R_id);
                }

                //return;
                
                rows = db.UpdateDeleteAdd(sql);

                

                sql = string.Format("update Guest set faceDate = '{0}' where R_id = '{1}' and  (faceDate = '{2}' or faceDate is null)",time, R_id,"");
                db.UpdateDeleteAdd(sql);

                if (!Underwrite)
                {
                    //sql = string.Format("update Guest set Fact='{0}' where G_GuestId='{1}'", lblDeal.Text, lvFitout.Items[0].SubItems[0].Text);
                    //MessageBox.Show(sql);
                    //db.UpdateDeleteAdd(sql);

                    if(i==0)
                    {
                        AutoId ai = new AutoId();

                        string money = Convert.ToString(Convert.ToDouble(lblDeal.Text) * IsAwoke.discount);
                        
                        sql = string.Format("insert Consume values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                           ai.GetId("C_ConsumeId", "Consume"), lvFitout.Items[0].SubItems[0].Text, "房间消费", money.ToString(), 1, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "1", UserHelper.LoginId, ""
                            );
                        db.UpdateDeleteAdd(sql);
                    }
                }
                else
                {
                    AutoId ai = new AutoId();
                    string A_Id = ai.GetId("A_Id", "UnderwriteAnnal");
                    string Room_id = lvFitout.Items[i].SubItems[1].Text;
                    string G_GuestId = lvFitout.Items[i].SubItems[0].Text;
                    string Underwritestr = cboUnderwrite.Text;
                    string U_money = lvFitout.Items[i].SubItems[7].Text;
                    string State = "未付";
                    sql = string.Format("insert UnderwriteAnnal values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", A_Id, Room_id, G_GuestId, Underwritestr, U_money, 0, 0, 0, State, Room_id+"号房费");
                    db.UpdateDeleteAdd(sql);

                    if (i == 0)
                    {
                        sql = string.Format("update UnderwriteAnnal set U_money = U_money - '{0}' where G_GuestId='{1}'", Convert.ToDouble(lblYaJin.Text), G_GuestId);
                        db.UpdateDeleteAdd(sql);
                    }
                }
            }
            
            //如果是签单
            if (Underwrite)
            {
                for (int i = 0; i < lvConsume.Items.Count;i++ )
                {
                    AutoId ai = new AutoId();
                    string A_Id = ai.GetId("A_Id", "UnderwriteAnnal");
                    string Room_id = lvFitout.Items[0].SubItems[1].Text;
                    string G_GuestId = lvFitout.Items[0].SubItems[0].Text;
                    string Underwritestr = cboUnderwrite.Text;
                    string U_money = lvConsume.Items[i].SubItems[4].Text;
                    string State = "未付";
                    string Remark = lvConsume.Items[i].SubItems[0].Text;
                    sql = string.Format("insert UnderwriteAnnal values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", A_Id, Room_id, G_GuestId, Underwritestr, U_money, 0, 0, 0, State, Remark);
                    db.UpdateDeleteAdd(sql);  
                }                
            }

            //判断是否是会员
            if(chkCust.Checked)
            {
                db = new DBHelper();
                double score = Convert.ToDouble(lblDeal.Text) / 100;
                sql = string.Format("update Users set Score = Score + '{0}',U_money = U_money -'{1}' where U_UsersId='{2}' ", score,lblDeal.Text ,lblU_UserId.Text);
                db.UpdateDeleteAdd(sql);
            }


            if (rows > 0)
            {
                MessageBox.Show("退房成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("退房失败", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        //判断金钱是否足够
        private bool isHaveMoney()
        {
            double YinMoney = Convert.ToDouble(lblDeal.Text) * IsAwoke.discount;
            bool isOk = true;
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select U_money from Users where U_UsersId = '{0}'", lblU_UserId.Text);
                SqlDataReader sdr = db.SelectAll(sql);
                double money = 0;
                if (sdr.Read())
                {
                    money = Convert.ToDouble(sdr["U_money"].ToString());
                }
                sdr.Close();

                if(YinMoney>money)
                {
                    isOk = false;
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
            return isOk;
        }

        
        //控制只能输入数字，退格，小数点
        private void txtPaicl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                 btnOk_Click(null,null);
            }
        }

        //内容改变，计算找零
        private void txtPaicl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (lblDeal.Text != "")
                {
                    if (Convert.ToInt32(lblYaJin.Text) > Convert.ToInt32(lblDeal.Text))
                    {
                        txtSpare.Text = Convert.ToString(Convert.ToDouble(lblYaJin.Text) - Convert.ToDouble(lblDeal.Text)+ Convert.ToDouble(txtPaicl.Text));
                    }
                    else
                    {
                        txtSpare.Text = Convert.ToString(Convert.ToDouble(txtPaicl.Text) - (Convert.ToDouble(lblDeal.Text) - Convert.ToDouble(lblYaJin.Text)));
                    }
                }
            }
            catch
            {

            }           
        }

        //签单显示
        private void chkUnderwrite_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnderwrite.Checked)
            {
                chkCust.Enabled = false;
                cboUnderwrite.Enabled = true;     
           
                chkCust.Checked = false;

                lblDeal2.Enabled = false;
                lblDeal.Enabled = false;
                lblYaJin1.Enabled = false;
                lblYaJin.Enabled = false;
                lblPaicl.Enabled = false;
                txtPaicl.Enabled = false;
                lblSpare.Enabled = false;
                txtSpare.Enabled = false;
            }
            else
            {
                if (ShowCust())
                {
                    chkCust.Enabled = true;
                }
                cboUnderwrite.Enabled = false;

                lblDeal2.Enabled = true;
                lblDeal.Enabled = true;
                lblYaJin1.Enabled = true;
                lblYaJin.Enabled = true;
                lblPaicl.Enabled = true;
                txtPaicl.Enabled = true;
                lblSpare.Enabled = true;
                txtSpare.Enabled = true;  
            }
        }

        //显示全部客人
        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            lvFitout.Items.Clear();
        }

        //验证密码
        private void txtPass_Leave(object sender, EventArgs e)
        {            
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select count(*) from Users where U_UsersId='{0}' and Pass='{1}'", lblU_UserId.Text,txtPass.Text);
                //MessageBox.Show(sql);
                int count = (int)db.SelectOne(sql);               
                if (count <= 0 && txtPass.Text!="")
                {
                    DialogResult result = MessageBox.Show("密码错误！", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        txtPass.SelectAll();
                        txtPass.Focus();
                    }
                    else if(result==DialogResult.No)
                    {
                        chkCust.Checked = false;
                        txtPass.Text = "";
                        txtPaicl.Focus();
                    }
                } 
                if(txtPass.Text=="")
                {
                    chkCust.Checked = false;
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

        //判断是否会员
        private void chkCust_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCust.Checked == true)
            {
                lblU_UserId.Visible = true;
                txtPass.Visible = true;
                lbldiscount.Visible = true;
                lbldiscount2.Visible = true;

                chkUnderwrite.Enabled = false;

                lblDeal2.Enabled = false;
                lblDeal.Enabled = false;
                lblYaJin1.Enabled = false;
                lblYaJin.Enabled = false;
                lblPaicl.Enabled = false;
                txtPaicl.Enabled = false;
                lblSpare.Enabled = false;
                txtSpare.Enabled = false;
            }
            else
            {
                lblU_UserId.Visible = false;
                txtPass.Visible = false;
                lbldiscount.Visible = false;
                lbldiscount2.Visible = false;

                if (chkUnderwrite.Checked == false)
                {  
                    lblDeal2.Enabled = true;
                    lblDeal.Enabled = true;
                    lblYaJin1.Enabled = true;
                    lblYaJin.Enabled = true;
                    lblPaicl.Enabled = true;
                    txtPaicl.Enabled = true;
                    lblSpare.Enabled = true;
                    txtSpare.Enabled = true;
                }
                chkUnderwrite.Enabled = true;
            }
        }

        //根据房间号查询
        private void txtRoom_id_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvUptownHouse.Items.Count; i++)
            {
                lvUptownHouse.Items[i].ForeColor = Color.Black;
                lvUptownHouse.Items[i].BackColor = Color.White;
            }

            for (int i = 0; i < lvUptownHouse.Items.Count; i++)
            {
                if (lvUptownHouse.Items[i].SubItems[1].Text == txtRoom_id.Text)
                {
                    lvUptownHouse.Items[i].Selected = true;
                    lvUptownHouse.Items[i].ForeColor = Color.White;
                    lvUptownHouse.Items[i].BackColor = Color.Blue;
                    //lblroom.Text = lvDeposit.SelectedItems[0].SubItems[0].Text;
                    break;
                }
            }
        }

        //改变颜色
        private void lvUptownHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvUptownHouse.Items.Count; i++)
            {
                lvUptownHouse.Items[i].ForeColor = Color.Black;
                lvUptownHouse.Items[i].BackColor = Color.White;
            }                           
        }

        //如果是回车，选定文本框
        private void txtRoom_id_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(e.KeyChar==13)
           {
               txtRoom_id.SelectAll();
           }
        }

        //private void chkListBack_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkListBack.Checked == true)
        //    {
        //        chkUnderwrite.Checked = false;
        //        chkCust.Checked = false;
        //        chkUnderwrite.Enabled = false;
        //        chkCust.Enabled = false;

        //        lblDeal2.Enabled = false;
        //        lblDeal.Enabled = false;
        //        lblYaJin1.Enabled = false;
        //        lblYaJin.Enabled = false;
        //        lblPaicl.Enabled = false;
        //        txtPaicl.Enabled = false;
        //        lblSpare.Enabled = false;
        //        txtSpare.Enabled = false;
        //    }
        //    else
        //    {
        //        //chkUnderwrite.Checked = true;
        //        //chkCust.Checked = true;
        //        chkUnderwrite.Enabled = true;
        //        chkCust.Enabled = true;

        //        lblDeal2.Enabled = true;
        //        lblDeal.Enabled = true;
        //        lblYaJin1.Enabled = true;
        //        lblYaJin.Enabled = true;
        //        lblPaicl.Enabled = true;
        //        txtPaicl.Enabled = true;
        //        lblSpare.Enabled = true;
        //        txtSpare.Enabled = true;
        //    }
        //}          
    }
}