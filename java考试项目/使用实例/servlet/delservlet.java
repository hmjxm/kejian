//将删除数据和页面联系在一起的一些操作

package com.mvc.servlet1;

import java.io.IOException;
import java.sql.SQLException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.mvc.bean.newdao;

public class delservlet extends HttpServlet{
	protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		 resp.setContentType("text/html");
		 resp.setCharacterEncoding("utf-8");
                 //获取前端xh文本框中的数据
		 String xh= new String(req.getParameter("xh").getBytes("ISO8859_1"),"utf-8");
		 newdao d=new newdao();  //创建newdao对象
		 try {
			boolean isDelete=d.delete(xh);  //调用newdao类中的delete方法,判断是否可以进行删除
			if(isDelete)   //如果返回true，即可以进行删除，则返回到主页面，显示删除操作后的所有数据
			{
				resp.sendRedirect("showServlet");
			}
			else  //如果返回false，即不能进行删除，则给出以下提示，并且还是跳转到删除页面
			{
				req.setAttribute("delError", "不存在此学号，无法删除，请重新输入！");
    	    	req.getRequestDispatcher("delete.jsp").forward(req, resp);     	    	
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		 
		 
	}
}
