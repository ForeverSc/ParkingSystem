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
    public partial class FreedomCarLeave : Form
    {
        public Model_FreedomCars freecar;
        public Model_Records record;

        public FreedomCarLeave()
        {
            InitializeComponent();
        }

        //加载各项数据
        private void LoadLeaveCarData()
        {

        }


        private void Button_Allow_Leave_Click(object sender, EventArgs e)
        {
            BLL_ParkingStatus.SetPlaceidAvailable(freecar.ReturnPlaceid());
            BLL_FreedomCars.LeaveOneFreeCar(freecar);
            BLL_Records.FinishOneRecord(record);
            this.Close();
        }

        private void Button_NotAllow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_NextStep_Click(object sender, EventArgs e)
        {
            if (this.textBox_placeid.Text == "" || this.textBox_carnumbers.Text == "" || this.textBox_mastername.Text == "" || this.textBox_contactway.Text == "")
            {
                MessageBox.Show("输入项不能为空");
            }
            else
            {
                freecar = new Model_FreedomCars(Convert.ToInt32(this.textBox_placeid.Text),
                                            this.textBox_carnumbers.Text,
                                            this.textBox_mastername.Text,
                                            this.textBox_contactway.Text);
                if (BLL_FreedomCars.ReturnCarExist(freecar) == true)
                {
                    this.Button_NextStep.Visible = false;
                    this.Button_NextStep.Enabled = false;
                    this.Button_Allow_Leave.Visible = true;
                    this.Button_Allow_Leave.Enabled = true;

                    record = BLL_Records.ReturnRecordByNumbersAndName(
                                                             this.textBox_carnumbers.Text,
                                                             this.textBox_mastername.Text
                                                             );

                    record.SetOuttime(DateTime.Now);
                    double hoursmoney = Convert.ToDouble(this.textBox_hoursmoney.Text);
                    record.SetMoney(hoursmoney);
                    this.label_entertime.Text = record.ReturnEntertime();
                    this.label_leavetime.Text = record.ReturnOutertime();
                    this.label_timecost.Text = record.ReturnAllStayTime();
                    this.label_hoursmoney.Text = hoursmoney.ToString();
                    this.label_moneycost.Text =string.Format("{0:CF}",record.ReturnMoney());
                    this.costlist.Visible = true;

                }
                else
                {
                    MessageBox.Show("输入信息有误，请重新输入！");
                    this.textBox_carnumbers.Text = "";
                    this.textBox_contactway.Text = "";
                    this.textBox_mastername.Text = "";
                    this.textBox_placeid.Text = "";
                }

            }


        }

        private void FreedomCarLeave_Load(object sender, EventArgs e)
        {
            if (FreedomCarInformation.f_carnumbers != ""
               && FreedomCarInformation.f_contactway != ""
               && FreedomCarInformation.f_name != ""
               && FreedomCarInformation.f_placeid != "")
            {
                this.textBox_carnumbers.Text = FreedomCarInformation.f_carnumbers;
                this.textBox_contactway.Text = FreedomCarInformation.f_contactway;
                this.textBox_mastername.Text = FreedomCarInformation.f_name;
                this.textBox_placeid.Text = FreedomCarInformation.f_placeid;
            }
            else
            {
                this.textBox_carnumbers.Text = "";
                this.textBox_contactway.Text = "";
                this.textBox_mastername.Text = "";
                this.textBox_placeid.Text = "";
                
            }
        }

        private void FreedomCarLeave_FormClosed(object sender, FormClosedEventArgs e)
        { 
            ManLogged.RefreshFreeStatus();
        }





    }
}
