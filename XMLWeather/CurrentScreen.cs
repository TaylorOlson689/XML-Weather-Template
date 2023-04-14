using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {

            cityOutput.Text = Form1.Days[0].location;
            currentOutput.Text = Form1.Days[0].currentTemp;

            int currentSec = DateTime.Now.Second;
            int currentMin = DateTime.Now.Minute;
            int currentHour = DateTime.Now.Hour;

            int currentMonth = DateTime.Now.Month;
            DayOfWeek currentDayOfWeek = DateTime.Now.DayOfWeek;
            int currentDayOfYear = DateTime.Now.DayOfYear;

            tempLabel.Text = "It is currently {condition} with a temprature of {temp}";
            minOutput.Text = "{mixTemp}";
            maxOutput.Text = "{maxTemp}";

            // displays 01/05/2014 11:01:27 AM 

            dateLabel.Text = DateTime.Now.ToString();
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }    
}