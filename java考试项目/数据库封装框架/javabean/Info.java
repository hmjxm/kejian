//关于学生信息xs表中涉及的一些属性方法

package com.mvc.bean;

public class Info {
	private String xh; //学号
	private String xm; //姓名
	private String xy; //学院
	private int age;   //年龄
	
	public Info(String xh,String xm,int age,String xy){  //学生信息的构造函数
		this.xh=xh;
		this.xm=xm;
		this.age=age;
		this.xy=xy;
	}
	
	public void setXm(String xm){    //设置学生姓名
		this.xm=xm;
	}
	public String getXm(){           //获取学生姓名
		return this.xm;
	}
	
	public void setXh(String xh){    //设置学生学号
		this.xh=xh;
	}
	public String getXh(){           //获取学生学号
		return this.xh;
	}
	
	public void setAge(int age){     //设置学生年龄
		this.age=age;
	}
	public int getAge(){             //获取学生年龄
		return  age;
	}
	
	public void setXy(String xy){    //设置学生所在学院
		this.xy=xy;
	}
	public String getXy(){           //获取学生所在学院
		return this.xy;
	}

}

