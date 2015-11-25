/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2009-01-01
 * 时间: 18:51
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace ParkingSystem.Model
{
	/// <summary>
	/// Description of Model_Master.
	/// </summary>
	public class Model_Master
	{
			private string name;
			private string address;
			private int age;
			private string contactway;
            private string carnumbers;
						
		public Model_Master(string name, string contactway,string carnumbers,int age=0,string address=null)
		{
			this.name=name;
			this.address=address;
            this.carnumbers = carnumbers;
			this.age=age;
			this.contactway=contactway;			
		}
		
		public string ReturnName()
		{
			return name;
		}
		
		public string ReturnAddress()
		{
			return address;
		}
		public int ReturnAge()
		{
			return age;
		}
		public string ReturnContactway()
		{
			return contactway;
		}

        public void SetName(string name)
        {
            this.name = name;
        }
		
        
		
		
		
	}
}
