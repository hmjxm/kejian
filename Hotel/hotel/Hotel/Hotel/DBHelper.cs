using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel
{
    public class DBHelper
    {
        SqlDataReader dataReader = null;    //dataRader  对象
        SqlCommand com = null;      //执行命令
        SqlConnection con = null;   //连库类
        
        /// <summary>
        /// 构造函数
        /// </summary>
        public DBHelper()
        {           
            //连接数据库字符串
            string connStr = "Data source=.;Initial Catalog=hotel;Integrated Security=True";

            con = new SqlConnection(connStr);
            //打开数据库连接
            con.Open();
            com = new SqlCommand();
            com.Connection = con;
        }

        /// <summary>
        /// 增删改查
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int UpdateDeleteAdd(string sql)
        {
            com.CommandText = sql;
            int rows = com.ExecuteNonQuery();
            return rows;
        }

        /// <summary>
        /// 查询多个值的方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlDataReader SelectAll(string sql)
        {
            com.CommandText = sql;
            dataReader = com.ExecuteReader();
            return dataReader;
        }

        /// <summary>
        /// 查询单个值的方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public double SelectOne(string sql)
        {
            double count;
            com.CommandText = sql;
            if (com.ExecuteScalar() is DBNull)
            {
                count = 0;                
            }
            else
            {                
                count = Convert.ToDouble(com.ExecuteScalar());               
            }
            return count;
        }

        /// <summary>
        /// 关闭数据库连接 
        /// </summary>
        public void GetClose()
        {
            con.Close();
        }
    }
}
