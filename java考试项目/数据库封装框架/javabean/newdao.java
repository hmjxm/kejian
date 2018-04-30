//����Ա��¼�ɹ�������ҳ��󣬶�ѧ��������Ϣ��һЩ��ɾ�Ĳ������

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
	
	public ArrayList<Info> show(){     //��ʾ������������ҳ����
    	ArrayList<Info> infos=new ArrayList<Info>();
 	   try {	
 		  
 	       conn = (Connection) connection.getConnection(); //��ȡ��te���ݿ������
 	 	   sql = "select * from xs";   //��ȡte���ݿ���xs������������
 	 	   pstat = (PreparedStatement) conn.prepareStatement(sql);//��sql����Ԥ����
		   ResultSet rs= (ResultSet) pstat.executeQuery();  //��ִ��sql�������ȡ��ֵ�ŵ�rs������
		   while(rs.next())  //��ȡ����rs�е�ֵ������ֵ���뵽Info����
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
 	   return infos;   //����infos���飬��������te���ݿ�xs������������
    }
	
	
	public void insert(Info info){  //��te���ݿ�xs������������
	 	   conn = (Connection) connection.getConnection();
	 	   sql = "insert into xs values(?,?,?,?)"; //��ǰ�˻�ȡ��ֵ���ӵ�xs����
	 	   try{
	 	    pstat = (PreparedStatement) conn.prepareStatement(sql);//Ԥ����sql���
	 	    pstat.setString(1,info.getXh());   //����ȡ��ǰ�˶����ѧ�Ÿ�ֵ��sql����е�һ��������
	 	    pstat.setString(2,info.getXm());   //����ȡ��ǰ�˶����������ֵ��sql����еڶ���������
	 	    pstat.setInt(3, info.getAge());    //����ȡ��ǰ�˶�������丳ֵ��sql����е�����������
	 	    pstat.setString(4,info.getXy());   //����ȡ��ǰ�˶����ѧԺ��ֵ��sql����е��ĸ�������
	 	    pstat.executeUpdate();    //ִ��sql���
	 	    pstat.close();
	 	    conn.close();
	 	   
	 	   }catch(SQLException e){
	 	    e.printStackTrace();
	 	   }
	 	  
	 	}
	
	
	 public boolean delete(String xh) throws SQLException{   //��te���ݿ�xs����ɾ������
	        sql="DELETE FROM xs WHERE xh=?";   //����ǰ�������ѧ�ţ���xs�����ɾ������
	        conn=(Connection) connection.getConnection(); 
	    	pstat=(PreparedStatement) conn.prepareStatement(sql);
	    	pstat.setString(1, xh);  //����ȡ��ǰ�˶����ѧ�Ÿ�ֵ��sql����е�һ��������
	    	if(pstat.executeUpdate()==1) 
	    	{
                  //������ݿ�xs������һ�����ݷ����仯����������ɾ�����򷵻�true�����򣬷���false�� 
	    		return true;
	    	}  	
	    	return false;    	 
	  	}
	 
	 public boolean update(Info info) throws SQLException{   //��te���ݿ�xs�����޸�����
	    	String sql="update xs set xm=?, age=?,xy=? where xh=?";//����ǰ�������ѧ�ţ���xs������޸Ĳ���
	        conn=(Connection) connection.getConnection(); 
	    	pstat=(PreparedStatement) conn.prepareStatement(sql);
	    	pstat.setString(1, info.getXm()); //����ȡ��ǰ�˶����������ֵ��sql����е�һ��������
	    	pstat.setInt(2, info.getAge());   //����ȡ��ǰ�˶�������丳ֵ��sql����еڶ���������
	    	pstat.setString(3, info.getXy()); //����ȡ��ǰ�˶����ѧԺ��ֵ��sql����е�����������
	    	pstat.setString(4, info.getXh()); //����ȡ��ǰ�˶����ѧ�Ÿ�ֵ��sql����е��ĸ�������
	    	if(pstat.executeUpdate()==1)
	    	{
                   //������ݿ�xs������һ�����ݷ����仯�����޸������ݣ�����true�����򣬷���false��
	    		return true;
	    	}  	
	    	return false;    	 
	  	}
	 
	 public ArrayList<Info> query(String xh) throws SQLException{ //��te���ݿ�xs���в�ѯ����
	    	ArrayList<Info> infos=new ArrayList<Info>();//����һ�����飬�����е����ݾ�ΪInfo����
	 	   conn = (Connection) connection.getConnection();
	 	   sql = "select * from xs  where xh=?";  //���ݻ�ȡǰ�˵�ѧ������ȡxs���е�����
	 	   pstat = (PreparedStatement) conn.prepareStatement(sql);
	 	   pstat.setString(1, xh); //����ȡ��ǰ�˶����ѧ�Ÿ�ֵ��sql����е�һ��������
	 	   ResultSet rs= (ResultSet) pstat.executeQuery();
	 	   while(rs.next())
	 	   {
	 		  String xm = rs.getString(2);//��ȡ��ѧ�Ŷ�Ӧ������
	          int age = rs.getInt(3);  //��ȡ��ѧ�Ŷ�Ӧ������
	          String xy = rs.getString(4); //��ȡ��ѧ�Ŷ�Ӧ��ѧԺ
	          Info info=new Info(xh,xm,age,xy);
	          infos.add(info);
	 	   }
	 	   return infos;  //����info���飬���д���˴�ѧ������Ӧ�ĸ�ѧ���������Ϣ
	 	}
}
