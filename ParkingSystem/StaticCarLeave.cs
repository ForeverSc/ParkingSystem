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
                car = BLL_StaticCars.ReturnStaticCarByCarnumbers(this.textBox_carnumbers.Text);
                Model_Records record=BLL_Records.ReturnRecordByNumbersAndName(car.ReturnCarnumbers(),car.ReturnName());
                record.SetOuttime(DateTime.Now);
                BLL_ParkingStatus.SetPlaceidAvailable(car.ReturnPlaceid());
                BLL_Records.FinishOneRecord(record);
                this.Close();         
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

        private void StaticCarLeave_Load(object sender, EventArgs e)
        {
            if (StaticCarInormation.staticcar!=null)
            {
                this.textBox_carnumbers.Text = StaticCarInormation.staticcar.ReturnCarnumbers();
                this.textBox_contactway.Text = StaticCarInormation.staticcar.ReturnContactway();
                this.textBox_name.Text = StaticCarInormation.staticcar.ReturnName();
                this.textBox_placeid.Text = StaticCarInormation.staticcar.ReturnPlaceid().ToString();
            }
            else
            {
                this.textBox_carnumbers.Text = "";
                this.textBox_contactway.Text = "";
                this.textBox_name.Text = "";
                this.textBox_placeid.Text = "";

            }
        }

        private void StaticCarLeave_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManLogged.RefreshFreeStatus();
            this.textBox_carnumbers.Text = "";
            this.textBox_contactway.Text = "";
            this.textBox_name.Text = "";
            this.textBox_placeid.Text = "";
        }
    }
}
