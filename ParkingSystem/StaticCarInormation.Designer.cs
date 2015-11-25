namespace ParkingSystem
{
    partial class StaticCarInormation
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
            this.Button_staticcar_leave = new System.Windows.Forms.Button();
            this.Button_cancel = new System.Windows.Forms.Button();
            this.Button_staticcar_savemodify = new System.Windows.Forms.Button();
            this.Button_staticcar_modify = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label_entertime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_placeid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.text_carnumbers = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.text_admin_tel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.text_admin_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_static_enter = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_staticcar_leave
            // 
            this.Button_staticcar_leave.Location = new System.Drawing.Point(147, 285);
            this.Button_staticcar_leave.Name = "Button_staticcar_leave";
            this.Button_staticcar_leave.Size = new System.Drawing.Size(75, 23);
            this.Button_staticcar_leave.TabIndex = 13;
            this.Button_staticcar_leave.Text = "离开";
            this.Button_staticcar_leave.UseVisualStyleBackColor = true;
            this.Button_staticcar_leave.Click += new System.EventHandler(this.Button_staticcar_leave_Click);
            // 
            // Button_cancel
            // 
            this.Button_cancel.Location = new System.Drawing.Point(535, 338);
            this.Button_cancel.Name = "Button_cancel";
            this.Button_cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_cancel.TabIndex = 12;
            this.Button_cancel.Text = "取消";
            this.Button_cancel.UseVisualStyleBackColor = true;
            this.Button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // Button_staticcar_savemodify
            // 
            this.Button_staticcar_savemodify.Location = new System.Drawing.Point(197, 338);
            this.Button_staticcar_savemodify.Name = "Button_staticcar_savemodify";
            this.Button_staticcar_savemodify.Size = new System.Drawing.Size(75, 23);
            this.Button_staticcar_savemodify.TabIndex = 11;
            this.Button_staticcar_savemodify.Text = "保存修改";
            this.Button_staticcar_savemodify.UseVisualStyleBackColor = true;
            this.Button_staticcar_savemodify.Click += new System.EventHandler(this.Button_staticcar_savemodify_Click);
            // 
            // Button_staticcar_modify
            // 
            this.Button_staticcar_modify.Location = new System.Drawing.Point(100, 338);
            this.Button_staticcar_modify.Name = "Button_staticcar_modify";
            this.Button_staticcar_modify.Size = new System.Drawing.Size(75, 23);
            this.Button_staticcar_modify.TabIndex = 10;
            this.Button_staticcar_modify.Text = "修改信息";
            this.Button_staticcar_modify.UseVisualStyleBackColor = true;
            this.Button_staticcar_modify.Click += new System.EventHandler(this.Button_staticcar_modify_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label_entertime);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.text_placeid);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.text_carnumbers);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.text_admin_tel);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.text_admin_name);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(22, 34);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(588, 221);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "自由车信息";
            // 
            // label_entertime
            // 
            this.label_entertime.AutoSize = true;
            this.label_entertime.Location = new System.Drawing.Point(99, 145);
            this.label_entertime.Name = "label_entertime";
            this.label_entertime.Size = new System.Drawing.Size(35, 12);
            this.label_entertime.TabIndex = 11;
            this.label_entertime.Text = "label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "进入时间";
            // 
            // text_placeid
            // 
            this.text_placeid.Location = new System.Drawing.Point(101, 90);
            this.text_placeid.Name = "text_placeid";
            this.text_placeid.ReadOnly = true;
            this.text_placeid.Size = new System.Drawing.Size(159, 21);
            this.text_placeid.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 8;
            this.label13.Text = "车位号";
            // 
            // text_carnumbers
            // 
            this.text_carnumbers.Location = new System.Drawing.Point(101, 35);
            this.text_carnumbers.Name = "text_carnumbers";
            this.text_carnumbers.ReadOnly = true;
            this.text_carnumbers.Size = new System.Drawing.Size(159, 21);
            this.text_carnumbers.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 6;
            this.label12.Text = "车牌号";
            // 
            // text_admin_tel
            // 
            this.text_admin_tel.Location = new System.Drawing.Point(389, 93);
            this.text_admin_tel.Name = "text_admin_tel";
            this.text_admin_tel.ReadOnly = true;
            this.text_admin_tel.Size = new System.Drawing.Size(139, 21);
            this.text_admin_tel.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(324, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "电话";
            // 
            // text_admin_name
            // 
            this.text_admin_name.Location = new System.Drawing.Point(389, 44);
            this.text_admin_name.Name = "text_admin_name";
            this.text_admin_name.ReadOnly = true;
            this.text_admin_name.Size = new System.Drawing.Size(139, 21);
            this.text_admin_name.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "车主姓名";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "月费结算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(237, 285);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 15;
            this.button_delete.Text = "删除该车";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_static_enter
            // 
            this.button_static_enter.Location = new System.Drawing.Point(58, 285);
            this.button_static_enter.Name = "button_static_enter";
            this.button_static_enter.Size = new System.Drawing.Size(75, 23);
            this.button_static_enter.TabIndex = 16;
            this.button_static_enter.Text = "进入";
            this.button_static_enter.UseVisualStyleBackColor = true;
            this.button_static_enter.Click += new System.EventHandler(this.button_static_enter_Click);
            // 
            // StaticCarInormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 395);
            this.Controls.Add(this.button_static_enter);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button_staticcar_leave);
            this.Controls.Add(this.Button_cancel);
            this.Controls.Add(this.Button_staticcar_savemodify);
            this.Controls.Add(this.Button_staticcar_modify);
            this.Controls.Add(this.groupBox5);
            this.Name = "StaticCarInormation";
            this.Text = "StaticCarModify";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaticCarInormation_FormClosed);
            this.Load += new System.EventHandler(this.StaticCarInormation_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_staticcar_leave;
        private System.Windows.Forms.Button Button_cancel;
        private System.Windows.Forms.Button Button_staticcar_savemodify;
        private System.Windows.Forms.Button Button_staticcar_modify;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label_entertime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_placeid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox text_carnumbers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox text_admin_tel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_admin_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_static_enter;
    }
}