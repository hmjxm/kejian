//���������ݺ�ҳ����ϵ��һ���һЩ����

package com.mvc.servlet1;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.mvc.bean.Info;
import com.mvc.bean.newdao;

public class insservlet extends HttpServlet{
	protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		 resp.setContentType("text/html");
		 resp.setCharacterEncoding("utf-8");
                 //��ǰ�˻�ȡxh�ı����е�����
		 String xh = new String(req.getParameter("xh").getBytes("ISO8859_1"),"utf-8");
                 //��ǰ�˻�ȡxm�ı����е�����
		 String xm= new String(req.getParameter("xm").getBytes("ISO8859_1"),"utf-8");
                 //��ǰ�˻�ȡage�ı����е�����
		 String age1= new String(req.getParameter("age").getBytes("ISO8859_1"),"utf-8");
                 //��ǰ�˻�ȡxy�ı����е�����
		 String xy= new String(req.getParameter("xy").getBytes("ISO8859_1"),"utf-8");
		 int age=0;
		 if(age1!=null)
		 {
			 age=Integer.parseInt(age1);
		 }
		 Info info=new Info(xh,xm,age,xy); //����ȡ�����ݷ�װ��Info����
		 newdao d=new newdao();       //����newdao����
		 d.insert(info);	      //����newdao���е�insert����
		 resp.sendRedirect("showServlet"); //���ص���ʾ�������ݵ�ҳ�棬����ҳ�棬��ʾ�޸ĺ����������
	}
}
