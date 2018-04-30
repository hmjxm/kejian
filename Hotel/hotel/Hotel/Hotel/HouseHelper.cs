using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel
{
    public class HouseHelper
    {
        public MainForm mf;

       

        //获得类型
        public string GetHouseType(string RoomTypeId)
        {
            string Roomtype = "";
            DBHelper db = null;
            try
            {
                string sql = string.Format("select R_Type from RoomType where R_RoomId='{0}'", RoomTypeId);
                db = new DBHelper();
                SqlDataReader sdr = db.SelectAll(sql);
                if (sdr.Read())
                {
                    Roomtype = sdr["R_Type"].ToString();
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
            //MessageBox.Show(Roomtype);
            return Roomtype;
        }

        //判断是否是预订
        public bool ValidateIsBook(string p,string dateTime)
        {
            DateTime time = Convert.ToDateTime( null);
            DBHelper db = null;
            db = new DBHelper();
            string sql = string.Format("select Bookleave from Book where Room_id='{0}'",p);
            
            SqlDataReader sdr = db.SelectAll(sql);
            if(sdr.Read())
            {
                time = Convert.ToDateTime(sdr["Bookleave"]);                
            }
            int result = DateTime.Compare(time,Convert.ToDateTime(dateTime));
            
            if (result == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //传入房间号，返回自动生成的id
        public string GetR_id(string p)
        {
            string R_id = "";
            DBHelper db = null;
            try
            {
                string sql = string.Format("select R_id from Room where R_RoomId='{0}'", p);
                db = new DBHelper();
                SqlDataReader sdr = db.SelectAll(sql);
                if (sdr.Read())
                {
                    R_id = sdr["R_id"].ToString();
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
            return R_id;
        }

        //传入自动生成的id，返回房间号
        public string GetRoomId(string p)
        {
            string Room_id = "";
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select R_RoomId from Room where R_id = '{0}'", p);
                SqlDataReader sdr = db.SelectAll(sql);
                if (sdr.Read())
                {
                    Room_id = sdr["R_RoomId"].ToString();
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
            return Room_id;
        }



        //导出Excel的方法

        public void getListView(ListView lsv, string title)
        {
            Excel.Application app = null;
            try
            {
                app = new Excel.Application();
                app.Visible = true;
                object obj = System.Reflection.Missing.Value;
                Excel.Workbooks wb = app.Workbooks;
                Excel._Workbook iwk = wb.Add(obj);
                Excel._Worksheet sheet = (Excel._Worksheet)(iwk.ActiveSheet);
                int colCount = lsv.Columns.Count;
                int rowCount = lsv.Items.Count;
                app.Caption = title;

                string[,] dataArray = new string[rowCount + 1, colCount];

                //添加列头标题
                for (int i = 0; i < colCount; i++)
                {
                    dataArray[0, i] = lsv.Columns[i].Text.ToString();
                }

                //添加每一行的数据
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < colCount; j++)
                    {

                        dataArray[i + 1, j] = lsv.Items[i].SubItems[j].Text.ToString();

                    }
                }
                sheet.get_Range("A1", sheet.Cells[rowCount + 1, colCount]).Value2 = dataArray;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                GC.Collect();
                app.Quit();
            }
        }

       
       

        //刷新
        public void ShowHouseState(int type)
        {
            HouseHelper hh = new HouseHelper();
            mf.lvConsole.Items.Clear();
            string R_RoomId = "";
            string RoomType = "";
            string state = "";
            string floot = "";
            string Uname = "";
            string AdvanceForegift = "";
            string Underwrite = "";
            string comeDate = "";
            string Bookleave = "";
            string R_price = "";
            string Operator = "";
            string remark = "";

            string sql = "";
            DBHelper db = null;
            try
            {
                if (type == 0)
                {
                    sql = string.Format("select * from temp left join Book on temp.R_id=Book.R_id and Book.State !='解除预订'");
                }
                else if (type >= 1 && type <= 7)
                {
                    sql = string.Format("select * from temp left join Book on temp.R_id=Book.R_id where temp.RoomType={0}", type);
                }
                else
                {
                    string tempType = "";
                    if(type==8)
                    {
                        tempType = "空净";
                    }
                    else if(type==9)
                    {
                        tempType = "待客";
                    }
                    else if(type==10)
                    {
                        tempType = "预订";
                    }
                    else if (type == 11)
                    {
                        tempType = "自用";
                    }
                    else if (type == 12)
                    {
                        tempType = "整理";
                    }

                    sql = string.Format("select * from temp left join Book on temp.R_id=Book.R_id where temp.state='{0}'", tempType);
                }
                db = new DBHelper();
                SqlDataReader sdr = db.SelectAll(sql);

                while (sdr.Read())
                {
                    R_RoomId = sdr[1].ToString();
                    RoomType = hh.GetHouseType(sdr[5].ToString());
                    state = sdr[3].ToString();
                    floot = sdr[4].ToString();
                    Uname = sdr[9].ToString();
                    AdvanceForegift = sdr[10].ToString();
                    Underwrite = sdr[11].ToString();
                    comeDate = sdr[12].ToString();
                    Bookleave = sdr[13].ToString();
                    R_price = sdr[2].ToString();
                    Operator = sdr[15].ToString();
                    remark = sdr[16].ToString();


                    
                    if (sdr[21].ToString() == "预订" ||sdr[21].ToString() == "待客")
                    {
                        Uname = sdr[27].ToString();
                        //MessageBox.Show(Uname);
                        AdvanceForegift = sdr[22].ToString();
                        Underwrite = sdr[23].ToString();
                        comeDate = sdr[24].ToString();
                        Bookleave = sdr[25].ToString();
                        Operator = sdr[26].ToString();
                        remark = sdr[33].ToString();
                    }


                    if (state == "空净")
                    {
                        Uname = "";
                        AdvanceForegift = "";
                        comeDate = "";
                        Bookleave = "";
                        Operator = "";
                        remark = "";
                    }


                    ListViewItem lviHouse = new ListViewItem(R_RoomId);
                    lviHouse.Tag = sdr["G_GuestId"].ToString();
                   // MessageBox.Show(lviHouse.Tag.ToString());
                    string[] strRoom ={ RoomType,state, floot, Uname, AdvanceForegift, Underwrite, comeDate, Bookleave, R_price, Operator, remark };
                    lviHouse.SubItems.AddRange(strRoom);
                    mf.lvConsole.Items.Add(lviHouse);
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

        //判断是否有预订
        public bool IshaveBook(string R_id)
        {
            DBHelper db = null;
            db = new DBHelper();
            string sql = string.Format("select * from Book where R_id='{0}' and State='预订'", R_id);
            SqlDataReader sdr = db.SelectAll(sql);
            if (sdr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
