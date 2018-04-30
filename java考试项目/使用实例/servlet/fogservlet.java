//将重置密码的数据以及相关页面联系在一起的一些操作

package com.mvc.servlet;

import java.io.IOException;
import java.sql.SQLException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.mvc.bean.User;
import com.mvc.bean.dao;

public class fogservlet extends HttpServlet{
	protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		 resp.setContentType("text/html");
		 resp.setCharacterEncoding("utf-8");
                 //从前端获取funame文本框中的值
		 String funame = new String(req.getParameter("funame").getBytes("ISO8859_1"),"utf-8");
                 //从前端获取pwd1文本框中的值
		 String pwd1= new String(req.getParameter("pwd1").getBytes("ISO8859_1"),"utf-8");
                 //从前端获取pwd2文本框中的值
		 String pwd2= new String(req.getParameter("pwd2").getBytes("ISO8859_1"),"utf-8");	
		 User user=new User(funame,pwd1);  //将数据封装到User对象中
		 dao d=new dao();   //创建一个dao对象
		 try {
			 int isForget=d.foget(user,pwd2); //调用dao类中foget方法，判断是否可以重置密码
			 switch(isForget)
			 {
			 case 0:{           //若返回0，则给出以下提示，并且还是跳转到重置密码页面
				     req.setAttribute("fogError", "用户名或密码不得为空，请重新输入！");
	    	         req.getRequestDispatcher("fog.jsp").forward(req, resp);
	    	         break;
			        }
			 case 1:{           //若返回1，则重置密码成功，并且跳转到登录页面
				     resp.sendRedirect("login.jsp");
				     break;
			        }
			 case 2:{           //若返回2，则给出以下提示，并且还是跳转到重置密码页面
			         req.setAttribute("fogError", "此用户名不存在，无法重置密码，请重新输入！");
    	             req.getRequestDispatcher("fog.jsp").forward(req, resp);
    	             break;
		            }
			 case 3:{           //若返回3，则给出以下提示，并且还是跳转到重置密码页面
		             req.setAttribute("fogError", "密码不得少于6位，请重新输入！");
	                 req.getRequestDispatcher("fog.jsp").forward(req, resp);
	                 break;
	                }
			 case 4:{           //若返回4，则给出以下提示，并且还是跳转到重置密码页面
	                 req.setAttribute("fogError", "两次密码输入不一致，请重新输入！");
                     req.getRequestDispatcher("fog.jsp").forward(req, resp);
                     break;
                    }
			 }
		 } catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
	}
}
