using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danilopoligon310
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Danilo Lazarevic
            tacka a = new tacka(1, 1);
            tacka A = new tacka(3, 1);
            tacka B = new tacka(-1, 3);
            tacka C = new tacka(3, 3);
            vektor OA = new vektor(A);
            vektor OB = new vektor(B);
            vektor AC = new vektor(A, C);
            Console.WriteLine(vektor.SP(OA, OB));
            Console.WriteLine(vektor.VP(OA, AC));
        }
    }
}
