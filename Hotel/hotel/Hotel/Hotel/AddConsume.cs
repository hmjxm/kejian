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
    public partial class AddConsume : Form
    {
        //传入房间号
        string Room_id;
        public AddConsume(string Roomid)
        {
            this.Room_id = Roomid;
            InitializeComponent();
        }

        //取消按钮
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //窗体加载事件
        private void MenuForm_Load(object sender, EventArgs e)
        {             
            //显示所有商品
            ShowAllWare("");
            //显示房间
            ShowHouseInfo();
            //显示商品
            ShowWareType();
        }

        //显示商品
        private void ShowWareType()
        {
            cboWareType.Items.Clear();
            string WareType;
            DBHelper db = null;
            try
            {
                cboWareType.Items.Add("全部");
                db = new DBHelper();
                string sql = string.Format("select WareTypeName from WareType");
                SqlDataReader sdr = db.SelectAll(sql);
                //循环加载数据库里面的类型
                while (sdr.Read())
                {
                    WareType = sdr["WareTypeName"].ToString();
                    cboWareType.Items.Add(WareType);
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

        //显示可供房间
        private void ShowHouseInfo()
        {
            cboRoomId.Items.Clear();
            string Room_id;
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from Room where State='{0}'", "待客");
                SqlDataReader sdr = db.SelectAll(sql);
                //循环显示可供房间
                while (sdr.Read())
                {
                    Room_id = sdr["R_RoomId"].ToString();
                    cboRoomId.Items.Add(Room_id);
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

        //显示所有商品
        private void ShowAllWare(string type)
        {
            lvAllWare.Items.Clear();
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = "";
                if(type=="全部")
                {
                    type = "";
                }

                if (type == "")
                {
                    sql = string.Format("select * from Ware");
                }
                else
                {
                    sql = string.Format("select * from Ware where WareType='{0}'", type);                    
                }
                SqlDataReader sdr = db.SelectAll(sql);

                //循环显示所有商品
                while (sdr.Read())
                {
                    ListViewItem lviWare = new ListViewItem(sdr["WareName"].ToString());
                    string[] str ={ sdr["WareType"].ToString(), sdr["WareGoPrice"].ToString(), sdr["WareCount"].ToString() };
                    lviWare.SubItems.AddRange(str);
                    lvAllWare.Items.Add(lviWare);
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

        //根据下拉框值　查询商品
        private void cboWareType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAllWare(cboWareType.Text);
        }

        //根据简索码　查询商品
        private void txtEasyName_TextChanged(object sender, EventArgs e)
        {
            EasySearch(txtEasyName.Text);
        }

        //简索码查找方法
        private void EasySearch(string EasyName)
        {
            lvAllWare.Items.Clear();
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = "";

                sql = string.Format("select * from Ware where WareEasyName like '{0}%'", EasyName);
                SqlDataReader sdr = db.SelectAll(sql);

                //循环加载符合要求的商品
                while (sdr.Read())
                {
                    ListViewItem lviWare = new ListViewItem(sdr["WareName"].ToString());
                    string[] str ={ sdr["WareType"].ToString(), sdr["WareGoPrice"].ToString(), sdr["WareCount"].ToString() };
                    lviWare.SubItems.AddRange(str);
                    lvAllWare.Items.Add(lviWare);
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

        //显示房间号
        private void AddConsume_Shown(object sender, EventArgs e)
        {
            cboRoomId.Text = Room_id;
        }

        //双击事件
        private void lvAllWare_DoubleClick(object sender, EventArgs e)
        {
            //将商品从左移至右
            LeftMoveRight();
        }

        //将商品从左移至右
        private void LeftMoveRight()
        {
            for (int j = 0; j < lvAllWare.SelectedItems.Count; j++)
            {
                //创建listViewItem 项
                ListViewItem lviWare = new ListViewItem(lvAllWare.SelectedItems[j].SubItems[0].Text);
                int Lcount = Convert.ToInt32(lvAllWare.SelectedItems[j].SubItems[3].Text);

                int MCount = Convert.ToInt32(Convert.ToInt32(txtCount.Text));

                //判断是否少于需要
                if (Lcount < MCount)
                {
                    MessageBox.Show("库存少于需求！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int i;

                //如果已经有则添加数量
                for (i = 0; i < lvSelect.Items.Count; i++)
                {
                    if (lvAllWare.SelectedItems[j].SubItems[0].Text == lvSelect.Items[i].SubItems[0].Text)
                    {
                        lvSelect.Items[i].SubItems[3].Text = Convert.ToString(MCount + Convert.ToInt32(lvSelect.Items[i].SubItems[3].Text));
                        break;
                    }
                }

                //循环移动商品
                if (i == lvSelect.Items.Count)
                {
                    string[] str ={ lvAllWare.SelectedItems[j].SubItems[1].Text, lvAllWare.SelectedItems[j].SubItems[2].Text, txtCount.Text };
                    lviWare.SubItems.AddRange(str);
                    lvSelect.Items.Add(lviWare);
                }

                lvAllWare.SelectedItems[j].SubItems[3].Text = Convert.ToString(Lcount - MCount);
            }
        }

        
        //控制只能输入数字
        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }       
        }

        //将商品从右移至左
        private void lvSelect_DoubleClick(object sender, EventArgs e)
        {
            RightMoveLeft();
        }

        //将商品从右移至左
        private void RightMoveLeft()
        {
            for (int j = 0; j < lvSelect.SelectedItems.Count; j++)
            {


                ListViewItem lviWare = new ListViewItem(lvSelect.SelectedItems[j].SubItems[0].Text);
                int Rcount = Convert.ToInt32(lvSelect.SelectedItems[j].SubItems[3].Text);

                int MCount = Convert.ToInt32(Convert.ToInt32(txtCount.Text));

                //判断数量是否可供
                if (Rcount < MCount)
                {
                    MessageBox.Show("数量不足！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                lvSelect.SelectedItems[j].SubItems[3].Text = Convert.ToString(Convert.ToInt32(lvSelect.SelectedItems[j].SubItems[3].Text) - MCount);

                //循环移动商品
                for (int i = 0; i < lvAllWare.Items.Count; i++)
                {
                    if (lvAllWare.Items[i].SubItems[0].Text == lvSelect.SelectedItems[j].SubItems[0].Text)
                    {
                        lvAllWare.Items[i].SubItems[3].Text = Convert.ToString(Convert.ToInt32(lvAllWare.Items[i].SubItems[3].Text) + MCount);
                        break;
                    }
                }

                if (lvSelect.SelectedItems[j].SubItems[3].Text == "0")
                {
                    lvSelect.SelectedItems[0].Remove();
                }
            }
        }

        //
        private void btnOk_Click(object sender, EventArgs e)
        {
            //验证
            if(ValidateInput())
            {
                //写入商品消费表中
                Consume();
                //修改数量
                UpdateDate();
                this.Close();
            }
        }

        //修改数量
        private void UpdateDate()
        {
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = "";
                for (int i = 0; i < lvAllWare.Items.Count; i++)
                {
                    sql = string.Format("update Ware set WareCount='{0}' where WareName = '{1}'", lvAllWare.Items[i].SubItems[3].Text, lvAllWare.Items[i].SubItems[0].Text);
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

        //写入商品消费表中
        private void Consume()
        {
            string G_GuestId="";
            AutoId ai = new AutoId();  //自动生成id  辅助类
            HouseHelper hh = new HouseHelper();  //辅助类
            DBHelper db = null;   //连数据库类
            db = new DBHelper();
            try
            {
                string sql;
                string C_ConsumeId;
                string R_id = hh.GetR_id(cboRoomId.Text);

                sql = string.Format("select G_GuestId from Guest where R_id='{0}' and faceDate='{1}'", R_id, "");
                SqlDataReader sdr = db.SelectAll(sql);
                if (sdr.Read())
                {
                    G_GuestId = sdr["G_GuestId"].ToString();
                }
                sdr.Close();
                int rows = 0;
                //循环写入
                for (int i = 0; i < lvSelect.Items.Count; i++)
                {
                    C_ConsumeId = ai.GetId("C_ConsumeId", "Consume");
                    sql = string.Format("insert into Consume values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                   C_ConsumeId, G_GuestId,lvSelect.Items[i].SubItems[0].Text, lvSelect.Items[i].SubItems[2].Text,lvSelect.Items[i].SubItems[3].Text,
                   DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "商品消费", UserHelper.LoginId, "");
                    //MessageBox.Show(sql);
                    rows = db.UpdateDeleteAdd(sql);
                }

                if (rows > 0)
                {
                    MessageBox.Show("消费成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("消费失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //验证是否为空
        private bool ValidateInput()
        {
            if (cboRoomId.Text == "")
            {
                MessageBox.Show("房间号不能为空！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (lvSelect.Items.Count <= 0)
            {
                MessageBox.Show("您没有选择任何商品", " 温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        //往将右移
        private void btnRight_Click(object sender, EventArgs e)
        {
            LeftMoveRight();
        }

        //清空商品
        private void btnClear_Click(object sender, EventArgs e)
        {
            ShowAllWare("");
            lvSelect.Items.Clear();
        }

        //往将商品左移
        private void btnLeft_Click(object sender, EventArgs e)
        {
            RightMoveLeft();
        }       
    }
}