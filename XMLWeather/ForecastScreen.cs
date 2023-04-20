using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

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
            min1Label.Text = $"Condition with a low of TempC";
            max1Label.Text = $"Condition with a high of TempC";

            date2.Text = DateTime.Now.AddDays(2).DayOfWeek.ToString();
            min2Label.Text = $"Condition with a low of TempC";
            max2Label.Text = $"Condition with a high of TempC";

            date3.Text = DateTime.Now.AddDays(3).DayOfWeek.ToString();
            min3Label.Text = $"Condition with a low of TempC";
            max3Label.Text = $"Condition with a high of TempC";
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
