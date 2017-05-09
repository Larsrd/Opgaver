using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg15Nedarvning
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Fornavn = "Hansi";
            p1.Efternavn = "Nielsen";
            Console.WriteLine(p1.FuldtNavn());

            //Console.ReadLine();

            Elev e1 = new Elev("jane", "Hansen", "u23");
            Console.WriteLine(e1.FuldtNavn() + ", " + e1.Klasselokale);
            Instruktør i1 = new Instruktør("Åge", "Svendsen", 16);
            Console.WriteLine(i1.FuldtNavn()+", "+i1.NøgleID);

            Console.ReadLine();
        }
    }
    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
        public Person()
        {

        }
        public Person(string fn, string en)
        {
            Fornavn = fn;
            Efternavn = en;
        }
    }
    class Elev : Person
    {
        public string Klasselokale { get; set; }
        public Elev(string fn, string en, string kl) : base(fn, en)
        {
            Klasselokale = kl;
        }
    }
    class Instruktør : Person
    {
        public int NøgleID { get; set; }
        public Instruktør(string fn, string en, int ni) : base (fn, en)
        {
            NøgleID = ni;
        }
    }
}


