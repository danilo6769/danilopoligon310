using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danilopoligon310
{
    internal class vektor
    {
        public tacka pocetak, kraj;
        public vektor(tacka A, tacka B)
        {
            pocetak = A;
            kraj = B;
        }
        public vektor(tacka A)
        {
            pocetak = new tacka();
            kraj = A;
        }
        public tacka centriraj()
        {
            double x = kraj.x - pocetak.x;
            double y = kraj.y - pocetak.y;
            return new tacka(x, y);
        }
    }
}
