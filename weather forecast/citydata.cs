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
    public partial class citydata : Form
    {
        public DataTable citiesdata { get; set; }
        public string selectedcity { get; set; }
        public DialogResult result { get; set; }
      

        public citydata()
        {
            InitializeComponent();
        }

        private void bnfcityname_TextChanged(object sender, EventArgs e)
        {
            citiesdata.DefaultView.RowFilter = String.Format("name LIKE '{0}*'", bnfcityname.Text);
        }

        private void citydata_Load(object sender, EventArgs e)
        {
            bunifuDataGridView1.DataSource = citiesdata;
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedcity = bunifuDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            result = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
