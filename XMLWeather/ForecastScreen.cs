﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {

            date1.Text = Form1.Days[1].date;
            min1.Text = Form1.Days[1].tempLow;
            max1.Text = Form1.Days[1].tempHigh;

            date2.Text = Form1.Days[2].date;
            min2.Text = Form1.Days[2].tempLow;
            max2.Text = Form1.Days[2].tempHigh;

            date3.Text = Form1.Days[3].date;
            min3.Text = Form1.Days[3].tempLow;
            max3.Text = Form1.Days[3].tempHigh;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
