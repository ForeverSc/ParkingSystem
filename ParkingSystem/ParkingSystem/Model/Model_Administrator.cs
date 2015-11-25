/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2009-01-01
 * 时间: 18:39
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace ParkingSystem.Model
{
	/// <summary>
	/// Description of Model_Administrator.
	/// </summary>
	public class Model_Administrator
	{
		
		
			private string idnumbers;
			private string password;
			private string name;
			private int age;
			private string contactway;
		//管理员（idnumbers,密码，姓名，年龄，联系方式）
		public Model_Administrator(string idnumbers,string password,string name=null,int age=0,string contactway=null)
		{
			this.idnumbers=idnumbers;
			this.password=password;
			this.name=name;
			this.age=age;
			this.contactway=contactway;
		}
		
		//返回管理员信息
		public string ReturnIdnumbers()
		{
			return idnumbers;
		}
        public string ReturnPassword()
        {
            return password;
        }
		public string ReturnName()
		{
			return name;
		}
		public int ReturnAge()
		{
			return age;
		}
		public string ReturnContactWay()
		{
			return contactway;
		}
		//修改管理员信息
		public void SetInformation(string idnumbers,string password,string name=null,int age=0,string contactway=null)
		{
			if (idnumbers=="") {
				//显示id不能为空
			}
			else
			 this.idnumbers=idnumbers;
			
			if (password=="") {
				//显示密码不能为空
			}
			else
			 this.password=password;	

			this.name=name;
			this.age=age;
			this.contactway=contactway;
			 		
		}
		
		
		
		
		
			
		
		
	}
}
