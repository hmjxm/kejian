////���ڹ���Ա��Ϣusers�����漰��һЩ���Է���
package com.mvc.bean;

public class User {
	private String uname,pwd; //�û���������

	public User(String uname,String pwd){   //����Ա��Ϣ�Ĺ��캯��
		this.uname=uname;
		this.pwd=pwd;
	}
	public String getUname(){              //��ȡ����Ա���û���
		return this.uname;
	}
	public void setUname(String uname){    //���ù���Ա���û���
		this.uname=uname;
	}
	public String getPwd(){                //��ȡ����Ա������
		return this.pwd; 
	}
	public void setPwd(String pwd){        //���ù���Ա������
		this.pwd=pwd;
	}
}
