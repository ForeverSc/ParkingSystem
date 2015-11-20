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
    public partial class FreedomCarInformation : Form
    {
        public static FreedomCarInformation fwindow;
        public string f_carnumbers;
        public string f_placeid;
        public string f_name;
        public string f_contactway;


        public FreedomCarInformation()
        {
            InitializeComponent();
            fwindow = this;
            this.text_admin_name.Text = ManLogged.freecar.ReturnMasterName();
            this.text_carnumbers.Text = ManLogged.freecar.ReturnCarNumbers();
            this.text_placeid.Text = ManLogged.freecar.ReturnPlaceid().ToString();
            this.text_admin_tel.Text = ManLogged.freecar.ReturnContactWay();
            this.label_entertime.Text = ManLogged.freecar.ReturnEnetertime();
        }

        private void Button_freecar_modify_Click(object sender, EventArgs e)
        {
            this.text_admin_name.ReadOnly = false;
            this.text_admin_tel.ReadOnly = false;
            this.text_carnumbers.ReadOnly = false;
            this.text_placeid.ReadOnly = false;
        }

        private void Button_freecar_savemodify_Click(object sender, EventArgs e)
        {
            Model_FreedomCars freecar = new Model_FreedomCars(
                Convert.ToInt32(this.text_placeid.Text),
                this.text_carnumbers.Text,
                this.text_admin_name.Text,
                this.text_admin_tel.Text
                );
            BLL_FreedomCars.UpdateInformation(freecar);
            this.Close();
        }

        private void Button_freecarInformation_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_freecar_leave_Click(object sender, EventArgs e)
        {
            f_carnumbers = this.text_carnumbers.Text;
            f_contactway = this.text_admin_tel.Text;
            f_placeid = this.text_placeid.Text;
            f_name = this.text_admin_name.Text;
            FreedomCarLeave freeleave = new FreedomCarLeave();
            freeleave.Show();
            f_carnumbers = null;
            f_contactway = null;
            f_name = null;
            f_placeid = null;
        }
    }
}
