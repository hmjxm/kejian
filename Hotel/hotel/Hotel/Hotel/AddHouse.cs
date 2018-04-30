using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
//download by http://www.codefans.net
namespace Hotel
{
    public partial class AddHouse : Form
    {
        
        public SameName sn = new SameName(0);　　//判断是否有同名类
        HouseHelper hh = new HouseHelper();　　　　//辅助类
        string picName;　　　　　　　　　　　　　//图片名称
        public AddHouse()　　　　　　　　
        {
            InitializeComponent();
        }        

        //添加图片，
        private void chkloadCertificate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkloadCertificate.Checked)
            {
                try
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "jpg格式(*.jpg)|*.jpg|bmp格式(*.bmp)|*.bmp";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string name = ofd.FileName;
                        picName = name.Substring(name.LastIndexOf("\\") + 1);
                        //bin目录
                        string extendName = picName.Substring(picName.LastIndexOf(".") + 1);
                        if (extendName != "jpg" && extendName != "bmp")
                        {
                            MessageBox.Show("图片格式只能是.jpg或.bmp");
                            return;
                        }
                        string workBin = Application.StartupPath;
                        workBin = workBin + picName;
                        //复制到bin目录                
                        File.Copy(picName, workBin);
                        picCertificate.ImageLocation = picName;
                        picCertificate.Visible = true;
                    }
                    else
                    {
                        chkloadCertificate.Checked = false;
                    }
                }
                catch
                {

                }
            }
            else
            {
                picCertificate.Visible = false;
            }
        }

       

        //窗体加载事件
        private void AddHouse_Load(object sender, EventArgs e)
        {
            dtpComeDate.Enabled = false;
            sn.ah = this;
            ShowTime();            
            Showhollow(0);
            cboHouseType.Text = "标准单人间";
        }               

        //显示预离时间
        private void ShowTime()
        {            
            //string temp = DateTime.Now.AddDays(1).ToString().Substring(0,dtpBookleave.Text.LastIndexOf(":")-3)+" 12:00";            
            string temp = DateTime.Now.AddDays(1).ToShortDateString() + " 12:00";           
            dtpBookleave.Text = temp;            
        }

        //显示可供房间信息
        private void Showhollow(int type)
        {
            lvHollowHouse.Items.Clear();
            string R_RoomId;
            string RoomTypeId;
            double price;
            DBHelper db = null;
            string sql = "";
            try
            {
                db = new DBHelper();

                type++;
                sql = string.Format("select * from Room where (State='{0}') and RoomType='{1}'", "空净",type);
                
                
               
                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    R_RoomId = sdr["R_RoomId"].ToString();
                    RoomTypeId = sdr["RoomType"].ToString();
                    price = Convert.ToDouble(sdr["price"]);

                    HouseHelper hh=new HouseHelper();
                    RoomTypeId = hh.GetHouseType(sdr["RoomType"].ToString());
               
                    ListViewItem lviHouse = new ListViewItem(R_RoomId);

                    lviHouse.Tag = sdr["R_id"].ToString();
                    lviHouse.SubItems[0].Tag = sdr["State"].ToString();;
                    string[] strHouse ={RoomTypeId,price.ToString()};
                    lviHouse.SubItems.AddRange(strHouse);
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
       

        //双击可供房间事件
        private void lvHollowHouse_DoubleClick(object sender, EventArgs e)
        {
            if (lvHollowHouse.SelectedItems.Count >= 1)
            { 
                //创建一个listView项
                ListViewItem lviHouse = new ListViewItem(lvHollowHouse.SelectedItems[0].Text);
                lviHouse.Tag = lvHollowHouse.SelectedItems[0].Tag;

                lviHouse.SubItems[0].Tag = lvHollowHouse.SelectedItems[0].SubItems[0].Tag.ToString();
                //判断是否是预订，如果是，则再判断是否在这个时间段
                if (lvHollowHouse.SelectedItems[0].SubItems[0].Tag.ToString() == "预订")
                {
                    HouseHelper hh = new HouseHelper();
                    if (hh.ValidateIsBook(lvHollowHouse.SelectedItems[0].Text, dtpComeDate.Text))
                    {

                    }
                    else
                    {
                        MessageBox.Show("此房间这个时间段，已经预订", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                //创建数组 将选中项的子项存在数中
                string[] strTemp ={ lvHollowHouse.SelectedItems[0].SubItems[1].Text, lvHollowHouse.SelectedItems[0].SubItems[2].Text }; 
                //添加子项
                lviHouse.SubItems.AddRange(strTemp);
                //添加到入住客房中
                lvSelectHouse.Items.Add(lviHouse);

                
                //移出已经存在的
                lvHollowHouse.Items.Remove(lvHollowHouse.SelectedItems[0]); 
            }            
        }



        //双击已选房间事件
        private void lvSelectHouse_DoubleClick(object sender, EventArgs e)
        {
            //创建一个listView项
            ListViewItem lviHouse = new ListViewItem(lvSelectHouse.SelectedItems[0].Text);
            lviHouse.Tag = (lvSelectHouse.SelectedItems[0].Tag).ToString();
            lviHouse.SubItems[0].Tag = lvSelectHouse.SelectedItems[0].SubItems[0].Tag.ToString();
            //创建数组 将选中项的子项存在数中
            string[] strTemp ={ lvSelectHouse.SelectedItems[0].SubItems[1].Text, lvSelectHouse.SelectedItems[0].SubItems[2].Text };
            //添加子项
            lviHouse.SubItems.AddRange(strTemp);
            //添加到空客房中
            lvHollowHouse.Items.Add(lviHouse);
            //移除已经选中记录
            lvSelectHouse.Items.Remove(lvSelectHouse.SelectedItems[0]);            
        }

        //关闭
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////入住酒店
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                if (lvSelectHouse.Items.Count == 0)
                {
                    MessageBox.Show("您没选任何房间！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    House();
                }
            }
        }

        //入住酒店
        private void House()
        {
            
            int count=lvSelectHouse.Items.Count;
            if(IsAwoke.foregiftSmall=="1")
            {
                double money=0;
                for (int i = 0; i < count;i++ )
                {
                    money += Convert.ToDouble(lvSelectHouse.Items[i].SubItems[2].Text);
                }
                if (Convert.ToDouble(txtAdvanceForegift.Text) < money && txtCust.Text=="")
                {
                    MessageBox.Show("押金小于房款！","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtAdvanceForegift.Focus();
                    txtAdvanceForegift.SelectAll();
                    return;
                }
            }
            int rows=0;
           
            
            for(int i=0;i<count;i++)
            {
                AutoId auto = new AutoId();
                
                string G_GuestId= auto.GetId("G_GuestId","Guest");
                //MessageBox.Show(G_GuestId);    
                string Room_id = lvSelectHouse.Items[i].SubItems[0].Text;

                string R_id = lvSelectHouse.Items[i].Tag.ToString();               
                
                string uName = txtName.Text;
                string sex = "";
                if (rdoMan.Checked)
                {
                    sex = "男";
                }
                else
                {
                    sex = "女";
                }

                string CertificateType = cboCertificate.Text;
                string CertificateID = txtCertificateId.Text;
                string CertificatePic = picName;
                string Address = txtAddress.Text;
                string contactTel = txtContactTel.Text;                
                string Underwrite = "";
                string comeDate = dtpComeDate.Text;
                string Bookleave = dtpBookleave.Text;
                string faceDate = "";
                string R_price = lvSelectHouse.Items[i].SubItems[2].Text;
                string Due = "";
                string Fact = "";
                string locate = "";
                string Operator = UserHelper.LoginId;
                string remark = txtRemark.Text;
                string U_UserId = txtCust.Text;

                string sql = string.Format("insert into Guest values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}')",
                    G_GuestId, R_id, U_UserId, uName, sex, CertificateType, CertificateID, CertificatePic, Address, contactTel, 0, Underwrite,
                    comeDate, Bookleave,faceDate, R_price, Due, Fact, locate, Operator, remark
                    );
                DBHelper db = null;                

                try
                {
                    db = new DBHelper();
                    rows = db.UpdateDeleteAdd(sql);

                    sql = string.Format("update Room set State='{0}', R_Count = R_Count + '{2}'  where R_id ='{1}'", "待客", R_id,1);
                    //MessageBox.Show(sql);
                    int temp = db.UpdateDeleteAdd(sql);

                    if(cboIsAwoke.Checked)
                    {
                        sql = string.Format("insert into Awoke values('{0}','{1}','{2}','{3}','{4}')",
                       auto.GetId("A_AwokeId", "Awoke"), lvSelectHouse.Items[i].SubItems[0].Text + "号房到期", "未读", dtpBookleave.Text, txtRemark.Text
                       );
                        db.UpdateDeleteAdd(sql);
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
            HouseHelper Uhh = new HouseHelper();

            string URoom_id = lvSelectHouse.Items[0].SubItems[0].Text;

            string R_id2= Uhh.GetR_id(lvSelectHouse.Items[0].Text);

            DBHelper Udb = null;
            string Usql = string.Format("update Guest set AdvanceForegift='{0}' where R_id='{1}'", txtAdvanceForegift.Text, R_id2);
            Udb = new DBHelper();
            Udb.UpdateDeleteAdd(Usql);

            if (rows > 0)
            {
                MessageBox.Show("入住成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("入住失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }       
       
        //验证输入
        private bool ValidateInput()
        {
            bool isOk = true;
            if(txtName.Text=="")
            {
                txtName.BackColor = Color.Red;
                txtName.Focus();
                isOk= false;
            }            
            if (txtAdvanceForegift.Text == "")
            {
                txtAdvanceForegift.BackColor = Color.Red;
                txtAdvanceForegift.Focus();
                isOk= false;
            }
            if(txtCertificateId.Text=="")
            {
                txtCertificateId.BackColor = Color.Red;
                txtCertificateId.Focus();
                isOk = false;
            }
            if (DateTime.Compare(Convert.ToDateTime(dtpComeDate.Text),Convert.ToDateTime(dtpBookleave.Text))>0)
            {
                 MessageBox.Show("入住时间不能小于预离时间");
            }
            
            return isOk;           
        }

        //改变文本框内容将“不能为空”设为隐藏
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
            isSN = false;
        }

        //改变文本框内容将“不能为空”设为隐藏
        private void txtAdvanceForegift_TextChanged(object sender, EventArgs e)
        {      
            txtAdvanceForegift.BackColor = Color.White;
        }

        //控制只能输入数字和小数点
        private void txtAdvanceForegift_KeyPress(object sender, KeyPressEventArgs e)
        {
            //8为空格，13为回车，IsDigit为十进数
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }            
        }

        //文本框内容改变事件
        private void txtCertificateId_TextChanged(object sender, EventArgs e)
        {
            //将"不能为空设为隐藏"
            txtCertificateId.BackColor = Color.White;


        }

        bool isSN = false;//判断是否有同名
        //名字文本框失去焦点事件        
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (isSN == false)
            {
                isSameName(txtName.Text);
            }            
        }       

        //房间类型改变
        private void cboHouseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Showhollow(cboHouseType.SelectedIndex);
            lvSelectHouse.Items.Clear();
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
        

        private void txtCust_Leave(object sender, EventArgs e)
        {
            if (txtCust.Text.Trim() != "" && UserHelper.isValidate == false)
            {
                ValidatePass vdp = new ValidatePass(this.txtCust.Text, 0);
                vdp.ah = this;
                vdp.ShowDialog();
                isSN = true;
                txtAdvanceForegift.Text = "0";
                //txtAdvanceForegift.Enabled = false;
            }
        }

        //会员框改变时
        private void txtCust_TextChanged(object sender, EventArgs e)
        {
            UserHelper.isValidate = false;
            txtAdvanceForegift.Enabled = true;
        }

        //时间入住控件　关闭事件
        private void dtpComeDate_CloseUp(object sender, EventArgs e)
        {
            DateTime dateone = Convert.ToDateTime(dtpComeDate.Text.Substring(0,10));
           
            if (dateone < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
            {
                MessageBox.Show("入住时间不得小于当前时刻");
                dtpComeDate.Text = DateTime.Now.ToString();
                return;
            }
        }
        //时间预离时间控件　关闭事件
        private void dtpBookleave_CloseUp(object sender, EventArgs e)
        {
            string comedate = dtpComeDate.Text;
            string bookleave = dtpBookleave.Text;
            if (Convert.ToDateTime(comedate.Substring(0,10)) > Convert.ToDateTime(bookleave.Substring(0,10)))
            {
                MessageBox.Show("预离时间必须大于入住时间");
                dtpBookleave.Text = DateTime.Now.AddDays(1).ToShortDateString() + " 12:00:00";
                return;
            }
        }

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