/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2009-01-01
 * 时间: 19:47
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Data;
using Parking_DB;

namespace ParkingSystem.DAL
{
	/// <summary>
	/// Description of DAL_StaticCars.
	/// </summary>
	public class DAL_StaticCars
	{
		DBConnection conn = new DBConnection();
        public DataSet DAL_ReturnStaticCarsWithCarNumbers(string cNum)
        {
            string sql = "select * from students where SNo='" + cNum + "'";
            return conn.DBQuery(sql);
        }

        public DataSet DAL_ReturnStaticCars()
        {
            string sql = "select * from students";
            return conn.DBQuery(sql);
        }
        
        //通过placeid找到自由车
		public DataSet ReturnStaticCarsByPlaceid(int placeid)
		{
			string sql="";
			return conn.DBQuery(sql);
		}
		//通过主人姓名找到自由车
		public DataSet ReturnStaticCarsByMasterName(string name)
		{
			string sql="";
			return conn.DBQuery(sql);
		}
        
	}
}
