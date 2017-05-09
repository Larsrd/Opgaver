using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg13Properties2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Fornavn = "Niels";
            p1.Efternavn = "Hansen";
            Console.WriteLine(p1.FuldtNavn());
            Person p2 = new Person();
            p2.Fornavn = "Hans";
            p2.Efternavn = "Nie";//lsen - da længde er <= 3 sættes den til "" i set metoden
            Console.WriteLine("Fuldt navn som funktionskald: " + p2.FuldtNavn());
            Console.WriteLine("Fuldt navn som property: " + p2.FuldtNavnProp);
            Person p3 = new Person();
            p3.Fornavn = "Kurt";
            p3.Efternavn = "Nielsen";
            Console.WriteLine("Fuldt navn som funktionskald: "+p3.FuldtNavn());
            Console.WriteLine("Fuldt navn som property: " + p3.FuldtNavnProp);
            Console.Read();
        }
    }
    public class Person
    {
        public string Fornavn { get; set; }

        private string efternavn;

        public string Efternavn
        {
            get { return efternavn; }
            set
            {
                if (value.Length <= 3) value = "";
                efternavn = value;
            }
        }
        //fuldt navn som metode
        public string FuldtNavn()
        {
            return Fornavn + " "+Efternavn;
        }
        //fuldt navn som egenskab
        private string fuldtNavnProp;

        public string FuldtNavnProp
        {
            get { return Fornavn +" " + Efternavn; }
            //set { fuldtNavnProp = value; }
        }

    }

}
