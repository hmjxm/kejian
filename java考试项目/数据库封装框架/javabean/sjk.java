//在te数据库下创建学生信息xs表和管理员信息users表

package com.mvc.bean;

import java.sql.SQLException;

import com.mysql.jdbc.Connection;
import com.mysql.jdbc.Statement;

public class sjk {
	public static void main(String[] args) throws SQLException {  
		Connection conn=(Connection) connection.getConnection(); //获取对te数据库的连接
		Statement stmt = (Statement) conn.createStatement();
		String sql = "create table users(uname varchar(100)character set utf8,pwd varchar(100)character set utf8)ENGINE=InnoDB DEFAULT CHARSET=utf8";   //创建管理员信息users表，有用户名和密码两个属性 

		String sql1 = "create table xs(xh varchar(100)character set utf8,"
				+ "xm varchar(100)character set utf8,age int,xy varchar(100)character set utf8)ENGINE=InnoDB DEFAULT CHARSET=utf8";        //创建学生信息xs表，有学号、姓名、年龄、学院四个属性 

		stmt.executeUpdate(sql);  //执行sql语句
		stmt.executeUpdate(sql1); //执行sql1语句
		System.out.println("Success to create table!");
	}
}
