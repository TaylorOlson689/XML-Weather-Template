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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {

            date1.Text = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            min1Label.Text = "{conditon} with a low of {minTemp}°C.";
            max1Label.Text = "{conditon} with a high of {maxTemp}°C.";

            date2.Text = DateTime.Now.AddDays(2).DayOfWeek.ToString();
            min2Label.Text = "{conditon} with a low of {minTemp}°C.";
            max2Label.Text = "{conditon} with a high of {maxTemp}°C.";

            date3.Text = DateTime.Now.AddDays(3).DayOfWeek.ToString();
            min3Label.Text = "{conditon} with a low of {minTemp}°C.";
            max3Label.Text = "{conditon} with a high of {maxTemp}°C.";
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
