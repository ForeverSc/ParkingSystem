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
    public partial class StaticCarInormation : Form
    {
        public static Model_StaticCars staticcar;

        public StaticCarInormation()
        {
            InitializeComponent();
        }

        private void StaticCarInormation_Load(object sender, EventArgs e)
        {
            staticcar = ManLogged.staticcar;
            this.text_admin_name.Text = ManLogged.staticcar.ReturnName();
            this.text_carnumbers.Text = ManLogged.staticcar.ReturnCarnumbers();
            this.text_admin_tel.Text = ManLogged.staticcar.ReturnContactway();
            this.text_placeid.Text = ManLogged.staticcar.ReturnPlaceid().ToString();
            this.label_entertime.Text = ManLogged.staticcar.ReturnEntertime();
        }

        private void Button_staticcar_modify_Click(object sender, EventArgs e)
        {
            this.text_admin_name.ReadOnly = false;
            this.text_admin_tel.ReadOnly = false;
            this.text_carnumbers.ReadOnly = false;
            this.text_placeid.ReadOnly = false;
        }

        private void Button_staticcar_savemodify_Click(object sender, EventArgs e)
        {
           staticcar = new Model_StaticCars(
                Convert.ToInt32(this.text_placeid.Text)
               , this.text_carnumbers.Text
               , this.text_admin_name.Text
               , this.text_admin_tel.Text
               , Convert.ToDateTime(this.label_entertime.Text)  
                );
            BLL_StaticCars.UpdateStaticCar(staticcar);
        }

        private void Button_staticcar_leave_Click(object sender, EventArgs e)
        {
            StaticCarLeave carleave = new StaticCarLeave();
            carleave.ShowDialog();
            this.Close();
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaticCarCostMoney costWindow = new StaticCarCostMoney();
            costWindow.Show();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            BLL_StaticCars.DeleteStaticCar(this.text_carnumbers.Text);
            this.Close();
        }

        private void StaticCarInormation_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManLogged.RefreshFreeStatus();
        }

        private void button_static_enter_Click(object sender, EventArgs e)
        {

            DateTime entertime = DateTime.Now;
            Model_StaticCars car = BLL_StaticCars.ReturnStaticCarByCarnumbers(this.text_carnumbers.Text);
            car.SetEntertime(entertime);
            BLL_StaticCars.UpdateStaticCar(car);//更新数据
            BLL_ParkingStatus.SetPlaceidOccupied(car.ReturnPlaceid());

            Model_Records newrecord = new Model_Records(
                this.text_admin_name.Text,
                this.text_carnumbers.Text,
                this.text_admin_tel.Text,
                car.ReturnPlaceid(),
                entertime
                );
            BLL_Records.AddNewRecord(newrecord);
            this.Close();
        }
    }
}
