namespace ParkingSystem
{
    partial class FreedomCarInformation
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
            this.Button_freecarInformation_close = new System.Windows.Forms.Button();
            this.Button_freecar_savemodify = new System.Windows.Forms.Button();
            this.Button_freecar_modify = new System.Windows.Forms.Button();
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
            this.Button_freecar_leave = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_freecarInformation_close
            // 
            this.Button_freecarInformation_close.Location = new System.Drawing.Point(543, 308);
            this.Button_freecarInformation_close.Name = "Button_freecarInformation_close";
            this.Button_freecarInformation_close.Size = new System.Drawing.Size(75, 23);
            this.Button_freecarInformation_close.TabIndex = 7;
            this.Button_freecarInformation_close.Text = "取消";
            this.Button_freecarInformation_close.UseVisualStyleBackColor = true;
            this.Button_freecarInformation_close.Click += new System.EventHandler(this.Button_freecarInformation_close_Click);
            // 
            // Button_freecar_savemodify
            // 
            this.Button_freecar_savemodify.Location = new System.Drawing.Point(315, 308);
            this.Button_freecar_savemodify.Name = "Button_freecar_savemodify";
            this.Button_freecar_savemodify.Size = new System.Drawing.Size(75, 23);
            this.Button_freecar_savemodify.TabIndex = 6;
            this.Button_freecar_savemodify.Text = "保存修改";
            this.Button_freecar_savemodify.UseVisualStyleBackColor = true;
            this.Button_freecar_savemodify.Click += new System.EventHandler(this.Button_freecar_savemodify_Click);
            // 
            // Button_freecar_modify
            // 
            this.Button_freecar_modify.Location = new System.Drawing.Point(209, 308);
            this.Button_freecar_modify.Name = "Button_freecar_modify";
            this.Button_freecar_modify.Size = new System.Drawing.Size(75, 23);
            this.Button_freecar_modify.TabIndex = 5;
            this.Button_freecar_modify.Text = "修改信息";
            this.Button_freecar_modify.UseVisualStyleBackColor = true;
            this.Button_freecar_modify.Click += new System.EventHandler(this.Button_freecar_modify_Click);
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
            this.groupBox5.Location = new System.Drawing.Point(30, 35);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(588, 230);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "自由车信息";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label_entertime
            // 
            this.label_entertime.AutoSize = true;
            this.label_entertime.Location = new System.Drawing.Point(101, 141);
            this.label_entertime.Name = "label_entertime";
            this.label_entertime.Size = new System.Drawing.Size(35, 12);
            this.label_entertime.TabIndex = 11;
            this.label_entertime.Text = "label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 141);
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
            // Button_freecar_leave
            // 
            this.Button_freecar_leave.Location = new System.Drawing.Point(432, 308);
            this.Button_freecar_leave.Name = "Button_freecar_leave";
            this.Button_freecar_leave.Size = new System.Drawing.Size(75, 23);
            this.Button_freecar_leave.TabIndex = 8;
            this.Button_freecar_leave.Text = "结账离开";
            this.Button_freecar_leave.UseVisualStyleBackColor = true;
            this.Button_freecar_leave.Click += new System.EventHandler(this.Button_freecar_leave_Click);
            // 
            // FreedomCarInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.Button_freecar_leave);
            this.Controls.Add(this.Button_freecarInformation_close);
            this.Controls.Add(this.Button_freecar_savemodify);
            this.Controls.Add(this.Button_freecar_modify);
            this.Controls.Add(this.groupBox5);
            this.Name = "FreedomCarInformation";
            this.Text = "FreeCarInformation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FreedomCarInformation_FormClosed);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_freecarInformation_close;
        private System.Windows.Forms.Button Button_freecar_savemodify;
        private System.Windows.Forms.Button Button_freecar_modify;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox text_placeid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox text_carnumbers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox text_admin_tel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_admin_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Button_freecar_leave;
        private System.Windows.Forms.Label label_entertime;
        private System.Windows.Forms.Label label1;
    }
}