/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2009-01-01
 * 时间: 19:44
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace ParkingSystem.Model
{
	/// <summary>
	/// Description of Model_Records.
	/// </summary>
	public class Model_Records
	{
		private static int recordid=0;//流水id
        private int thisid; 
		private DateTime entertime;
		private DateTime outertime;
        private string mastername;
        private string contactway;
        private string carnumbers;
        private int placeid;	
		private double  money;//这条记录所花费的金额

        //新建使用，未完成的
		public Model_Records(string mastername, string carnumbers,string contactway,int placeid,DateTime entertime )
		{
            this.mastername = mastername;
            this.carnumbers = carnumbers;
            this.placeid = placeid;
            this.contactway = contactway;
			this.entertime=entertime;
            recordid+= 1;
            this.thisid = recordid;
		}

        //未完成的记录查询使用
        public Model_Records(int id, string mastername, string carnumbers, string contactway, int placeid, DateTime entertime)
        {
            this.thisid = id;
            this.mastername = mastername;
            this.carnumbers = carnumbers;
            this.placeid = placeid;
            this.contactway = contactway;
            this.entertime = entertime;
         
        }


        //结账使用，查询使用,已经完成的记录
        public Model_Records(int id,string mastername, string carnumbers, string contactway, int placeid, DateTime entertime,DateTime leavetime,double money)
        {
            this.thisid = id;
            this.mastername = mastername;
            this.carnumbers = carnumbers;
            this.placeid = placeid;
            this.contactway = contactway;
            this.entertime = entertime;
            this.outertime =leavetime;
            this.money = money;
        }

        public void SetOuttime(DateTime outime)
        {
            this.outertime = outime;
        }

        public void SetMoney(double hoursmoney)
        {
            TimeSpan timespan = outertime - entertime;
            this.money = ((timespan.Days * 24 + timespan.Hours + timespan.Minutes / 60) * money);
        }

        public string ReturnAllStayTime()
        {
            TimeSpan timespan =outertime-entertime;
            return timespan.ToString();
        }
        public string ReturnMoney()
        {
            return money.ToString();
        }






        //设置离开时间


        //设置账单



		
        ////获取并设置离开时间
        //public void Setoutertime(DateTime outertime)
        //{
        //    this.outertime=outertime;
        //}
        ////设置收费
        //public void SetMoney(string money)
        //{
        //    this.money=money;
        //}
		
        //返回所有信息
		public int ReturnId()
		{
			return thisid;
		}
		public string ReturnEntertime()
		{
			return entertime.ToString();
		}
		public string ReturnOutertime()
		{
			return outertime.ToString();
		}
	
		public int ReturnPlaceid()
		{
			return placeid;
		}
		public string  ReturnCarNumbers()
		{
			return carnumbers;
		}
        //public string ReturnColor()
        //{
        //    return freedomcar.ReturnColor();
        //}
		
		public string ReturnMasterName()
		{
			return mastername;
		}
		public string ReturnMasterContactWay()
		{
			return contactway;
		}
        //public string ReturnMasterAddress()
        //{
        //    return freedomcar.ReturnMasterAddress();
        //}
        //public int 	ReturnMasterAge()
        //{
        //    return freedomcar.ReturnMasterAge();
        //}
		
		
		
		
	}
}
