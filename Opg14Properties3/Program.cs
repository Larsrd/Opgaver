using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg14Properties3
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t = new Trekant(3, 5);
            Console.WriteLine(t.Areal);
            Console.ReadLine();
        }
    }
    public class Trekant
    {
        public int Grundlinie { get; set; }
        public int Højde { get; set; }
        public Trekant(int g, int h)
        {
            Grundlinie = g;
            Højde = h;
        }
        public double Areal
        {
            get { return (double)(Grundlinie * Højde) / 2; }
        }
    }
}
