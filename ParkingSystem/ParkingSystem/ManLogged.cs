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
        public static ManLogged manlog;

        ArrayList ButtonList = new ArrayList();

        public ManLogged()
        {

            for (int i = 0; i <= 24; i++)
            {
                ButtonList.Add(new Button());
                //this.button1.Location = new System.Drawing.Point(3, 3);
                //this.button1.Name = "button1";
                ((Button)ButtonList[i]).Size = new System.Drawing.Size(500, 500);
                ((Button)ButtonList[i]).TabIndex = i;
                ((Button)ButtonList[i]).Text = "";
                ((Button)ButtonList[i]).UseVisualStyleBackColor = true;
            }
            InitializeComponent();
            manlog = this;
            ButtonUpdate();
            AdminInformationLog();


        }


        //管理员信息加载
        private void AdminInformationLog()
        {
            this.text_admin_name.Text = MainForm.admin.ReturnName();
            this.text_admin_age.Text = MainForm.admin.ReturnAge().ToString();
            this.text_admin_tel.Text = MainForm.admin.ReturnContactWay();
            this.text_admin_idnumbers.Text = MainForm.admin.ReturnIdnumbers();
        }


        private void ButtonUpdate()
        {
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    this.tableLayoutPanel1.Controls.Add((Button)ButtonList[5 * i + j], j, i);
                }
            }

        }

        private void ManLogged_Load(object sender, EventArgs e)
        {

        }

        private void ManLogged_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.pmain.Show();
        }

        private void ManLogged_Load_1(object sender, EventArgs e)
        {

        }

        private void ManLogged_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            MainForm.pmain.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    this.dataGridView_records.Rows[index].Cells["id"].Value=record.ReturnId();
                    this.dataGridView_records.Rows[index].Cells["mastername"].Value=record.ReturnMasterName();
                    this.dataGridView_records.Rows[index].Cells["contactway"].Value=record.ReturnMasterContactWay();
                    this.dataGridView_records.Rows[index].Cells["placeid"].Value=record.ReturnPlaceid();
                    this.dataGridView_records.Rows[index].Cells["carnumbers"].Value = record.ReturnCarNumbers();
                    this.dataGridView_records.Rows[index].Cells["Entertime"].Value=record.ReturnEntertime();
                    this.dataGridView_records.Rows[index].Cells["leavetime"].Value=record.ReturnOutertime();
                    TimeSpan timespan=DateTime.Now-Convert.ToDateTime(record.ReturnEntertime());
                    this.dataGridView_records.Rows[index].Cells["allstaytime"].Value=timespan.ToString();
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
            if (this.comboBox_records.SelectedItem.ToString() == "" || this.textBox_records.Text == "")
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
                this.dataGridView_records.Rows[index].Cells["id"].Value = rows[i]["id"];
                this.dataGridView_records.Rows[index].Cells["mastername"].Value = rows[i]["name"];
                this.dataGridView_records.Rows[index].Cells["contactway"].Value = rows[i]["contactway"];
                this.dataGridView_records.Rows[index].Cells["placeid"].Value = rows[i]["placeid"];
                this.dataGridView_records.Rows[index].Cells["Entertime"].Value = rows[i]["entertime"];
                this.dataGridView_records.Rows[index].Cells["leavetime"].Value = rows[i]["outtime"];
                TimeSpan timespan = DateTime.Now - Convert.ToDateTime(rows[i]["entertime"]);
                this.dataGridView_records.Rows[index].Cells["allstaytime"].Value = timespan.TotalSeconds.ToString();
                this.dataGridView_records.Rows[index].Cells["money"].Value = rows[i]["money"];
                
            }
        }



    }
}
