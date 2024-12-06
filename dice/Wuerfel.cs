using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice
{
    public class Wuerfel
    {
        Random r = new Random();
        int aktuellerWurf;
        int letzterWurf;
        List <int> alleWuerfe = new List<int>();

        public int LetzterWurf
        {
            get { return letzterWurf; }
        }

        public List <int> AlleWuerfe
        {
            get { return alleWuerfe; }
        }

        public int Werfen()
        {
            
            letzterWurf = aktuellerWurf;
            aktuellerWurf = r.Next(1, 7);
            alleWuerfe.Add(aktuellerWurf);
            return aktuellerWurf;
        }
    }
}
