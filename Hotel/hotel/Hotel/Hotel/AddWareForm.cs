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
    public partial class AddWareForm : Form
    {
        int type;
        List<string> ListSdr;　　　　//创建lsit集合
        public AddWareForm(int type)
        {
            this.type = type;
            InitializeComponent();
        }

        //接收list方法
        public void accept(List<string> str)
        {
            this.ListSdr = str;            
        }

        //加载事件
        private void AddWareForm_Load(object sender, EventArgs e)
        {

            //根据type显示不同的信息
            Info();
            //显示商品名
            ShowInfo();
            //显示商品类型
            ShowWareType();
        }

        //显示商品类型
        private void ShowWareType()
        {
            cboType.Items.Clear();
            string WareType;
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select WareTypeName from WareType");
                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    WareType = sdr["WareTypeName"].ToString();
                    cboType.Items.Add(WareType);
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

        //显示商品名
        private void ShowInfo()
        {
            cboName.Items.Clear();
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from Ware");
                SqlDataReader sdr = db.SelectAll(sql);

                while (sdr.Read())
                {
                    cboName.Items.Add(sdr["WareName"].ToString());
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

        //根据type显示不同的信息
        private void Info()
        {
            if (type == 0)
            {
                dtpDate.Text = DateTime.Now.ToString();

                cboWareUnit.Enabled = false;
                txtComePrice.Enabled = false;
                txtGoPrice.Enabled = false;
                cboType.Enabled = false;
                txtWareEasyName.Enabled = false;
                cboName.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                this.Text = "修改商品";
                btnAdd.Text = "保存";
                cbkBatch.Visible = false;
                chkNewWare.Visible = false;
                grbAdd.Text = "修改";
                
                //将传进来的list赋给相对应的文框

                txtComePrice.Text = ListSdr[1];
                txtGoPrice.Text = ListSdr[2];
                cboType.Text = ListSdr[3];
                txtCount.Text = ListSdr[4];
                cboWareUnit.Text = ListSdr[5];
                txtWareEasyName.Text = ListSdr[6];
                dtpDate.Text = ListSdr[7];
                cboAuthorized.Text = ListSdr[8];
            }
        }

       //控制只能输入数据小数点回车退格
        private void txtComePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        //控制只能输入数据小数点回车退格
        private void txtGoPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //添加按钮
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(ValidateInput())
            {

                if (Convert.ToDouble(txtComePrice.Text) >= Convert.ToDouble(txtGoPrice.Text))
                {
                    MessageBox.Show("预售单价不能小于或等于进货单价！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                
                AddWare();
            }
        }

        //添加商品方法
        private void AddWare()
        {
            //bool isFind;
            DBHelper db = null;
            string sql = "";
            try
            {
                db = new DBHelper();

                if (type == 0&&chkNewWare.Checked==true)
                {
                    db = new DBHelper();
                    sql = string.Format("select count(*) from Ware where WareName='{0}'", cboName.Text);
                    int count = (int) db.SelectOne(sql);
                    if (count > 0)
                    {
                        MessageBox.Show("已有此商品！请修改数量！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    sql = string.Format("insert into Ware values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                    cboName.Text, txtComePrice.Text, txtGoPrice.Text, txtWareEasyName.Text, cboType.Text, txtCount.Text, cboWareUnit.Text, Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd HH:mm:ss"), cboAuthorized.Text
                    );
                }
                else if (type == 0 && chkNewWare.Checked == false)
                {
                    int count = 0;
                    db = new DBHelper();
                    sql = string.Format("select WareCount from Ware where WareName='{0}'", cboName.Text);

                    SqlDataReader sdr = db.SelectAll(sql);
                    if (sdr.Read())
                    {
                        count = Convert.ToInt32(sdr["WareCount"]);
                    }
                    sdr.Close();

                    sql = string.Format("update Ware set WareName= '{0}',WareComePrice='{1}',WareGoPrice='{2}',WareEasyName='{3}',WareType='{4}',WareCount='{5}',WareUnit='{6}',Date='{7}',authorized='{8}' where WareName='{0}'",
                        cboName.Text, txtComePrice.Text, txtGoPrice.Text, txtWareEasyName.Text, cboType.Text, Convert.ToString(Convert.ToInt32(txtCount.Text) + count).ToString(), cboWareUnit.Text, Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd HH:mm:ss"), cboAuthorized.Text
                       );
                }
                else
                {
                    sql = string.Format("update Ware set WareName= '{0}',WareComePrice='{1}',WareGoPrice='{2}',WareEasyName='{3}',WareType='{4}',WareCount='{5}',WareUnit='{6}',Date='{7}',authorized='{8}' where WareName='{0}'",
                           cboName.Text, txtComePrice.Text, txtGoPrice.Text, txtWareEasyName.Text, cboType.Text, Convert.ToString(Convert.ToInt32(txtCount.Text)).ToString(), cboWareUnit.Text, Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd HH:mm:ss"), cboAuthorized.Text
                          );
                }

                if (db.UpdateDeleteAdd(sql) > 0)
                {
                    MessageBox.Show("操作成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (cbkBatch.Checked)
                    {
                        cboName.Text = "";
                        txtCount.Text = "";
                        cboWareUnit.Text = "";
                        txtWareEasyName.Text = "";
                        cboType.Text = "";
                        txtComePrice.Text = "";
                        txtGoPrice.Text = "";
                        cboAuthorized.Text = "";
                    }
                    else
                    {
                        this.Close();
                    }                    
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


        //验证是否为空
        private bool ValidateInput()
        {
            bool isOk = true;
            if (cboName.Text == "")
            {
                cboName.BackColor = Color.Red;
                cboName.Focus();
                isOk = false;
            }
            if (txtCount.Text == "")
            {
                txtCount.BackColor = Color.Red;
                txtCount.Focus();
                isOk = false;
            }
            if (cboWareUnit.Text == "")
            {
                cboWareUnit.BackColor = Color.Red;
                cboWareUnit.Focus();
                isOk = false;
            }

            if (txtWareEasyName.Text == "")
            {
                txtWareEasyName.BackColor = Color.Red;
                txtWareEasyName.Focus();
                isOk = false;
            }
            if (txtComePrice.Text == "")
            {
                txtComePrice.BackColor = Color.Red;
                txtComePrice.Focus();
                isOk = false;
            }
            if (txtGoPrice.Text == "")
            {
                txtGoPrice.BackColor = Color.Red;
                txtGoPrice.Focus();
                isOk = false;
            }            
            return isOk;
        }

        //取消按钮
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //文本框的值改变时，改变背景颜色 
        private void cboName_TextChanged(object sender, EventArgs e)
        {
            this.cboName.BackColor = Color.White;
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            txtCount.BackColor = Color.White;
        }

        private void txtWareEasyName_TextChanged(object sender, EventArgs e)
        {
            txtWareEasyName.BackColor = Color.White;
        }

        private void cboType_TextChanged(object sender, EventArgs e)
        {
            cboType.BackColor = Color.White;
        }

        private void txtComePrice_TextChanged(object sender, EventArgs e)
        {
            txtComePrice.BackColor = Color.White;
        }

        private void txtGoPrice_TextChanged(object sender, EventArgs e)
        {
            txtGoPrice.BackColor = Color.White;
        }

        private void cboAuthorized_TextChanged(object sender, EventArgs e)
        {
            cboAuthorized.BackColor = Color.White;
        }

        //新商品多选 事件
        private void chkNewWare_CheckedChanged(object sender, EventArgs e)
        {
            //如果是是新商品则可以修改相关数据
            if (chkNewWare.Checked == false)
            {
                cboWareUnit.Enabled = false;
                txtComePrice.Enabled = false;
                txtGoPrice.Enabled = false;
                cboType.Enabled = false;
                txtWareEasyName.Enabled = false;
                cboName.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                cboWareUnit.Enabled = true;
                txtComePrice.Enabled = true;
                txtGoPrice.Enabled = true;
                cboType.Enabled = true;
                txtWareEasyName.Enabled = true;
                cboName.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }

        //根据名字查询
        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboName.DropDownStyle == ComboBoxStyle.DropDownList)
            {
                DBHelper db = null;
                try
                {
                    db = new DBHelper();
                    string sql = string.Format("select * from Ware where WareName='{0}'", cboName.Text);
                    SqlDataReader sdr = db.SelectAll(sql);

                    if (sdr.Read())
                    {
                        cboWareUnit.Text = sdr["WareUnit"].ToString();
                        txtCount.Text = sdr["WareCount"].ToString();
                        txtComePrice.Text = sdr["WareComePrice"].ToString();
                        txtGoPrice.Text = sdr["WareGoPrice"].ToString();
                        cboType.Text = sdr["WareType"].ToString();
                        txtWareEasyName.Text = sdr["WareEasyName"].ToString();
                        cboAuthorized.Text = sdr["authorized"].ToString();
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

        //将list第一项传给下拉框
        private void AddWareForm_Shown(object sender, EventArgs e)
        {
            if(type!=0)
            {
                cboName.Text = ListSdr[0];
            }           
        }

        //控件只能输入数据和退格
        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }            
    }
}