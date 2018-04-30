//管理员登录成功进入主页面后，对学生个人信息的一些增删改查操作。

package com.mvc.bean;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

import com.mvc.bean.Info;
import com.mvc.bean.connection;
import com.mysql.jdbc.Connection;
import com.mysql.jdbc.PreparedStatement;

public class newdao {
	private Connection conn;
	private PreparedStatement pstat;
	String sql="";
	
	public ArrayList<Info> show(){     //显示所有数据在主页面上
    	ArrayList<Info> infos=new ArrayList<Info>();
 	   try {	
 		  
 	       conn = (Connection) connection.getConnection(); //获取对te数据库的连接
 	 	   sql = "select * from xs";   //获取te数据库中xs表中所有数据
 	 	   pstat = (PreparedStatement) conn.prepareStatement(sql);//对sql语句的预处理
		   ResultSet rs= (ResultSet) pstat.executeQuery();  //将执行sql语句所获取的值放到rs集合中
		   while(rs.next())  //获取集合rs中的值，并把值加入到Info类中
		    {
		            String xh= rs.getString(1);
		            String xm = rs.getString(2);
		            int age = rs.getInt(3);
		            String xy = rs.getString(4);
		            Info info=new Info(xh,xm,age,xy);
		            infos.add(info);
		    }
	} catch (SQLException e) {
		e.printStackTrace();
	}
 	   return infos;   //返回infos数组，里面存放了te数据库xs表中所有数据
    }
	
	
	public void insert(Info info){  //往te数据库xs表中增加数据
	 	   conn = (Connection) connection.getConnection();
	 	   sql = "insert into xs values(?,?,?,?)"; //将前端获取的值增加到xs表中
	 	   try{
	 	    pstat = (PreparedStatement) conn.prepareStatement(sql);//预处理sql语句
	 	    pstat.setString(1,info.getXh());   //将获取的前端对象的学号赋值给sql语句中第一个“？”
	 	    pstat.setString(2,info.getXm());   //将获取的前端对象的姓名赋值给sql语句中第二个“？”
	 	    pstat.setInt(3, info.getAge());    //将获取的前端对象的年龄赋值给sql语句中第三个“？”
	 	    pstat.setString(4,info.getXy());   //将获取的前端对象的学院赋值给sql语句中第四个“？”
	 	    pstat.executeUpdate();    //执行sql语句
	 	    pstat.close();
	 	    conn.close();
	 	   
	 	   }catch(SQLException e){
	 	    e.printStackTrace();
	 	   }
	 	  
	 	}
	
	
	 public boolean delete(String xh) throws SQLException{   //在te数据库xs表中删除数据
	        sql="DELETE FROM xs WHERE xh=?";   //根据前端输入的学号，对xs表进行删除操作
	        conn=(Connection) connection.getConnection(); 
	    	pstat=(PreparedStatement) conn.prepareStatement(sql);
	    	pstat.setString(1, xh);  //将获取的前端对象的学号赋值给sql语句中第一个“？”
	    	if(pstat.executeUpdate()==1) 
	    	{
                  //如果数据库xs表中有一行数据发生变化，即进行了删除，则返回true；否则，返回false； 
	    		return true;
	    	}  	
	    	return false;    	 
	  	}
	 
	 public boolean update(Info info) throws SQLException{   //在te数据库xs表中修改数据
	    	String sql="update xs set xm=?, age=?,xy=? where xh=?";//根据前端输入的学号，对xs表进行修改操作
	        conn=(Connection) connection.getConnection(); 
	    	pstat=(PreparedStatement) conn.prepareStatement(sql);
	    	pstat.setString(1, info.getXm()); //将获取的前端对象的姓名赋值给sql语句中第一个“？”
	    	pstat.setInt(2, info.getAge());   //将获取的前端对象的年龄赋值给sql语句中第二个“？”
	    	pstat.setString(3, info.getXy()); //将获取的前端对象的学院赋值给sql语句中第三个“？”
	    	pstat.setString(4, info.getXh()); //将获取的前端对象的学号赋值给sql语句中第四个“？”
	    	if(pstat.executeUpdate()==1)
	    	{
                   //如果数据库xs表中有一行数据发生变化，即修改了数据，返回true；否则，返回false；
	    		return true;
	    	}  	
	    	return false;    	 
	  	}
	 
	 public ArrayList<Info> query(String xh) throws SQLException{ //在te数据库xs表中查询数据
	    	ArrayList<Info> infos=new ArrayList<Info>();//创建一个数组，数组中的数据均为Info类型
	 	   conn = (Connection) connection.getConnection();
	 	   sql = "select * from xs  where xh=?";  //根据获取前端的学号来获取xs表中的数据
	 	   pstat = (PreparedStatement) conn.prepareStatement(sql);
	 	   pstat.setString(1, xh); //将获取的前端对象的学号赋值给sql语句中第一个“？”
	 	   ResultSet rs= (ResultSet) pstat.executeQuery();
	 	   while(rs.next())
	 	   {
	 		  String xm = rs.getString(2);//获取此学号对应的姓名
	          int age = rs.getInt(3);  //获取此学号对应的年龄
	          String xy = rs.getString(4); //获取此学号对应的学院
	          Info info=new Info(xh,xm,age,xy);
	          infos.add(info);
	 	   }
	 	   return infos;  //返回info数组，其中存放了此学号所对应的该学生的相关信息
	 	}
}
