/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2015-11-13
 * 时间: 14:48
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Data;
using Parking_DB;

namespace ParkingSystem.DAL
{
	/// <summary>
	/// Description of DAL_Administrator.
	/// </summary>
	public class DAL_Administrator
	{
        private DataSet dataset;
		private DBConnection conn;
		public DAL_Administrator()
		{
			conn=new DBConnection();
		}
        //修改管理员信息
        public void SetAdminInformation(string idnumbers, string password, string name, int age, string contactway,string oldidnumbers)
        {
            string sql = "UPDATE administrator "+
                         "SET age="+age+",contactway='"+contactway+"',name='"+name+"',idnumbers='"+idnumbers+"',password='"+password+"'"+
                         "WHERE idnumbers='"+oldidnumbers+"'";
            conn.DBcmd(sql);
        }

		//返回管理员信息
		 public DataSet ReturnAllInformation(string idnumbers,string password)
        {
            string sql = "select * from administrator where idnumbers='" + idnumbers 
                                                 + "' and password='"+password+"'";
            dataset = conn.DBQuery(sql);
            return dataset;
        }

         public string ReturnName()
         {
             return dataset.Tables[0].Rows[0]["name"].ToString();
         }
         public int ReturnAge()
         {
             return Convert.ToInt32(dataset.Tables[0].Rows[0]["age"].ToString());
         }
         public string ReturnContactway()
         {
             return dataset.Tables[0].Rows[0]["contactway"].ToString();
         }
        

		
		
	}
}
