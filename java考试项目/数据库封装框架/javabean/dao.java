//管理员进行“登录”、“注册”、“忘记密码？”、“注销”操作时，所需要涉及到的一些关于数据的操作

package com.mvc.bean;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

import com.mvc.bean.Info;
import com.mvc.bean.connection;
import com.mysql.jdbc.Connection;
import com.mysql.jdbc.PreparedStatement;

public class dao {
	private Connection conn;
	private PreparedStatement pstat;
	String sql="";
	
       public int logoin(User user) throws SQLException{  //管理员进行“登录”所需要进行的操作

       conn = (Connection) connection.getConnection(); //获取对te数据库的连接
       sql = "select * from users";	    //获取te数据库中users表中所有的数据
       pstat = (PreparedStatement) conn.prepareStatement(sql);//预处理sql语句
       ResultSet rs= (ResultSet) pstat.executeQuery();  //执行sql语句将获取的值放在rs集合中
       String uname=user.getUname();  //读取前端传来的User对象，取出User对象的用户名
       String pwd=user.getPwd();      //读取前端传来的User对象，取出User对象的密码
       boolean flag=false;
       while(rs.next())           //判断前端输入的用户名和对应的密码是否存在于数据库中
	    {
	            String userName = rs.getString("uname");
	            String userPassword = rs.getString("pwd");
	            if(uname.equals(userName))
	            	flag=true;
	            if((uname.equals(userName))&&(pwd.equals(userPassword))&&pwd.length()>=6)
	            {
                           //若输入的用户名和密码存在数据库中且密码长度>=6，则返回1；
	                   return 1;  
	            }
	    }	
       if(uname.isEmpty()||pwd.isEmpty())  //判断用户名或密码是否为空，为空，返回0；
			return 0;
       if(flag==false)     //判断用户名是否存在，若不存在，返回3；
    	   return 3;
       if(pwd.length()<6)  //判断输入的密码长度是否小于6位，若小于6位，则返回2；
    	   return 2;     
	    return 4;              
	}
	
	public int regist(User user) throws SQLException{   //管理员进行“注册”所需要进行的操作
	   conn = (Connection) connection.getConnection();
	   sql = "insert into users values(?,?)";  //将前端传来的数据插入到te数据库中users表里；
	    pstat = (PreparedStatement) conn.prepareStatement(sql);//对sql语句进行预处理
	    pstat.setString(1,user.getUname()); //将前端获取的对象的用户名赋值给sql语句中的第一个“？”
	    pstat.setString(2,user.getPwd());   //将前端获取的对象的密码赋值给sql语句中的第二个“？”

	    String sql1="select * from users";	//获取te数据库中users表中所有的数据
	    PreparedStatement pstat1=(PreparedStatement) conn.prepareStatement(sql1);//对sql1语句进行预处理
		ResultSet rs= (ResultSet) pstat1.executeQuery(); //执行sql1语句将获取的值放在rs集合中

		if(user.getUname().isEmpty()||user.getPwd().isEmpty()) //判断用户名或密码是否为空，若为空，返回3；
			return 3;
		boolean flag=false;
	    while(rs.next())    //判断前端输入的用户名是否存在于数据库中
	    {
	    	    String uname=user.getUname();
	            String userName = rs.getString("uname");
	            if((uname.equals(userName))) //若输入的用户名已经存在，则不可以进行注册，返回0；
	            {
	                   flag=true;
	                   return 0;
	            }
	    }		   
	    if((user.getPwd().toCharArray().length>=6)&&(flag==false))//若用户名不存在且密码长度>=6，则可以进行注册，返回1；
	    {
	    	pstat.executeUpdate();
	        return 1;
	    }
	    if((user.getPwd().toCharArray().length<6))//若用户名的密码<6，则不可以注册，返回2；
	    {
	        return 2;
	    }
	    
	    pstat.close();
	    conn.close();
	    return 4;
	}

	
	public int foget(User user,String pwd2) throws SQLException{   //管理员进行“重置密码”所需要进行的操作
    	String sql="update users set pwd=? where uname=?";  //根据前端传来的值修改数据库te中users表中存在的值
        conn=(Connection) connection.getConnection(); 
    	pstat=(PreparedStatement) conn.prepareStatement(sql);
    	pstat.setString(1, user.getPwd());    //将前端获取的对象的密码赋值给sql语句中的第一个“？”
    	pstat.setString(2, user.getUname());  //将前端获取的对象的用户名赋值给sql语句中的第二个“？”
    	
    	String sql1="select * from users";  //获取te数据库中users表中所有的数据
    	PreparedStatement pstat1=(PreparedStatement) conn.prepareStatement(sql1);
		ResultSet rs= (ResultSet) pstat1.executeQuery();
		if(user.getUname().isEmpty()||user.getPwd().isEmpty()||pwd2.isEmpty())//判断前端输入的用户名、密码、确认密码是否为空，若为空，返回0；
			return 0;
		boolean flag=false;
	    while(rs.next())  //判断前端输入的用户名是否存在于数据库中
	    {
	    	    String uname=user.getUname();
	            String userName = rs.getString("uname");
	            if((uname.equals(userName)))  
	            {
	                   flag=true;
	            }
	    }	
	    if((user.getPwd().equals(pwd2))&&(user.getPwd().toCharArray().length>=6)&&flag==true)
        {
               //如果前端输入用户名存在，密码和确认密码一致且密码长度>=6位时，则可以进行重置密码，返回1；
        		pstat.executeUpdate();
        	    return 1; 
        }  
	    if(flag==false)  //若输入的用户名不存在，则返回2；
	    	return 2;
	    if(user.getPwd().length()<6||pwd2.length()<6) //若输入的密码或确认密码的长度<6位，则返回3；
        	return 3;
	    if(!user.getPwd().equals(pwd2))   //若输入的密码和确认密码不一致，则返回4；
	    	return 4;
	    
        return 5;
  	}
	
	
	 public boolean zx(String uname) throws SQLException{     //管理员进行“注销”所需要进行的操作
	        sql="DELETE FROM users WHERE uname=? ";    //根据前端传来的数据对te数据库users表中的数据进行删除
	        conn=(Connection) connection.getConnection(); 
	    	pstat=(PreparedStatement) conn.prepareStatement(sql);
	    	pstat.setString(1, uname);   //将前端获取的对象的用户名赋值给sql语句中的第一个“？”
	    	if(pstat.executeUpdate()==1) //如果数据库中一行数据发生变化，则说明此操作成功，返回true；否则，返回false；
	    	{
	    		return true;
	    	}  	
	    	return false;    	 
	  	}
	 
	 
		
		
	
}
