using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ParkingSystem.BLL;
using ParkingSystem.Model;

namespace ParkingSystem
{
    public partial class StaticCarLeave : Form
    {
        public StaticCarLeave()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_allow_leave_Click(object sender, EventArgs e)
        {
            Model_StaticCars car = new Model_StaticCars(
                this.textBox_carnumbers.Text,
                this.textBox_name.Text,
                this.textBox_contactway.Text
                );
            if (BLL_StaticCars.ReturnExistStaticCar(car)==true)
            {
                BLL_ParkingStatus.SetPlaceidAvailable(car.ReturnPlaceid());
                Model_Records record=BLL_Records.ReturnRecordByNumbersAndName(car.ReturnCarnumbers(),car.ReturnName());
                record.SetOuttime(DateTime.Now);
                BLL_Records.FinishOneRecord(record);    
                
            }
            else
            {
                MessageBox.Show("信息错误，请重新输入！");
                this.textBox_carnumbers.Text = "";
                this.textBox_contactway.Text = "";
                this.textBox_name.Text = "";
                this.textBox_placeid.Text = "";
            }



        }
    }
}
