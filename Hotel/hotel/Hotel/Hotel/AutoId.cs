using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Hotel
{
    //此类  很用哦  自认为比较先进  呵呵!  臭下美！
    //自动生成id 格式为 20081018001 
    public class AutoId
    {

        //公开方法　　传入　id字段  和表名
        public string GetId(string field,string tableName)
        {
            DBHelper db = null;
            double today;
            try
            {
                //今天时间
                today = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));

                //查询是否有 今天日期 的id  例如 今天是 2008年10月18号 则第一个id 为20081018001 
                string sql = string.Format("select count({0}) from {1} where {0}='{2}'", field,tableName,today + "001");
                //MessageBox.Show(sql);
                db = new DBHelper();
                double countHave = db.SelectOne(sql);
                
                //如果存在 则再查询 今天日期最大的id 再累加   否则返回今天的 第一个id
                if (countHave > 0)
                {
                    sql = string.Format("select Max({0}) from {1}",field,tableName);
                    
                    db = new DBHelper();
                    field = db.SelectOne(sql).ToString();
                   
                    double temp = Convert.ToDouble(field);
                    //累加
                    temp++;
                    field=temp.ToString();
                    
                }
                else
                {                  
                    //今天的id
                    field = Convert.ToDouble((DateTime.Now.ToString("yyyyMMdd")) + "001").ToString();                   
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
            //返回
            return field.ToString();
        }
    }
}
