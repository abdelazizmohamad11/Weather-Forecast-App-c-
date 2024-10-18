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
using System.Text;
using System.Net;



namespace weather_forecast
{
    public partial class Form1 : Form
    {
        public string city = "";
        public Form1(string mystring)
        {
            InitializeComponent();
            city = mystring;
            string[] ct = city.Split(' ', ',');
            if (ct.Length == 1) {
                getcurrent(getcityid(city));
                getforecastforeca(getcityid(city));
            }
            if (ct.Length == 2) { 
                getcurrent(getcitycountid(ct[0], ct[1]));
                getforecastforeca(getcitycountid(ct[0], ct[1]));
            }
           

        }
        DataTable citiesdatable = new DataTable();
        string apikey = "4218445f5e2ac7636527a95941008dd1";
        double lat;
        double lon;

        public string message = "";

        private void getallcities()
        {
            
            using (WebClient web = new WebClient())
            {
                try
                {
                    string url = string.Format("https://cities-cost-of-living1.p.rapidapi.com/get_cities_list");
                    web.Headers.Add("x-rapidapi-host", "cities-cost-of-living1.p.rapidapi.com");
                    web.Headers.Add("x-rapidapi-key", "f398ea423emshd7a6a3170913407p12ddd6jsn7b610aae44a8");
                    var json = web.DownloadString(url);

                    city city = JsonConvert.DeserializeObject<city>(json);

                    try { citiesdatable.Columns.Add(columnName: "name"); }
                    catch { }
                    for (int c = 0; c < city.cities.Count; c++)
                    {
                        citiesdatable.Rows.Add(city.cities[c].name);
                    }
                }
                catch (System.Net.WebException e)
                {
                    MessageBox.Show("no internet connection");
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
                    labcitycountry.Text = cityid.locations[0].name + " ," + cityid.locations[0].country;
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
        private string getcitycountid(string cityname,string count)
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    string url = string.Format("https://foreca-weather.p.rapidapi.com/location/search/{0}?country={1}", cityname,count);
                    web.Headers.Add("x-rapidapi-host", "foreca-weather.p.rapidapi.com");
                    web.Headers.Add("x-rapidapi-key", "34f03e88d0msh45cec71ffa9165dp1f7e12jsn4992f1cc145e");
                    var json = web.DownloadString(url);
                    cityid cityid = JsonConvert.DeserializeObject<cityid>(json);
                    labcitycountry.Text = cityid.locations[0].name + " ," + cityid.locations[0].country;
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

        private void getforecastforeca(string id)
        {
            using (WebClient web=new WebClient())
            {
                try
                {
                    string url = string.Format("https://foreca-weather.p.rapidapi.com/forecast/daily/{0}", id);
                    web.Headers.Add("x-rapidapi-host", "foreca-weather.p.rapidapi.com");
                    web.Headers.Add("x-rapidapi-key", "34f03e88d0msh45cec71ffa9165dp1f7e12jsn4992f1cc145e");
                    var json = web.DownloadString(url);
                    forecastforeca forecastf = JsonConvert.DeserializeObject<forecastforeca>(json);
                    labtempmax1.Text = forecastf.forecast[0].maxtemp.ToString() + "°C";
                    labtempmax2.Text = forecastf.forecast[1].maxtemp.ToString() + "°C";
                    labtempmax3.Text = forecastf.forecast[2].maxtemp.ToString() + "°C";
                    labtempmax4.Text = forecastf.forecast[3].maxtemp.ToString() + "°C";
                    labtempmax5.Text = forecastf.forecast[4].maxtemp.ToString() + "°C";
                    labtempmax6.Text = forecastf.forecast[5].maxtemp.ToString() + "°C";
                    labtempmax7.Text = forecastf.forecast[6].maxtemp.ToString() + "°C";
                    labtempmin1.Text = forecastf.forecast[0].mintemp.ToString() + "°C";
                    labtempmin2.Text = forecastf.forecast[1].mintemp.ToString() + "°C";
                    labtempmin3.Text = forecastf.forecast[2].mintemp.ToString() + "°C";
                    labtempmin4.Text = forecastf.forecast[3].mintemp.ToString() + "°C";
                    labtempmin5.Text = forecastf.forecast[4].mintemp.ToString() + "°C";
                    labtempmin6.Text = forecastf.forecast[5].mintemp.ToString() + "°C";
                    labtempmin7.Text = forecastf.forecast[6].mintemp.ToString() + "°C";
                    picic7.ImageLocation = "https://developer.foreca.com/static/images/symbols/" + forecastf.forecast[0].symbol + ".png";
                    picic1.ImageLocation = "https://developer.foreca.com/static/images/symbols/" + forecastf.forecast[1].symbol + ".png";
                    picic2.ImageLocation = "https://developer.foreca.com/static/images/symbols/" + forecastf.forecast[2].symbol + ".png";
                    picic3.ImageLocation = "https://developer.foreca.com/static/images/symbols/" + forecastf.forecast[3].symbol + ".png";
                    picic4.ImageLocation = "https://developer.foreca.com/static/images/symbols/" + forecastf.forecast[4].symbol + ".png";
                    picic5.ImageLocation = "https://developer.foreca.com/static/images/symbols/" + forecastf.forecast[5].symbol + ".png";
                    picic6.ImageLocation = "https://developer.foreca.com/static/images/symbols/" + forecastf.forecast[6].symbol + ".png";
                    DateTime[] last_seven_days = Enumerable.Range(0, 7).Select(i => DateTime.Now.Date.AddDays(i)).ToArray();
                   for(int i = 0; i<7; i++)
                    {
                        DateTime dateTime = new DateTime(last_seven_days[i].Date.Year, last_seven_days[i].Date.Month, last_seven_days[i].Date.Day);
                        if (i == 0)
                        {
                            btnday.Text = dateTime.ToString("ddd");

                        }
                        if (i == 1)
                        {
                            btnday1.Text = dateTime.ToString("ddd");
                        }
                        if (i == 2)
                        {
                            btnday2.Text = dateTime.ToString("ddd");
                        }
                        if (i == 3)
                        {
                            btnday3.Text = dateTime.ToString("ddd");

                        }
                        if (i == 4)
                        {
                            btnday4.Text = dateTime.ToString("ddd");
                        }
                        if (i == 5)
                        {
                            btnday5.Text = dateTime.ToString("ddd");
                        }
                        if (i == 6){
                            btnday6.Text = dateTime.ToString("ddd");
                        }
                    }
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
                    picic.ImageLocation = "https://developer.foreca.com/static/images/symbols/" + current.current.symbol + ".png";
                    labtemp.Text = current.current.temperature.ToString()+"°C";
                    labvisibility.Text = current.current.visibility.ToString() + "m";
                    labgust.Text = current.current.windgust.ToString() + "mph E";
                    labpressure.Text = current.current.pressure.ToString();
                    labwindspeed.Text = current.current.windspeed.ToString();
                    labcondition.Text = current.current.symbolphrase;
                    labtimezone.Text = DateTime.Now.ToLongTimeString();
                }
                catch (System.Net.WebException)
                {
                    MessageBox.Show("no internet connetion");
                    return;
                }

            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labtemp_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button_4(object sender, EventArgs e)
        {

        }

        private void labcity_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnforecast_Click(object sender, EventArgs e)
        {
            string[] ct = city.Split(' ', ',');
            if (ct.Length == 1)
            {
                getcurrent(getcityid(city));
                getforecastforeca(getcityid(city));
            }
            if (ct.Length == 2)
            {
                getcurrent(getcitycountid(ct[0], ct[1]));
                getforecastforeca(getcitycountid(ct[0], ct[1]));
            }

        }

        private void btnmap_Click(object sender, EventArgs e)
        {
            map mp = new map(city);
            mp.Show();
            this.Hide();
        }

        private void btndetail_Click(object sender, EventArgs e)
        {
            details details = new details(city);
            details.Show();
            this.Close();
        }

        private void bnfcityname_TextChanged(object sender, EventArgs e)
        {

        }
     

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
         
        }

        
        private void btnday2_Click(object sender, EventArgs e)
        {

        }

        private void citybunifubutton_Click(object sender, EventArgs e)
        {
            getallcities();
            citydata cityData = new citydata();
            cityData.citiesdata = citiesdatable;
            cityData.Location = new Point(275,+143);
            cityData.ShowDialog();
            if (cityData.result == DialogResult.OK)
            {
                city = cityData.selectedcity;
                if (getcityid(city) != null)
                {

                    getcurrent(getcityid(city));
                    getforecastforeca(getcityid(city));
                }
                
            }
        }

        private void labtemp2_Click(object sender, EventArgs e)
        {

        }

        private void bnfexit_Click(object sender, EventArgs e)
        {
            exitform frm = new exitform();
            frm.Show();
        }

        private void bnfminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
          
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Close();
        }
    }
    
   
    }

