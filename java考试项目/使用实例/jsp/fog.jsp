//重置密码页面

<%@ page language="java" contentType="text/html; charset=utf-8"%>
<html>
<head>
</head>
<body>
<div align="center">
   <h3><%=request.getAttribute("fogError")==null?"":request.getAttribute("fogError") %></h3>
   <h1 >重置密码</h1>  
   <form name=fogFrm action="fogServlet" method="post">
                          用户名:<input type=text name=funame /><br />
                               密码:<input type=password name=pwd1 /><br />
                               确认密码:<input type=password name=pwd2 /><br /><br />
            <input type=submit value="提交">
   </form> 
   </div>        
</body>
</html>