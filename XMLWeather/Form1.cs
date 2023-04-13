using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // list to hold day objects
        public static List<Day > Days = new List<Day> ();

            public Form1()
            {
               InitializeComponent();

               ExtractForecast();
               ExtractCurrent();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
            }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            
            while (reader.Read())
            { 
                // create a day object
                Day d = new Day ();

                //fill day object with required data
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                reader.ReadToFollowing("tempreature");
                d.tempHigh = reader.GetAttribute("max");
                d.tempLow = reader.GetAttribute("min");



                if (d.date != null)
                {
                    Days.Add(d);
                }

                //TODO: if day object not null add to the days list
            }
        }

        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("name");
            Days[0].location = reader.GetAttribute("city");

            reader.ReadToFollowing("temprature");
            Days[0].currentTemp = reader.GetAttribute("value");
        }


    }
}
