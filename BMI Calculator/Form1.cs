﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
	public partial class Form1 : Form
	{
		double h;
		double w;
		double t;
		public Form1()
		{
			InitializeComponent();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			txtWeight.Clear();
			txtHeight.Clear();
			SumupBMI.Clear();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			h = Double.Parse(txtHeight.Text);
			w = Double.Parse(txtWeight.Text);
			t = w / (h * h);
			SumupBMI.Text = "" + t;

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}