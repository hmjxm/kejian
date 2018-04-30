//将修改数据和页面联系在一起的一些操作

package com.mvc.servlet1;

import java.io.IOException;
import java.sql.SQLException;
import java.util.ArrayList;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.mvc.bean.Info;
import com.mvc.bean.newdao;

public class queservlet extends HttpServlet{
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		 response.setContentType("text/html");
		 request.setCharacterEncoding("utf-8");
                 //获取前端xh文本框中的数据
		 String xh= new String(request.getParameter("xh").getBytes("ISO8859_1"),"utf-8");
		newdao d=new newdao();  //创建一个newdao对象
		ArrayList<Info> infos=new ArrayList<Info>();  
		try {
			infos = d.query(xh);  //调用newdao类中的query方法，判断是否能够查询数据
		} catch (SQLException e) {
			e.printStackTrace();
		}

		if(!infos.isEmpty())  //如果返回的数组不为空，即可以查询到数据，则跳转到查询结果显示页面,即result.jsp
		{
	         request.getSession().setAttribute("infos",infos) ;
		     request.getRequestDispatcher("result.jsp").forward(request, response);
		}
		else    //若返回的数组为空，即不能查询到数据，则给出以下提示并且还是跳转到查询页面
    	{
    		request.setAttribute("queError", "无此学号，无法查询，请重新输入！");
	    	request.getRequestDispatcher("query.jsp").forward(request, response);
   	}
	}
}
