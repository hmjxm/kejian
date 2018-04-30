//用于将注册时的数据和注册页面所联系在一起的一些操作

package com.mvc.servlet;

import java.io.IOException;
import java.sql.SQLException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.mvc.bean.User;
import com.mvc.bean.dao;

public class regservlet extends HttpServlet {

	protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		 resp.setContentType("text/html");
		 resp.setCharacterEncoding("utf-8");

                 //从前端获取runame文本框中的值
		 String runame = new String(req.getParameter("runame").getBytes("ISO8859_1"),"utf-8");
                 //从前端获取rpwd文本框中的值
		 String rpwd= new String(req.getParameter("rpwd").getBytes("ISO8859_1"),"utf-8");
		User user=new User(runame,rpwd); //把获取的数据封装到User类中
		dao d=new dao();  //创建了一个dao对象
		int isReg;
		try {
			isReg = d.regist(user);  //调用dao类中regist方法，来判断是否可以注册
			switch(isReg)
			{
			case 0:{       //若返回为0，则给出以下提示，并且还是跳转到注册的页面
                        req.setAttribute("regError", "此用户名已存在,请重新输入!");
	                req.getRequestDispatcher("reg.jsp").forward(req, resp);
			        break;
			        }
			case 1:        //若返回为1，则注册成功，并且跳转到登录的页面
                               resp.sendRedirect("login.jsp");break;

			case 2:{        //若返回为2，则给出以下提示，并且还是跳转到注册的页面
                    req.setAttribute("regError", "密码位数不得少于6位,请重新输入!");
                    req.getRequestDispatcher("reg.jsp").forward(req, resp);
	                break;
	               }
			case 3:{        //若返回为3，则给出以下提示，并且还是跳转到注册的页面
                    req.setAttribute("regError", "用户名或密码不能为空,请重新输入!");
                    req.getRequestDispatcher("reg.jsp").forward(req, resp);
                    break;
                   }
		}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		

	}
}
