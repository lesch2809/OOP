
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wayToMoon
{
    internal class Mondreise
    {
        public double speedKmh;
        public double resualt;

        

        public double GetTravelDurationDays(double speedKmh)
        {
            return 384403 / speedKmh / 24;
        }

        public double GetTravelDurationHours(double speedKmh)
        {
            return 384403 / speedKmh;
        }

        
    }
}
