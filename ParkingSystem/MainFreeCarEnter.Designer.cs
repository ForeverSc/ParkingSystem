namespace ParkingSystem
{
    partial class MainFreeCarEnter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_enter_ban = new System.Windows.Forms.Button();
            this.Button_enter_allow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_placeid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_carnumbers = new System.Windows.Forms.TextBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.textBox_mastername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_enter_ban
            // 
            this.Button_enter_ban.Location = new System.Drawing.Point(260, 344);
            this.Button_enter_ban.Name = "Button_enter_ban";
            this.Button_enter_ban.Size = new System.Drawing.Size(75, 23);
            this.Button_enter_ban.TabIndex = 6;
            this.Button_enter_ban.Text = "拒绝进入";
            this.Button_enter_ban.UseVisualStyleBackColor = true;
            this.Button_enter_ban.Click += new System.EventHandler(this.Button_enter_ban_Click);
            // 
            // Button_enter_allow
            // 
            this.Button_enter_allow.Location = new System.Drawing.Point(140, 344);
            this.Button_enter_allow.Name = "Button_enter_allow";
            this.Button_enter_allow.Size = new System.Drawing.Size(75, 23);
            this.Button_enter_allow.TabIndex = 5;
            this.Button_enter_allow.Text = "允许进入";
            this.Button_enter_allow.UseVisualStyleBackColor = true;
            this.Button_enter_allow.Click += new System.EventHandler(this.Button_enter_allow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_placeid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_carnumbers);
            this.groupBox1.Controls.Add(this.textBox_tel);
            this.groupBox1.Controls.Add(this.textBox_mastername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 268);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自由车进入";
            // 
            // textBox_placeid
            // 
            this.textBox_placeid.Location = new System.Drawing.Point(78, 165);
            this.textBox_placeid.Name = "textBox_placeid";
            this.textBox_placeid.ReadOnly = true;
            this.textBox_placeid.Size = new System.Drawing.Size(100, 21);
            this.textBox_placeid.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "停车位号";
            // 
            // textBox_carnumbers
            // 
            this.textBox_carnumbers.Location = new System.Drawing.Point(78, 122);
            this.textBox_carnumbers.Name = "textBox_carnumbers";
            this.textBox_carnumbers.Size = new System.Drawing.Size(100, 21);
            this.textBox_carnumbers.TabIndex = 5;
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(78, 78);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(100, 21);
            this.textBox_tel.TabIndex = 4;
            // 
            // textBox_mastername
            // 
            this.textBox_mastername.Location = new System.Drawing.Point(78, 38);
            this.textBox_mastername.Name = "textBox_mastername";
            this.textBox_mastername.Size = new System.Drawing.Size(100, 21);
            this.textBox_mastername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "车牌号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "电话";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "车主姓名";
            // 
            // MainFreeCarEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 419);
            this.Controls.Add(this.Button_enter_ban);
            this.Controls.Add(this.Button_enter_allow);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainFreeCarEnter";
            this.Text = "FreeCarEnter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFreeCarEnter_FormClosed);
            this.Load += new System.EventHandler(this.MainFreeCarEnter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_enter_ban;
        private System.Windows.Forms.Button Button_enter_allow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_placeid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_carnumbers;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.TextBox textBox_mastername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}