using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace Hotel
{
    public partial class MainForm : Form
    {
        int index = 0;
        HouseHelper hh = new HouseHelper();

        /// <summary>
        /// panMain  移动方法
        /// </summary>
        int begin;　　　　 //　panMain　移动开始值
        int end;　　　　　　　//panMain　　移动结束值
        public MainForm()
        {
            InitializeComponent();
        }

        //前台操作
        private void tsbtnForegrounding_Click(object sender, EventArgs e)
        {
            //开始为现在的左边的像素
            begin = panMain.Left;
            //结事为-160
            end = -160;
            //调用方法　　传入起始位置和结束位置
            MovePanMain(begin,end);          
        }

        //移动方法
        private void MovePanMain(int begin,int end)
        {            
            int gap;　　//差值
            int step = 0;　　　//每步移动的像素点
            gap = Math.Abs(begin - end);         //开始值减去结束值　取绝对值
            //判断差值　在哪个阶段　　还决定每步移动的像素
            if(gap<170)
            {
                step = 4;
            }
            else if(gap<340)
            {
                step = 10;
            }
            else if(gap<510)
            {
                step = 30;
            }
            else if (gap <= 680)
            {
                step = 80;
            }
            else
            {
                step = 100;
            }

            //如果开始小于结束循环往右移　否则移左移
            if (begin < end)
            {
                for (int i = begin; i <= end; i = i + step)
                {                    
                    panMain.Left = i;                    
                }
            }
            else
            {
                for (int i = begin; i >= end; i = i - step)
                {                    
                    panMain.Left = i;                    
                }
            }
            //　注意！！　　关键　！！　
            //　将结束位置　赋给左边　　否则将会出现偏移的问题
            panMain.Left = end;
        }

        //预订
        private void tsmiBookManage_Click(object sender, EventArgs e)
        {
            begin = panMain.Left;
            end = -320;
            MovePanMain(begin,end);            
        }       

        //收银管理
        private void tsmiCashierManage_Click(object sender, EventArgs e)
        {
            begin = panMain.Left;
            end = -480;
            MovePanMain(begin, end);  
        }

        //窗体加载事件
        private void MainForm_Load(object sender, EventArgs e)
        { 
            
            //显示时间
            tslblTime.Text = DateTime.Now.ToString();
            //刷新数据库里面设置的数据
            IsAwoke.isAwork();
            cboLook.Text = "全部";
            hh.mf = this;
            //显示房间信息
            hh.ShowHouseState(0);
            //显示服务信息
            ShowServer(0);
            //显示价格
            ShowPrice();
            //显示标题
            ShowTitle();
            //显示总房态
            ShowAllInfo();
            //显示当前登录用户
            ShowLoginId();
            ShowPurview();
            pHelp();
        }

        //显示权限
        private void ShowPurview()
        {
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from purview where Admin = '{0}'", UserHelper.LoginId);
                SqlDataReader sdr = db.SelectAll(sql);
                if (sdr.Read())
                {
                    if (!(bool)sdr[1])
                    {
                        tsmiSoftSet.Visible = false;
                    }

                    if (!(bool)sdr[19])
                    {
                        tsmiBaseSet.Visible = false;
                    }


                    tsbtnSoftSet.Visible = (bool)sdr[1];

                    tsbtnForegrounding.Visible = (bool)sdr[17];
                    tsmiBookManage.Visible = (bool)sdr[18];
                    tsmiCashierManage.Visible = (bool)sdr[19];
                    tsbtnBaseOper.Visible = (bool)sdr[20];
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
       
        //显示当前登录用户名
        private void ShowLoginId()
        {
            tslblUserId.Text = tslblUserId.Text + UserHelper.LoginId;           
           
        }

        //显示左边标签信息
        private void ShowAllInfo()
        {
            DBHelper db = null;
            db = new DBHelper();
            string sql;
            //总房间数
            sql = string.Format("select count(*) from Room");
            lblSum.Text = Convert.ToString(db.SelectOne(sql));

            sql = string.Format("select count(*) from Room where State = '{0}'","待客");
            lblZY.Text = Convert.ToString(db.SelectOne(sql));

            sql = string.Format("select count(*) from Room where State = '{0}'","空净");
            lblHk.Text = Convert.ToString(db.SelectOne(sql));

            sql = string.Format("select count(*) from Room where State = '{0}'", "预订");
            lblYD.Text = Convert.ToString(db.SelectOne(sql));

            sql = string.Format("select count(*) from Room where State = '{0}'", "自用");
            lblZiY.Text = Convert.ToString(db.SelectOne(sql));

            sql = string.Format("select count(*) from Room where State = '{0}'", "整理");
            lblZL.Text = Convert.ToString(db.SelectOne(sql));

            lblZYL.Text = Convert.ToString(Math.Round((Convert.ToDouble(lblZY.Text) / Convert.ToDouble(lblSum.Text)),2)*100)+"%";
            
        }

        //显示酒店标题
        private void ShowTitle()
        {
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select HotelName from SoftWareSet");
                SqlDataReader sdr = db.SelectAll(sql);

                if (sdr.Read())
                {
                    this.Text = sdr["HotelName"].ToString()+"酒店管理系统";
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

        //显示价格
        private void ShowPrice()
        {
            List<string> listStr = new List<string>();
            DBHelper db = null;
            
            string sql;
            for (int i = 1; i < 8;i++ )
            {
                sql = string.Format("select price from Room where RoomType='{0}'",i);
                db = new DBHelper();
                SqlDataReader sdr = db.SelectAll(sql);
                string price = " ";
                if(sdr.Read())
                {                    
                    price = sdr["price"].ToString();                   
                }
                listStr.Add(price);
            }
            lblbd.Text = listStr[0];
            lblbs.Text = listStr[1];
            lblhd.Text = listStr[2];
            lblhs.Text = listStr[3];
            lblsw.Text = listStr[4];
            lblzt.Text = listStr[5];
            lblhyt.Text = listStr[6];
           
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
                
                string sql = string.Format("select * from Consume where G_GuestId = '{0}' ", G_GuestId);               
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.GetClose();
            }
        }


        //显示服务　
        private void ShowServer(int type)
        {
            lvServer.Items.Clear();
            string U_UsersId;
            string S_content;
            string State;
            string Date;
            string sql;

            DBHelper db = null;
            try
            {
                db = new DBHelper();
                if (type == 0)
                {
                    sql = string.Format("select * from Service");
                }
                else
                {
                    sql = string.Format("select * from Service where State='{0}'",cboLook.Text);
                }
                

                SqlDataReader sdr = db.SelectAll(sql);
                HouseHelper hh = new HouseHelper();
                while (sdr.Read())
                {
                    U_UsersId = sdr["U_UsersId"].ToString();
                    S_content = sdr["S_content"].ToString();
                    State = sdr["State"].ToString();
                    Date = sdr["Date"].ToString();

                    ListViewItem lviServer = new ListViewItem(U_UsersId);

                    lviServer.Tag = sdr["S_serviceId"].ToString();

                    string[] str ={ S_content, State, Date };
                    lviServer.Tag = sdr["S_serviceId"].ToString();
                    lviServer.SubItems.AddRange(str);
                    lvServer.Items.Add(lviServer);
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

       
        //提醒服务　　
        private void ShowAwokeFrom()
        {
            DBHelper db = null;
            try
            {
                string temp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ".000";
                //MessageBox.Show(temp);
                
                db = new DBHelper();
                string sql = string.Format("select count(*) from Awoke where State='{0}' and Date='{1}'", "未读",temp);
                int count = (int)db.SelectOne(sql);
                if (count > 0)
                {
                    FormCollection fc = Application.OpenForms;
                    bool isFind = false;
                    string formName = "提醒";
                    
                    for (int i = 0; i < fc.Count; i++)
                    {                       
                        if (fc[i].Text == formName)
                        {
                            isFind = true;
                            break;
                        }
                    }                 

                    if (!isFind)
                    {
                        AwokeFrom af = new AwokeFrom();
                        af.Show();
                    }                   
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

        
        //控制台
        private void tsbtnEachTime_Click(object sender, EventArgs e)
        {   
            begin = panMain.Left;
            end = 0;
            MovePanMain(begin, end);
        }

        //关闭时事件　
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判断是否提示”真的退出“
            if (IsAwoke.isExit == false)
            {
                DialogResult result = MessageBox.Show("真的退出？", "退出提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    //判断是否退出时备份数据库
                    if (IsAwoke.GoOutBak == 1)
                    {
                        DBHelper db = null;
                        try
                        {
                            string path = IsAwoke.path;
                            File.Delete(path);
                            //备份sql语句
                            string sql = string.Format("backup database {0} to disk='{1}'", "Hotel", path);
                            //MessageBox.Show(sql);
                            db = new DBHelper();
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
                    Application.ExitThread();
                }
            }
            //退出记录日志
            AnnalLog();
        }

        //记录日志
        private void AnnalLog()
        {
            DBHelper db = null;
            try
            {
                db = new DBHelper();

                string sql = string.Format("update LoginLog set LeaveDate='{0}' where L_LoginLogId='{1}'", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), UserHelper.L_LoginLogId);
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

       　//添加房间
        private void btnAddHouse_Click_1(object sender, EventArgs e)
        {
            AddHouse ah = new AddHouse();
            ah.ShowDialog();
        }

        //设置
        private void tsbtnSoftSet_Click(object sender, EventArgs e)
        {
            begin = panMain.Left;
            end = -800;
            MovePanMain(begin, end);  
        }

        //合并房间             

        private void btnJoinHouse_Click(object sender, EventArgs e)
        {
            JoinHouseForm JoinHosueFormFrm = new JoinHouseForm();
            JoinHosueFormFrm.ShowDialog();
        }

        //预订
        private void btnBook_Click(object sender, EventArgs e)
        {
            BookHouse BookHouseFrm = new BookHouse();
            BookHouseFrm.ShowDialog();
        }

        //private void btnWareManage_Click(object sender, EventArgs e)
        //{
        //    WareManageForm WareManageFrm = new WareManageForm();
        //    WareManageFrm.ShowDialog();
        //}

        //换房
        private void btnSwap_Click(object sender, EventArgs e)
        {
            SwapHouseForm SwapHouseFrm = new SwapHouseForm();
            SwapHouseFrm.ShowDialog();
        }

        //团体开单
        private void btnGroup_Click(object sender, EventArgs e)
        {
            GroupAddHouseForm GroupAddHouseFrm = new GroupAddHouseForm();
            GroupAddHouseFrm.ShowDialog();
        }

        //收银
        private void btnCashier_Click(object sender, EventArgs e)
        {
            CashierForm cashierFrm = new CashierForm();
            cashierFrm.ShowDialog();
        }

        //商品管理　
        private void btnBusiness_Click(object sender, EventArgs e)
        {
            BusinessForm BusinessFrm = new BusinessForm();
            BusinessFrm.ShowDialog();
        }

        //收退押金
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositManage DepositManageFrm = new DepositManage();
            DepositManageFrm.ShowDialog();
        }

        //系统设置
        private void btnDaily_Click(object sender, EventArgs e)
        {
            SoftWareSet SoftWareSetFrm = new SoftWareSet();
            SoftWareSetFrm.ShowDialog();
        }

        //预订入住
        private void btnBookInfall_Click(object sender, EventArgs e)
        {
            BookInfall BookInfallfrm = new BookInfall();
            BookInfallfrm.ShowDialog();
        }

        //预订解除
        private void btnRescind_Click(object sender, EventArgs e)
        {
            RescindForm RescinFrm = new RescindForm();
            RescinFrm.ShowDialog();
        }

        //单位补款
        private void btnUnitFill_Click(object sender, EventArgs e)
        {
            UnitFillForm UnitFillFrm = new UnitFillForm();
            UnitFillFrm.ShowDialog();
        }

        //基本设置
        private void btnBaseSet_Click(object sender, EventArgs e)
        {
            BaseSetForm bsf = new BaseSetForm(0);
            bsf.ShowDialog();
        }

        //时钟事件
        private void trmAwork_Tick(object sender, EventArgs e)
        {
            ShowAwokeFrom();
        }

        //清空便签
        private void tsbtnClear_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("是否清空?","清空提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(result==DialogResult.Yes)
            {
                txtScratchpad.Text = "";
            }
        }

        //插入时间　
        private void tsbtnDate_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString();
            txtScratchpad.Text += "\n" + "-------------------\n" + time;
        }

        //调出计算器　　注意导入命名空间
        private void tsbtnCalc_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        //保存.txt文件  注意导入命名空间
        private void tsbtnNotepad_Click(object sender, EventArgs e)
        {            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "所有文件(*.*)|*.*|文本文件(*.txt)|*.txt";
            sfd.Title = "保存";
            sfd.FileName = "*.txt";
            
            if (sfd.ShowDialog()==DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.Default);
                sw.Write(txtScratchpad.Text);
                sw.Flush();
                sw.Close();
            }          

        }

        //根据 下标显示服务
        private void cboLook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLook.SelectedIndex == 0)
            {
                ShowServer(0);
            }
            else
            {
                ShowServer(1);
            }            
        }      

        //查找房间按钮
        private void btnFind_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < lvConsole.Items.Count;j++ )
            {
                lvConsole.Items[j].ForeColor = Color.Black;
                lvConsole.Items[j].BackColor = Color.White;
            }
            int i;
            for (i = 0; i < lvConsole.Items.Count;i++ )
            {
                if(txtFind.Text==lvConsole.Items[i].SubItems[0].Text)
                {
                    lvConsole.Items[i].Selected = true;
                    lvConsole.Items[i].BackColor = Color.Blue;
                    lvConsole.Items[i].ForeColor = Color.White;
                    break;
                }
            }
            if(i==lvConsole.Items.Count)
            {
                MessageBox.Show("对不起没有找此房间！","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            txtFind.SelectAll();
        }       

        //单击事件  改变颜色
        private void lvConsole_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < lvConsole.Items.Count; i++)
            {
                lvConsole.Items[i].ForeColor = Color.Black;
                lvConsole.Items[i].BackColor = Color.White;
            }
        }

        //刷新时钟
        private void tsmiRefurbish_Click(object sender, EventArgs e)
        {
            hh.mf = this;
            hh.ShowHouseState(index);
            ShowPrice();
            ShowAllInfo();
            //显示服务信息
            ShowServer(0);
            //显示价格
            ShowPrice();
            ShowPurview();
        }       

        
        //导出excel
        private void tsmiExcel_Click(object sender, EventArgs e)
        {
            HouseHelper hh = new HouseHelper();
            hh.getListView(this.lvConsole,"房源表信息");
        }

        //锁屏
        private void tsmiLock_Click(object sender, EventArgs e)
        {
            Lock lockFrm = new Lock();
            lockFrm.Show();
                    
        }

        //关于窗口
        private void tsmiAboutTwo_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog();
        } 
        
        //退出事件
        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            //退出整个应用程序
            Application.Exit();
        }

        //当激活窗体时发生
        private void MainForm_Activated(object sender, EventArgs e)
        {
            hh.ShowHouseState(index);
            //显示标题
            ShowTitle();
            //显示总房态
            ShowAllInfo();
            //显示服务信息
            ShowServer(0);
            //显示价格
            ShowPrice();
            pHelp();
            ShowPurview();
        }       
        //快捷菜单
        private void cmsFashion_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                string state = lvConsole.SelectedItems[0].SubItems[2].Text;

                if (state == "待客")
                {
                     for (int i = 0; i < cmsFashion.Items.Count; i++)
                    {
                        cmsFashion.Items[i].Enabled = true;
                    }
                }                
                else
                {                   
                    cmsFashion.Items[4].Enabled = false;
                    cmsFashion.Items[5].Enabled = false;
                    cmsFashion.Items[6].Enabled = false;
                    cmsFashion.Items[7].Enabled = false;
                }

                if (state == "待客"||state == "预订")
                {
                    tsmiKG.Enabled = false;
                    tsmiZY.Enabled = false;
                    tsmiZL.Enabled = false;
                }
                else
                {
                    tsmiKG.Enabled = true;
                    tsmiZY.Enabled = true;
                    tsmiZL.Enabled = true;
                }
                if(state=="空净")
                {
                    tsmiKG.Enabled = false;
                }
                if(qian)
                {
                    tsmiAddHouse.Enabled = false;
                    tsmiGroupHouse.Enabled=false;
                    tsmibarter.Enabled=false;
                    tsmiJoinHouse.Enabled = false;
                }

            }
            catch (Exception)
            {             
            }
        }        

        //显示当前时间 
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            tslblTime.Text = DateTime.Now.ToString();
        }

        //权限帮助方法
        public void pHelp()
        {
             DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from purview where Admin = '{0}'", UserHelper.LoginId);
                SqlDataReader sdr = db.SelectAll(sql);

                //读取是否有权限
                if (sdr.Read())
                {
                    //赋值给全局变量
                    tsbtnSoftSet.Visible = (bool)sdr[1];

                    qian = (bool)sdr[17];
                    yuding = (bool)sdr[18];
                    shouyin = (bool)sdr[19];
                    jinben = (bool)sdr[20];
                }
                sdr.Close();
            }    
            catch
            {
            }
        }
        bool qian;
        bool yuding;
        bool shouyin;
        bool jinben;

        //快捷键，必要时屏蔽 则无权限
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (qian)
                {
                    if (e.KeyCode == Keys.F1)
                    {
                        AddHouse ah = new AddHouse();
                        ah.ShowDialog();
                    }
                    if (e.KeyCode == Keys.F2)
                    {
                        GroupAddHouseForm GroupAddHouseFrm = new GroupAddHouseForm();
                        GroupAddHouseFrm.ShowDialog();
                    }

                    if (e.KeyCode == Keys.F3)
                    {
                        txtFind.Focus();
                        txtFind.SelectAll();
                    }


                    if (e.KeyCode == Keys.F6)
                    {
                        SwapHouseForm SwapHouseFrm = new SwapHouseForm();
                        SwapHouseFrm.ShowDialog();
                    }

                    if (e.KeyCode == Keys.F7)
                    {
                        JoinHouseForm JoinHosueFormFrm = new JoinHouseForm();
                        JoinHosueFormFrm.ShowDialog();
                    }
                }


                if (yuding)
                {
                  
                    if (e.KeyCode == Keys.F8)
                    {
                        BookHouse BookHouseFrm = new BookHouse();
                        BookHouseFrm.ShowDialog();
                    }

                    if (e.KeyCode == Keys.F9)
                    {
                        BookInfall BookInfallfrm = new BookInfall();
                        BookInfallfrm.ShowDialog();
                    }

                    if (e.KeyCode == Keys.F10)
                    {
                        RescindForm RescinFrm = new RescindForm();
                        RescinFrm.ShowDialog();
                    }
                    
                }


                if (shouyin)
                {
                    if (e.KeyCode == Keys.F4)
                    {
                        CashierForm cashierFrm = new CashierForm();
                        cashierFrm.ShowDialog();
                    }
                }

                if (jinben)
                {
                    if (e.KeyCode == Keys.F11)
                    {
                        BusinessForm bf = new BusinessForm();
                        bf.ShowDialog();
                    }

                    if (e.KeyCode == Keys.F12)
                    {
                        Member m = new Member();
                        m.ShowDialog();
                    }
                }


                if (e.KeyCode == Keys.F5)
                {
                    hh.ShowHouseState(index);
                    ShowPrice();
                    ShowAllInfo();
                    ShowServer(0);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("如快捷键无效！则是您没有权限！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {

            }
        }
       
        //调出计算器
        private void tsmiCalculator_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        //退出
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //软件设置
        private void tsmiSoftSet_Click(object sender, EventArgs e)
        {
            SoftWareSet sws = new SoftWareSet();
            sws.ShowDialog();
        }
                
        //判断是否刷新
        private void trmRefurbish_Tick(object sender, EventArgs e)
        {
            if (IsAwoke.IsRefurbish == "1")
            {
                trmRefurbish.Start();
                trmRefurbish.Interval = (IsAwoke.Refurbish * 1000);
            }
            else
            {
                trmRefurbish.Stop();
            }
            hh.ShowHouseState(index);
            ShowPrice();
            ShowAllInfo();
            ShowServer(0);
        }

        //会员管理
        private void btnCustManage_Click(object sender, EventArgs e)
        {
            Member m = new Member();
            m.ShowDialog();
        }

        //增加消费
        private void tsmiconsume_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = lvConsole.SelectedItems[0].SubItems[0].Text;
                AddConsume mf = new AddConsume(temp);
                mf.ShowDialog();
            }
            catch(Exception)
            {

            }
        }

        //商品管理
        private void btnWareManage_Click(object sender, EventArgs e)
        {
            BusinessForm bf = new BusinessForm();
            bf.ShowDialog();
        }

        string G_GuestId;

        private void lvConsole_Click(object sender, EventArgs e)
        {
                 
        }

        //双击服务
        private void lvServer_DoubleClick(object sender, EventArgs e)
        {
            if(lvServer.SelectedItems.Count<=0)
            {
                return;
            }
            SericesForm sf = new SericesForm(lvServer.SelectedItems[0].SubItems[0].Text);
            sf.Show();
        }

        //查询
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvConsole.Items.Count; i++)
            {
                lvConsole.Items[i].ForeColor = Color.Black;
                lvConsole.Items[i].BackColor = Color.White;
            }

            for (int i = 0; i < lvConsole.Items.Count; i++)
            {
                if (txtFind.Text == lvConsole.Items[i].SubItems[0].Text)
                {
                    lvConsole.Items[i].Selected = true;
                    lvConsole.Items[i].BackColor = Color.Blue;
                    lvConsole.Items[i].ForeColor = Color.White;
                }
            }
            //txtFind.SelectAll();
        }
       
        //最小化隐藏自身　显示任务图标
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Minimized)
            {
                this.Hide();
                nico.Visible = true;
            }
        }

        //双击任务栏图标事件
        private void nico_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            nico.Visible = false;
        }

        //散客开单
        private void tsmiAddHouse_Click(object sender, EventArgs e)
        {
            AddHouse ah = new AddHouse();
            ah.ShowDialog();
        }

        //团体开单
        private void tsmiGroupHouse_Click(object sender, EventArgs e)
        {
            GroupAddHouseForm gah = new GroupAddHouseForm();
            gah.ShowDialog();
        }

        //结帐
        private void tsmiCashier_Click(object sender, EventArgs e)
        {
            CashierForm cf = new CashierForm();
            cf.ShowDialog();
        }

        //换房
        private void tsmibarter_Click(object sender, EventArgs e)
        {
            SwapHouseForm shf = new SwapHouseForm();
            shf.ShowDialog();
        }

        //合并房
        private void tsmiJoinHouse_Click(object sender, EventArgs e)
        {
            JoinHouseForm jhf = new JoinHouseForm();
            jhf.ShowDialog();
        }

        //改变值　显示消费信息　和改变颜色
        private void lvConsole_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                G_GuestId = lvConsole.SelectedItems[0].Tag.ToString();

                ShowWareInfo();
                ChangeColor();
            }
            catch (Exception)
            {
            }    
        }

        //和改变颜色
        private  void ChangeColor()
        {
            for (int i = 0; i < lvConsole.Items.Count; i++)
            {
                lvConsole.Items[i].ForeColor = Color.Black;
                lvConsole.Items[i].BackColor = Color.White;
            }
        }

        //改为可供
        private void tsmiKG_Click(object sender, EventArgs e)
        {
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                if (lvConsole.SelectedItems.Count <= 0)
                {
                    return;
                }
                string state = ((ToolStripMenuItem)sender).Text;
                
                string roomId = lvConsole.SelectedItems[0].SubItems[0].Text;
                string sql = string.Format("update Room set State ='{0}' where R_RoomId='{1}'", state, roomId);
                //MessageBox.Show(sql);
                if (db.UpdateDeleteAdd(sql) > 0)
                {
                    MessageBox.Show("修改成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("修改失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                db.GetClose();
            }
        }

        //商业查询
        private void btnBusiness_Click_1(object sender, EventArgs e)
        {
            //LoghistoryFor lf = new LoghistoryFor();
            //lf.ShowDialog();
            MoneySelsct ms = new MoneySelsct();
            ms.ShowDialog();
        }

        //基本设置
        private void tsmiBaseSet_Click(object sender, EventArgs e)
        {
            BaseSetForm bsf = new BaseSetForm(1);
            bsf.ShowDialog();
        }

        //标准单人间查询
        private void tsmiBD_Click(object sender, EventArgs e)
        {
            index = Convert.ToInt32(((ToolStripMenuItem)sender).Tag);
            hh.ShowHouseState(index);
        }

        //自动解除预订和改整理为空净时钟
        private void tmrAuto_Tick(object sender, EventArgs e)
        {
            RescindBook();
            ChangeState();
        }

        //改整理为空净
        private void ChangeState()
        {
            string NowTime = DateTime.Now.AddHours(3).ToString("yyyy-MM-dd HH:mm:ss");
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from guest left join room on room.R_id=Guest.R_id where state='{0}'", "整理");
                SqlDataReader sdr = db.SelectAll(sql);

                while (sdr.Read())
                {
                    DateTime dt =Convert.ToDateTime(sdr["faceDate"].ToString());
                    if (dt <= Convert.ToDateTime(NowTime))
                    {
                        db = new DBHelper();
                        sql = string.Format("update room set State = '{0}' where R_id = '{1}' ", "空净", sdr[1].ToString());
                        int rows = db.UpdateDeleteAdd(sql);
                        //MessageBox.Show(sql + rows);
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

        ////自动解除预订
        private void RescindBook()
        {
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from Book");
                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    if (Convert.ToDateTime(sdr["comeDate"]) < Convert.ToDateTime(DateTime.Now.AddHours(IsAwoke.ExceedTime).ToString("yyyy-MM-dd HH:mm:ss")) && sdr["State"].ToString() == "预订")
                    {
                        //MessageBox.Show(Convert.ToDateTime(DateTime.Now.AddHours(5).ToString("yyyy-MM-dd HH:mm:ss")).ToString()+"   "+sdr["comeDate"].ToString());

                        db = new DBHelper();
                        sql = string.Format("update Book set State = '已解除' where B_BookId = '{0}'", sdr["B_BookId"]);
                        // MessageBox.Show(sql);
                        int rows = (int)db.UpdateDeleteAdd(sql);
                        //MessageBox.Show(rows.ToString());
                        sql = string.Format("update Room set State = '空净' where R_RoomId = '{0}'", sdr["Room_id"]);
                        // MessageBox.Show(sql);
                        db.UpdateDeleteAdd(sql);
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

        //交班
        private void btnJiaoBan_Click(object sender, EventArgs e)
        {
            ShiftExchange se = new ShiftExchange();
            se.mf = this;
            se.ShowDialog();
        }

        //删除服务
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            int count = lvServer.SelectedItems.Count;
            if (count <= 0)
            {
                return;
            }
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                //MessageBox.Show(count.ToString());
                int rows=0;
                for (int i = 0; i < count; i++)
                {
                    string S_serviceId = lvServer.SelectedItems[i].Tag.ToString();                    
                    string sql = string.Format("delete Service where S_serviceId ='{0}'", S_serviceId);                    
                     db.UpdateDeleteAdd(sql);
                }
                if (rows > 0)
                {
                    MessageBox.Show("删除成功!", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("删除失败!", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //服务快捷键
        private void cmsServices_Opening(object sender, CancelEventArgs e)
        {
            if (lvServer.SelectedItems.Count > 1)
            {
                cmsServices.Items[0].Enabled = false;
            }
            else
            {
                cmsServices.Items[0].Enabled = true;
            }
        }

        //显示基本设置　并将选项卡设为提醒
        private void tsmiAwoke_Click(object sender, EventArgs e)
        {
            BaseSetForm bsf = new BaseSetForm(1);
            bsf.ShowDialog();
        }

        //支出
        private void btndefray_Click(object sender, EventArgs e)
        {
            DefrayForm df = new DefrayForm();
            df.ShowDialog();
        }

        //显示空净
        private void tsmiKJ_Click(object sender, EventArgs e)
        {
            hh.ShowHouseState(8);
        }

        //显示待客
        private void tsmiDK_Click(object sender, EventArgs e)
        {
            hh.ShowHouseState(9);
        }

        //显示预订
        private void tsmiYD_Click(object sender, EventArgs e)
        {
            hh.ShowHouseState(10);
        }

        //显示自用
        private void tsmiStateZY_Click(object sender, EventArgs e)
        {
            hh.ShowHouseState(11);
        }

        //显示整理
        private void tsmiStateZL_Click(object sender, EventArgs e)
        {
            hh.ShowHouseState(12);
        }

        //显示所有
        private void tsmiStateAll_Click(object sender, EventArgs e)
        {
            hh.ShowHouseState(0);
        }

        private void tsbtnBaseOper_Click(object sender, EventArgs e)
        {
            begin = panMain.Left;
            end = -640;
            MovePanMain(begin, end);  
        }      
                                                   
    }
}