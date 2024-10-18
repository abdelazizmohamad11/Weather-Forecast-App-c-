using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weather_forecast
{
    public partial class map : Form
    {
        public string city = "";
        public map(string cityname)
        {
            InitializeComponent();
            city = cityname;


            StringBuilder queryaddress = new StringBuilder();
            queryaddress.Append("http://google.com/maps?q=");
            queryaddress.Append(city + "," + "+");
            webBrowser1.Navigate(queryaddress.ToString());
            webBrowser1.ScriptErrorsSuppressed = true;
        }

    
        private void bnfforecast_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(city);
            frm.Show();
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            details det = new details(city);
            det.Show();
            this.Close();
        }

        private void map_Load(object sender, EventArgs e)
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

        private void bnfhome_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
