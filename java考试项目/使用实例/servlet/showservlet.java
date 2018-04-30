//登录成功后进入的显示所有数据的页面，即主页面

package com.mvc.servlet1;

import java.io.IOException;
import java.util.ArrayList;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.mvc.bean.Info;
import com.mvc.bean.newdao;


public class showservlet extends HttpServlet {

	protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		newdao d=new newdao();   //创建一个newdao对象
		ArrayList<Info> infos=d.show();  //调用newdao类中的show方法
	        req.getSession().setAttribute("infos",infos) ;  //得到数据库中xs表中的所有信息
		req.getRequestDispatcher("show.jsp").forward(req, resp);   //跳转到显示所有数据的页面，即show.jsp页面
	}
}