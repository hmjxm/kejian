using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel
{
    public partial class AddAworkeForm : Form
    {
        public List<string> listString;  //list集合
        int type;  //验证 传进来的类型是添加还是修改

        //构造函有选举权
        public AddAworkeForm(int type)  
        {
            this.type = type;
            InitializeComponent();
        }

        //添加按钮
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //验证是否为空
            if (ValidateInput())
            {
                AddAwoke();
            }
        }

        //验证是否为空
        private bool ValidateInput()
        {
            bool isOk = true;
            if(txtA_content.Text=="")
            {
                txtA_content.BackColor = Color.Red;
                txtA_content.Focus();
                isOk = false;
            }
            return isOk;
        }

        //添加提醒
        private void AddAwoke()
        {
            AutoId ai = new AutoId();
            string A_AwokeId = ai.GetId("A_AwokeId", "Awoke");
            DBHelper db = null;
            string sql;
            try
            {
                //MessageBox.Show(dtpDate.Text);
                db = new DBHelper();
                //如果是0，则是添加语句  //否则是修改
                if (type == 0)
                {
                    sql = string.Format("insert into Awoke values('{0}','{1}','{2}','{3}','{4}')",
                        A_AwokeId, txtA_content.Text, cboState.Text, dtpDate.Text, txtRemark.Text
                        );
                }
                else
                {
                    sql = string.Format("update Awoke set A_content='{0}',State='{1}',Date='{2}',Remark='{3}' where A_AwokeId='{4}'",
                       txtA_content.Text, cboState.Text, dtpDate.Text, txtRemark.Text, listString[0]
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

        //窗体加载事件
        private void AddAworkeForm_Load(object sender, EventArgs e)
        {            
            //如果是0则是未读
            if (type == 0)
            {
                cboState.Text = "未读";
            }
            else
            {
                this.Text = "修改";
                btnAdd.Text = "保存";
                this.cboState.Enabled = true;

                this.txtA_content.Text = listString[1];
                this.cboState.Text = listString[2];
                this.dtpDate.Text = listString[3];
                this.txtRemark.Text = listString[4];
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void grbAddAwoke_Enter(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRemark_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_content_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRemark_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblState_Click(object sender, EventArgs e)
        {

        }

        private void lblA_content_Click(object sender, EventArgs e)
        {

        }
    }
}