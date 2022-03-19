/*
 * Created by SharpDevelop.
 * User: User
 * Date: 17/03/2022
 * Time: 10:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace kalkulator
{
	partial class MainForm
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
			this.hasil = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button19 = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.button21 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// hasil
			// 
			this.hasil.Location = new System.Drawing.Point(42, 54);
			this.hasil.MaxLength = 33000;
			this.hasil.Name = "hasil";
			this.hasil.Size = new System.Drawing.Size(209, 20);
			this.hasil.TabIndex = 0;
			this.hasil.Text = "0";
			this.hasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(42, 117);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 30);
			this.button1.TabIndex = 1;
			this.button1.Text = "←";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.backspace);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(128, 117);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 30);
			this.button2.TabIndex = 2;
			this.button2.Text = "C";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.clear1);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(214, 117);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(37, 30);
			this.button3.TabIndex = 3;
			this.button3.Text = "√";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.sqrt);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(42, 153);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(37, 30);
			this.button4.TabIndex = 4;
			this.button4.Text = "7";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.btn_click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(85, 153);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(37, 30);
			this.button5.TabIndex = 5;
			this.button5.Text = "8";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.btn_click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(128, 153);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(37, 30);
			this.button6.TabIndex = 6;
			this.button6.Text = "9";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.btn_click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(171, 153);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(37, 30);
			this.button7.TabIndex = 7;
			this.button7.Text = "/";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.operator_click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(214, 153);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(37, 30);
			this.button8.TabIndex = 8;
			this.button8.Text = "%";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.persen);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(42, 189);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(37, 30);
			this.button9.TabIndex = 9;
			this.button9.Text = "4";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.btn_click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(85, 189);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(37, 30);
			this.button10.TabIndex = 10;
			this.button10.Text = "5";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.btn_click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(128, 189);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(37, 30);
			this.button11.TabIndex = 11;
			this.button11.Text = "6";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.btn_click);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(171, 189);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(37, 30);
			this.button12.TabIndex = 12;
			this.button12.Text = "X";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.operator_click);
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(214, 189);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(37, 30);
			this.button13.TabIndex = 13;
			this.button13.Text = "1/x";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.reciprocal);
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(42, 225);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(37, 30);
			this.button14.TabIndex = 14;
			this.button14.Text = "1";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.btn_click);
			// 
			// button15
			// 
			this.button15.Location = new System.Drawing.Point(85, 225);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(37, 30);
			this.button15.TabIndex = 15;
			this.button15.Text = "2";
			this.button15.UseVisualStyleBackColor = true;
			this.button15.Click += new System.EventHandler(this.btn_click);
			// 
			// button16
			// 
			this.button16.Location = new System.Drawing.Point(128, 225);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(37, 30);
			this.button16.TabIndex = 16;
			this.button16.Text = "3";
			this.button16.UseVisualStyleBackColor = true;
			this.button16.Click += new System.EventHandler(this.btn_click);
			// 
			// button17
			// 
			this.button17.Location = new System.Drawing.Point(171, 225);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(37, 30);
			this.button17.TabIndex = 17;
			this.button17.Text = "-";
			this.button17.UseVisualStyleBackColor = true;
			this.button17.Click += new System.EventHandler(this.operator_click);
			// 
			// button19
			// 
			this.button19.Location = new System.Drawing.Point(128, 261);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(37, 30);
			this.button19.TabIndex = 19;
			this.button19.Text = ",";
			this.button19.UseVisualStyleBackColor = true;
			this.button19.Click += new System.EventHandler(this.btn_click);
			// 
			// button20
			// 
			this.button20.Location = new System.Drawing.Point(171, 261);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(37, 30);
			this.button20.TabIndex = 20;
			this.button20.Text = "+";
			this.button20.UseVisualStyleBackColor = true;
			this.button20.Click += new System.EventHandler(this.operator_click);
			// 
			// button21
			// 
			this.button21.Location = new System.Drawing.Point(214, 225);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(37, 66);
			this.button21.TabIndex = 21;
			this.button21.Text = "=";
			this.button21.UseVisualStyleBackColor = true;
			this.button21.Click += new System.EventHandler(this.hitung_click);
			// 
			// button18
			// 
			this.button18.Location = new System.Drawing.Point(42, 261);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(80, 30);
			this.button18.TabIndex = 22;
			this.button18.Text = "0";
			this.button18.UseVisualStyleBackColor = true;
			this.button18.Click += new System.EventHandler(this.btn_click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label1.Location = new System.Drawing.Point(-1, -1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 22);
			this.label1.TabIndex = 23;
			this.label1.Text = "Exit";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.exit);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 325);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button18);
			this.Controls.Add(this.button21);
			this.Controls.Add(this.button20);
			this.Controls.Add(this.button19);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.button16);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.hasil);
			this.Name = "MainForm";
			this.Text = "kalkulator";
			this.Click += new System.EventHandler(this.persen);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button19;
		//private System.Windows.Forms.Button btn_click;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox hasil;
	}
}
