/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/28/2024
 * Time: 10:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace calculatorAvionConsum
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		public void calculeaza(double s, double w, double d, ref TextBox txtr)
		{
			double ppmoft = 166; // pounds of fuel for each minute of flight time
			double gs = (s+w)/w; //ground speed mph to mpminutes
			double tt = d/gs; //time traveled in minutes
			double fn = ppmoft *tt ; //fuel neded in pounds heavy
			txtr.Text += "\r\n";
			txtr.Text += "Plane speed = "  + s.ToString() + "mph"; 
			txtr.Text += "\r\n";
			txtr.Text += "Wind speed = " + w.ToString() + " mph or tail wind";
			txtr.Text += "\r\n";
			txtr.Text += "Distance = " +d.ToString() + " miles" ;
			txtr.Text += "\r\n";
			txtr.Text +="Ground speed (speed + wind ) / wind = " +gs.ToString() + " miles per minute" ;
			txtr.Text += "\r\n";
			txtr.Text +="Time traveled in minutes distance / ground speed =" +tt.ToString() + " minutes" ;
			txtr.Text += "\r\n";
			txtr.Text +="Fuel nedded =" + fn.ToString() + " Pounds of fuel as heavy" ;
			
			
		}
		public double textbox2double(ref TextBox t)
		{
			try
			{
				return double.Parse(t.Text);
			}
			catch{};
			return -1;
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			double ps = textbox2double(ref textBox2);
			double ws = textbox2double(ref textBox3);
			double d = textbox2double(ref textBox4);
			
			calculeaza(ps,ws,d,ref textBox1);
		}
		
	}
}
