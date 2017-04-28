using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg02variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;
            int heltalopr = heltal;
            string intops = "";
            heltal++; intops=intops+"+1";
            heltal--; intops = intops + "-1";
            heltal += 20; intops = intops + "+20";
            Console.WriteLine("heltal {0} {1} = {2}", heltalopr,intops, heltal);
            

            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal);


            
            Filtyper ft = Filtyper.txt;
            Console.WriteLine("Enum: {0}", ft);
            var ftNumberInt = ft.GetHashCode();
            Console.WriteLine("Enum code: {0}", ftNumberInt);
            //var ftNumber = ft.GetTypeCode();
            var ftNumberCode = ft.GetTypeCode();
            Console.WriteLine("Enum typecode: {0}", ftNumberCode);
            string ftNumberAsStr =ft.ToString();
            Console.WriteLine("Enum as string: {0}", ftNumberAsStr);

            DateTime dato = DateTime.Now;
            Console.WriteLine("date and time: {0}", dato.ToString());
            Console.WriteLine("date shortstring: {0}", dato.ToShortDateString());
            Console.WriteLine("date longstring: {0}", dato.ToLongDateString());
            Console.WriteLine("date: {0}{1}{2}", dato.Day,dato.Month,dato.Year);

            Person p;
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);

            Console.ReadLine();

        }
        enum Filtyper
        {
            csv=2,
            pdf = 4,
            txt = 6
        }

        struct Person
        {
            public int Id;
            public string Navn;
        }
    }

}
