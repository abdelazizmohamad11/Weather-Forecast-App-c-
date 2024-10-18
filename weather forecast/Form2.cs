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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }
       
        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
        public string msg = "";
        private string Detectmylocation(string apikey)
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    string url = string.Format("https://find-any-ip-address-or-domain-location-world-wide.p.rapidapi.com/iplocation?apikey=873dbe322aea47f89dcf729dcc8f60e8");
                    web.Headers.Add("x-rapidapi-host", "find-any-ip-address-or-domain-location-world-wide.p.rapidapi.com");
                    web.Headers.Add("x-rapidapi-key", "34f03e88d0msh45cec71ffa9165dp1f7e12jsn4992f1cc145e");
                    var json = web.DownloadString(url);
                    mylocation mylocation = JsonConvert.DeserializeObject<mylocation>(json);
                    return mylocation.countrycapital;

                }
                catch (System.Net.WebException e)
                {
                    MessageBox.Show("no internet connection");
                    return null;
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
                    msg = "no internet connection";
                    expetion ex = new expetion(msg);
                    ex.Show();
                    this.Hide();
                    return null;
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    msg = "city not found";
                    expetion ex = new expetion(msg);
                    ex.Show();
                    this.Hide();
                    return null;
                }
            }
        }

        private string getcitycountid(string cityname,string country)
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    string url = string.Format("https://foreca-weather.p.rapidapi.com/location/search/{0}?country={1}", cityname,country);
                    web.Headers.Add("x-rapidapi-host", "foreca-weather.p.rapidapi.com");
                    web.Headers.Add("x-rapidapi-key", "34f03e88d0msh45cec71ffa9165dp1f7e12jsn4992f1cc145e");
                    var json = web.DownloadString(url);
                    cityid cityid = JsonConvert.DeserializeObject<cityid>(json);
                    return cityid.locations[0].id;
                }
                catch (System.Net.WebException)
                {
                    msg = "no internet connection";
                    expetion ex = new expetion(msg);
                    ex.Show();
                    this.Hide();
                    return null;
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    msg = "city not found";
                    expetion ex = new expetion(msg);
                    ex.Show();
                    this.Hide();
                    return null;
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (bnfcity.Text != "")
            {
                string[] ct = bnfcity.Text.Split(' ', ',');
                if (ct.Length == 2)
                {
                    if (getcitycountid(ct[0], ct[1]) != null)
                    {
                        Form1 frm = new Form1(bnfcity.Text);
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    getcityid(bnfcity.Text);
                    if (getcityid(bnfcity.Text) != null)
                    {
                        Form1 frm = new Form1(bnfcity.Text);
                        frm.Show();
                        this.Hide();
                    }
                }
            }
        }
            
        
      
        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnfcity_Enter(object sender, EventArgs e)
        {
            //button1_Click(sender, e);

        }

        private void bnfcity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(Char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void btndetectloc_Click(object sender, EventArgs e)
        {
            Detectmylocation("873dbe322aea47f89dcf729dcc8f60e8");
            Form1 frm = new Form1(Detectmylocation("873dbe322aea47f89dcf729dcc8f60e8"));
            frm.Show();
            this.Hide();
        }
    }
}
