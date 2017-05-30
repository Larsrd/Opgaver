using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg25Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(100);
            foreach (var person in people)
                Console.WriteLine(person.Name);
            Console.ReadLine();
            var sortedpeople = people.OrderBy(i => i.Name);
            foreach (var person in sortedpeople)
                Console.WriteLine(person.Name);
            Console.ReadLine();
        }
    }
}
