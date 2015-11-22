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
    public partial class MainFreeCarEnter : Form
    {
        public MainFreeCarEnter()
        {
            InitializeComponent();
        }

        private void Button_enter_allow_Click(object sender, EventArgs e)
        {
            DateTime timenow = DateTime.Now;
            //新建一个model，数据通过这个model进行传递
            Model_FreedomCars newcar = new Model_FreedomCars(
                Convert.ToInt32(this.textBox_placeid.Text),
                this.textBox_carnumbers.Text,
                this.textBox_mastername.Text,
                this.textBox_tel.Text,
                timenow
                );
            BLL_FreedomCars.EnterNewFreeCar(newcar);
            BLL_ParkingStatus.SetPlaceidOccupied(Convert.ToInt32(this.textBox_placeid.Text));

            Model_Records newrecord = new Model_Records(
                this.textBox_mastername.Text,
                this.textBox_carnumbers.Text,
                this.textBox_tel.Text,
                Convert.ToInt32(this.textBox_placeid.Text),
                timenow
                );
            BLL_Records.AddNewRecord(newrecord);

            this.Close();
            
        }

        private void Button_enter_ban_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainFreeCarEnter_Load(object sender, EventArgs e)
        {
            this.textBox_placeid.Text = ManLogged.buttonplaceid;
        }

        private void MainFreeCarEnter_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManLogged.RefreshFreeStatus();
        }
    }
}
