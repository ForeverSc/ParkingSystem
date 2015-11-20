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


namespace ParkingSystem.BLL
{
	/// <summary>
	/// Description of BLL_StaticCars.
	/// </summary>
	public class BLL_StaticCars
	{

		private DAL_StaticCars dal_staticcars;
		
		
		//自由车（车牌，placeID，姓名，颜色，包月费用）
		//查找操作
		//通过车牌号查找
		BLL_StaticCars(string carnumbers)
		{
			dal_staticcars=new DAL_StaticCars();
			
			if (dal_staticcars.DAL_ReturnStaticCarsWithCarNumbers(carnumbers)==null) {
				//dataset操作
				//staticcars=new Model_StaticCars();
			}
			else
			{
				//显示无
			}			
		}
        /*
		//通过车主姓名查找
		 BLL_StaticCars(string name)
		{
			dal_staticcars=new DAL_StaticCars();
			
			if (dal_staticcars.ReturnStaticCarsByMasterName(name)==null) {
				//dataset操作
				//staticcars=new Model_StaticCars();
			}
			else
			{
				//显示无
			}			
		}
		//通过placeid查找
		 BLL_StaticCars(int placeid)
		{
			dal_staticcars=new DAL_StaticCars();
			
			if (dal_staticcars.ReturnStaticCarsByPlaceid(placeid)==null) {
				//dataset操作
				//staticcars=new Model_StaticCars();
			}
			else
			{
				//显示无
			}			
		}
		*/
		
		
        ////修改操作
        //public void SetStaticCarsInformation(string carnumbers,string name,int placeid ,string color,double money )
        //{
        //    staticcars.SetInformation(carnumbers,name,placeid,color,money);
        //}
		
	}
}
