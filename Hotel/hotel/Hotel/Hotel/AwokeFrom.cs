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
    public partial class AwokeFrom : Form
    {
        public AwokeFrom()
        {
            InitializeComponent();
        }

        //加载事件
        private void AwokeFrom_Load(object sender, EventArgs e)
        {
            //获取屏幕像素
            int width = Screen.AllScreens[0].Bounds.Width;
            int height = Screen.AllScreens[0].Bounds.Height;
           
             //305, 166

            //根据像素显示位置
            ShowAwoke();
            this.Left = width - 305;
            this.Top = -800;   
        }

        //移动效果　
        private void MoveForm()
        {
            int width = Screen.AllScreens[0].Bounds.Width;
            int height = Screen.AllScreens[0].Bounds.Height;
            for(int i=750;i> height - 179;i=i-3)
            {
                this.Left = width - 305;
                this.Top = i;               
            }           
        }

        //加载数据
        private void ShowAwoke()
        { 
            DBHelper db = null;
            try
            {
                string sql = string.Format("select * from Awoke where State='{0}' and Date ='{1}' ", "未读", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                db = new DBHelper();
                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    ListViewItem lviAWoke = new ListViewItem(sdr["A_content"].ToString());
                    lviAWoke.Tag = sdr["A_AwokeId"].ToString();
                    string[] str ={ sdr["state"].ToString(), sdr["date"].ToString(), sdr["remark"].ToString() };

                    lviAWoke.SubItems.AddRange(str);
                    lvAwoke.Items.Add(lviAWoke);
                }
                sdr.Close();
                tmrStart.Start();
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

        //时钟时间，控制提醒窗口移动
        private void tmrStart_Tick(object sender, EventArgs e)
        {
            MoveForm();
            this.tmrStart.Stop();
        }

        //取消按钮
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AwokeFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBHelper db = null;
            db = new DBHelper();          
            string A_AwokeId;
            for (int i = 0; i < lvAwoke.Items.Count;i++ )
            {  
                A_AwokeId = lvAwoke.Items[i].Tag.ToString();                
                string sql = string.Format("Update Awoke set State='{0}' where A_AwokeId='{1}'", "已读", A_AwokeId);
                int rows = db.UpdateDeleteAdd(sql);
                
            }            
        }           
    }
}