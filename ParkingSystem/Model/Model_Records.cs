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
            this.outertime = Convert.ToDateTime("00:00:00");
         
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
            this.money = ((timespan.Days * 24 + timespan.Hours + timespan.Minutes / 60.0) * hoursmoney);
        }

        public string ReturnAllStayTime()
        {
            TimeSpan timespan =outertime-entertime;
            return string.Format("{0}天{1}小时{2}分钟", timespan.Days, timespan.Hours, timespan.Minutes);
        }
        public string ReturnMoney()
        {
            return money.ToString();
        }

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
            if (outertime==Convert.ToDateTime("00:00:00"))
            {
                return "";
            }
            else
            {
                return outertime.ToString();
            }
			
		}
	
		public int ReturnPlaceid()
		{
			return placeid;
		}
		public string  ReturnCarNumbers()
		{
			return carnumbers;
		}

		public string ReturnMasterName()
		{
			return mastername;
		}
		public string ReturnMasterContactWay()
		{
			return contactway;
		}
   
		
		
		
		
	}
}
