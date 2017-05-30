using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg21Collections
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            List<Person> listp = new List<Person>();
            listp.Add(new Person { Navn = "Jørgen", Id = 217 });
            listp.Add(new Person { Navn = "Aase", Id = 27 });
            listp.Add(new Person { Navn = "Niels", Id = 314 });
            listp.Add(new Person { Navn = "Jens", Id = 22 });
            listp.Add(new Person { Navn = "Asta", Id = 11 });
            foreach (var item in listp)
            {
                Console.WriteLine(item.Id+", "+ item.Navn);
            }

            listp.Sort();
            Console.WriteLine("\n\rSorteret på Id: ");
            foreach (var item in listp)
            {
                Console.WriteLine(item.Id + ", " + item.Navn);
            }
            logger.Debug("så langt så godt");
            Console.WriteLine("\n\r");
            Dictionary<int, Person> dictp = new Dictionary<int, Person>();
            dictp.Add(100650, new Person { Navn = "Jørgen", Id = 217 });
            dictp.Add( 010459, new Person { Navn = "Aase", Id = 27 });
            dictp.Add(071261, new Person { Navn = "Niels", Id = 314 }   );
            dictp.Add(040160, new Person { Navn = "Jens", Id = 22 });
            dictp.Add(070770, new Person { Navn = "Asta", Id = 11 });
            Console.WriteLine("Indtast person-nøgle:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("tilsvarende person: "+dictp[n].Navn);


            Console.ReadLine();
        }
        class Person:IComparable<Person>
        {
            public int Id { get; set; }
            public string Navn { get; set; }
                        
            public int CompareTo(Person other)
            {
                logger.Debug("Enter");
                if (this.Id > other.Id) return 1;
                if (this.Id < other.Id) return -1;
                return 0;
                logger.Debug("Exit");
            }
        }
    }
}
