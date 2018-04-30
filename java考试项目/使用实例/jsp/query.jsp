//查询te数据库xs表数据的页面

<%@ page language="java" contentType="text/html; charset=utf-8"%>
<html>
<head>
</head>
<body>
  <div align="center"> 
<h3><%=request.getAttribute("queError")==null?"":request.getAttribute("queError") %></h3>
  <h1 align="center">查询数据</h1>
   <form name=queFrm action="queServlet" method="post" >
                               学号:<input type=text name=xh /><br />
               <input type=submit value="提交">              
   </form>   
   </div>      
</body>
</html>