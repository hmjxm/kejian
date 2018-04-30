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
    public partial class DepositManage : Form
    {
        bool isCheck = true;
        public DepositManage()
        {
            InitializeComponent();
        }

        //取消按钮
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //加载事件
        private void DepositManage_Load(object sender, EventArgs e)
        {
            ShowHouseInfo();

        }

        //显示房子信息
        private void ShowHouseInfo()
        {
            string Room_id;
            string name;
            string AdvanceForegift;
            HouseHelper hh = new HouseHelper();
            DBHelper db = null;
            db = new DBHelper();
            string sql = string.Format("select * from Guest,Room where State='{0}' and Guest.R_id = Room.R_id  and  faceDate ='{1}'", "待客","");
            SqlDataReader sdr = db.SelectAll(sql);
            while (sdr.Read())
            {
                Room_id = hh.GetRoomId(sdr["R_id"].ToString());
                name = sdr["Uname"].ToString();
                AdvanceForegift = sdr["AdvanceForegift"].ToString();

                ListViewItem lviDM = new ListViewItem(Room_id);
                lviDM.Tag = sdr["R_id"].ToString();
                
                string[] str ={ name, AdvanceForegift };
                lviDM.SubItems.AddRange(str);
                lvDeposit.Items.Add(lviDM);
            }
        }

        //ok按钮
        private void btnOK_Click(object sender, EventArgs e)
        {
            
            if (lblroom.Text == "")
            {
                MessageBox.Show("没选定房间！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result ;
                
                string sql;
                string message;
                DBHelper db = null;
                try
                {
                    db = new DBHelper();
                    if (isCheck)
                    {
                        sql = string.Format("update Guest set AdvanceForegift = AdvanceForegift + '{0}' where R_id='{1}' and  faceDate ='{2}'", txtDeposit.Text, lblroom.Tag,"");
                        message = string.Format("{0}房\n交押金{1}",lblroom.Text,txtDeposit.Text);
                    }
                    else
                    {
                        sql = string.Format("update Guest set AdvanceForegift = AdvanceForegift - '{0}' where R_id='{1}' and  faceDate ='{2}'", txtDeposit.Text, lblroom.Tag,"");
                        message = string.Format("{0}房\n退押金{1}", lblroom.Text, txtDeposit.Text);
                    }
                    
                    result = MessageBox.Show(message, "确定", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result==DialogResult.No)
                    {
                        return;
                    }
                    int rows = db.UpdateDeleteAdd(sql);
                    if (rows > 0)
                    {
                        MessageBox.Show("修改成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //查询改变背景颜色
        private void lvDeposit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvDeposit.Items.Count; i++)
            {
                lvDeposit.Items[i].ForeColor = Color.Black;
                lvDeposit.Items[i].BackColor = Color.White;
            }

            lblroom.Text = lvDeposit.SelectedItems[0].SubItems[0].Text;
            lblroom.Tag = lvDeposit.SelectedItems[0].Tag;                        
        }

        //单选按钮
        private void rdoComeDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoComeDeposit.Checked)
            {
                isCheck = true;
                lblDeposit.Text = "补交押金：";
            }
            else
            {
                isCheck = false;
                lblDeposit.Text = "   退押金：";
            }
        }

        //搜索事件
        private void btnSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvDeposit.Items.Count; i++)
            {
                lvDeposit.Items[i].ForeColor = Color.Black;
                lvDeposit.Items[i].BackColor = Color.White;
            }

            for (int i = 0; i < lvDeposit.Items.Count;i++ )
            {
                if(lvDeposit.Items[i].SubItems[0].Text==txtRoom_id.Text)
                {
                    lvDeposit.Items[i].Selected = true;
                    lvDeposit.Items[i].ForeColor = Color.White;
                    lvDeposit.Items[i].BackColor = Color.Blue;
                    lblroom.Text = lvDeposit.SelectedItems[0].SubItems[0].Text;
                    break;
                }
            }
        }

        //改变颜色
        private void txtRoom_id_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvDeposit.Items.Count; i++)
            {
                lvDeposit.Items[i].ForeColor = Color.Black;
                lvDeposit.Items[i].BackColor = Color.White;
            }

            for (int i = 0; i < lvDeposit.Items.Count; i++)
            {
                if (lvDeposit.Items[i].SubItems[0].Text == txtRoom_id.Text)
                {
                    lvDeposit.Items[i].Selected = true;
                    lvDeposit.Items[i].ForeColor = Color.White;
                    lvDeposit.Items[i].BackColor = Color.Blue;
                    lblroom.Text = lvDeposit.SelectedItems[0].SubItems[0].Text;
                    break;
                }
            }
        }       
    }
}