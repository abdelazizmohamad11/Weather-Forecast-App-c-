using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace weather_forecast
{
    public partial class details : Form
    {
        public string cityname;
        public details(string city)
        {
            InitializeComponent();
            cityname = city;
            string[] ct = city.Split(' ', ',');
            if (ct.Length == 1)
            {
                getforecastforeca(getcityid(cityname));
                getcurrent(getcityid(cityname));
               
            }
            if (ct.Length == 2)
            {
                getforecastforeca(getcitycountid(ct[0], ct[1]));
                getcurrent(getcitycountid(ct[0], ct[1]));
                
            }
            

        }
        public string apikey = "4218445f5e2ac7636527a95941008dd1";
        public double lat;
        public double lon;
      
        private void getforecastforeca(string id)
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    string url = string.Format("https://foreca-weather.p.rapidapi.com/forecast/daily/{0}?dataset=full", id);
                    web.Headers.Add("x-rapidapi-host", "foreca-weather.p.rapidapi.com");
                    web.Headers.Add("x-rapidapi-key", "34f03e88d0msh45cec71ffa9165dp1f7e12jsn4992f1cc145e");
                    var json = web.DownloadString(url);
                    forecastforeca forecastf = JsonConvert.DeserializeObject<forecastforeca>(json);
                    bnfradialwindmax.Value = (int)forecastf.forecast[0].maxwindspeed;
                    labtempmax.Text = forecastf.forecast[0].maxtemp.ToString()+ "°C";
                    labtempmin.Text = forecastf.forecast[0].mintemp.ToString()+ "°C";
                    labsunrise.Text = forecastf.forecast[0].sunrise;
                    labsunset.Text = forecastf.forecast[0].sunset;

                }
                catch (System.Net.WebException)
                {
                    MessageBox.Show("no internet connection");
                    return;
                }

            }

        }
        private void getcurrent(string id)
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    string url = string.Format("https://foreca-weather.p.rapidapi.com/current/{0}", id);
                    web.Headers.Add("x-rapidapi-host", "foreca-weather.p.rapidapi.com");
                    web.Headers.Add("x-rapidapi-key", "34f03e88d0msh45cec71ffa9165dp1f7e12jsn4992f1cc145e");
                    var json = web.DownloadString(url);
                    weathercurrent current = JsonConvert.DeserializeObject<weathercurrent>(json);
                    bnfcirclehumidity.Value = (int)current.current.relhumidity;
                    
                }
                catch (System.Net.WebException)
                {
                    MessageBox.Show("no internet connetion");
                    return;
                }

            }
        }


        private string getcityid(string cityname)
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    string url = string.Format("https://foreca-weather.p.rapidapi.com/location/search/{0}", cityname);
                    web.Headers.Add("x-rapidapi-host", "foreca-weather.p.rapidapi.com");
                    web.Headers.Add("x-rapidapi-key", "34f03e88d0msh45cec71ffa9165dp1f7e12jsn4992f1cc145e");
                    var json = web.DownloadString(url);
                    cityid cityid = JsonConvert.DeserializeObject<cityid>(json);
                    return cityid.locations[0].id;
                }
                catch (System.Net.WebException)
                {
                    MessageBox.Show("no internet connection");
                    return null;
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    MessageBox.Show("city not found");
                    return null;
                }

            }
        }
        private string getcitycountid(string cityname, string count)
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    string url = string.Format("https://foreca-weather.p.rapidapi.com/location/search/{0}?country={1}", cityname, count);
                    web.Headers.Add("x-rapidapi-host", "foreca-weather.p.rapidapi.com");
                    web.Headers.Add("x-rapidapi-key", "34f03e88d0msh45cec71ffa9165dp1f7e12jsn4992f1cc145e");
                    var json = web.DownloadString(url);
                    cityid cityid = JsonConvert.DeserializeObject<cityid>(json);
                    return cityid.locations[0].id;
                }
                catch (System.Net.WebException)
                {
                    MessageBox.Show("no internet connection");
                    return null;
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    MessageBox.Show("city not found");
                    return null;
                }

            }
        }
        DateTime convertdatetime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();
            return day;


        }

       

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(cityname);
            frm.Show();
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            map mp = new map(cityname);
            mp.Show();
            this.Close();
        }
        
        private void bnfcirclehumidity_ProgressChanged(object sender, EventArgs e)
        {

        }

        private void labtempmax_Click(object sender, EventArgs e)
        {

        }

        private void bnfminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bnfexit_Click(object sender, EventArgs e)
        {
            exitform fr = new exitform();
            fr.Show();
        }

        private void bnfhome_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
