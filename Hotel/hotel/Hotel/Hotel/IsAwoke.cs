using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace Hotel
{
    public static class IsAwoke
    {
        public static string sameName = "0";
        public static string foregiftSmall = "0";
        public static string IsRefurbish = "0";
        public static int Refurbish = 0;
        public static int IgnoreTime = 0;       
        public static int ExceedTime = 0;
        public static int GoOutBak = 0;
        public static string path = "";
        public static double discount = 0;

        public static bool  isExit = false;

        public static void isAwork()
        {
            DBHelper db = null;
            try
            {
                db = new DBHelper();
                string sql = string.Format("select * from SoftWareSet");
                SqlDataReader sdr = db.SelectAll(sql);
                while (sdr.Read())
                {
                    sameName = sdr["SameName"].ToString();
                    foregiftSmall = sdr["ForegiftSmall"].ToString();
                    IsRefurbish = sdr["IsRefurbish"].ToString();
                    Refurbish = Convert.ToInt32(sdr["Refurbish"]);
                    IgnoreTime = Convert.ToInt32(sdr["IgnoreTime"]);                    
                    ExceedTime = Convert.ToInt32(sdr["ExceedTime"]);
                    GoOutBak = Convert.ToInt32(sdr["GoOutBak"]);
                    discount = Convert.ToDouble(sdr["discount"]);

                    if ("D:\\hotel.bak" == sdr["S_Path"].ToString())
                    {
                        path = Application.StartupPath + "\\hotel.bak";
                    }
                    else
                    {
                        path = sdr["S_Path"].ToString();
                    }
                    
                }
                sdr.Close(); 
            }                
            catch (Exception)
            {

            }
        }
    }
}
