using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather_forecast
{
    internal class cityid
    {
        public List<locations> locations { get; set; }
    }
    public class locations
    {
        public string country { get; set; }
        public string id { get; set; }
        public string name { get; set; }
    }
}
