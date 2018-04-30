//将增加数据和页面联系在一起的一些操作

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
                 //从前端获取xh文本框中的数据
		 String xh = new String(req.getParameter("xh").getBytes("ISO8859_1"),"utf-8");
                 //从前端获取xm文本框中的数据
		 String xm= new String(req.getParameter("xm").getBytes("ISO8859_1"),"utf-8");
                 //从前端获取age文本框中的数据
		 String age1= new String(req.getParameter("age").getBytes("ISO8859_1"),"utf-8");
                 //从前端获取xy文本框中的数据
		 String xy= new String(req.getParameter("xy").getBytes("ISO8859_1"),"utf-8");
		 int age=0;
		 if(age1!=null)
		 {
			 age=Integer.parseInt(age1);
		 }
		 Info info=new Info(xh,xm,age,xy); //将获取的数据封装到Info类中
		 newdao d=new newdao();       //创建newdao对象
		 d.insert(info);	      //调用newdao类中的insert方法
		 resp.sendRedirect("showServlet"); //返回到显示所有数据的页面，即主页面，显示修改后的所有数据
	}
}
