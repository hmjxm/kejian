//登录页面

<%@ page language="java" contentType="text/html; charset=utf-8"%>
<html>
<head>
</head>
<body>
<div align="center">
   <h3><%=request.getAttribute("loginError")==null?"":request.getAttribute("loginError") %></h3>
   <h1 >用户登录</h1>   
   <form name=regFrm action="loginServlet" method="post">
                               用户名:<input type=text name=uname /><br />
                               密码:<input type=password name=pwd /><br /><br />
            <input type=submit value="登录">
            <a href="reg.jsp" align="center" >注册</a> 
            <a href="fog.jsp" align="center" >忘记密码？</a>
            <a href="zx.jsp" align="center" >注销</a>  
   </form> 
   </div>        
</body>
</html>