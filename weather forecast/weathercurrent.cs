using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather_forecast
{
    internal class weathercurrent
    {
        public current current { get; set; }
    }
    public class current
    {
        public string symbolphrase { get; set; }
        public string time { get; set; }
        public string symbol { get; set; }
        public double temperature { get; set; }
        public double relhumidity { get; set; }
        public double dewpoint { get; set; }
        public double windspeed { get; set; }
        public double windgust { get; set; }
        public double pressure { get; set; }
        public double visibility { get; set; }

    }
}
