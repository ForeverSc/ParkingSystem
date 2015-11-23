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
using ParkingSystem.Model;

namespace ParkingSystem.DAL
{
	/// <summary>
	/// Description of DAL_StaticCars.
	/// </summary>
	public class DAL_StaticCars
	{
		DBConnection conn = new DBConnection();

        
        public  Model_StaticCars ReturnStaticcarModelByCarnumbers(string carnumbers)
        {
            Model_StaticCars staticcar;
            string sql = "select * from staticcars where carnumbers='"+carnumbers+"'";
            DataSet dataset = conn.DBQuery(sql);
            DataTable datatable = dataset.Tables[0];
            if (datatable.Rows.Count>0)
            {
                DataRow row = datatable.Rows[0];
                if (row["entertime"] is DBNull)
                {
                    staticcar = new Model_StaticCars(
                   Convert.ToInt32(row["placeid"].ToString())
                  , row["carnumbers"].ToString()
                  , row["name"].ToString()
                  , row["address"].ToString()
                  , row["contactway"].ToString()
                  );
                }
                else
                {
                    staticcar = new Model_StaticCars(
                      Convert.ToInt32(row["placeid"].ToString())
                     , row["carnumbers"].ToString()
                     , row["name"].ToString()
                     , row["address"].ToString()
                     , row["contactway"].ToString()
                     , Convert.ToDouble(row["money"].ToString())
                     , Convert.ToDateTime(row["entertime"].ToString()));

                }
            }
            else
            {
                staticcar = null;
            }
            return staticcar;

         }

        public Model_StaticCars ReturnStaticcarModelByPlaceid(int placeid)
        {
            Model_StaticCars staticcar;
            string sql = "select * from staticcars where placeid='" + placeid + "'";
            DataSet dataset = conn.DBQuery(sql);
            DataTable datatable = dataset.Tables[0];
            if (datatable.Rows.Count > 0)
            {
                DataRow row = datatable.Rows[0];
                if (row["entertime"] is DBNull)
                {
                    staticcar = new Model_StaticCars(
                   Convert.ToInt32(row["placeid"].ToString())
                  , row["carnumbers"].ToString()
                  , row["name"].ToString()
                  , row["address"].ToString()
                  , row["contactway"].ToString()
                  );
                }
                else
                {
                    staticcar = new Model_StaticCars(
                      Convert.ToInt32(row["placeid"].ToString())
                     , row["carnumbers"].ToString()
                     , row["name"].ToString()
                     , row["address"].ToString()
                     , row["contactway"].ToString()
                     , Convert.ToDouble(row["money"].ToString())
                     , Convert.ToDateTime(row["entertime"].ToString()));

                }
            }
            else
            {
                staticcar = null;
            }
            return staticcar;
 
        }

        public Model_StaticCars ReturnStaticcarModelByName(string name)
        {
            Model_StaticCars staticcar;
            string sql = "select * from staticcars where name='" + name + "'";
            DataSet dataset = conn.DBQuery(sql);
            DataTable datatable = dataset.Tables[0];
            if (datatable.Rows.Count > 0)
            {
                DataRow row = datatable.Rows[0];

                if (row["entertime"] is DBNull)
                {
                    staticcar = new Model_StaticCars(
                   Convert.ToInt32(row["placeid"].ToString())
                  , row["carnumbers"].ToString()
                  , row["name"].ToString()
                  , row["address"].ToString()
                  , row["contactway"].ToString()
                  );
                }
                else
                { staticcar = new Model_StaticCars(
                    Convert.ToInt32(row["placeid"].ToString())
                   , row["carnumbers"].ToString()
                   , row["name"].ToString()
                   , row["address"].ToString()
                   , row["contactway"].ToString()
                   , Convert.ToDouble(row["money"].ToString())
                   , Convert.ToDateTime(row["entertime"].ToString()));

                }
               
            }
            else
            {
                staticcar = null;
            }
            return staticcar;
        }


        public DataSet ReturnAllStaticCars()
        {
            string sql = "select * from staticcars";
            return conn.DBQuery(sql);
        }

        public DataSet ReturnExistOfOne(Model_StaticCars car)
        {
            Model_StaticCars staticcar=car;
            string sql = "select * from staticcars where carnumbers='" + car.ReturnCarnumbers()
                + "' and name='" + car.ReturnName() + "' and contactway='" + car.ReturnContactway() + "'";
            return conn.DBQuery(sql);
        }

        //修改操作
        public void UpdateInformation(Model_StaticCars car)
        {
            string sql = "UPDATE staticcars " +
                      " SET placeid='" + car.ReturnPlaceid()
                      + "',carnumbers='" + car.ReturnCarnumbers()
                      + "',name='" + car.ReturnName()
                      + "',contactway='" + car.ReturnContactway() 
                      + "',address='"+car.ReturnAddress()
                      + "',entertime='"+car.ReturnEntertime()
                      + "',money='"+car.ReturnMoney()+"'"+
                      " WHERE carnumbers='" + car.ReturnCarnumbers() + "'";
            conn.DBcmd(sql);
        }


        public void AddNewStaticCar(Model_StaticCars car)
        {
            string sql = string.Format("INSERT INTO "
                                       + "staticcars (placeid,carnumbers,name,contactway,address) "
                                       + " VALUES('{0}','{1}','{2}','{3}','{4}')"
                                       , car.ReturnPlaceid(),
                                       car.ReturnCarnumbers(),
                                       car.ReturnName(),
                                       car.ReturnContactway(),
                                       car.ReturnAddress()
                                       );
            conn.DBcmd(sql);
        }


        public void DeleteStaticCar(string carnumbers)
        {
            string sql = "delete from staticcars where carnumbers='" + carnumbers + "'";
            conn.DBcmd(sql);
        }


    }
}
