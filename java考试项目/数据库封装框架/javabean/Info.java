//����ѧ����Ϣxs�����漰��һЩ���Է���

package com.mvc.bean;

public class Info {
	private String xh; //ѧ��
	private String xm; //����
	private String xy; //ѧԺ
	private int age;   //����
	
	public Info(String xh,String xm,int age,String xy){  //ѧ����Ϣ�Ĺ��캯��
		this.xh=xh;
		this.xm=xm;
		this.age=age;
		this.xy=xy;
	}
	
	public void setXm(String xm){    //����ѧ������
		this.xm=xm;
	}
	public String getXm(){           //��ȡѧ������
		return this.xm;
	}
	
	public void setXh(String xh){    //����ѧ��ѧ��
		this.xh=xh;
	}
	public String getXh(){           //��ȡѧ��ѧ��
		return this.xh;
	}
	
	public void setAge(int age){     //����ѧ������
		this.age=age;
	}
	public int getAge(){             //��ȡѧ������
		return  age;
	}
	
	public void setXy(String xy){    //����ѧ������ѧԺ
		this.xy=xy;
	}
	public String getXy(){           //��ȡѧ������ѧԺ
		return this.xy;
	}

}

