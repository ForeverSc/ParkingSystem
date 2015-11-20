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
            DataSet data=conn.DBQuery(sql);
            return data;
        }



    }
}
