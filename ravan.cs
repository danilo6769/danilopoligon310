using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danilopoligon310
{
    internal class ravan
    {
        public static int SIS(vektor AB, tacka C, tacka D)
        {
            vektor AC = new vektor(AB.pocetak, C);;
            vektor AD = new vektor(AB.pocetak, D);
            double ABAC = vektor.VP(AB, AC);
            double ABAD = vektor.VP(AB, AD);
            
        }
    }
}
