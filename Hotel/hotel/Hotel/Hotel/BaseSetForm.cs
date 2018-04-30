using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace Hotel
{
    public partial class BaseSetForm : Form
    {
        int type;
        int page=1;
        int pages;
        HouseHelper hh = new HouseHelper();
        public BaseSetForm(int type)
        {
            this.type = type;
            InitializeComponent();
        }

        private void BaseSetForm_Load(object sender, EventArgs e)
        {           
           
            if(type!=0)
            {
                this.tcBaseSet.SelectedIndex = 2;
            }

           // ValidatePurview();

            ShowHouse("0");            
            ShowUnderwrite();
            ShowL_LoginLogId();
            ValidatePurview();
        }

        int Ispurview = 5;
        int SysSet;

        int HAdd;
        int HUpdate;
        int HDelete;

        int EAdd;
        int EUpdate;
        int EDelete;

        int AAdd;
        int AUpdate;
        int ADelete;

        int UAdd;
        int UUpdate;
        int UDelete;

        int LLook;
        int LDelete;

        private void ValidatePurview()
        { 
            DBHelper db = null;
            db = new DBHelper();
            string sql = string.Format("select * from purview where Admin='{0}'",UserHelper.LoginId);
            SqlDataReader sdr = db.SelectAll(sql);
            
            while(sdr.Read())
            {
                Ispurview = Convert.ToInt32(sdr["Ispurview"]);
                SysSet = Convert.ToInt32(sdr["SysSet"]);

                HAdd = Convert.ToInt32(sdr["SysSet"]);
                HUpdate = Convert.ToInt32(sdr["HUpdate"]);
                HDelete = Convert.ToInt32(sdr["HDelete"]);

                EAdd = Convert.ToInt32(sdr["EAdd"]);
                EUpdate = Convert.ToInt32(sdr["EUpdate"]);
                EDelete = Convert.ToInt32(sdr["EDelete"]);

                AAdd =Convert.ToInt32(sdr["AAdd"]);
                AUpdate = Convert.ToInt32(sdr["AUpdate"]);
                ADelete =Convert.ToInt32(sdr["ADelete"]) ;

                UAdd = Convert.ToInt32(sdr["UAdd"]) ;
                UUpdate = Convert.ToInt32(sdr["UUpdate"]);
                UDelete =Convert.ToInt32(sdr["UDelete"]) ;

                LLook = Convert.ToInt32(sdr["LLook"]) ;
                LDelete = Convert.ToInt32(sdr["LDelete"]);
            }
            house();
            Cust();
            Awoke();
            Underwrite();
            LoginLog();

        }

        //根据根据来判断是否显示选项卡
        private void LoginLog()
        {
            if (LLook == 1)
            {
                
            }
            else
            {
                tcBaseSet.TabPages.RemoveAt(4);
            }
            if (LDelete == 1)
            {
                tsbtnDeleteLoginLog.Visible = true;
            }
            else
            {
                tsbtnDeleteLoginLog.Visible = false;
            }
        }

        //显示签单
        private void Underwrite()
        {
            //如果是１则显示按钮
            if (UAdd == 1)
            {
                tsbtnAddUnderwrite.Visible = true;
            }
            else
            {
                tsbtnAddUnderwrite.Visible = false;
            }

            if (UUpdate == 1)
            {
                tsbtnUpdateUnderwrite.Visible = true;
            }
            else
            {
                tsbtnUpdateUnderwrite.Visible = false;
            }

            if (UDelete == 1)
            {
                 tsbtnDeleteUnderwrite.Visible = true;
            }
            else
            {
                tsbtnDeleteUnderwrite.Visible = false;
            }
        }

        //提醒界面按钮显示

        private void Awoke()
        {
            if (AAdd == 1)
            {
                tsbtnAddAwoke.Visible = true;
            }
            else
            {
                tsbtnAddAwoke.Visible = false;
            }

            if (AUpdate == 1)
            {
                tsbtnUpdateAwoke.Visible = true;
            }
            else
            {
                tsbtnUpdateAwoke.Visible = false;
            }

            if (ADelete == 1)
            {
                tsbtnDeleteAwoke.Visible = true;
            }
            else
            {
                tsbtnDeleteAwoke.Visible = false;
            }
        }

        //会员界面按钮显示
        private void Cust()
        {
            if (EAdd == 1)
            {
                tsbtnAddCust.Visible = true;
            }
            else
            {
                tsbtnAddCust.Visible = false;
            }

            if (EUpdate == 1)
            {
                tsbtnUpdateCust.Visible = true;
            }
            else
            {
                tsbtnUpdateCust.Visible = false;
            }

            if (EDelete == 1)
            {
                tsBtnDeleteCust.Visible = true;
            }
            else
            {
                tsBtnDeleteCust.Visible = false;
            }
        }

        //房源界面按钮显示
        private void house()
        {
          //  MessageBox.Show(Ispurview.ToString());
            if (Ispurview == 1)
            {
                tsbtnIspurview.Visible = true;
            }
            else
            {
                tsbtnIspurview.Visible = false;
            }

            if (HAdd == 1)
            {
                tsbtnAddHouse.Visible = true;
            }
            else
            {
                tsbtnAddHouse.Visible = false;
            }

            if (HUpdate == 1)
            {
                tsbtnUpdateHouse.Visible = true;
            }
            else
            {
                tsbtnUpdateHouse.Visible = false;
            }


            if (HDelete == 1)
            {
                tsbtnDeleteHouse.Visible = true;
            }
            else
            {
                tsbtnDeleteHouse.Visible = false;
            }

        }

        //显赫日志 
        private void ShowL_LoginLogId()
        {
            lvLoginLog.Items.Clear();
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from LoginLog");
                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    ListViewItem lviLoginLog = new ListViewItem(sdr["L_LoginLogId"].ToString());
                    string[] str ={ sdr["L_AdminId"].ToString(), sdr["LoginDate"].ToString(), sdr["LeaveDate"].ToString()};
                    lviLoginLog.SubItems.AddRange(str);
                    lvLoginLog.Items.Add(lviLoginLog);
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

        //显示签单
        private void ShowUnderwrite()
        {
            lvUnderwrite.Items.Clear();
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from Underwrite");
                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    ListViewItem lviUnderwrite = new ListViewItem(sdr["U_Id"].ToString());
                    string[] str ={ sdr["Underwrite"].ToString(), sdr["Remark"].ToString() };
                    lviUnderwrite.SubItems.AddRange(str);
                    lvUnderwrite.Items.Add(lviUnderwrite);
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

        //根据类型显示房源信息
        public void ShowHouse(string type)
        {
            lvHouse.Items.Clear();
            string R_RoomId;
            string State;
            string Floot;
            string RoomType;
            string price;
            string R_Count;
            string fixing;
            string sql = "";

            DBHelper db = null;
            try
            {
                db = new DBHelper();

                if (type == "0"||type=="全部")
                {
                    sql = string.Format("select * from Room");
                }
                else if (type == "1" || type == "2" || type == "3" || type == "4" || type == "5" || type == "6")
                {
                    sql = string.Format("select * from Room where RoomType='{0}'", type);
                }
                else
                {
                    sql = string.Format("select * from Room where State='{0}'", type);
                }
                
                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    R_RoomId = sdr["R_RoomId"].ToString();
                    State = sdr["State"].ToString();
                    Floot = sdr["Floot"].ToString();
                    RoomType = hh.GetHouseType(sdr["RoomType"].ToString());      
                    price = sdr["price"].ToString();
                    R_Count = sdr["R_Count"].ToString();
                    fixing = sdr["fixing"].ToString();

                    ListViewItem lviHouse = new ListViewItem(R_RoomId);
                    string[] str ={ State, Floot, RoomType, price, R_Count, fixing };
                    lviHouse.SubItems.AddRange(str);
                    lvHouse.Items.Add(lviHouse);
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

        //添加房子按钮
        private void tsbtnAddHouse_Click(object sender, EventArgs e)
        {
            AddHouseForm ahf = new AddHouseForm("");
            ahf.ShowDialog();
        }

        //修改房子按钮
        private void tsbtnUpdate_Click(object sender, EventArgs e)
        {
            if (lvHouse.SelectedItems.Count <= 0)
            {
                return;
            }

            AddHouseForm ahf = new AddHouseForm(lvHouse.SelectedItems[0].SubItems[0].Text);
            ahf.ShowDialog();
        }

        //删除房子按钮
        private void tsbtnDeleteHouse_Click(object sender, EventArgs e)
        {
            if(lvHouse.SelectedItems.Count <= 0)
            {
                return;
            }
            if (lvHouse.SelectedItems[0].SubItems[1].Text!="空净")
            {
                MessageBox.Show("此房间状态为非空净！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string Room_id = lvHouse.SelectedItems[0].SubItems[0].Text;
            DialogResult result = MessageBox.Show("是否删除"+Room_id,"删除提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                DBHelper db = null;
                try
                {
                    db = new DBHelper();
                    string sql = string.Format("delete Room where R_RoomId='{0}'",Room_id);
                    if (db.UpdateDeleteAdd(sql) > 0)
                    {
                        //MessageBox.Show("删除成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("删除失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    db.GetClose();
                    ShowHouse("0");
                }
            }
        }

        //窗体激活，更新数据
        private void BaseSetForm_Activated(object sender, EventArgs e)
        {
            ShowHouse("0");
            ShowCboPages();
            ShowEmp();           
            ShowUnderwrite();
            ShowL_LoginLogId();
        }       

        //分页功能 
        private void ShowCboPages()
        {
            cboPage.Items.Clear();
            DBHelper db = null;
            db = new DBHelper();
            string sql = string.Format("select count(*) from Awoke");
            pages = (int)db.SelectOne(sql);
            if (pages % 10 == 0)
            {
                page = pages / 10;
            }
            else
            {
                page = pages / 10 + 1;
            }
            for (int i = 1; i <= page; i++)
            {
                cboPage.Items.Add(i);
            }
        }

        //关闭
        private void tsbtnExitHouse_Click(object sender, EventArgs e)
        {
            Close();
        }

        //根据下拉框值改变查询条件
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowHouse(cboType.SelectedIndex.ToString());
        }

        //根据下拉框值改变查询条件
        private void cboHouseState_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowHouse(cboHouseState.Text);
        }

        //导出excel
        private void tsbtnExcelHouse_Click(object sender, EventArgs e)
        {
            HouseHelper hh = new HouseHelper();
            hh.getListView(this.lvHouse,"房源表");
        }

        //添加会员按钮
        private void tsbtnAddCust_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee("");
            ae.ShowDialog();
        }

        //修改会员按钮
        private void tsbtnUpdateCust_Click(object sender, EventArgs e)
        {
            //如果没选中，则返回
            if(lvAdmin.SelectedItems.Count<=0)
            {
                return;
            }
            AddEmployee ae = new AddEmployee(lvAdmin.SelectedItems[0].Text);
            ae.ShowDialog();
        }

        //选项卡控制
        private void tcBaseSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tcBaseSet.SelectedIndex==1)
            {
                ShowEmp();
            }
            if (tcBaseSet.SelectedIndex == 2)
            {
                ShowAwoke(page);
            }
        }

        //显示提醒服务
        private void ShowAwoke(int page)
        {
            lvAwoke.Items.Clear();
            string A_AwokeId;
            string A_content;
            string State;
            string Date;
            string Remark;
            
            string sql="";
            DBHelper db = null;
            db = new DBHelper();

            if (page >= 0)
            {
                page = (page - 1) * 10;
                sql = string.Format("select top 10 * from Awoke where A_AwokeId not in (select top " + page + " A_AwokeId from Awoke)");
            }
            else
            {
                if(page==-1)
                {
                    sql = string.Format("select * from Awoke where State ='{0}'","未读");           
                }
                else if (page == -2)
                {
                    sql = string.Format("select * from Awoke where State ='{0}'", "已读");
                }
                else if (page == -3)
                {
                    sql = string.Format("select * from Awoke where Date between '{0}' and '{1}'",dtpBeginTime.Text,dtpEndTime.Text);
                }
            }
                       
           
            SqlDataReader sdr = db.SelectAll(sql);
            while (sdr.Read())
            {
                A_AwokeId = sdr["A_AwokeId"].ToString();
                A_content = sdr["A_content"].ToString();
                State = sdr["State"].ToString();
                Date = Convert.ToDateTime(sdr["Date"]).ToString("yyyy-MM-dd HH:mm:ss");
                Remark = sdr["Remark"].ToString();

                ListViewItem lviAwoke = new ListViewItem(A_AwokeId);
                string[] str ={ A_content, State, Date, Remark };
                lviAwoke.SubItems.AddRange(str);
                lvAwoke.Items.Add(lviAwoke);
            }
            sdr.Close();
        }

        //显示员工信息
        private void ShowEmp()
        {
            lvAdmin.Items.Clear();
            string A_AdminId;
            string A_Name;
            string Password;
            string A_Type;

            string sql = "";

            DBHelper db = null;
            try
            {
                db = new DBHelper();

                sql = string.Format("select * from Admin");               

                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    A_AdminId = sdr["A_AdminId"].ToString();
                    A_Name = sdr["A_Name"].ToString();
                    Password = sdr["Password"].ToString();
                    A_Type = sdr["A_Type"].ToString();

                    ListViewItem lviAdmin = new ListViewItem(A_AdminId);
                    string[] str ={A_Name, Password,A_Type};
                    lviAdmin.SubItems.AddRange(str);
                    lvAdmin.Items.Add(lviAdmin);
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

        //删除员工
        private void tsBtnDeleteCust_Click(object sender, EventArgs e)
        {
            if(lvAdmin.SelectedItems.Count <= 0)
            {
                return;
            }
            //如果正是使用，则不能删除
            if(lvAdmin.SelectedItems[0].Text==UserHelper.LoginId)
            {
                MessageBox.Show("此服务员正在使用中...", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string A_AdminId = lvAdmin.SelectedItems[0].SubItems[0].Text;
            DialogResult result = MessageBox.Show("是否删除"+A_AdminId,"删除提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DBHelper db = null;
                try
                {
                    db = new DBHelper();
                    string sql = string.Format("delete Admin where A_AdminId='{0}'", A_AdminId);
                    if (db.UpdateDeleteAdd(sql) > 0)
                    {
                        //MessageBox.Show("删除成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("删除失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    db.GetClose();
                    ShowEmp();
                }
            }
        }

        //退出
        private void tsbtnExitCust_Click(object sender, EventArgs e)
        {
            Close();
        }

        //导出excel
        private void tsbtnExcelCust_Click(object sender, EventArgs e)
        {
            HouseHelper hh = new HouseHelper();
            hh.getListView(this.lvAdmin, "管理员表");
        }
        
        //添加提醒
        private void tsbtnAddAwoke_Click(object sender, EventArgs e)
        {
            AddAworkeForm aaf = new AddAworkeForm(0);
            aaf.ShowDialog();
        }

        //退出按钮
        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbtnExcelAwoke_Click(object sender, EventArgs e)
        {
            hh.getListView(lvAwoke,"提醒表");
        }

        //修改提醒按钮
        private void tsbtnUpdateAwoke_Click(object sender, EventArgs e)
        {
            if(lvAwoke.SelectedItems.Count<=0)
            {
                return;
            }
            AddAworkeForm aaf = new AddAworkeForm(1);

            List<string> listString = new List<string>();
            for (int i = 0; i < lvAwoke.SelectedItems[0].SubItems.Count;i++ )
            {
                listString.Add(lvAwoke.SelectedItems[0].SubItems[i].Text);
            }
            aaf.listString = listString;
            aaf.ShowDialog();
        }

        //删除提醒按钮
        private void tsbtnDeleteAwoke_Click(object sender, EventArgs e)
        {
            if (lvAwoke.SelectedItems.Count <= 0)
            {
                return;
            }
            string A_AwokeId = lvAwoke.SelectedItems[0].SubItems[0].Text;
            DialogResult result = MessageBox.Show("是否删除?", "删除提示！", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DBHelper db = null;
                db = new DBHelper();
                string sql = string.Format("delete Awoke where A_AwokeId='{0}'",A_AwokeId);
                int rows = db.UpdateDeleteAdd(sql);
                if (rows > 0)
                {
                    //MessageBox.Show("删除成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lvAwoke.SelectedItems[0].Remove();
                }
                else
                {
                    MessageBox.Show("删除失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //下一页
        private void btnNextAwoke_Click(object sender, EventArgs e)
        {
            DBHelper db = null;
            db = new DBHelper();
            string sql = string.Format("select count(*) from Awoke");
            pages = (int) db.SelectOne(sql);
            
            if (page-1 == (pages / 10))
            {

            }
            else
            {
                page++;
            }
           
            ShowAwoke(page);
        }

        //上一页
        private void btnUpAwoke_Click(object sender, EventArgs e)
        {           
            if(page>1)
            {
                page--;
            }
            
            ShowAwoke(page);
        }

        //最后一页
        private void btnLastAwoke_Click(object sender, EventArgs e)
        {
            DBHelper db = null;
            db = new DBHelper();
            string sql = string.Format("select count(*) from Awoke");
            pages = (int) db.SelectOne(sql);

            if (pages % 10 == 0)
            {
                page = pages / 10;
            }
            else
            {
                page = pages / 10 + 1;
            }
            ShowAwoke(page);
        }

        //第一页
        private void btnFirstAwoke_Click(object sender, EventArgs e)
        {
            ShowAwoke(1);
        }   

        //退出
        private void tsbtnExitUnderwrite_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //添加签单
        private void tsbtnAddUnderwrite_Click(object sender, EventArgs e)
        {
            UnderwriteForm uf = new UnderwriteForm(0);
            uf.ShowDialog();
        }

        //修改签单
        private void tsbtnUpdateUnderwrite_Click(object sender, EventArgs e)
        {
            if (lvUnderwrite.SelectedItems.Count <= 0)
            {
                return;
            }
            else
            {
                List<string> listStr = new List<string>();
                for (int i = 0; i < lvUnderwrite.SelectedItems[0].SubItems.Count;i++ )
                {
                    listStr.Add(lvUnderwrite.SelectedItems[0].SubItems[i].Text);
                }
                UnderwriteForm uf = new UnderwriteForm(1);
                uf.listStr = listStr;
                uf.ShowDialog();
            }
        }
        //导出excel

        private void tsbtnExcelUnderwrite_Click(object sender, EventArgs e)
        {
            HouseHelper hh = new HouseHelper();
            hh.getListView(lvUnderwrite,"签单详细表");
        }

        //修改签单
        private void tsbtnDeleteUnderwrite_Click(object sender, EventArgs e)
        {
             
            if (lvUnderwrite.SelectedItems.Count <= 0)
            {
                return;
            }

            string temp = lvUnderwrite.SelectedItems[0].SubItems[0].Text;

            if(!isHave())
            {
                return;
            }
           
            DialogResult result = MessageBox.Show("真的删除？","删除提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                DBHelper db = null;
                try
                {
                    db = new DBHelper();
                    string sql = string.Format("delete Underwrite where U_Id='{0}'", temp);
                    db.UpdateDeleteAdd(sql);
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

        //判断是产生消费记录
        private bool isHave()
        {
            DBHelper db = null;
            db = new DBHelper();
            string sql = string.Format("select count(*) from UnderwriteAnnal where Underwrite = '{0}' and State= '{1}'",lvUnderwrite.SelectedItems[0].SubItems[1].Text,"未付");
           // MessageBox.Show(sql);
            int count = (int) db.SelectOne(sql);
            if (count > 0)
            {
                string message = string.Format("此单位已经产生{0}条消费记录！请补款后再删！",count);
                MessageBox.Show(message, "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }       

        //导出excel
        private void tsbtnExcelLoginLog_Click(object sender, EventArgs e)
        {
            HouseHelper hh = new HouseHelper();
            hh.getListView(lvLoginLog,"日志表");
        }

        //删除日志 
        private void tsbtnDeleteLoginLog_Click(object sender, EventArgs e)
        {            
            for (int i = 0; i < lvLoginLog.SelectedItems.Count;i++ )
            {
                string temp = lvLoginLog.SelectedItems[i].SubItems[0].Text;
                DBHelper db = new DBHelper();
                db = new DBHelper();
                string sql = string.Format("delete LoginLog where L_LoginLogId='{0}'", temp);
                int rows = (db.UpdateDeleteAdd(sql));
                //MessageBox.Show(rows.ToString());
            }

            //重新显示日志 
            ShowL_LoginLogId();
        }

        //退出
        private void tsbtnExitLoginLog_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //根据下拉框的页码显示提醒
        private void cboPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAwoke(Convert.ToInt32(cboPage.Text));
        }

        //根据状态显示提醒
        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboState.SelectedIndex == 0)
            {
                ShowAwoke(-1);
            }
            else
            {
                ShowAwoke(-2);
            }
        }

        //查找按钮
        private void btnFind_Click(object sender, EventArgs e)
        {
            ShowAwoke(-3);
        }

        //权限按钮
        private void tsbtnIspurview_Click(object sender, EventArgs e)
        {
            if(lvAdmin.SelectedItems.Count<=0)
            {
                return;
            }
            string adminId = lvAdmin.SelectedItems[0].SubItems[0].Text;
            PurviewForm pf = new PurviewForm(adminId);
            pf.ShowDialog();
        }             
    }
}