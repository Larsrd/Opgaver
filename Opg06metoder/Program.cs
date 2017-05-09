using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg06metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res); // 7
            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);
            double rad = BeregnRadius(31.415);// 31.415
            Console.WriteLine(rad);
            Udskriv();  // bloank linje
            Udskriv("Dette er en test"); // Dette er en test
            double res3 = BeregnMoms(100.35);
            Console.WriteLine(res3);    // 25.0875
            //                            // Optional parameter
            double res4 = BeregnMoms(100.35, 0.25);
            Console.WriteLine(res3);    // 25.0875
            int[] løn = { 10000, 5000, 30000 };
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns);     // 15.000
            Console.Read();
        }
        public static int LægSammen(int a, int b)
        {
            return a + b;
        }
        
        public static double BeregnAreal(double radius)
        {
            return radius * radius * Math.PI;
        }

        public static double BeregnRadius(double areal)
        {
            return Math.Sqrt(areal / Math.PI);
        }

        public static void Udskriv(string a = "")
        {
            Console.WriteLine(a);
        }

        public static double BeregnMoms(double beløb, double sats = 0.25)
        {
            return sats * beløb;
        }

        public static double Gennemsnit(params int[] månedslønne)
        {
            return månedslønne.Average();
        }
    }
}
