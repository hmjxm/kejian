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
    public partial class MoneySelsct : Form
    {
        public MoneySelsct()
        {
            InitializeComponent();
        }

        private void MoneySelsct_Load(object sender, EventArgs e)
        {
            //查询消费表里的收入记录
            string sql = "select * from Consume";
            DBHelper dx = new DBHelper();
            SqlDataReader dr = dx.SelectAll(sql);
            //循环录入到listview中
            while(dr.Read())
            {
                string id = dr["C_ConsumeId"].ToString();
                string type = dr["C_type"].ToString();
                string money = dr["Price"].ToString();
                string date = dr["date"].ToString();
                string Remark = dr["Remark"].ToString();
                ListViewItem list = new ListViewItem();
                list.Text = id;
                string[] sum ={type,money,date,Remark};
                list.SubItems.AddRange(sum);
                listone.Items.Add(list);
            }
            //关闭数据库
            dx.GetClose();

            //查询支出表中的支出记录
            string sqlone = "select * from defray";
            DBHelper dd = new DBHelper();
            SqlDataReader de = dd.SelectAll(sqlone);
            //循环录入到listview中
            while (de.Read())
            {
                string id = de["D_defrayId"].ToString();
                string type = de["C_type"].ToString();
                string money = de["price"].ToString();
                string date = de["date"].ToString();
                string remark = de["Remark"].ToString();
                ListViewItem listone = new ListViewItem();
                listone.Text = id;
                string[] sumone ={ type, money, date, remark };
                listone.SubItems.AddRange(sumone);
                listtwo.Items.Add(listone);

            }

            //关闭数据库
            dd.GetClose();
        }

        private void dtpDatetwo_CloseUp(object sender, EventArgs e)
        {

            //判断查询消费记录的截至日
            DateTime dateone = Convert.ToDateTime(dtpDateone.Text);
            DateTime datetwo = Convert.ToDateTime(dtpDatetwo.Text);
            if (datetwo > Convert.ToDateTime(DateTime.Now.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss")))
            {
                dtpDatetwo.Text = DateTime.Now.ToString();
                MessageBox.Show("不得超过当前时间一天~！");
                return;

            }

            //判断查询消费记录的截止日要比开始日大
            if(dateone>datetwo)
            {
                dtpDatetwo.Text=DateTime.Now.ToString();
                MessageBox.Show("截止时间要比开始的时间大！");
                return;
            }

            //清空listview
            listone.Items.Clear();

            //查询时间段的消费记录
            string sql = string.Format("select * from consume where date>'{0}' and date<'{1}'",dateone,datetwo);
            DBHelper dx=new DBHelper();
            SqlDataReader dr = dx.SelectAll(sql);

            //循环讲数据录入listview中
            while (dr.Read())
            {
                string id = dr["C_ConsumeId"].ToString();
                string type = dr["C_type"].ToString();
                string money = dr["Price"].ToString();
                string date = dr["date"].ToString();
                string Remark = dr["Remark"].ToString();
                ListViewItem list = new ListViewItem();
                list.Text = id;
                string[] sum ={ type, money, date, Remark };
                list.SubItems.AddRange(sum);
                listone.Items.Add(list);
            }

            //关闭数据库
            dx.GetClose();
        }

        private void dtpDateone_CloseUp(object sender, EventArgs e)
        {


            //判断查询消费记录的截止日要比开始日大
            DateTime dateone = Convert.ToDateTime(dtpDateone.Text);
            DateTime datetwo = Convert.ToDateTime(dtpDatetwo.Text);
            if (dateone > datetwo)
            {
                dtpdatethree.Text=DateTime.Now.ToString();

                MessageBox.Show("至什么时间要比开始的时间大！");
                return;
            }

            //清空listview记录
            listone.Items.Clear();

            //查询时间段的消费记录
            string sql = string.Format("select * from consume where date>'{0}' and date<'{1}'", dateone, datetwo);
            DBHelper dx = new DBHelper();
            SqlDataReader dr = dx.SelectAll(sql);

            //循环将数据录入listview中
            while (dr.Read())
            {
                string id = dr["C_ConsumeId"].ToString();
                string type = dr["C_type"].ToString();
                string money = dr["Price"].ToString();
                string date = dr["date"].ToString();
                string Remark = dr["Remark"].ToString();
                ListViewItem list = new ListViewItem();
                list.Text = id;
                string[] sum ={ type, money, date, Remark };
                list.SubItems.AddRange(sum);
                listone.Items.Add(list);
            }

            //关闭数据库
            dx.GetClose();
        }

        private void cboTypeone_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
                //通过类型查询消费记录
                string typeone = cboTypeone.SelectedItem.ToString();
                listone.Items.Clear();
                string sql;
                if (typeone == "全部")
                {
                    sql = "select * from consume";
                }
                else
                {
                    sql = string.Format("select * from consume where C_type='{0}'", typeone);
                }
                DBHelper dx = new DBHelper();
                SqlDataReader dr = dx.SelectAll(sql);

                //循环将数据录入listview中
                while (dr.Read())
                {
                    string id = dr["C_ConsumeId"].ToString();
                    string type = dr["C_type"].ToString();
                    string money = dr["Price"].ToString();
                    string date = dr["date"].ToString();
                    string Remark = dr["Remark"].ToString();
                    ListViewItem list = new ListViewItem();
                    list.Text = id;
                    string[] sum ={ type, money, date, Remark };
                    list.SubItems.AddRange(sum);
                    listone.Items.Add(list);
                }
            
            
             
                //打开数据库
                dx.GetClose();
            
        }

       
        private void dtpDatefrom_CloseUp(object sender, EventArgs e)
        {

            //判断查询支出记录的截至日
            DateTime dateone = Convert.ToDateTime(dtpdatethree.Text);
            DateTime datetwo = Convert.ToDateTime(dtpDatefrom.Text);
            if (datetwo > Convert.ToDateTime(DateTime.Now.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss")))
            {
                dtpDatefrom.Text=DateTime.Now.ToString(); 
                MessageBox.Show("不得超过当前时间一天~！");
                return;
            }

            //判断查询支出记录的截止日要比开始日大
            if (dateone > datetwo)
            {
               dtpDatefrom.Text=DateTime.Now.ToString();
                MessageBox.Show("至什么时间要比开始的时间大！");
                return;
            }

            //查询时间段的支出记录
            listtwo.Items.Clear();
            string sql = string.Format("select * from defray where date>'{0}' and date<'{1}'", dateone, datetwo);
            DBHelper dx = new DBHelper();
            SqlDataReader dr = dx.SelectAll(sql);
            
            //循环将数据录入listview中
            while (dr.Read())
            {
                string id = dr["D_defrayid"].ToString();
                string type = dr["c_type"].ToString();
                string money = dr["Price"].ToString();
                string date = dr["date"].ToString();
                string Remark = dr["Remark"].ToString();
                ListViewItem list = new ListViewItem();
                list.Text = id;
                string[] sum ={ type, money, date, Remark };
                list.SubItems.AddRange(sum);
                listtwo.Items.Add(list);
            }

            //关闭数据库
            dx.GetClose();
        }

       

        private void dtpdatethree_CloseUp(object sender, EventArgs e)
        {

            DateTime dateone = Convert.ToDateTime(dtpdatethree.Text);
            DateTime datetwo = Convert.ToDateTime(dtpDatefrom.Text);

            //判断查询支出记录的截止日要比开始日大
            if (dateone > datetwo)
            {
                dtpdatethree.Text = DateTime.Now.ToString();
                MessageBox.Show("至什么时间要比开始的时间大！");
                return;
            }

            //清空listview记录
            listtwo.Items.Clear();

            //查询时间段的支出记录
            string sql = string.Format("select * from defray where date>'{0}' and date<'{1}'", dateone, datetwo);
            DBHelper dx = new DBHelper();
            SqlDataReader dr = dx.SelectAll(sql);
            //循环将数据录入listview中
            while (dr.Read())
            {
                string id = dr["D_defrayid"].ToString();
                string type = dr["c_type"].ToString();
                string money = dr["Price"].ToString();
                string date = dr["date"].ToString();
                string Remark = dr["Remark"].ToString();
                ListViewItem list = new ListViewItem();
                list.Text = id;
                string[] sum ={ type, money, date, Remark };
                list.SubItems.AddRange(sum);
                listtwo.Items.Add(list);
            }
        }

        private void cboTypetwo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //通过类型查询支出记录
                string typeone = cboTypetwo.SelectedItem.ToString();
                string sql;
                if (typeone == "全部")
                {
                    sql = "select * from defray";
                }
                else
                {
                    sql = string.Format("select * from defray where C_type='{0}'", typeone);
                }
                DBHelper dx = new DBHelper();
                SqlDataReader dr = dx.SelectAll(sql);
                listtwo.Items.Clear();

                //循环将数据录入listveiw中
                while (dr.Read())
                {
                    string id = dr["D_defrayid"].ToString();
                    string type = dr["c_type"].ToString();
                    string money = dr["Price"].ToString();
                    string date = dr["date"].ToString();
                    string Remark = dr["Remark"].ToString();
                    ListViewItem list = new ListViewItem();
                    list.Text = id;
                    string[] sum ={ type, money, date, Remark };
                    list.SubItems.AddRange(sum);
                    listtwo.Items.Add(list);
                }
            
           
            
                //关闭数据库
                dx.GetClose();
            
        }
    }
}