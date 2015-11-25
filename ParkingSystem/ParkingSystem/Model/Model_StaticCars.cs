/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2009-01-01
 * 时间: 19:43
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;


namespace ParkingSystem.Model
{
	/// <summary>
	/// Description of Model_StaticCars.
	/// </summary>
	public class Model_StaticCars
	{
		private int placeid;
		private string carnumbers;
        private string name;
        private string address;
        private int age;
        private string contactway;
		private double money;//包月费用
 
	
		public Model_StaticCars(int placeid,int age, string carnumbers,string name,string address,string contactway,double money)
		{
			this.placeid=placeid;
			this.carnumbers=carnumbers;
            this.name = name;
            this.address = address;
            this.age = age;
            this.contactway = contactway;
			this.money=money;	
		}
		
		public int ReturnPlaceid()
		{
			return placeid;
		}

        public int ReturnAge()
        {
            return age;
        }
        public string ReturnAddress()
        {
            return address;
        }

		public string ReturnCarnumbers()
		{
			return carnumbers;
		}

		public double ReturnMoney()
		{
			return money;
		}

        public string ReturnName()
        {
            return name;
        }
        public string ReturnContactway()
        {
            return contactway;
        }
       
		
        //public void SetInformation(string carnumbers,string name,int placeid ,string color,double money)
        //{
        //    this.carnumbers=carnumbers;
        //    this.master.SetName(name);
        //    this.placeid = placeid;
        //    this.color = color;
        //    this.money = money;
        //}
		
		
		
	}
}
