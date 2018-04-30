//用于将登录数据和登录页面联系在一起的一些操作

package com.mvc.servlet;

import java.io.IOException;
import java.sql.SQLException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.mvc.bean.User;
import com.mvc.bean.dao;

public class loginservlet extends HttpServlet {
	
	private static final long serialVersionUID = 1L;
	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {   //post方法

		 response.setContentType("text/html");
		 request.setCharacterEncoding("utf-8");
		String uname =request.getParameter("uname");  //获取登录界面uname文本框中的值
		 String pwd= request.getParameter("pwd");     //获取登录界面uname文本框中的值
		User user=new User(uname,pwd);     //将数据封装到User类中
		dao d=new dao();  //创建一个dao类
		int isLogin;
		try{
		 	isLogin=d.logoin(user);  //调用dao类中的login方法，判断是否能够登录
		 	switch(isLogin)
		 	{
		 	case 0:{          //若返回为0，则给出以下提示，并且还是跳转到登录页面
                        request.setAttribute("loginError", "用户名或密码不能为空,请重新输入!");
	                request.getRequestDispatcher("login.jsp").forward(request, response);
		 	        break;
		 	       }
		 	case 1:{         //若返回为1，则登录成功，并且跳转到主页面
		   		    request.getSession().setAttribute("user", user);
	 		        response.sendRedirect("showServlet");
	 		        break;
		           }
		 	case 2:{         //若返回为2，则给出以下提示，并且还是跳转到登录页面
                                request.setAttribute("loginError", "密码位数不得少于6位,请重新输入!");
		 	        request.getRequestDispatcher("login.jsp").forward(request, response);
 	                break;
 	               }
		 	case 3:{         //若返回为3，则给出以下提示，并且还是跳转到登录页面
                        request.setAttribute("loginError", "此用户名不存在,请重新输入!");
 	                request.getRequestDispatcher("login.jsp").forward(request, response);
                    break;
                   }
		 	}
		   }catch(SQLException e){
		        e.printStackTrace();
		 }
}
}
