//将修改数据和页面联系在一起的一些操作

package com.mvc.servlet1;

import java.io.IOException;
import java.sql.SQLException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.mvc.bean.Info;
import com.mvc.bean.newdao;

public class updservlet extends HttpServlet{
	protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		 resp.setContentType("text/html");
		 resp.setCharacterEncoding("utf-8");
                 //获取前端xh文本框中的数据
		 String xh = new String(req.getParameter("xh").getBytes("ISO8859_1"),"utf-8");
                 //获取前端xm文本框中的数据
		 String xm= new String(req.getParameter("xm").getBytes("ISO8859_1"),"utf-8");
                 //获取前端age文本框中的数据
		 String age1= new String(req.getParameter("age").getBytes("ISO8859_1"),"utf-8");
                 //获取前端xy文本框中的数据
		 String xy= new String(req.getParameter("xy").getBytes("ISO8859_1"),"utf-8");
		 int age=0;
		 if(age1!=null)
		 {
			 age=Integer.parseInt(age1);
		 }
		 Info info=new Info(xh,xm,age,xy);  //将数据封装在Info类中
		 newdao d=new newdao();     //创建newdao对象
		 try {
			boolean isUpdate=d.update(info);   //调用newdao类中的update方法，判断是否可以修改数据
			if(isUpdate) //若返回true，即可以进行修改，则跳转到主页面，显示修改数据后的所有数据
			{
				resp.sendRedirect("showServlet");
			}
			else  //若返回false，即不能进行修改，则给出以下提示并且还是跳转到修改数据页面
			{
				req.setAttribute("updError", "不存在此学号，无法修改，请重新输入！");
   	    	req.getRequestDispatcher("update.jsp").forward(req, resp);     	    	
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		 
		 
	}
}
