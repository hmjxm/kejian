//显示查询te数据库xs表数据结果的页面

<%@ page language="java" contentType="text/html; charset=utf-8" import="java.util.*" isELIgnored="false" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<html>
<head>
</head>
<body>
<h1 align="center">学生信息查询结果</h1>
 <table border="1" align="center">
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