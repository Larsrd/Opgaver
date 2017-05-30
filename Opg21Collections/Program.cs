using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg21Collections
{
    class Program
    {
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
            foreach (var item in listp)
            {
                Console.WriteLine(item.Id + ", " + item.Navn);
            }
            Console.ReadLine();
        }
        class Person:IComparable<Person>
        {
            public int Id { get; set; }
            public string Navn { get; set; }
                        
            public int CompareTo(Person other)
            {
                if (this.Id > other.Id) return 1;
                if (this.Id < other.Id) return -1;
                return 0;
            }
        }
    }
}
