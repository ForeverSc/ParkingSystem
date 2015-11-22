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

        public static int ReturnAvailablePlaceid()
        {
            DataSet dataset = dal_parkingstatus.ReturnAvailablePlaceid();
            return Convert.ToInt32(dataset.Tables[0].Rows[0]["placeid"].ToString());
        }

        public static void SetPlaceidOccupied(int placeid)
        {
            dal_parkingstatus.SetPlaceidOccupied(placeid);
        }

        public static string ReturnLeftNumbersOfPlace()
        {
            return dal_parkingstatus.ReturnLeftNumbersOfPlace().Tables[0].Rows[0][0].ToString();
        }

        public static void SetPlaceidAvailable(int placeid)
        {
            dal_parkingstatus.SetPlaceidAvailable(placeid);
        }
    }
}
