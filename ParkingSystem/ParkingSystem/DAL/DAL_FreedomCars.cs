/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2009-01-01
 * 时间: 19:47
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb; 
using Parking_DB;
using ParkingSystem.Model;


namespace ParkingSystem.DAL
{
	/// <summary>
	/// Description of DAL_FreedomCars.
	/// </summary>
	public class DAL_FreedomCars
	{
		
		DBConnection conn = new DBConnection();
        //查询操作
        //通过车牌号返回一个model对象
        public Model_FreedomCars ReturnFreecarModelByCarnumbers(string carnumbers)
        {
            Model_FreedomCars freecar;
            string sql = "select * from freedomcar where carnumbers='" + carnumbers + "'";
            DataSet dataset=conn.DBQuery(sql);
            DataTable datatable = dataset.Tables[0];
            if (datatable.Rows.Count>0)
            {
                DataRow row = datatable.Rows[0];
                 freecar = new Model_FreedomCars(
                    Convert.ToInt32(row["placeid"].ToString()),
                    row["carnumbers"].ToString(),
                    row["name"].ToString(),
                    row["contactway"].ToString(),
                    Convert.ToDateTime(row["entertime"])
                    );
            }
            else
            {
                freecar = null;
            }
            return freecar;         
        }
        //通过车位号返回一个model对象
        public Model_FreedomCars ReturnFreecarModelByPlaceid(string placeid)
        {
            Model_FreedomCars freecar;
            string sql = "select * from freedomcar where placeid='" + placeid + "'";
            DataSet dataset = conn.DBQuery(sql);
            DataTable datatable = dataset.Tables[0];
            if (datatable.Rows.Count > 0)
            {
                DataRow row = datatable.Rows[0];
                freecar = new Model_FreedomCars(
                   Convert.ToInt32(row["placeid"].ToString()),
                   row["carnumbers"].ToString(),
                   row["name"].ToString(),
                    row["contactway"].ToString(),
                    Convert.ToDateTime(row["entertime"]));
            }
            else
            {
                freecar = null;
            }
            return freecar;
        }
        //返回所有
        public DataSet ReturnFreecarModelByPlaceid()
        {     
            string sql = "select * from freedomcar";
            return conn.DBQuery(sql);
        }

        //插入操作
        public void InsertNewCar(Model_FreedomCars newcar)
        {
            string sql = string.Format("INSERT INTO "
                                       + "freedomcar (placeid,carnumbers,name,contactway,entertime) "
                                       + " VALUES('{0}','{1}','{2}','{3}','{4}')"
                                       , newcar.ReturnPlaceid(), 
                                       newcar.ReturnCarNumbers(),
                                       newcar.ReturnMasterName(),
                                       newcar.ReturnContactWay(),
                                       newcar.ReturnEnetertime().ToString());
            conn.DBcmd(sql);
        }

        //删除操作
        public void DeleteOneCar(Model_FreedomCars leavecar)
        {
            string sql = "delete from freedomcar where carnumbers='"+ leavecar.ReturnCarNumbers()+"'";
            conn.DBcmd(sql);
        }
        
        //修改操作
        public void UpdateInformation(Model_FreedomCars car)
        {
            string sql = "UPDATE freedomcar " +
                      " SET placeid='" + car.ReturnPlaceid() 
                      + "',carnumbers='"   + car.ReturnCarNumbers() 
                      + "',name='" + car.ReturnMasterName()  
                      + "',contactway='"+car.ReturnContactWay()+"'"+
                      " WHERE carnumbers='" + car.ReturnCarNumbers()+ "'";
            conn.DBcmd(sql);
        }
        //返回所有自由车
        public DataSet ReturnAllFreecars()
        {
            string sql = "select * from freedomcar";
            return conn.DBQuery(sql);
        }

        public DataSet ReturnCarExitst(Model_FreedomCars car)
        {
            string sql = string.Format("select * from freedomcar where carnumbers='{0}'" +
                                      "and placeid='{1}' and name='{2}'"
                                      , car.ReturnCarNumbers(), car.ReturnPlaceid(), car.ReturnMasterName());
            return conn.DBQuery(sql);
        }







        ////通过placeid找到自由车
        //public DataSet ReturnFreedomCarsByPlaceid(int placeid)
        //{
        //    string sql="";
        //    return conn.DBQuery(sql);
        //}
        ////通过主人姓名找到自由车
        //public DataSet ReturnFreedomCarsByMasterName(string name)
        //{
        //    string sql="";
        //    return conn.DBQuery(sql);
        //}
		
        ////通过车牌号返回自由车
        //public DataSet DAL_ReturnFreedomCarsWithCarNumbers(string carnumbers)
        //{
        //    string sql = "select * from freedomcar where carnumbers='" + carnumbers + "'";
        //    return conn.DBQuery(sql);
        //}

        ////保存自由车信息
        //public void SaveInformation(int placeid,string carnumbers,string name)
        //{
        //    string sql = string.Format("INSERT INTO "
        //                                + "records (placeid,carnumbers,name) "
        //                                + " VALUES({0},{1},{2})"
        //                                ,placeid,carnumbers,name);
        //    conn.DBcmd(sql);
        //}
        //////修改信息
        ////public void UpdateInformation(int placeid,string carnumbers,string name)
        ////{
        ////    string sql = "UPDATE freedomcar " +
        ////              " SET placeid='" + placeid + "',carnumbers='" + carnumbers + "',name='" + name + "'"+
        ////              " WHERE carnumbers='"+carnumbers+"'";
        ////}


        //删除自由车
        public void Delete(string carnumbers)
        {
            string sql = "delete from freedomcar where carnumbers='"+ carnumbers+"'";
            conn.DBcmd(sql);
        }



    }
}
