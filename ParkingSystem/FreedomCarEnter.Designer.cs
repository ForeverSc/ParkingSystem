/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2009-01-01
 * Time: 18:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ParkingSystem
{
	partial class FreedomCarEnter
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_placeid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_carnumbers = new System.Windows.Forms.TextBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.textBox_mastername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_enter_allow = new System.Windows.Forms.Button();
            this.Button_enter_ban = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_AutoGiven = new System.Windows.Forms.Button();
            this.Button_Status = new System.Windows.Forms.Button();
            this.label_leftplace = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自由车进入";
            // 
            // textBox_placeid
            // 
            this.textBox_placeid.Location = new System.Drawing.Point(78, 126);
            this.textBox_placeid.Name = "textBox_placeid";
            this.textBox_placeid.ReadOnly = true;
            this.textBox_placeid.Size = new System.Drawing.Size(100, 21);
            this.textBox_placeid.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "停车位号";
            // 
            // textBox_carnumbers
            // 
            this.textBox_carnumbers.Location = new System.Drawing.Point(78, 96);
            this.textBox_carnumbers.Name = "textBox_carnumbers";
            this.textBox_carnumbers.Size = new System.Drawing.Size(100, 21);
            this.textBox_carnumbers.TabIndex = 5;
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(78, 69);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(100, 21);
            this.textBox_tel.TabIndex = 4;
            // 
            // textBox_mastername
            // 
            this.textBox_mastername.Location = new System.Drawing.Point(78, 41);
            this.textBox_mastername.Name = "textBox_mastername";
            this.textBox_mastername.Size = new System.Drawing.Size(100, 21);
            this.textBox_mastername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "车牌号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 69);
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
            // Button_enter_allow
            // 
            this.Button_enter_allow.Location = new System.Drawing.Point(403, 365);
            this.Button_enter_allow.Name = "Button_enter_allow";
            this.Button_enter_allow.Size = new System.Drawing.Size(75, 23);
            this.Button_enter_allow.TabIndex = 1;
            this.Button_enter_allow.Text = "允许进入";
            this.Button_enter_allow.UseVisualStyleBackColor = true;
            this.Button_enter_allow.Click += new System.EventHandler(this.Button_enter_allow_Click);
            // 
            // Button_enter_ban
            // 
            this.Button_enter_ban.Location = new System.Drawing.Point(510, 365);
            this.Button_enter_ban.Name = "Button_enter_ban";
            this.Button_enter_ban.Size = new System.Drawing.Size(75, 23);
            this.Button_enter_ban.TabIndex = 2;
            this.Button_enter_ban.Text = "拒绝进入";
            this.Button_enter_ban.UseVisualStyleBackColor = true;
            this.Button_enter_ban.Click += new System.EventHandler(this.Button_enter_ban_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_leftplace);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Button_AutoGiven);
            this.groupBox2.Controls.Add(this.Button_Status);
            this.groupBox2.Location = new System.Drawing.Point(363, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 316);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "停车场状态";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "剩余车位数";
            // 
            // Button_AutoGiven
            // 
            this.Button_AutoGiven.Location = new System.Drawing.Point(16, 258);
            this.Button_AutoGiven.Name = "Button_AutoGiven";
            this.Button_AutoGiven.Size = new System.Drawing.Size(206, 23);
            this.Button_AutoGiven.TabIndex = 1;
            this.Button_AutoGiven.Text = "自动分配";
            this.Button_AutoGiven.UseVisualStyleBackColor = true;
            this.Button_AutoGiven.Click += new System.EventHandler(this.Button_AutoGiven_Click);
            // 
            // Button_Status
            // 
            this.Button_Status.Location = new System.Drawing.Point(16, 213);
            this.Button_Status.Name = "Button_Status";
            this.Button_Status.Size = new System.Drawing.Size(206, 23);
            this.Button_Status.TabIndex = 0;
            this.Button_Status.Text = "详细状况";
            this.Button_Status.UseVisualStyleBackColor = true;
            this.Button_Status.Click += new System.EventHandler(this.Button_Status_Click);
            // 
            // label_leftplace
            // 
            this.label_leftplace.AutoSize = true;
            this.label_leftplace.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_leftplace.Location = new System.Drawing.Point(67, 79);
            this.label_leftplace.Name = "label_leftplace";
            this.label_leftplace.Size = new System.Drawing.Size(101, 38);
            this.label_leftplace.TabIndex = 3;
            this.label_leftplace.Text = "label6";
            // 
            // FreedomCarEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 412);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Button_enter_ban);
            this.Controls.Add(this.Button_enter_allow);
            this.Controls.Add(this.groupBox1);
            this.Name = "FreedomCarEnter";
            this.Text = "ParkingSystem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FreedomCarEnter_FormClosed);
            this.Load += new System.EventHandler(this.FreedomCarEnter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_placeid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_carnumbers;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.TextBox textBox_mastername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_enter_allow;
        private System.Windows.Forms.Button Button_enter_ban;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Button_AutoGiven;
        private System.Windows.Forms.Button Button_Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_leftplace;
	}
}
