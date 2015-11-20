using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ParkingSystem.BLL;
using ParkingSystem.DAL;

namespace ParkingSystem
{
    public partial class MainForm : Form
    {
        public static  MainForm pmain;
        public static BLL_Administrator admin;

        public MainForm()
        {
            InitializeComponent();
            pmain = this;
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool IsCorrect = true;
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("账号不可为空", "", MessageBoxButtons.OK);
                IsCorrect = false;
            }
            else if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("密码不可为空", "", MessageBoxButtons.OK);
                IsCorrect = false;
            }
            if (IsCorrect == true)
            {
               admin=new BLL_Administrator(this.textBox1.Text,this.textBox2.Text);

                if (admin.ReturnIfLogged()==1)
                {
                    this.Hide();  
                    ManLogged mlogged = new ManLogged();
                    mlogged.Show();
                                    
                }
                else
                {
                    MessageBox.Show("用户名或密码错误");
                    this.textBox1.Clear();
                    this.textBox2.Clear();
                }


               
                
            }
        }
    }
}
