namespace ParkingSystem
{
    partial class StaticCarLeave
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_contactway = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_carnumbers = new System.Windows.Forms.TextBox();
            this.textBox_placeid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_allow_leave = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_contactway);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.textBox_carnumbers);
            this.groupBox1.Controls.Add(this.textBox_placeid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "固定车离开";
            // 
            // textBox_contactway
            // 
            this.textBox_contactway.Location = new System.Drawing.Point(128, 179);
            this.textBox_contactway.Name = "textBox_contactway";
            this.textBox_contactway.Size = new System.Drawing.Size(100, 21);
            this.textBox_contactway.TabIndex = 7;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(128, 139);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_name.TabIndex = 6;
            // 
            // textBox_carnumbers
            // 
            this.textBox_carnumbers.Location = new System.Drawing.Point(128, 96);
            this.textBox_carnumbers.Name = "textBox_carnumbers";
            this.textBox_carnumbers.Size = new System.Drawing.Size(100, 21);
            this.textBox_carnumbers.TabIndex = 5;
            // 
            // textBox_placeid
            // 
            this.textBox_placeid.Location = new System.Drawing.Point(128, 53);
            this.textBox_placeid.Name = "textBox_placeid";
            this.textBox_placeid.Size = new System.Drawing.Size(100, 21);
            this.textBox_placeid.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "车位号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "联系电话";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "车主姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "车牌号";
            // 
            // button_allow_leave
            // 
            this.button_allow_leave.Location = new System.Drawing.Point(423, 440);
            this.button_allow_leave.Name = "button_allow_leave";
            this.button_allow_leave.Size = new System.Drawing.Size(75, 23);
            this.button_allow_leave.TabIndex = 1;
            this.button_allow_leave.Text = "允许离开";
            this.button_allow_leave.UseVisualStyleBackColor = true;
            this.button_allow_leave.Click += new System.EventHandler(this.button_allow_leave_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(530, 440);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // StaticCarLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 494);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_allow_leave);
            this.Controls.Add(this.groupBox1);
            this.Name = "StaticCarLeave";
            this.Text = "StaticCarLeave";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaticCarLeave_FormClosed);
            this.Load += new System.EventHandler(this.StaticCarLeave_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_contactway;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_carnumbers;
        private System.Windows.Forms.TextBox textBox_placeid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_allow_leave;
        private System.Windows.Forms.Button button_cancel;
    }
}