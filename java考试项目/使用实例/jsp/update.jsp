//修改te数据库xs表数据的页面

<%@ page language="java" contentType="text/html; charset=utf-8"%>
<html>
<head>
</head>
<body>
  <div align="center"> 
<h3><%=request.getAttribute("updError")==null?"":request.getAttribute("updError") %></h3>
  <h1 align="center">修改数据</h1>
   <form name=updFrm action="updServlet" method="post" >
                              学号:<input type=text name=xh /><br />
                               姓名:<input type=text name=xm /><br />
                               年龄:<input type=text name=age /><br />
                               学院:<input type=text name=xy /><br /><br />
               <input type=submit value="提交">              
   </form>   
   </div>      
</body>
</html>