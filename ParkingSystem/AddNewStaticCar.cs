using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ParkingSystem.Model;
using ParkingSystem.BLL;

namespace ParkingSystem
{
    public partial class AddNewStaticCar : Form
    {
        public AddNewStaticCar()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Model_StaticCars car = new Model_StaticCars(
                Convert.ToInt32(this.textBox_placeid.Text)
                , textBox_carnumbers.Text
                , textBox_name.Text
                , textBox_contactway.Text
                , textBox_address.Text
                );

            BLL_StaticCars.AddNewStaticCar(car);
            this.Close();

        }
    }
}
