using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Current
    {
        public int id { get; set; }
        public string observationTime { get; set; }
        public string weather { get; set; }
        public double tempF { get; set; }
        public string relativeHumidity { get; set; }
        public string windDir { get; set; }
        public double windMph { get; set; }
        public DateTime lastcheck { get; set; }
    }
}
