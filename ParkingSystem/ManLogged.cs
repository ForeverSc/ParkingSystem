using System;
using System.Collections;
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
    public partial class ManLogged : Form
    {

        public static Model_FreedomCars freecar;
        public static Model_StaticCars staticcar;
        public static Model_Records record;
        public static ManLogged manlog;
        public static string buttonplaceid;


        public ManLogged()
        {
            InitializeComponent();
            manlog = this;
            AdminInformationLog();
        }

        

        public static void newButton_Click(object sender, EventArgs e)
        {
             Button thisbutton = (Button)sender;
             freecar=BLL_FreedomCars.ReturnCarByPlaceid(Convert.ToInt32(thisbutton.Text));
             buttonplaceid =thisbutton.Text;
            if (freecar!=null)
            {
                FreedomCarInformation fwindow = new FreedomCarInformation();
                fwindow.Show();
            }
            else
            {
                MainFreeCarEnter enterwindow = new MainFreeCarEnter();
                enterwindow.Show();
            }
                       
            
        }

        public static void staticButton_Click(object sender, EventArgs e)
        {
            Button thisbutton = (Button)sender;
            staticcar= BLL_StaticCars.ReturnCarByPlaceid(Convert.ToInt32(thisbutton.Text));        
            buttonplaceid = thisbutton.Text;
            if (staticcar != null)
            {
                StaticCarInormation fwindow = new StaticCarInormation();
                fwindow.Show();
            }
            else
            {
                StaticCarEnter enterwindow = new StaticCarEnter();
                enterwindow.Show();
            }


        }


       


        //管理员信息加载
        private void AdminInformationLog()
        {
            this.text_admin_name.Text = MainForm.admin.ReturnName();
            this.text_admin_age.Text = MainForm.admin.ReturnAge().ToString();
            this.text_admin_tel.Text = MainForm.admin.ReturnContactWay();
            this.text_admin_idnumbers.Text = MainForm.admin.ReturnIdnumbers();
        }


        private static void LoadStaticButtons()
        {
            DataSet placeset = BLL_ParkingStatus.ReturnParkingStatusDataSet();
            DataTable placetable = placeset.Tables[0];
            DataRowCollection placerows = placetable.Rows;
            for (int i = 25; i < 50; i++)
            {
                Button newButton = new Button();
                newButton.Text = placerows[i]["placeid"].ToString();
                if (placerows[i]["status"].ToString() == "0")
                {
                    newButton.BackColor = Color.Green;
                }
                else
                {
                    newButton.BackColor = Color.Red;
                }
                newButton.Click+=staticButton_Click;

                manlog.flowLayoutPanel_static.Controls.Add(newButton);
            }
 
        }


        private void ManLogged_Load(object sender, EventArgs e)
        {
            LoadButtons();
            LoadStaticButtons();
            this.label_leftplace.Text = BLL_ParkingStatus.ReturnFreeLeftNumbersOfPlace();
            
        }

        private void ManLogged_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.pmain.Show();
        }


        private void ManLogged_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            MainForm.pmain.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            freecar = new Model_FreedomCars(Convert.ToInt32(this.dataGridView_freecars.CurrentRow.Cells["freeplaceid"].Value),
                                            this.dataGridView_freecars.CurrentRow.Cells["freecarnumbers"].Value.ToString(),
                                            this.dataGridView_freecars.CurrentRow.Cells["freemastername"].Value.ToString(),
                                            this.dataGridView_freecars.CurrentRow.Cells["freetel"].Value.ToString(),
                                            Convert.ToDateTime(this.dataGridView_freecars.CurrentRow.Cells["freeentertime"].Value.ToString()));
            FreedomCarInformation modifywindow = new FreedomCarInformation();
            modifywindow.ShowDialog();


        }

        private void button_admin_quit_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.pmain.Focus();
        }
        //保存修改管理员信息
        private void button_admin_savemodify_Click(object sender, EventArgs e)
        {
            if (this.text_admin_password.Text == "" && this.text_admin_password2.Text == "")
            {
                MainForm.admin.SetInformation(this.text_admin_idnumbers.Text, MainForm.admin.ReturnPassword(), this.text_admin_name.Text, Convert.ToInt32(this.text_admin_age.Text), this.text_admin_tel.Text);
            }
            else if (this.text_admin_password.Text != this.text_admin_password2.Text)
            {
                MessageBox.Show("两次输入的密码不一致！请重新输入");
                this.text_admin_password.Text = "";
                this.text_admin_password2.Text = "";
            }
            else
                MainForm.admin.SetInformation(this.text_admin_idnumbers.Text, this.text_admin_password.Text, this.text_admin_name.Text, Convert.ToInt32(this.text_admin_age.Text), this.text_admin_tel.Text);
        }

        private void button_admin_modifyinformation_Click(object sender, EventArgs e)
        {
            this.text_admin_age.ReadOnly = false;
            this.text_admin_name.ReadOnly = false;
            this.text_admin_tel.ReadOnly = false;
            this.text_admin_idnumbers.ReadOnly = false;
            this.text_admin_password.ReadOnly = false;
            this.text_admin_password2.ReadOnly = false;
        }

        private void Button_Freecar_Enter_Click(object sender, EventArgs e)
        {
            FreedomCarEnter freecarEnter = new FreedomCarEnter();
            freecarEnter.Show();
        }



        private void Button_records_search_Click(object sender, EventArgs e)
        {
            this.dataGridView_records.Rows.Clear();
            Model_Records record;
            if (this.comboBox_records.SelectedItem.ToString() == "" || this.textBox_records.Text == "")
            {
                MessageBox.Show("查询方式有误，请重试！");
            }
            else
            {
                record = BLL_Records.ReturnSearchBy(this.comboBox_records.SelectedItem.ToString(), this.textBox_records.Text);
                if (record != null)
                {
                    int index = this.dataGridView_records.Rows.Add();
                    this.dataGridView_records.Rows[index].Cells["mastername"].Value = record.ReturnMasterName();
                    this.dataGridView_records.Rows[index].Cells["contactway"].Value = record.ReturnMasterContactWay();
                    this.dataGridView_records.Rows[index].Cells["placeid"].Value = record.ReturnPlaceid();
                    this.dataGridView_records.Rows[index].Cells["carnumbers"].Value = record.ReturnCarNumbers();
                    this.dataGridView_records.Rows[index].Cells["Entertime"].Value = record.ReturnEntertime();
                    this.dataGridView_records.Rows[index].Cells["leavetime"].Value = record.ReturnOutertime();
                    TimeSpan timespan = DateTime.Now - Convert.ToDateTime(record.ReturnEntertime());
                    this.dataGridView_records.Rows[index].Cells["allstaytime"].Value = string.Format("{0}天{1}小时{2}分钟", timespan.Days, timespan.Hours, timespan.Minutes);
                    this.dataGridView_records.Rows[index].Cells["money"].Value = record.ReturnMoney();

                }

            }

        }

        private void Button_Freecar_Leave_Click(object sender, EventArgs e)
        {
            FreedomCarLeave freecarLeave = new FreedomCarLeave();
            freecarLeave.Show();
        }

        private void Button_Freecar_Search_Click(object sender, EventArgs e)
        {

            //清除数据
            this.dataGridView_freecars.Rows.Clear();
            if (this.comboBox_freecar.SelectedItem.ToString() == "" || this.textBox_freecar.Text == "")
            {
                MessageBox.Show("查询方式有误，请重试！");
            }
            else
            {
                //返回结果
                Model_FreedomCars freecar = BLL_FreedomCars.ReturnSearchBy(this.comboBox_freecar.SelectedItem.ToString(), this.textBox_freecar.Text);

                if (freecar != null)
                {
                    int index = this.dataGridView_freecars.Rows.Add();
                    this.dataGridView_freecars.Rows[index].Cells["freecarnumbers"].Value = freecar.ReturnCarNumbers();
                    this.dataGridView_freecars.Rows[index].Cells["freeplaceid"].Value = freecar.ReturnPlaceid();
                    this.dataGridView_freecars.Rows[index].Cells["freemastername"].Value = freecar.ReturnMasterName();
                    this.dataGridView_freecars.Rows[index].Cells["freetel"].Value = freecar.ReturnContactWay();
                    this.dataGridView_freecars.Rows[index].Cells["freeentertime"].Value = freecar.ReturnEnetertime();
                    TimeSpan timespan = DateTime.Now -Convert.ToDateTime(freecar.ReturnEnetertime());
                    this.dataGridView_freecars.Rows[index].Cells["timestay"].Value = string.Format("{0}天{1}小时{2}分钟", timespan.Days, timespan.Hours, timespan.Minutes);

                }

            }





        }

        private void Button_checkall_freecars_Click(object sender, EventArgs e)
        {

            //清除数据
            this.dataGridView_freecars.Rows.Clear();
            DataSet dataset = BLL_FreedomCars.ReturnAll();
            DataRowCollection rows = dataset.Tables[0].Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                int index = this.dataGridView_freecars.Rows.Add();
                this.dataGridView_freecars.Rows[index].Cells["freecarnumbers"].Value = rows[i]["carnumbers"];
                this.dataGridView_freecars.Rows[index].Cells["freeplaceid"].Value = rows[i]["placeid"];
                this.dataGridView_freecars.Rows[index].Cells["freemastername"].Value = rows[i]["name"];
                this.dataGridView_freecars.Rows[index].Cells["freetel"].Value = rows[i]["contactway"];
                this.dataGridView_freecars.Rows[index].Cells["freeentertime"].Value = rows[i]["entertime"];
                TimeSpan timespan = DateTime.Now - Convert.ToDateTime(rows[i]["entertime"]);
                this.dataGridView_freecars.Rows[index].Cells["timestay"].Value = string.Format("{0}天{1}小时{2}分钟", timespan.Days, timespan.Hours, timespan.Minutes);
            }



        }

        private void Button_Check_AllRecords_Click(object sender, EventArgs e)
        {
            this.dataGridView_records.Rows.Clear();
            DataSet dataset = BLL_Records.ReturnAllRecords();
            DataRowCollection rows = dataset.Tables[0].Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                int index = this.dataGridView_records.Rows.Add();
                this.dataGridView_records.Rows[index].Cells["mastername"].Value = rows[i]["name"];
                this.dataGridView_records.Rows[index].Cells["carnumbers"].Value = rows[i]["carnumbers"];
                this.dataGridView_records.Rows[index].Cells["contactway"].Value = rows[i]["contactway"];
                this.dataGridView_records.Rows[index].Cells["placeid"].Value = rows[i]["placeid"];
                this.dataGridView_records.Rows[index].Cells["Entertime"].Value = rows[i]["entertime"];
                this.dataGridView_records.Rows[index].Cells["leavetime"].Value = rows[i]["outtime"];
                TimeSpan timespan = DateTime.Now - Convert.ToDateTime(rows[i]["entertime"]);
                this.dataGridView_records.Rows[index].Cells["allstaytime"].Value = string.Format("{0}天{1}小时{2}分钟", timespan.Days, timespan.Hours, timespan.Minutes);
                this.dataGridView_records.Rows[index].Cells["money"].Value = rows[i]["money"];

            }
        }
        //通过从ParkingStatus读取到datatble中，然后和button进行数据绑定
        public static void LoadButtons()
        {
            DataSet placeset = BLL_ParkingStatus.ReturnParkingStatusDataSet();
            DataTable placetable = placeset.Tables[0];
            DataRowCollection placerows = placetable.Rows;
            for (int i = 0; i < 25; i++)
            {
                Button newButton = new Button();
                newButton.Text = placerows[i]["placeid"].ToString();
                if (placerows[i]["status"].ToString() == "0")
                {
                    newButton.BackColor = Color.Green;
                }
                else
                {
                    newButton.BackColor = Color.Red;
                }
                newButton.Click += newButton_Click;

                manlog.flowLayoutPanel_free.Controls.Add(newButton);
            }


        }

        public static void RefreshFreeStatus()
        {
            manlog.flowLayoutPanel_free.Controls.Clear();
            manlog.flowLayoutPanel_static.Controls.Clear();
            LoadButtons();
            LoadStaticButtons();
            manlog.label_leftplace.Text = BLL_ParkingStatus.ReturnFreeLeftNumbersOfPlace();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel_free.Controls.Clear();
            LoadButtons();
            LoadStaticButtons();
        }

        private void Button_Staticcar_Search_Click(object sender, EventArgs e)
        {
            //清除数据
            this.datagridview_staticcars.Rows.Clear();
            if (this.combox_staticcar.SelectedItem.ToString() == "" || this.textBox_static_search.Text == "")
            {
                MessageBox.Show("查询方式有误，请重试！");
            }
            else
            {
                //返回结果
                
                Model_StaticCars staticcar =  BLL_StaticCars.ReturnSearchBy(this.combox_staticcar.SelectedItem.ToString(), this.textBox_static_search.Text);

                if (staticcar != null)
                {
                    int index = this.datagridview_staticcars.Rows.Add();
                    this.datagridview_staticcars.Rows[index].Cells["staticcarnumbers"].Value =staticcar.ReturnCarnumbers() ;
                    this.datagridview_staticcars.Rows[index].Cells["staticplaceid"].Value = staticcar.ReturnPlaceid();
                    this.datagridview_staticcars.Rows[index].Cells["staticname"].Value =staticcar.ReturnName();
                    this.datagridview_staticcars.Rows[index].Cells["statictel"].Value = staticcar.ReturnContactway();
                    this.datagridview_staticcars.Rows[index].Cells["staticmoney"].Value = staticcar.ReturnMoney();
                    this.datagridview_staticcars.Rows[index].Cells["staticaddress"].Value = staticcar.ReturnAddress();
                    this.datagridview_staticcars.Rows[index].Cells["staticentertime"].Value = staticcar.ReturnEntertime();

                }

            }
        }

        private void label_leftplace_Click(object sender, EventArgs e)
        {

        }

        private void Button_StaticCar_Enter_Click(object sender, EventArgs e)
        {
            StaticCarEnter staticEnter = new StaticCarEnter();
            staticEnter.Show();
        }

        private void Button_allstaticcars_Click(object sender, EventArgs e)
        {
            //清除数据
            this.datagridview_staticcars.Rows.Clear();
            DataSet dataset = BLL_StaticCars.ReturnAllStaticCars();
            DataRowCollection rows = dataset.Tables[0].Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                int index = this.datagridview_staticcars.Rows.Add();
                this.datagridview_staticcars.Rows[index].Cells["staticcarnumbers"].Value = rows[i]["carnumbers"];
                this.datagridview_staticcars.Rows[index].Cells["staticplaceid"].Value = rows[i]["placeid"];
                this.datagridview_staticcars.Rows[index].Cells["staticname"].Value = rows[i]["name"];
                this.datagridview_staticcars.Rows[index].Cells["statictel"].Value = rows[i]["contactway"];
                this.datagridview_staticcars.Rows[index].Cells["staticmoney"].Value = rows[i]["money"];
                this.datagridview_staticcars.Rows[index].Cells["staticaddress"].Value = rows[i]["address"];
                this.datagridview_staticcars.Rows[index].Cells["staticentertime"].Value = rows[i]["entertime"];
            }
        }

        private void Button_modifystaticcar_Click(object sender, EventArgs e)
        {

        }

        private void datagridview_staticcars_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.datagridview_staticcars.CurrentRow.Cells["staticentertime"].Value.ToString()=="")
            {
                staticcar = new Model_StaticCars(Convert.ToInt32(this.datagridview_staticcars.CurrentRow.Cells["staticplaceid"].Value.ToString())
                , this.datagridview_staticcars.CurrentRow.Cells["staticcarnumbers"].Value.ToString()
                , this.datagridview_staticcars.CurrentRow.Cells["staticname"].Value.ToString()
                , this.datagridview_staticcars.CurrentRow.Cells["statictel"].Value.ToString()     
                                        );
            }
            else
            {
                staticcar = new Model_StaticCars(Convert.ToInt32(this.datagridview_staticcars.CurrentRow.Cells["staticplaceid"].Value.ToString())
                , this.datagridview_staticcars.CurrentRow.Cells["staticcarnumbers"].Value.ToString()
                , this.datagridview_staticcars.CurrentRow.Cells["staticname"].Value.ToString()
                , this.datagridview_staticcars.CurrentRow.Cells["statictel"].Value.ToString()
                , Convert.ToDateTime(this.datagridview_staticcars.CurrentRow.Cells["staticentertime"].Value.ToString())  
                                        );

            }
       
            StaticCarInormation swindow = new StaticCarInormation();
            swindow.Show();
        }

        private void button_addnewstaticcar_Click(object sender, EventArgs e)
        {
            AddNewStaticCar addnew = new AddNewStaticCar();
            addnew.Show();
        }

        private void Button_StaticCar_Leave_Click(object sender, EventArgs e)
        {
            StaticCarLeave staticcarleave = new StaticCarLeave();
            staticcarleave.Show();
        }

        private void dataGridView_records_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

    



    }
}
