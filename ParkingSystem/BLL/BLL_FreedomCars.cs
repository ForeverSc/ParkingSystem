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
using ParkingSystem.DAL;
using ParkingSystem.Model;

namespace ParkingSystem.BLL
{
    /// <summary>
    /// Description of BLL_FreedomCars.
    /// </summary>
    public class BLL_FreedomCars
    {
       private static  DAL_FreedomCars dal_freecar= new DAL_FreedomCars();

        //搜索返回结果
        public static Model_FreedomCars ReturnSearchBy(string choice, string searchtxt)
        {

            if (choice == "车牌号")
            {
                return dal_freecar.ReturnFreecarModelByCarnumbers(searchtxt);
            }
            else if (choice == "车位号")
            {
                return dal_freecar.ReturnFreecarModelByPlaceid(Convert.ToInt32(searchtxt));
            }
            else if (choice=="车主姓名")
            {
                return dal_freecar.ReturnFreecarModelByName(searchtxt);
            }
            
            else
            {
                return null;
            }
          
        }


        public static Model_FreedomCars ReturnCarByPlaceid(int placeid)
        {
            return dal_freecar.ReturnFreecarModelByPlaceid(placeid);
        }

        //返回所有
        public static  DataSet ReturnAll()
        {
            return dal_freecar.ReturnAllFreecars();
        }

        //判断是否存在这辆车
        public static bool ReturnCarExist(Model_FreedomCars car)
        {
            if (dal_freecar.ReturnCarExitst(car).Tables[0].Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //一辆自由车进入
        public static void EnterNewFreeCar(Model_FreedomCars newcar)
        {
            dal_freecar.InsertNewCar(newcar);
        }
        //一辆自由车离开
        public static void LeaveOneFreeCar(Model_FreedomCars leavecar)
        {
            dal_freecar.DeleteOneCar(leavecar);
        }
        //修改一辆车的信息
        public static void UpdateInformation(Model_FreedomCars car)
        {
            dal_freecar.UpdateInformation(car);
        }








        //freedomcar(车牌，placeid，姓名，颜色)

        ////查找操作
        ////通过placeid找到相应的freecar
        //public BLL_FreedomCars(Model_FreedomCars mfreecar)
        //{
        //    dal_freecar=new DAL_FreedomCars();

        //    if (dal_freecar.DAL_ReturnFreedomCarsWithCarNumbers(carnumbers).Tables[0].Rows.Count!=0) {
        //        master = new Model_Master(mastername, contactway, carnumbers);
        //        freecar=new Model_FreedomCars(placeid,carnumbers,master);
        //    }
        //    else
        //    {
        //        freecar = null;
        //    }	
        //}

        ////删除操作
        //public static void DeleteFreedomCar(string carnumbers)
        //{
        //    dal_freecar.Delete(carnumbers);
        //}


        ////修改操作
        //public void SetFreedomCarsInformation(string carnumbers, string name, int placeid, string color)
        //{
        //    freecar.SetInformation(carnumbers, name, placeid, color);
        //    dal_freecar.UpdateInformation(placeid, carnumbers, name);
        //}


    }
}
