using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ParkingSystem.DAL;

namespace ParkingSystem.BLL
{
    class BLL_ParkingStatus
    {
        private static DAL_ParkingStatus dal_parkingstatus=new DAL_ParkingStatus();

        public static DataSet ReturnParkingStatusDataSet()
        {
            return dal_parkingstatus.ReturnParkingStatusDataSet();
        }
    }
}
