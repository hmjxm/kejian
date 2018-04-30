using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//download by http://www.codefans.net
namespace Hotel
{
    public partial class AddHouseForm : Form
    {
        HouseHelper hh = new HouseHelper();　　　//辅助类
        string type;　　　//根据类型来判断是添加还是修改操作
        public AddHouseForm(string type)
        {
            this.type = type;
            InitializeComponent();
        }

        //关闭事件
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //添加事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //验证是否为空
            if(ValidateInput())
            {
                DBHelper db = null;
                db = new DBHelper();
                string sql = string.Format("select count(R_RoomId) from Room where R_RoomId='{0}'",txtRoom_id.Text);
                if(db.UpdateDeleteAdd(sql)>0)
                {
                    MessageBox.Show("已经存在相同的房间号，请另选！","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }                

                AddHouse();
            }            
        }

        //验证是否为空
        private bool ValidateInput()
        {
            bool isOk = true;
            if(txtRoom_id.Text=="")
            {
                txtRoom_id.BackColor = Color.Red;
                isOk = false;
            }
            if(txtFloot.Text=="") 
            {
                txtFloot.BackColor = Color.Red;
                isOk = false;
            }
            if(txtPrice.Text=="")
            {
                txtPrice.BackColor = Color.Red;
                isOk = false;
            }
            return isOk;
        }

        //添加操作
        private void AddHouse()
        {
            DBHelper db = null;
            string sql = "";
            try
            {
                db = new DBHelper();

                //根据type来判断是添加操作，还是修改操作
                if (type == "")
                {
                    sql = string.Format("insert into room values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                     txtRoom_id.Text, "空净", txtFloot.Text, (cboRoomType.SelectedIndex + 1), txtPrice.Text, 0, txtfixing.Text
                    );
                }
                else
                {
                    sql = string.Format("update room set R_RoomId='{0}',State='{1}',Floot='{2}',RoomType='{3}',price='{4}',R_Count='{5}',fixing='{6}' where R_RoomId='{7}'",
                      txtRoom_id.Text, "空净", txtFloot.Text, (cboRoomType.SelectedIndex + 1), txtPrice.Text, 0, txtfixing.Text,type
                       );
                }

                

                if (db.UpdateDeleteAdd(sql) > 0)
                {
                    MessageBox.Show("操作成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("操作失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //加载事件
        private void AddHouseForm_Load(object sender, EventArgs e)
        {
            //显示房间类型
            ShowHouseType();
            //根据type判断操作
            if (type == "")
            {
                
            }
            else
            {
                btnAdd.Text = "保存";
                this.Text = "修改";
                DBHelper db = null;
                try
                {
                    db = new DBHelper();
                    string sql = string.Format("select * from Room where R_RoomId='{0}'",type);
                    SqlDataReader sdr = db.SelectAll(sql);
                    if (sdr.Read())
                    {
                        txtRoom_id.Text = sdr["R_RoomId"].ToString();
                        txtFloot.Text = sdr["Floot"].ToString();                        
                        cboRoomType.Text = hh.GetHouseType(sdr["RoomType"].ToString());
                                                txtPrice.Text = sdr["price"].ToString();
                        txtfixing.Text = sdr["fixing"].ToString();
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
            
        }

        //显示房间类型
        private void ShowHouseType()
        {
            string RoomType;
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from RoomType");
                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    RoomType = sdr["R_Type"].ToString();
                    cboRoomType.Items.Add(RoomType);
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

        //根据下标来改变查询的条件
        private void cboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //显示价格
            ShowPrice(cboRoomType.SelectedIndex+1);
        }

        //显示价格方法
        private void ShowPrice(int price)
        {
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select price from Room where RoomType='{0}'", price);
                SqlDataReader sdr = db.SelectAll(sql);

                if (sdr.Read())
                {
                    this.txtPrice.Text = sdr["price"].ToString();
                    txtPrice.Enabled = false;
                }
                else
                {
                    txtPrice.Enabled = true;
                    txtPrice.Text = "";
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
        //文本框的值改变时，改变背景颜色 
        private void txtRoom_id_TextChanged(object sender, EventArgs e)
        {
            txtRoom_id.BackColor = Color.White;
        }

        private void txtFloot_TextChanged(object sender, EventArgs e)
        {
            txtFloot.BackColor = Color.White;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            txtPrice.BackColor = Color.White;
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {
            txtPrice.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePriceForm upf = new UpdatePriceForm();
            upf.ShowDialog();
        }

        //当成为激活窗体时，查询价格
        private void AddHouseForm_Activated(object sender, EventArgs e)
        {
            ShowPrice(cboRoomType.SelectedIndex + 1);
        }

        //当移出房间号文框，查询是否有相同号房间
        private void txtRoom_id_Leave(object sender, EventArgs e)
        {
            if (type != "")
            {
                return;
            }
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select count(*) from Room where R_RoomId = '{0}'", txtRoom_id.Text);

                if (db.SelectOne(sql) > 0)
                {
                    MessageBox.Show("已有相同的房间号！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRoom_id.Focus();
                    txtRoom_id.SelectAll();
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
}