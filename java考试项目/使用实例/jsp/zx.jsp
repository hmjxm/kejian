//注销页面

<%@ page language="java" contentType="text/html; charset=utf-8"%>
<html>
<head>
</head>
<body>
<div align="center">
   <h3><%=request.getAttribute("zxError")==null?"":request.getAttribute("zxError") %></h3>
   <h1 >用户注销</h1>   
   <form name=zxFrm action="zxServlet" method="post">
                               用户名:<input type=text name=uname /><br /><br />
              <input type=submit value="提交">
   </form> 
   </div>        
</body>
</html>