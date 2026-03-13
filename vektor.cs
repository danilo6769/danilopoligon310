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
        static public double SP(vektor a, vektor b)
        {
            tacka A = a.centriraj();
            tacka B = b.centriraj();
            return A.x * B.x + A.y * B.y;
        }
        static public double VP(vektor a, vektor b)
        {
            tacka A = a.centriraj();
            tacka B = b.centriraj();
            double k = A.x * B.y - A.y * B.x;
            return k;
        }
    }
}
