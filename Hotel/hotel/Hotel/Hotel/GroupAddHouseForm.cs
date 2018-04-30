using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Hotel
{
    public partial class GroupAddHouseForm : Form
    {
        private string picName = "";   //图片名称
        SameName sn = new SameName(1);
        HouseHelper hh = new HouseHelper();
        public GroupAddHouseForm()
        {
            InitializeComponent();
        }

        //加载事件
        private void GroupAddHouseForm_Load(object sender, EventArgs e)
        {
            dtpComeDate.Enabled = false;
            sn.gh = this;
            ShowTime();           
            ShowTreeHouse();           
        }

        


        //显示预离时间
        private void ShowTime()
        {
            string temp = DateTime.Now.AddDays(1).ToString().Substring(0, dtpBookleave.Text.LastIndexOf(":") - 3) + " 12:00";

            dtpBookleave.Text = temp;
        }

        //显示房间信息
        private void ShowTreeHouse()
        {
            DBHelper db = null;
            try
            {
                string sql = string.Format("select * from RoomType");
                db = new DBHelper();
                SqlDataReader sdr = db.SelectAll(sql);
                string type;
                while (sdr.Read())
                {
                    type = sdr["R_Type"].ToString();
                    TreeNode node = new TreeNode(type);
                    node.Tag = (int)sdr["R_RoomId"];
                    

                    sql = string.Format("select * from Room where RoomType='{0}' and State='{1}'", node.Tag, "空净");
                    DBHelper db2 = new DBHelper();
                    SqlDataReader sdr2 = db2.SelectAll(sql);
                    string room_id;

                    while (sdr2.Read())
                    {
                        room_id = sdr2["R_RoomId"].ToString();
                        TreeNode node2 = new TreeNode(room_id);
                        
                        node2.Tag = sdr2["R_id"].ToString();
                        //MessageBox.Show(node.Tag.ToString());
                        node.Nodes.Add(node2);
                    }
                    sdr2.Close();

                    tvHouse.Nodes.Add(node);
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

        

        //双击树控件
        private void tvHouse_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string temp = tvHouse.SelectedNode.Text;
                FillDate(temp);

                if (lvNeedHouse.Items.Count > 0)
                {
                    dtpComeDate.Enabled = false;
                }
                else
                {
                    dtpComeDate.Enabled = true;
                }
                         
            }
            catch
            {
 
            }
        }

        //填充数据
        private  void FillDate(string RoomId)
        {
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from Room where R_RoomId='{0}'", RoomId);
                SqlDataReader sdr = db.SelectAll(sql);
                string type;
                
                double price;

                if (sdr.Read())
                {
                    HouseHelper hh = new HouseHelper();
                    type = hh.GetHouseType( sdr["RoomType"].ToString());                   
                    price = Convert.ToDouble(sdr["price"]);
                    ListViewItem lviHosue = new ListViewItem(RoomId);
                    
                    //if (sdr["State"].ToString()=="预订")
                    //{
                    //    if (hh.ValidateIsBook(tvHouse.SelectedNode.Text, dtpComeDate.Text))
                    //    {

                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("此房间这个时间段，已经预订", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        return;
                    //    }
                    //}
                         

                    string[] str ={ type, price.ToString() };
                    lviHosue.Tag = tvHouse.SelectedNode.Tag;
                    

                    lviHosue.SubItems.AddRange(str);
                    lvNeedHouse.Items.Add(lviHosue);
                    txtMainHouse.Text = lvNeedHouse.Items[0].SubItems[0].Text;

                    this.tvHouse.SelectedNode.Remove();
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

        //关闭按钮
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //双击已选ListView
        private void lvNeedHouse_DoubleClick(object sender, EventArgs e)
        {
            string temp = this.lvNeedHouse.SelectedItems[0].SubItems[1].Text ;
            string Room_id = this.lvNeedHouse.SelectedItems[0].SubItems[0].Text;
            //MessageBox.Show(temp);
            int index=0;
            if(temp=="标准单人间")
            {
                index = 0;
            }
            else if (temp == "标准双人间")
            {
                index = 1;
            }
            else if(temp=="豪华单人间")
            {
                index = 2;
            }
            else if (temp == "豪华双人间")
            {
                index = 3;
            }
            else if (temp == "商务套房")
            {
                index = 4;
            }
            else if (temp == "总统套房")
            {
                index = 5;
            }
            else if (temp == "会议厅")
            {
                index = 6;
            }

            //传树的下标
            AddHouse(index, Room_id);            
        }

        //添加方法
        private void AddHouse(int index,string str)
        {
            //根据传过来的值,添加树
            TreeNode node = new TreeNode(str);
            tvHouse.Nodes[index].Nodes.Add(node);
            lvNeedHouse.SelectedItems[0].Remove();
            

            //如果已选客房中有数据,则入住时间为不可修改
            if (lvNeedHouse.Items.Count > 0)
            {
                dtpComeDate.Enabled = false;
            }
            else
            {
                dtpComeDate.Enabled = true;
            }
        }
      
       
        //OK按钮
        private void btnTransact_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }
            if(lvNeedHouse.Items.Count<=0)
            {
                MessageBox.Show("您没选任何房间！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            HouseHelper hh=new HouseHelper();
            AutoId auto = new AutoId();
            int count = lvNeedHouse.Items.Count;
            
            string room_id;
            string type;
            string r_type;
            double R_price;
            int rows=0;
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                if (IsAwoke.foregiftSmall == "1")
                {
                    double money = 0;
                    for (int i = 0; i < count; i++)
                    {
                        money += Convert.ToDouble(lvNeedHouse.Items[i].SubItems[2].Text);
                    }
                    if (Convert.ToDouble(txtAdvanceForegift.Text) < money && txtCust.Text == "")
                    {
                        MessageBox.Show("押金小于房款！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }


                for (int i = 0; i < count; i++)
                {
                    

                    string G_GuestId = auto.GetId("G_GuestId", "Guest");
                    room_id = lvNeedHouse.Items[i].SubItems[0].Text;
                    type = lvNeedHouse.Items[i].SubItems[1].Text;
                    r_type = lvNeedHouse.Items[i].SubItems[2].Text;
                    R_price = Convert.ToDouble(lvNeedHouse.Items[i].SubItems[2].Text);

                    string R_id = hh.GetR_id(room_id);
                    
                    string cust = txtCust.Text;
                    string Uname = txtName.Text;
                    string sex = rdoMan.Checked ? "南" : "女";
                    string CertificateType = cboCertificate.Text;
                    string CertificateID = txtCertificateId.Text;
                    string Address = txtAddress.Text;
                    string contactTel = txtContactTel.Text;
                    string AdvanceForegift = txtAdvanceForegift.Text;
                    string Underwrite = "";
                    string comeDate = dtpComeDate.Text;
                    string Bookleave = dtpBookleave.Text;
                    string faceDate="";
                    string Due = "";
                    string Fact = "";
                    string locate = "";
                    string Operator = UserHelper.LoginId;
                    string remark = txtRemark.Text;

                    string sql = string.Format("insert into Guest values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}')",
                        G_GuestId, R_id,cust, Uname, sex, CertificateType, CertificateID, picName, Address, contactTel, 0, Underwrite, comeDate, Bookleave, faceDate,R_price, Due, Fact, locate, Operator, remark
                     );

                    
                    rows = db.UpdateDeleteAdd(sql);                    

                    sql = string.Format("update Room set State='{0}', R_Count = R_Count + '{2}'  where R_id ='{1}'", "待客", R_id, 1);
                   
                    db.UpdateDeleteAdd(sql);


                    if (cboIsAwoke.Checked)
                    {
                        sql = string.Format("insert into Awoke values('{0}','{1}','{2}','{3}','{4}')",
                       auto.GetId("A_AwokeId", "Awoke"), lvNeedHouse.Items[i].SubItems[0].Text + "号房到期", "未读", dtpBookleave.Text, txtRemark.Text
                       );
                        db.UpdateDeleteAdd(sql);
                    }
                }

                

                HouseHelper Uhh = new HouseHelper();
                string URoom_id = txtMainHouse.Text;

                string UR_id = lvNeedHouse.Items[0].Tag.ToString(); 

                DBHelper Udb = null;
                string Usql = string.Format("update Guest set AdvanceForegift='{0}' where R_id='{1}'", txtAdvanceForegift.Text, UR_id);
                Udb = new DBHelper();
                Udb.UpdateDeleteAdd(Usql);

                if (rows > 0)
                {
                    MessageBox.Show("入住成功！","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
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

        private bool ValidateInput()
        {
            bool isOk = true ;
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

        //加载证件
        private void chkloadCertificate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkloadCertificate.Checked)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = ("图片(*.jpg)|*.jpg|图片(*.bmp)|*.bmp|图片(*.gif)|*.gif");
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string name = ofd.FileName;
                    picName = name.Substring(name.LastIndexOf("\\") + 1);
                    string workBin = Application.StartupPath;
                    workBin = workBin + picName;

                    File.Copy(picName, workBin);
                    picCertificate.ImageLocation = picName;
                    picCertificate.Visible = true;
                }
                else
                {
                    chkloadCertificate.Checked = false;
                }
            }
            else
            {
                picCertificate.Visible = false;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
            isSN = false;
        }

        private void txtCertificateId_TextChanged(object sender, EventArgs e)
        {
            txtCertificateId.BackColor = Color.White;
        }

        private void txtAdvanceForegift_TextChanged(object sender, EventArgs e)
        {
            txtAdvanceForegift.BackColor = Color.White;
        }

        private void txtAdvanceForegift_KeyPress(object sender, KeyPressEventArgs e)
        {
            //8为空格，13为回车，IsDigit为十进数
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }         
        }

        bool isSN = false;//判断是否有同名
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (isSN == false)
            {
                isSameName(txtName.Text);
            }
        }

        public void isSameName(string name)
        {
            if (IsAwoke.sameName == "0")
            {
                return;
            }
            sn.lvSameName.Items.Clear();
            string UserId = "";
            string Uname = "";
            string Sex = "";
            string CertificateType = "";
            string CertificateID = "";
            string Address = "";
            string contactTel = "";

            bool isFind = false;

            DBHelper db = null;
            try
            {
                db = new DBHelper();
                //查找历史记录相同的客户
                string sql = string.Format("select distinct U_UserId,Uname,Sex,CertificateType,CertificateID,Address,contactTel from Guest where Uname='{0}'", name);

                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    UserId = sdr["U_UserId"].ToString();
                    Uname = sdr["Uname"].ToString();
                    Sex = sdr["Sex"].ToString();
                    CertificateType = sdr["CertificateType"].ToString();
                    CertificateID = sdr["CertificateID"].ToString();
                    Address = sdr["Address"].ToString();
                    contactTel = sdr["contactTel"].ToString();

                    ListViewItem lviSameName = new ListViewItem(UserId);
                    string[] str ={ Uname, Sex, CertificateType, CertificateID, Address, contactTel };
                    lviSameName.SubItems.AddRange(str);
                    sn.lvSameName.Items.Add(lviSameName);
                    isFind = true;
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
            if (isFind)
            {
                //如果找到了,则显示提示框
                sn.ShowDialog();
                isSN = true;
                txtAdvanceForegift.Focus();
            }
        }
       
        //当移出文框时事件 验证密码用
        private void txtCust_Leave(object sender, EventArgs e)
        {
            if (txtCust.Text.Trim() != "" && UserHelper.isValidate == false)
            {
                ValidatePass vdp = new ValidatePass(this.txtCust.Text, 1);
                vdp.ga = this;
                vdp.ShowDialog();
                isSN = true;
                txtAdvanceForegift.Focus();
            }
        }

        //当值改变时把 是否验证改为false
        private void txtCust_TextChanged(object sender, EventArgs e)
        {
            UserHelper.isValidate = false;
        }

        //判断时间
        private void dtpComeDate_CloseUp(object sender, EventArgs e)
        {

            DateTime dateone = Convert.ToDateTime(dtpComeDate.Text.Substring(0, 10));

            if (dateone < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
            {
                MessageBox.Show("入住时间不得小于当前时刻");
                dtpComeDate.Text = DateTime.Now.ToString();
                return;
            }
        }

        //判断时间
        private void dtpBookleave_CloseUp(object sender, EventArgs e)
        {
            string comedate = dtpComeDate.Text;
            string bookleave = dtpBookleave.Text;
            if (Convert.ToDateTime(comedate.Substring(0, 10)) > Convert.ToDateTime(bookleave.Substring(0, 10)))
            {
                MessageBox.Show("预离时间必须大于入住时间");
                dtpBookleave.Text = DateTime.Now.AddDays(1).ToShortDateString() + " 12:00:00";
                return;
            }
        }

        //身份证只能是18位
        private void txtCertificateId_Leave(object sender, EventArgs e)
        {
            if (cboCertificate.Text == "身份证")
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