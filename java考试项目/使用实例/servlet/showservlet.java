//��¼�ɹ���������ʾ�������ݵ�ҳ�棬����ҳ��

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
		newdao d=new newdao();   //����һ��newdao����
		ArrayList<Info> infos=d.show();  //����newdao���е�show����
	        req.getSession().setAttribute("infos",infos) ;  //�õ����ݿ���xs���е�������Ϣ
		req.getRequestDispatcher("show.jsp").forward(req, resp);   //��ת����ʾ�������ݵ�ҳ�棬��show.jspҳ��
	}
}