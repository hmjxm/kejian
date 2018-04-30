////关于管理员信息users表中涉及的一些属性方法
package com.mvc.bean;

public class User {
	private String uname,pwd; //用户名，密码

	public User(String uname,String pwd){   //管理员信息的构造函数
		this.uname=uname;
		this.pwd=pwd;
	}
	public String getUname(){              //获取管理员的用户名
		return this.uname;
	}
	public void setUname(String uname){    //设置管理员的用户名
		this.uname=uname;
	}
	public String getPwd(){                //获取管理员的密码
		return this.pwd; 
	}
	public void setPwd(String pwd){        //设置管理员的密码
		this.pwd=pwd;
	}
}
