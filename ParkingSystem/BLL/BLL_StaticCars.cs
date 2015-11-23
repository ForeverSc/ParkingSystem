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
	/// Description of BLL_StaticCars.
	/// </summary>
	public class BLL_StaticCars
	{

		private static DAL_StaticCars dal_staticcars=new DAL_StaticCars();

        //搜索返回结果
        public static Model_StaticCars ReturnSearchBy(string choice, string searchtxt)
        {

            if (choice == "车牌号")
            {
                return dal_staticcars.ReturnStaticcarModelByCarnumbers(searchtxt);
            }
            else if (choice == "车位号")
            {
                return dal_staticcars.ReturnStaticcarModelByPlaceid(Convert.ToInt32(searchtxt));
            }
            else if (choice == "车主姓名")
            {
                return dal_staticcars.ReturnStaticcarModelByName(searchtxt);
            }
            else
            {
                return null;
            }

        }

        //返回所有
        public static DataSet ReturnAllStaticCars()
        {
            return dal_staticcars.ReturnAllStaticCars();
        }

       
        //查询是否存在这辆固定车
        public static bool ReturnExistStaticCar(Model_StaticCars car)
        {
            DataSet dataset = dal_staticcars.ReturnExistOfOne(car);
            if (dataset.Tables[0].Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Model_StaticCars ReturnStaticCarByCarnumbers(string carnumbers)
        {
            return dal_staticcars.ReturnStaticcarModelByCarnumbers(carnumbers);
        }



        public static void UpdateStaticCar(Model_StaticCars car)
        {
            dal_staticcars.UpdateInformation(car);
 
        }


        public static void DeleteStaticCar(string carnumbers)
        {
            dal_staticcars.DeleteStaticCar(carnumbers);
        }



        public static Model_StaticCars ReturnCarByPlaceid(int placeid)
        {
            return dal_staticcars.ReturnStaticcarModelByPlaceid(placeid);
        }

        public static void AddNewStaticCar(Model_StaticCars car)
        {
            dal_staticcars.AddNewStaticCar(car);
        }
    }
}
