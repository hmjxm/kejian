//注册页面

<%@ page language="java" contentType="text/html; charset=utf-8"%>
<html>
<head>
</head>
<body>
<div align="center">
   <h3><%=request.getAttribute("regError")==null?"":request.getAttribute("regError") %></h3>
   <h1 >用户注册</h1>  
   <form name=regFrm action="regServlet" method="post">
                               用户名:<input type=text name=runame /><br />
                               密码:<input type=password name=rpwd /><br />
            <input type=submit value="注册">
   </form> 
   </div>        
</body>
</html>