using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class GenericExample5
    {
        public static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>();
            set1.Add(1);
            set1.Add(2);
            set1.Add(3);
            set1.Add(4);
            HashSet<int> set2 = new HashSet<int>();
            set2.Add(4);
            set2.Add(1);
            set2.Add(7);
            set2.Add(8);
            IEnumerable<int> set3 = set1.Intersect(set2);
            foreach(var x in set3)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("*****************");
            IEnumerable<int >set4=set1.Concat(set2);
            foreach (var x1 in set4)
            {
                Console.WriteLine(x1);
            }
            Console.WriteLine("*****************");
            IEnumerable<int> set5=set1.Union(set2);
            foreach (var x2 in set5)
            {
                Console.WriteLine(x2);
            }

        }
    }
}
