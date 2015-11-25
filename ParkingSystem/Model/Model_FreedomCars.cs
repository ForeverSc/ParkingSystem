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
	/// Description of Model_FreedomCars.
	/// </summary>
	public class Model_FreedomCars
	{
		private int placeid;
		private string carnumbers;
        private DateTime entertime;
		private string mastername;
        private string contactway;
		
		public Model_FreedomCars(int placeid, string carnumbers,string mastername,string contactway,DateTime entertime)
		{
			this.placeid=placeid;
			this.carnumbers=carnumbers;
            this.contactway = contactway;
            this.entertime = entertime;
			this.mastername=mastername;
		}
        //供车离开时，查询实体使用
        public Model_FreedomCars(int placeid, string carnumbers, string mastername, string contactway)
        {
            this.placeid = placeid;
            this.carnumbers = carnumbers;
            this.contactway = contactway;
            this.mastername = mastername;
        }

        public string ReturnEnetertime()
        {
            return entertime.ToString();
        }

        //返回信息
		public int ReturnPlaceid()
		{
			return placeid;
		}
		public string  ReturnCarNumbers()
		{
			return carnumbers;
		}

        public string  ReturnContactWay()
        {
            return contactway;
        }
        
        public string ReturnMasterName()
        {
            return mastername;
        }


        
		
	}
}
