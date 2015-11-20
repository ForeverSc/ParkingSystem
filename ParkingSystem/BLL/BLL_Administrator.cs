/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2015-11-13
 * 时间: 14:38
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using ParkingSystem.Model;
using ParkingSystem.DAL;
using System.Windows.Forms;
using System.Data;

namespace ParkingSystem.BLL
{
	/// <summary>
	/// Description of BLL_Administrator.
	/// </summary>
	public class BLL_Administrator
	{
		private Model_Administrator admin;
		private DAL_Administrator dal_admin;
        private string oldidnumbers = "";
		//管理员（idnumbers,密码，姓名，年龄，联系方式）
		public BLL_Administrator(string idnumbers,string password)
		{
			dal_admin=new DAL_Administrator();
            if (dal_admin.ReturnAllInformation(idnumbers, password).Tables[0].Rows.Count != 0)
            {
				admin=new Model_Administrator(idnumbers,password);
                admin.SetInformation(idnumbers,password,dal_admin.ReturnName(),dal_admin.ReturnAge(),dal_admin.ReturnContactway());      
                oldidnumbers = idnumbers;
			}
			else 
			{
                admin = null;
			}		
						
		}
        //返回是否登陆成功
        public int ReturnIfLogged()
        {
            if (admin!=null)
            {
                return 1;//登陆成功
            }
            else
            {
                return 0;//登陆失败
            }
        }

		//修改管理员信息
		public void SetInformation(string idnumbers,string password,string name,int age,string contactway )
		{
			admin.SetInformation(idnumbers,password,name,age,contactway);
            dal_admin.SetAdminInformation(idnumbers, password, name, age, contactway, oldidnumbers);
		}
		
		//显示管理员的信息
		//返回管理员信息
		public string ReturnIdnumbers()
		{
			return admin.ReturnIdnumbers();
		}
		public string ReturnName()
		{
			return admin.ReturnName();
		}
		public int ReturnAge()
		{
			return admin.ReturnAge();
		}
		public string ReturnContactWay()
		{
			return admin.ReturnContactWay();
		}
        public string ReturnPassword()
        {
            return admin.ReturnPassword();
        }
		
	}
}
