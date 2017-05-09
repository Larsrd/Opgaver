using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg16Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Fornavn = "Jens";
            p1.Efternavn = "Hansen";
            p1.Skriv();
            Elev e1 = new Elev();
            e1.Fornavn = "Agnes";
            e1.Efternavn = "Østergaard";
            e1.Klasselokale = "K23";
            e1.Skriv();
            instruktør i1 = new instruktør();
            i1.Fornavn = "Peter";
            i1.Efternavn = "Jespersen";
            i1.NøgleId = 13;
            i1.Skriv();
            Person[] persons = new Person[3];
            persons[0] = p1;
            persons[1] = e1;
            persons[2] = i1;
            foreach (var item in persons) item.Skriv();
            Console.ReadLine();


        }
    }
    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public virtual void Skriv()
        {
            Console.WriteLine(Fornavn+" "+Efternavn);
        }
    }
    class Elev : Person
    {
        public string Klasselokale { get; set; }
        public override void Skriv()
        {
            Console.WriteLine("Elev: " + Fornavn + " " + Efternavn + ", lok." + Klasselokale);
        }
    }
    class instruktør : Person
    {
        public int NøgleId { get; set; }
        public override void Skriv()
        {
            Console.WriteLine("Instruktør: " + Fornavn+" "+Efternavn+", nøgle "+NøgleId);
        }
    }
}
