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
        private string contactway;
        private DateTime entertime;
		private double money;//欠费金额

 
	//查询返回时使用
		public Model_StaticCars(int placeid,string carnumbers,string name,string address,string contactway,double money,DateTime entertime)
		{
			this.placeid=placeid;
			this.carnumbers=carnumbers;
            this.name = name;
            this.address = address;     
            this.contactway = contactway;
			this.money=money;
            this.entertime = entertime;
		}

        //进入时使用
        public Model_StaticCars(string carnumbers, string name, string contactway)
        {
            this.carnumbers = carnumbers;
            this.name = name;
            this.contactway = contactway;
        }

        //双击查询时使用
        public Model_StaticCars(int placeid, string carnumbers, string name, string contactway, DateTime entertime)
        {
            this.placeid = placeid;
            this.name = name;
            this.contactway = contactway;
            this.carnumbers = carnumbers;
            this.entertime = entertime;
        }


        public Model_StaticCars(int placeid, string carnumbers, string name, string contactway, string address)
        {
            this.placeid = placeid;
            this.name = name;
            this.contactway = contactway;
            this.carnumbers = carnumbers;
            this.address = address;
        }

        public Model_StaticCars(int placeid, string carnumbers, string name, string contactway)
        {

            this.placeid = placeid;
            this.carnumbers = carnumbers;
            this.name = name;
            this.contactway = contactway;
        }

        public Model_StaticCars(string carnumbers, string name, string contactway, string placeid)
        {
            this.carnumbers = carnumbers;
            this.name = name;
            this.contactway = contactway;
            this.placeid = Convert.ToInt32(placeid);
        }

        public void SetEntertime(DateTime entertime)
        {
            this.entertime = entertime;

        }
        
		public int ReturnPlaceid()
		{
			return placeid;
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

        public string ReturnEntertime()
        {
            if (entertime.ToString() == "1900/1/1 0:00:00")
            {
                return "";
            }
            else
            {
                return entertime.ToString();
            }
            
        }
	}
}
