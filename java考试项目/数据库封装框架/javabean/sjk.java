//��te���ݿ��´���ѧ����Ϣxs��͹���Ա��Ϣusers��

package com.mvc.bean;

import java.sql.SQLException;

import com.mysql.jdbc.Connection;
import com.mysql.jdbc.Statement;

public class sjk {
	public static void main(String[] args) throws SQLException {  
		Connection conn=(Connection) connection.getConnection(); //��ȡ��te���ݿ������
		Statement stmt = (Statement) conn.createStatement();
		String sql = "create table users(uname varchar(100)character set utf8,pwd varchar(100)character set utf8)ENGINE=InnoDB DEFAULT CHARSET=utf8";   //��������Ա��Ϣusers�����û����������������� 

		String sql1 = "create table xs(xh varchar(100)character set utf8,"
				+ "xm varchar(100)character set utf8,age int,xy varchar(100)character set utf8)ENGINE=InnoDB DEFAULT CHARSET=utf8";        //����ѧ����Ϣxs����ѧ�š����������䡢ѧԺ�ĸ����� 

		stmt.executeUpdate(sql);  //ִ��sql���
		stmt.executeUpdate(sql1); //ִ��sql1���
		System.out.println("Success to create table!");
	}
}
