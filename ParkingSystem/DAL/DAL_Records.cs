/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2009-01-01
 * 时间: 19:47
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using Parking_DB;
using System.Data;
using ParkingSystem.Model;
namespace ParkingSystem.DAL
{
    /// <summary>
    /// Description of DAL_Records.
    /// </summary>
    public class DAL_Records
    {
        DBConnection conn;
        public DAL_Records()
        {
            conn = new DBConnection();
        }
        public Model_Records ReturnRecordsByCarnumbers(string carnumbers)
        {
            Model_Records record;
            string sql = "select * from records where carnumbers='" + carnumbers + "'";
            DataSet dataset = conn.DBQuery(sql);
            DataTable datatable = dataset.Tables[0];
            if (datatable.Rows.Count > 0)
            {
                DataRow row = datatable.Rows[0];
                if (row["outtime"] is DBNull)
                {
                    record = new Model_Records(
              Convert.ToInt32(row["id"].ToString()),
              row["name"].ToString(),
              row["carnumbers"].ToString(),
              row["contactway"].ToString(),
              Convert.ToInt32(row["placeid"].ToString()),
              Convert.ToDateTime(row["entertime"])
              );
                }
                else
                {
                    record = new Model_Records(
                 Convert.ToInt32(row["id"].ToString()),
                 row["name"].ToString(),
                 row["carnumbers"].ToString(),
                 row["contactway"].ToString(),
                 Convert.ToInt32(row["placeid"].ToString()),
                 Convert.ToDateTime(row["entertime"]),
                 Convert.ToDateTime(row["outtime"]),
                 Convert.ToDouble(row["money"])
                 );


                }  
            }
            else
            {
                record = null;
            }
            return record;            
        }

        public Model_Records ReturnRecordslByPlaceid(string searchtxt)
        {
            Model_Records record;
            string sql = "select * from records where placeid='" + searchtxt + "'";
            DataSet dataset = conn.DBQuery(sql);
            DataTable datatable = dataset.Tables[0];
            if (datatable.Rows.Count > 0)
            {
                DataRow row = datatable.Rows[0];
                if (row["outtime"] is DBNull)
                {
                      record = new Model_Records(
                Convert.ToInt32(row["id"].ToString()),
                row["name"].ToString(),
                row["carnumbers"].ToString(),
                row["contactway"].ToString(),
                Convert.ToInt32(row["placeid"].ToString()),
                Convert.ToDateTime(row["entertime"])
                );
                }
                else
                {
                    record = new Model_Records(
                 Convert.ToInt32(row["id"].ToString()),
                 row["name"].ToString(),
                 row["carnumbers"].ToString(),
                 row["contactway"].ToString(),
                 Convert.ToInt32(row["placeid"].ToString()),
                 Convert.ToDateTime(row["entertime"]),
                 Convert.ToDateTime(row["outtime"]),
                 Convert.ToDouble(row["money"])
                 );
                
                }                
            }
            else
            {
                record = null;
            }
            return record;  
        }


        public Model_Records ReturnRecordsByMasterName(string searchtxt)
        {
            Model_Records record;
            string sql = "select * from records where name='" + searchtxt + "'";
            DataSet dataset = conn.DBQuery(sql);
            DataTable datatable = dataset.Tables[0];
            if (datatable.Rows.Count > 0)
            {
                DataRow row = datatable.Rows[0];
                if (row["outtime"] is DBNull)
                {
                    record = new Model_Records(
              Convert.ToInt32(row["id"].ToString()),
              row["name"].ToString(),
              row["carnumbers"].ToString(),
              row["contactway"].ToString(),
              Convert.ToInt32(row["placeid"].ToString()),
              Convert.ToDateTime(row["entertime"])
              );
                }
                else
                {
                    record = new Model_Records(
                 Convert.ToInt32(row["id"].ToString()),
                 row["name"].ToString(),
                 row["carnumbers"].ToString(),
                 row["contactway"].ToString(),
                 Convert.ToInt32(row["placeid"].ToString()),
                 Convert.ToDateTime(row["entertime"]),
                 Convert.ToDateTime(row["outtime"]),
                 Convert.ToDouble(row["money"])
                 );


                }  
            }
            else
            {
                record = null;
            }
            return record;  
        }

        public DataSet ReturnAllInformation()
        {
            string sql = "select * from records";
            return conn.DBQuery(sql);
        }

        public void InsertRecord(Model_Records record)
        {
            string sql = string.Format("INSERT INTO "
                                         + "records (placeid,name,carnumbers,contactway,entertime) "
                                         + " VALUES('{0}','{1}','{2}','{3}','{4}')"
                                         ,record.ReturnPlaceid(),record.ReturnMasterName(),record.ReturnCarNumbers(),record.ReturnMasterContactWay(),record.ReturnEntertime().ToString());
            conn.DBcmd(sql);
        }

        //结账操作
        public void FinishOneRecord(Model_Records record)
        {

            string sql = "UPDATE records " +
                      " SET outtime='" + record.ReturnOutertime()
                      + "',money='" + record.ReturnMoney() + "'" +
                      " WHERE carnumbers='" + record.ReturnCarNumbers() + "'";
            conn.DBcmd(sql);

        }

        //修改操作，需要考虑
        public void UpdateInformation(Model_Records record)
        {

            string sql = "UPDATE records " +
                      " SET outtime='" + record.ReturnOutertime()
                      + "',money='" + record.ReturnMoney() + "'" +
                      " WHERE carnumbers='" + record.ReturnCarNumbers() + "'";
            conn.DBcmd(sql);
        }
        //通过姓名和车牌号返回record,帮助判断数据库中是否存在这条记录
        public Model_Records ReturnRecordByNumbersAndName(string carnumbers,string name)
        {
            Model_Records record;
            string sql = "select * from records where name='" + name + "' and carnumbers='"+carnumbers+"'";
            DataSet dataset = conn.DBQuery(sql);
            DataTable datatable = dataset.Tables[0];
            if (datatable.Rows.Count > 0)
            {
                DataRow row = datatable.Rows[0];
                record = new Model_Records(
                   row["name"].ToString(),
                   row["carnumbers"].ToString(),
                   row["contactway"].ToString(),
                   Convert.ToInt32(row["placeid"].ToString()),
                   Convert.ToDateTime(row["entertime"])
                   );
            }
            else
            {
                record = null;
            }
            
            return record;  
 
        }


    }
}
