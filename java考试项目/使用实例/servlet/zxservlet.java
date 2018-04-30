//将注销的数据和相关页面联系在一起的操作

package com.mvc.servlet;

import java.io.IOException;
import java.sql.SQLException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.mvc.bean.User;
import com.mvc.bean.dao;

public class zxservlet extends HttpServlet{
	protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		 resp.setContentType("text/html");
		 resp.setCharacterEncoding("utf-8");
                 //从前端获取uname文本框中的值
		 String uname = new String(req.getParameter("uname").getBytes("ISO8859_1"),"utf-8");
		 dao d=new dao();  //创建一个dao对象
		 try {
			boolean iszx=d.zx(uname);  //调用dao类中的zx方法，判断是否能够注销
			if(iszx) //若返回true，则可以注销，跳转到登录页面
			{
				resp.sendRedirect("login.jsp");
			}
			else  //若返回false，则给出以下提示，并还是跳转到注销页面
			{
				req.setAttribute("zxError","此用户名不存在，无法注销，请重新输入！");
    	    	req.getRequestDispatcher("zx.jsp").forward(req, resp);     	    	
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		 
		 
	}
}
