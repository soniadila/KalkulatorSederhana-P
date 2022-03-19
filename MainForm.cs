/*
 * Created by SharpDevelop.
 * User: User
 * Date: 17/03/2022
 * Time: 10:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace kalkulator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		double value = 0;
		string ops = "";
		bool op_pressed = false;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void btn_click(object sender, EventArgs e)
		{
			if  ((hasil.Text == "0") || (op_pressed))
			{
				hasil.Clear();
			}
			Button b = (Button)sender;
			hasil.Text = hasil.Text + b.Text;
		}

		private void operator_click(object sender, EventArgs e)
		{
			Button b = (Button) sender;
			ops = b.Text;
			value = Double.Parse(hasil.Text);
			
			op_pressed = true;
		}
		
		void hitung_click(object sender, EventArgs e)
		{
			switch(ops)
			{
				case "+": hasil.Text = (value + Double.Parse(hasil.Text)).ToString();
					break;
				case "-": hasil.Text = (value - Double.Parse(hasil.Text)).ToString();
					break;
				case "X": hasil.Text = (value * Double.Parse(hasil.Text)).ToString();
					break;
				case "/": hasil.Text = (value / Double.Parse(hasil.Text)).ToString();
					break;
			}
		}
		
		void sqrt(object sender, EventArgs e)
		{
			hasil.Text = (Math.Sqrt(Double.Parse(hasil.Text))).ToString();
		}
		
		void persen(object sender, EventArgs e)
		{
			hasil.Text = (Double.Parse(hasil.Text)*0.01).ToString();
		}
		
		void reciprocal(object sender, EventArgs e)
		{
			hasil.Text = (1/Double.Parse(hasil.Text)).ToString();
		}
		
		void clear1(object sender, EventArgs e)
		{
			hasil.Text = "0";			
		}
		
		void backspace(object sender, EventArgs e)
		{
			hasil.Text = hasil.Text.Remove(hasil.Text.Length - 1, 1);
		}
		
		void exit(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
