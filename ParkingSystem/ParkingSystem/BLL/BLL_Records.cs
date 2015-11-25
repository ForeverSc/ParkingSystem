/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2009-01-01
 * 时间: 19:48
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using ParkingSystem.Model;
using ParkingSystem.DAL;
using System.Data;

namespace ParkingSystem.BLL
{
	/// <summary>
	/// Description of BLL_Records.
	/// </summary>
	public class BLL_Records
	{	
        private static DAL_Records dal_record=new DAL_Records();

        //搜索返回结果
        public static Model_Records ReturnSearchBy(string choice, string searchtxt)
        {
            
            if (choice == "车牌号")
            {
                return dal_record.ReturnRecordsByCarnumbers(searchtxt);
            }
            else if (choice == "车位号")
            {
                return dal_record.ReturnRecordslByPlaceid(searchtxt);
            }
            else if (choice=="车主姓名")
            {
                return dal_record.ReturnRecordsByMasterName(searchtxt);
            }
            else
            {
                return null;
            }

        }

        //返回所有记录
        public static  DataSet ReturnAllRecords()
        {
            return dal_record.ReturnAllInformation();
        }
        //新建一条记录，等待支付
        public static void AddNewRecord(Model_Records newrecord)
        {
            dal_record.InsertRecord(newrecord);
        }
        //完成一条记录，保存在记录表中
        public static void FinishOneRecord(Model_Records finishedrecord)
        {
            dal_record.FinishOneRecord(finishedrecord);
        }
        //修改一条记录
        public static void UpdateInformation(Model_Records record)
        {
            dal_record.UpdateInformation(record);
        }
        //根据carnumbers和mastername，查找返回数据库中的记录
        public static Model_Records ReturnRecordByNumbersAndName(string carnumbers, string mastername)
        {
            return  dal_record.ReturnRecordByNumbersAndName(carnumbers, mastername);
        }
     












        ////新建一条记录的姓名，联系方式，place，车牌号		
        //public BLL_Records(string name,string contactways,int placeid,string carnumbers)
        //{
        //    master=new Model_Master(name,contactways,carnumbers);
        //    freedomcar=new Model_FreedomCars(placeid,contactways,master);
        //    entertime=DateTime.Now;
        //    id+=1;
        //    record=new Model_Records(master,freedomcar,entertime,id);
        //    dal_record = new DAL_Records();
        //    dal_freecar = new DAL_FreedomCars();
			
        //}

        ////离开时先查找记录，然后进行更改
        //public BLL_Records(string name,string carnumbers)
        //{          
        //    dal_record = new DAL_Records();
        //    dal_record.AddLeaveTime(carnumbers);
        //    dataset = dal_record.ReturnRecordByNameAndCarnumbers(name, carnumbers);
                        
        //}
        //返回进入时间
        //public string ReturnEntertime()
        //{
        //    return dataset.Tables[0].Rows[0]["entertime"].ToString();
        //}
        //public string ReturnLeavetime()
        //{
        //    return dataset.Tables[0].Rows[0]["outtime"].ToString();
        //}
        //public string ReturnAllStayTime()
        //{
        //    TimeSpan timespan = Convert.ToDateTime(this.ReturnEntertime()) - Convert.ToDateTime(this.ReturnLeavetime());
        //    return timespan.ToString();
        //}


        //public string ReturnMoney(double money)
        //{
        //    TimeSpan timespan = Convert.ToDateTime(this.ReturnEntertime()) - Convert.ToDateTime(this.ReturnLeavetime());
        //    record.SetMoney(((timespan.Days * 24 + timespan.Hours + timespan.Minutes / 60) * money).ToString());
        //    return ((timespan.Days * 24 + timespan.Hours + timespan.Minutes / 60) * money).ToString();
        //}

        
       



        ////通过车主名，车牌，车位，所有记录来返回dataset 
        //private DataSet ReturnDataSetByName(string name)
        //{
        //    return  dal_record.ReturnRecordByName(name);
        //}

        //private DataSet ReturnDataSetByCarNumbers(string carnumbers)
        //{
        //    return dal_record.ReturnRecordByCarnumbers(carnumbers);
        //}



        ////返回record,model对象
        //private Model_Records ReturnModel_Records()
        //{
        //    return record;
        //}

        ////保存这条记录到数据库
        //public void SaveRecords()
        //{
        //    //保存当前在停车场内的自由车信息
        //    dal_freecar.SaveInformation(record.ReturnPlaceid(),record.ReturnCarNumbers(),record.ReturnMasterName());
        //    //保存记录
        //    dal_record = new DAL_Records();
        //    dal_record.SaveRecords(record.ReturnId(),
        //                           record.ReturnPlaceid(),
        //                           record.ReturnMasterName(),
        //                           record.ReturnMasterContactWay(),
        //                           record.ReturnCarNumbers(),
        //                           record.ReturnEntertime(),
        //                           record.ReturnOutertime(),
        //                           record.ReturnMoney());

        //}
        

		
        ////离开时，设置每小时收费，返回收费金额
        //public string ReturnCostMoney(double money)
        //{
        //    outertime=DateTime.Now;
        //    record.Setoutertime(outertime);
        //    TimeSpan timespan=outertime-entertime;	
        //    record.SetMoney(((timespan.Days*24+timespan.Hours+timespan.Minutes/60)*money).ToString());			
        //    return ((timespan.Days*24+timespan.Hours+timespan.Minutes/60)*money).ToString();
        //}
		
		//通过点击记录查看详细信息
        //public int ReturnId()
        //{
        //    return record.ReturnId();
        //}
        //public string ReturnEntertime()
        //{
        //    return record.ReturnEntertime();
        //}
        //public string ReturnOutertime()
        //{
        //    return record.ReturnOutertime();
        //}
        //public string ReturnMoney()
        //{
        //    return record.ReturnMoney();
        //}
		
        //public int ReturnPlaceid()
        //{
        //    return record.ReturnPlaceid();
        //}
        //public string  ReturnCarNumbers()
        //{
        //    return record.ReturnCarNumbers();
        //}
        ////public string ReturnColor()
        ////{
        ////    return record.ReturnColor();
        ////}
		
        //public string ReturnMasterName()
        //{
        //    return record.ReturnMasterName();
        //}
        //public string ReturnMasterContactWay()
        //{
        //    return record.ReturnMasterContactWay();
        //}
        //public string ReturnMasterAddress()
        //{
        //    return record.ReturnMasterAddress();
        //}
        //public int 	ReturnMasterAge()
        //{
        //    return record.ReturnMasterAge();
        //}
		
		
		
		
	}
}
