//����Ա���С���¼������ע�ᡱ�����������룿������ע��������ʱ������Ҫ�漰����һЩ�������ݵĲ���

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
	
       public int logoin(User user) throws SQLException{  //����Ա���С���¼������Ҫ���еĲ���

       conn = (Connection) connection.getConnection(); //��ȡ��te���ݿ������
       sql = "select * from users";	    //��ȡte���ݿ���users�������е�����
       pstat = (PreparedStatement) conn.prepareStatement(sql);//Ԥ����sql���
       ResultSet rs= (ResultSet) pstat.executeQuery();  //ִ��sql��佫��ȡ��ֵ����rs������
       String uname=user.getUname();  //��ȡǰ�˴�����User����ȡ��User������û���
       String pwd=user.getPwd();      //��ȡǰ�˴�����User����ȡ��User���������
       boolean flag=false;
       while(rs.next())           //�ж�ǰ��������û����Ͷ�Ӧ�������Ƿ���������ݿ���
	    {
	            String userName = rs.getString("uname");
	            String userPassword = rs.getString("pwd");
	            if(uname.equals(userName))
	            	flag=true;
	            if((uname.equals(userName))&&(pwd.equals(userPassword))&&pwd.length()>=6)
	            {
                           //��������û���������������ݿ��������볤��>=6���򷵻�1��
	                   return 1;  
	            }
	    }	
       if(uname.isEmpty()||pwd.isEmpty())  //�ж��û����������Ƿ�Ϊ�գ�Ϊ�գ�����0��
			return 0;
       if(flag==false)     //�ж��û����Ƿ���ڣ��������ڣ�����3��
    	   return 3;
       if(pwd.length()<6)  //�ж���������볤���Ƿ�С��6λ����С��6λ���򷵻�2��
    	   return 2;     
	    return 4;              
	}
	
	public int regist(User user) throws SQLException{   //����Ա���С�ע�ᡱ����Ҫ���еĲ���
	   conn = (Connection) connection.getConnection();
	   sql = "insert into users values(?,?)";  //��ǰ�˴��������ݲ��뵽te���ݿ���users���
	    pstat = (PreparedStatement) conn.prepareStatement(sql);//��sql������Ԥ����
	    pstat.setString(1,user.getUname()); //��ǰ�˻�ȡ�Ķ�����û�����ֵ��sql����еĵ�һ��������
	    pstat.setString(2,user.getPwd());   //��ǰ�˻�ȡ�Ķ�������븳ֵ��sql����еĵڶ���������

	    String sql1="select * from users";	//��ȡte���ݿ���users�������е�����
	    PreparedStatement pstat1=(PreparedStatement) conn.prepareStatement(sql1);//��sql1������Ԥ����
		ResultSet rs= (ResultSet) pstat1.executeQuery(); //ִ��sql1��佫��ȡ��ֵ����rs������

		if(user.getUname().isEmpty()||user.getPwd().isEmpty()) //�ж��û����������Ƿ�Ϊ�գ���Ϊ�գ�����3��
			return 3;
		boolean flag=false;
	    while(rs.next())    //�ж�ǰ��������û����Ƿ���������ݿ���
	    {
	    	    String uname=user.getUname();
	            String userName = rs.getString("uname");
	            if((uname.equals(userName))) //��������û����Ѿ����ڣ��򲻿��Խ���ע�ᣬ����0��
	            {
	                   flag=true;
	                   return 0;
	            }
	    }		   
	    if((user.getPwd().toCharArray().length>=6)&&(flag==false))//���û��������������볤��>=6������Խ���ע�ᣬ����1��
	    {
	    	pstat.executeUpdate();
	        return 1;
	    }
	    if((user.getPwd().toCharArray().length<6))//���û���������<6���򲻿���ע�ᣬ����2��
	    {
	        return 2;
	    }
	    
	    pstat.close();
	    conn.close();
	    return 4;
	}

	
	public int foget(User user,String pwd2) throws SQLException{   //����Ա���С��������롱����Ҫ���еĲ���
    	String sql="update users set pwd=? where uname=?";  //����ǰ�˴�����ֵ�޸����ݿ�te��users���д��ڵ�ֵ
        conn=(Connection) connection.getConnection(); 
    	pstat=(PreparedStatement) conn.prepareStatement(sql);
    	pstat.setString(1, user.getPwd());    //��ǰ�˻�ȡ�Ķ�������븳ֵ��sql����еĵ�һ��������
    	pstat.setString(2, user.getUname());  //��ǰ�˻�ȡ�Ķ�����û�����ֵ��sql����еĵڶ���������
    	
    	String sql1="select * from users";  //��ȡte���ݿ���users�������е�����
    	PreparedStatement pstat1=(PreparedStatement) conn.prepareStatement(sql1);
		ResultSet rs= (ResultSet) pstat1.executeQuery();
		if(user.getUname().isEmpty()||user.getPwd().isEmpty()||pwd2.isEmpty())//�ж�ǰ��������û��������롢ȷ�������Ƿ�Ϊ�գ���Ϊ�գ�����0��
			return 0;
		boolean flag=false;
	    while(rs.next())  //�ж�ǰ��������û����Ƿ���������ݿ���
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
               //���ǰ�������û������ڣ������ȷ������һ�������볤��>=6λʱ������Խ����������룬����1��
        		pstat.executeUpdate();
        	    return 1; 
        }  
	    if(flag==false)  //��������û��������ڣ��򷵻�2��
	    	return 2;
	    if(user.getPwd().length()<6||pwd2.length()<6) //������������ȷ������ĳ���<6λ���򷵻�3��
        	return 3;
	    if(!user.getPwd().equals(pwd2))   //������������ȷ�����벻һ�£��򷵻�4��
	    	return 4;
	    
        return 5;
  	}
	
	
	 public boolean zx(String uname) throws SQLException{     //����Ա���С�ע��������Ҫ���еĲ���
	        sql="DELETE FROM users WHERE uname=? ";    //����ǰ�˴��������ݶ�te���ݿ�users���е����ݽ���ɾ��
	        conn=(Connection) connection.getConnection(); 
	    	pstat=(PreparedStatement) conn.prepareStatement(sql);
	    	pstat.setString(1, uname);   //��ǰ�˻�ȡ�Ķ�����û�����ֵ��sql����еĵ�һ��������
	    	if(pstat.executeUpdate()==1) //������ݿ���һ�����ݷ����仯����˵���˲����ɹ�������true�����򣬷���false��
	    	{
	    		return true;
	    	}  	
	    	return false;    	 
	  	}
	 
	 
		
		
	
}
