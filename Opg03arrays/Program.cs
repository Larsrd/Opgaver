using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg03arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] månedslønninger = { 30000, 40000, 37000, 50000, 60000 };
            Console.WriteLine("Antal månedslønninger: {0}", månedslønninger.Count());
            Console.WriteLine("individuelle månedslønninger: ");
            for (int i = 0; i < månedslønninger.Length; i++)
            {
                Console.WriteLine(månedslønninger[i]);
            }
            Console.WriteLine("Gennemsnit: {0}", månedslønninger.Average());
            Console.WriteLine();

            System.Array.Sort(månedslønninger);
            Console.WriteLine("sorterede individuelle månedslønninger: ");
            for (int i = 0; i < månedslønninger.Length; i++)
            {
                Console.WriteLine(månedslønninger[i]);
            }
            Console.WriteLine();

            System.Array.Reverse(månedslønninger);
            Console.WriteLine("omvendt sorterede individuelle månedslønninger: ");
            for (int i = 0; i < månedslønninger.Length; i++)
            {
                Console.WriteLine(månedslønninger[i]);
            }
            Console.WriteLine();

            int[] månedslønninger_kopi = månedslønninger;
            bool ens = System.Array.ReferenceEquals(månedslønninger, månedslønninger_kopi);
            Console.WriteLine("Er array-reference for ens? {0}", ens);

            int j = 2;
            int månedsløn_j = månedslønninger[j];
            Console.WriteLine("månedsløn {0} er {1}", j, månedsløn_j);

            int findmånedsløn = 50000;
            int k = System.Array.IndexOf(månedslønninger, findmånedsløn);
            Console.WriteLine("måned med løn {0} er {1}", findmånedsløn, k);

            System.Array.Reverse(månedslønninger);

            int findmånedsløn_binarysearch = 50000;
            int l =System.Array.BinarySearch(månedslønninger, findmånedsløn_binarysearch);
            Console.WriteLine("måned med løn {0} fundet med binarysearch er {1}", findmånedsløn_binarysearch, l);

            Console.ReadLine();


        }
    }
}
