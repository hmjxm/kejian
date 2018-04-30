//删除te数据库xs表数据的页面

<%@ page language="java" contentType="text/html; charset=utf-8"%>
<html>
<head>
</head>
<body>
<div align="center"> 
<h3><%=request.getAttribute("delError")==null?"":request.getAttribute("delError") %></h3>
  <h1 align="center">删除数据</h1>
   <form name=delFrm action="delServlet" method="post" >
                              学号:<input type=text name=xh /><br />
               <input type=submit value="提交">              
   </form>   
   </div>      
</body>
</html>