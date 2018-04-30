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
    public partial class ShiftExchange : Form
    {
        public MainForm mf;
        public ShiftExchange()
        {
            InitializeComponent();
        }
        double sumone=0;
        private void ShiftExchange_Load(object sender, EventArgs e)
        {
            
            double price=0;
            //在交班的表中查找最后一条记录
            
            string sql = string.Format("select top 1  * from CashManage order by C_Id desc");
            txtjiaoban.Text = UserHelper.LoginId;
            txtxiaban.Text = UserHelper.LoginId;
            DBHelper dx = new DBHelper();
            SqlDataReader dr=dx.SelectAll(sql);
            DateTime jiaoban = Convert.ToDateTime("2008-1-1 12:00:00"); 
            

            if (dr.Read())
            {
                sumone = Convert.ToDouble(dr["c_sum"].ToString());
                jiaoban = Convert.ToDateTime(dr["jiebanDate"].ToString());
            }
                //关闭数据库
                dx.GetClose();
                dateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                
            //在消费表里查询上次交班到现在的所有记录

                string sqlone = string.Format("select * from Consume where date>'{0}' and date<'{1}'", Convert.ToDateTime(jiaoban).ToString("yyyy-MM-dd HH:mm:ss"), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                DBHelper dq = new DBHelper();
                SqlDataReader du = dq.SelectAll(sqlone);
            
            //循环录入到listview中

                while (du.Read())
                {
                    
                    string id = du["C_ConsumeId"].ToString();
                    string type = du["C_type"].ToString();
                    string money = du["price"].ToString();
                    string date = du["date"].ToString();
                    string Remark = du["Remark"].ToString();
                    ListViewItem list = new ListViewItem();
                    list.Text = id;
                    string[] sum ={ type, money, date, Remark };
                    list.SubItems.AddRange(sum);
                    listone.Items.Add(list);
                }
            //关闭数据库
                dq.GetClose();


            //查找时间段里的所有消费记录
               
                DBHelper dz = new DBHelper();
                SqlDataReader da = dz.SelectAll(sqlone);

             //循环录入到listview中

                while (da.Read())
                {
                    string id = da["C_ConsumeId"].ToString();
                    string type = da["C_type"].ToString();
                    string money = da["price"].ToString();
                    string date = da["date"].ToString();
                    string Remark = da["Remark"].ToString();
                    ListViewItem list = new ListViewItem();
                    list.Text = id;
                    string[] sum ={ type, money, date, Remark };
                    list.SubItems.AddRange(sum);
                    listtwo.Items.Add(list);
                }

            //关闭数据库
                dz.GetClose();

            //在数据库里查找时间段里的消费金额的总数

                string sqltheel = string.Format("select sum(Price) from Consume where date>'{0}' and date<'{1}'", Convert.ToDateTime(jiaoban).ToString("yyyy-MM-dd HH:mm:ss"), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                DBHelper di = new DBHelper();
                price = di.SelectOne(sqltheel);
            
                txtjiaobanqian.Text = price + "";
                txtxiabanqian.Text = txtjiaobanqian.Text;
             //关闭数据库
                di.GetClose();
            
        }

        private void bntascertainone_Click(object sender, EventArgs e)
        {
            string jieban = txtid.Text;
            string jiebanpwd = txtpwd.Text;
            string jiaobanqian = txtjiebanqian.Text;
            string jiebanqian = txtjiaobanqian.Text;

            //判断控件为非空

            if(jieban==""||jiaobanqian==""||jiebanpwd=="")
            {
                MessageBox.Show("接班人帐号、密码与接班金额不能为空``","温馨提醒",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
           //验证输入的帐号密码是否正确

            string sql = string.Format("select count(*) from admin where A_AdminId='{0}' and Password='{1}'",jieban,jiebanpwd);
            DBHelper dr = new DBHelper();
            double count = dr.SelectOne(sql);
            if(count<=0)
            {
                MessageBox.Show("请输入正确的接班人帐号与密码~！");
                return;
            }
            dr.GetClose();
            AutoId dx=new AutoId();
            string id = dx.GetId("C_id", "CashManage");
            string admin = txtid.Text;
            string jiaobanhou = txtjiaobanqian.Text;
            string jiebandate = dateTime.Text;

           //判断输入的是否都为数字
            try
            {
                double jiebanqianone = Convert.ToDouble(jiaobanqian);
            }
            catch
            {
                MessageBox.Show("接班金额只能是数字~！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


          // 判断是否为空
            if (double.Parse(jiaobanqian)<0)
            {
                MessageBox.Show("金额必须为非负数~！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            //判断交班时的金额是否相等

            if (jiaobanqian != jiebanqian)
            {
                DialogResult result =
                MessageBox.Show("接班金额与实际应有金额有差异~！是否交易`?", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                txtjiebanqian.SelectAll();
                txtjiebanqian.Focus();                
                return;
                
            }

            //在交班表里添加一条交班记录
            string sqlone = string.Format("insert into CashManage (C_Id,A_AdminId,C_sum,jiaobanhou,jiebanqian,jiebanDate) values('{0}','{1}','{2}','{3}','{4}','{5}')", id, admin, sumone, jiaobanhou, jiaobanqian, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            MessageBox.Show(sqlone);
            DBHelper de = new DBHelper();
            int countone = de.UpdateDeleteAdd(sqlone);

            if (countone > 0)
            {
                MessageBox.Show("交班成功~！","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                IsAwoke.isExit = true;
                this.Close();
                mf.Close();
                LoginForm lf = new LoginForm(this.txtid.Text, this.txtpwd.Text);
                lf.Show();
            }
            else
            {
                MessageBox.Show("交班失败~！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void btnascertaintwo_Click(object sender, EventArgs e)
        {

            AutoId dx = new AutoId();
            string id = dx.GetId("C_id", "CashManage");
            string admin = txtxiaban.Text;
            string jiaobanhou = txtxiabanqian.Text;
            sumone = sumone + double.Parse(jiaobanhou);
            string jiaobanqian = "0";
            string jiebandate = dateTimetwo.Text;
            
            //在交班表里添加一天下班记录

            string sqlone = string.Format("insert into CashManage (C_Id,A_AdminId,C_sum,jiaobanhou,jiebanqian,jiebanDate) values('{0}','{1}','{2}','{3}','{4}','{5}')", id, admin, sumone, jiaobanhou, jiaobanqian, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            DBHelper dr=new DBHelper();
            int count = dr.UpdateDeleteAdd(sqlone);
            if (count > 0)
            {
                MessageBox.Show("下班成功~！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                IsAwoke.isExit = true;
                Application.Exit();
            }
            else
            {
                MessageBox.Show("下班成功~！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //关闭数据库
            dr.GetClose();
        }

        private void btnabolishone_Click(object sender, EventArgs e)
        {
            //关闭窗口
            this.Close();
        }

        private void btnabolishtwo_Click(object sender, EventArgs e)
        {
            //关闭窗口
            this.Close();
        }

        private void txtjiebanqian_KeyPress(object sender, KeyPressEventArgs e)
        {
            //控制控件中只能输数字退格小数点
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

       
    }
}