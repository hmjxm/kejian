using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace Hotel
{
    public partial class SoftWareSet : Form
    {
        public MainForm mf;
        HouseHelper hh = new HouseHelper();
        public SoftWareSet()
        {
            InitializeComponent();
        }

        //保存事件
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            IsAwoke.isAwork();
            IsAwoke.isExit = true;
            this.Close();
        }

       

        //保存数据
        private void Save()
        {
            DBHelper db = null;

            try
            {
                db = new DBHelper();

                int sameName = 0;　　　//同名是否提醒
                int foregiftSmall = 0;　　　//押金少于房款可开房
                int IsRefurbish = 0;　　　　　//是否刷新控制台数据
                int Refurbish = Convert.ToInt32(cboTime.Text);　　//刷新时间　
                int IgnoreTime = Convert.ToInt32(cboIgnore.Text);　　　//换房忽略时间　
                int ExceedTime = Convert.ToInt32(cboExceed.Text);　　　　//预订超过时间
                
                int GoOutBak = 0;　　//退出是否备份数据库
                string S_Path = txtPath.Text;　　　//路径

                


                if (chkSameName.Checked)
                {
                    sameName = 1;
                }
                if (chkForegiftSmall.Checked)
                {
                    foregiftSmall = 1;
                }
                if (chkRefurbish.Checked)
                {
                    IsRefurbish = 1;
                }
                if (chkGoOutBak.Checked)
                {
                    if (txtPath.Text == "")
                    {
                        MessageBox.Show("自动备份时，路径不能为空！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    GoOutBak = 1;
                }



                string sql = string.Format("update  SoftWareSet set HotelName='{0}',Intro='{1}',discount = '{10}',sameName='{2}',ForegiftSmall='{3}',IsRefurbish='{4}',Refurbish='{5}',IgnoreTime='{6}',ExceedTime='{7}',GoOutBak='{8}',S_Path='{9}'",
                    txtHotelName.Text, txtIntro.Text, sameName, foregiftSmall, IsRefurbish, Refurbish, IgnoreTime,  ExceedTime, GoOutBak, S_Path,cboDis.Text
                    );
                int rows = db.UpdateDeleteAdd(sql);
                if (rows > 0)
                {
                    DialogResult result = MessageBox.Show("重起程序生效是否重启？", "重启提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("保存失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //退出是否备份数据库
        private void chkGoOutBak_CheckedChanged(object sender, EventArgs e)
        {
            if(!chkGoOutBak.Checked)
            {
                panBack.Enabled = false;
            }
            else if (chkGoOutBak.Checked)
            {
                panBack.Enabled = true;
            }
        }

        private void SoftWareSet_Load(object sender, EventArgs e)
        {            
            ShowInfo(); 
        }
       

        //从数据库中读取相关信息
        private void ShowInfo()
        {
            int sameName=0;
            int foregiftSmall=0;
            int IsRefurbish=0;           
            int GoOutBak=0;            

            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from SoftWareSet");
                SqlDataReader sdr = db.SelectAll(sql);

                if (sdr.Read())
                {
                    txtHotelName.Text = sdr["HotelName"].ToString();
                    txtIntro.Text = sdr["Intro"].ToString();
                    sameName = (int)sdr["SameName"];
                    foregiftSmall = (int)sdr["ForegiftSmall"];
                    IsRefurbish = (int)sdr["IsRefurbish"];
                    cboTime.Text = sdr["Refurbish"].ToString();
                    cboIgnore.Text = sdr["IgnoreTime"].ToString();                    
                    cboExceed.Text = sdr["ExceedTime"].ToString();
                    GoOutBak = (int)sdr["GoOutBak"];
                    cboDis.Text = sdr["discount"].ToString();

                    if ("D:\\hotel.bak" == sdr["S_Path"].ToString())
                    {
                        txtPath.Text = Application.StartupPath+"\\hotel.bak";
                    }
                    else
                    {
                        txtPath.Text = sdr["S_Path"].ToString();
                    }
                }
                if (sameName == 1)
                {
                    chkSameName.Checked = true;
                }
                if (foregiftSmall == 1)
                {
                    chkForegiftSmall.Checked = true;
                }
                if (IsRefurbish == 1)
                {
                    chkRefurbish.Checked = true;
                }
                else
                {
                    cboTime.Enabled = false;
                }
                if (GoOutBak == 1)
                {
                    chkGoOutBak.Checked = true;
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

        //备份
        private void btnBack_Click(object sender, EventArgs e)
        {
            DBHelper db = null;
            try
            {
                string path = txtPath.Text;
                File.Delete(path);

                string sql = string.Format("backup database {0} to disk='{1}'", "Hotel", txtPath.Text);
                db = new DBHelper();
                db.UpdateDeleteAdd(sql);
                MessageBox.Show("备份成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //路径
        private void btnPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath+"\\";
            sfd.Filter = "备份文件(*.bak)|*.bak";

            if(sfd.ShowDialog()==DialogResult.OK)
            {
                this.txtPath.Text = sfd.FileName;
                this.btnBack.Enabled = true;
            }
        }

        /// <summary>
        /// 注意！
        /// 　还原需要退出应用程序  真正还原 代码在 resume.exe  debug 下面 自己找源码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRevert_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("需退出应用程序，是否继续？！","温馨提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(result==DialogResult.Yes)
            {
                IsAwoke.isExit = true;
                Process.Start(Application.StartupPath + "\\resume.exe");
                Application.Exit();
            }            
        }   
        
        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //是否刷新
        private void chkRefurbish_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRefurbish.Checked)
            {
                cboTime.Enabled = true;
            }
            else
            {
                cboTime.Enabled = false;
            }
        }
        
    }
}