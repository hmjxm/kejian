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
    public partial class PurviewForm : Form
    {
        string AdminId;
        //传入用户名
        public PurviewForm(string AdminId)
        {
            this.AdminId = AdminId;
            InitializeComponent();
        }

        //取消铵钮
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //加载事件
        private void PurviewForm_Load(object sender, EventArgs e)
        {
            this.lblAdminId.Text = AdminId;
            ShowPurview();
            if (AdminId == "admin")
            {
                chkSysSet.Enabled = false;
                chkIspurview.Enabled = false;
            }
        }

        //从数据库里面读取值　来决定　复选框是否选中
        private void ShowPurview()
        {
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from purview where Admin ='{0}'", AdminId);
                SqlDataReader sdr = db.SelectAll(sql);

                if (sdr.Read())
                {
                    chkIspurview.Checked = (bool)sdr[1];
                    chkSysSet.Checked = (bool)sdr[2];

                    chkHAdd.Checked = (bool)sdr[3];
                    chkHUpdate.Checked = (bool)sdr[4];
                    chkHDelete.Checked = (bool)sdr[5];

                    chkEAdd.Checked = (bool)sdr[6];
                    chkEUpdate.Checked = (bool)sdr[7];
                    chkEDelete.Checked = (bool)sdr[8];

                    chkAAdd.Checked = (bool)sdr[9];
                    chkAUpdate.Checked = (bool)sdr[10];
                    chkADelete.Checked = (bool)sdr[11];

                    chkUAdd.Checked = (bool)sdr[12];
                    chkUUpdate.Checked = (bool)sdr[13];
                    chkUDelete.Checked = (bool)sdr[14];

                    chkLLook.Checked = (bool)sdr[15];
                    chkLDelete.Checked = (bool)sdr[16];

                    chkQiantai.Checked = (bool)sdr[17];
                    chkYuding.Checked = (bool)sdr[18];
                    chkShouYin.Checked = (bool)sdr[19];
                    chkBaseOper.Checked = (bool)sdr[20];
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

        //保存按钮
        private void btnSave_Click(object sender, EventArgs e)
        {
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("update purview set Ispurview = '{0}',SysSet = '{1}',HAdd = '{2}',HUpdate = '{3}',HDelete = '{4}',EAdd = '{5}',EUpdate = '{6}',EDelete = '{7}',AAdd = '{8}',AUpdate = '{9}',ADelete = '{10}',UAdd = '{11}',UUpdate = '{12}',UDelete = '{13}',LLook = '{14}',LDelete = '{15}' ,Qiantai = '{16}',Yuding = '{17}',ShouYin = '{18}',jiben = '{19}' where Admin='{20}' ",
                    (chkIspurview.Checked == true) ? 1 : 0,
                    (chkSysSet.Checked == true) ? 1 : 0,

                    (chkHAdd.Checked == true) ? 1 : 0,
                    (chkHUpdate.Checked == true) ? 1 : 0,
                    (chkHDelete.Checked == true) ? 1 : 0,

                    (chkEAdd.Checked == true) ? 1 : 0,
                    (chkEUpdate.Checked == true) ? 1 : 0,
                    (chkEDelete.Checked == true) ? 1 : 0,

                    (chkAAdd.Checked == true) ? 1 : 0,
                    (chkAUpdate.Checked == true) ? 1 : 0,
                    (chkADelete.Checked == true) ? 1 : 0,

                    (chkUAdd.Checked == true) ? 1 : 0,
                    (chkUUpdate.Checked == true) ? 1 : 0,
                    (chkUDelete.Checked == true) ? 1 : 0,

                    (chkLLook.Checked == true) ? 1 : 0,
                    (chkLDelete.Checked == true) ? 1 : 0,

                    (chkQiantai.Checked == true) ? 1 : 0,
                    (chkYuding.Checked == true) ? 1 : 0,
                    (chkShouYin.Checked == true) ? 1 : 0,
                    (chkBaseOper.Checked == true) ? 1 : 0,
                    AdminId
                    );
                if (db.UpdateDeleteAdd(sql) > 0)
                {
                    MessageBox.Show("保存成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
       

        //如果基本操作没有，则 N 多权限没有
        private void chkBaseOper_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBaseOper.Checked == false)
            {
                grbHouse.Enabled = false;
                grbAwoke.Enabled = false;
                grbEmp.Enabled = false;
                grbQianDan.Enabled = false;

                chkHAdd.Checked = false;
                chkHUpdate.Checked = false;
                chkHDelete.Checked = false;

                chkEAdd.Checked = false;
                chkEUpdate.Checked = false;
                chkEDelete.Checked = false;

                chkAAdd.Checked = false;
                chkAUpdate.Checked = false;
                chkADelete.Checked = false;

                chkUAdd.Checked = false;
                chkUUpdate.Checked = false;
                chkUDelete.Checked = false;
            }
            else
            {
                grbHouse.Enabled = true;
                grbAwoke.Enabled = true;
                grbEmp.Enabled = true;
                grbQianDan.Enabled = true;


                chkHAdd.Checked = true;
                chkHUpdate.Checked = true;
                chkHDelete.Checked = true;

                chkEAdd.Checked = true;
                chkEUpdate.Checked = true;
                chkEDelete.Checked = true;

                chkAAdd.Checked = true;
                chkAUpdate.Checked = true;
                chkADelete.Checked = true;

                chkUAdd.Checked = true;
                chkUUpdate.Checked = true;
                chkUDelete.Checked = true;
            }
        }
    }
}