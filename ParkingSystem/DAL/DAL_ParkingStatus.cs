using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Parking_DB;

namespace ParkingSystem.DAL
{
    public class DAL_ParkingStatus
    {
        DBConnection conn;
        public DAL_ParkingStatus()
        {
            conn = new DBConnection();
        }

        public DataSet ReturnParkingStatusDataSet()
        {
            string sql = "select * from parkingstatus";
            return conn.DBQuery(sql);
        }
        //返回自由车
        public DataSet ReturnFreeAvailablePlaceid()
        {
            string sql = "select * from parkingstatus where status = '0' and placeid<=25";
            return conn.DBQuery(sql);
        }

        public void SetPlaceidOccupied(int placeid)
        {
            string sql = "update parkingstatus set status='1' where placeid='" + placeid + "'";
            conn.DBcmd(sql);
        }

        public DataSet ReturnFreeLeftNumbersOfPlace()
        {
            string sql = "select COUNT(*) from parkingstatus where status='0' and placeid<=25";
            return conn.DBQuery(sql);
        }
        public void SetPlaceidAvailable(int placeid)
        {
            string sql = "update parkingstatus set status='0' where placeid='" + placeid + "'";
            conn.DBcmd(sql);
        }


    }
}
