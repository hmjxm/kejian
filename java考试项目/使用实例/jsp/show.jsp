//显示te数据库xs表所有数据的页面

<%@ page language="java" contentType="text/html; charset=utf-8" import="java.util.*" isELIgnored="false"  import="com.mvc.bean.User" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"  %>
<html>
<head>
</head>
<body>
<h2><%=((User)session.getAttribute("user")).getUname() %></h2>
<h2>欢迎登录学生信息系统!</h2>
   <a href="exitServlet" >退出！</a>
<h1 align="center">学生个人信息</h1>
 <table border="1" align="center">
     <tr><a href="insert.jsp">增加</a>
         <a href="delete.jsp">删除</a>
         <a href="update.jsp">修改</a>
         <a href="query.jsp">查询</a>
     </tr>
     <tr>
  			<td><b>学号</b></td>
  			<td><b>姓名</b></td>
  			<td><b>年龄</b></td>
  			<td><b>学院</b></td>

  	</tr>
     <c:forEach items="${infos}" var="info">
  		<tr>
  			<td>${info.xh }</td>
  			<td>${info.xm }</td>
  			<td>${info.age}</td>
  			<td>${info.xy}</td>
  		</tr>
  	 </c:forEach>
 </table>
</body>
</html>