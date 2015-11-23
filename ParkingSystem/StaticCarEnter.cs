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
    public partial class StaticCarEnter : Form
    {


        public DateTime entertime;
        public StaticCarEnter()
        {
            InitializeComponent();
        }

        private void Button_staticcar_next_Click(object sender, EventArgs e)
        {
            Model_StaticCars staticcar = new Model_StaticCars(
                this.textBox_static_carnumbers.Text
               , this.textBox_static_mastername.Text
               , this.textBox_static_contactway.Text);
            if (BLL_StaticCars.ReturnExistStaticCar(staticcar)==true)
            {
                //先返回数据库中的车的信息
                Model_StaticCars car = BLL_StaticCars.ReturnStaticCarByCarnumbers(this.textBox_static_carnumbers.Text);

                //然后对进入时间进行更新
               entertime = DateTime.Now;

               this.label_static_address.Text = car.ReturnAddress();
                this.label_static_carnumbes.Text = car.ReturnCarnumbers();
                this.label_static_contactway.Text = car.ReturnContactway();
                this.label_static_placeid.Text = car.ReturnPlaceid().ToString();
                this.label_static_mastername.Text = car.ReturnName();
                this.label_static_entertime.Text = entertime.ToString();

                this.groupBox2.Visible = true;
                this.Button_static_allowenter.Visible = true;
               

            }
            else
            {
                MessageBox.Show("不存在这样的固定车，请重新输入信息");
                this.textBox_static_contactway.Text = "";
                this.textBox_static_carnumbers.Text = "";
                this.textBox_static_mastername.Text = "";
            }


        }

        private void Button_static_allowenter_Click(object sender, EventArgs e)
        {
            Model_StaticCars car = BLL_StaticCars.ReturnStaticCarByCarnumbers(this.textBox_static_carnumbers.Text);
            car.SetEntertime(entertime);
            BLL_StaticCars.UpdateStaticCar(car);//更新数据
            BLL_ParkingStatus.SetPlaceidOccupied(car.ReturnPlaceid());

            Model_Records newrecord=new Model_Records(
                this.textBox_static_mastername.Text,
                this.textBox_static_carnumbers.Text,
                this.textBox_static_contactway.Text,
                car.ReturnPlaceid(),
                entertime
                );
            BLL_Records.AddNewRecord(newrecord);
            this.Close();
            
          

        }

        private void Button_static_notallowed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StaticCarEnter_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManLogged.RefreshFreeStatus();
        }
    }
}
