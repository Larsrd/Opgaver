using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg12Properties
{
    class Program
    {
        public static string log = "";
            
        static void Main(string[] args)
        {
            Vare v1 = new Vare();
            v1.Navn = "Cola";
            v1.Pris = 10;
            Console.WriteLine("Navn: " + v1.Navn);
            Console.WriteLine("Pris: " + v1.Pris);
            Console.WriteLine("Pris med moms: " + v1.PrisMedMoms());
            v1.Navn = "Pepsi";
            v1.Pris = 12;
            Console.WriteLine("Navn: " + v1.Navn);
            Console.WriteLine("Pris: " + v1.Pris);
            Console.WriteLine("Pris med moms: " + v1.PrisMedMoms());
            Console.WriteLine("Log: " + log);
            Vare v2 = new Vare(13, "Fanta");
            Console.WriteLine("Navn: " + v2.Navn);
            Console.WriteLine("Pris: " + v2.Pris);
            Console.WriteLine("Pris med moms: " + v2.PrisMedMoms());

            Console.Read();

        }
    }
        public class Vare
        {
            private string navn;
            //private string log = "";

            public Vare()
            {
                pris = 0;
                navn = "";
            }
        public Vare(double pr, string n)
        {
            pris = pr;
            navn = n;
        }
        public string Navn
            {
                //string tempnavn;
                get { Program.log = Program.log + this.navn+", navn aflæst.\n ";
                    return navn;  }
                set { string tempnavn; tempnavn = navn; navn = value; Program.log = Program.log + tempnavn + " ændret til " + navn+"\n"; Console.WriteLine(Program.log); }
            }

            private double pris;

            public double Pris
            {
                get { Program.log = Program.log + this.Navn+ ", pris aflæst.\n";return pris;  }
                set { pris = value; Program.log = Program.log + this.navn+ ", pris sat.\n"; }
            }

            public double PrisMedMoms()
            {
                return this.Pris * 1.25;
            }
        }
    
}
