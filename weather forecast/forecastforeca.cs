using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather_forecast
{
    internal class forecastforeca
    {
        public List<forecast> forecast { get; set; }
       
    }
    public class forecast
    {
        public string date { get; set; }
        public string symbol { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public double maxtemp { get; set; }
        public double mintemp { get; set; }
        public double maxwindspeed { get; set; }

    }
}
