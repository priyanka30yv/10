using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class GenericCollection
    {
        public static void Main(string[]args)
        {
            List<int> lst = new List<int>();
            lst.Add(10);
            lst.Add(20);
            lst.Add(30);
            lst.Add(40);
            lst.Add(50);
            lst.Add(60);
            int sum = 0, avg = 0;
                foreach(int x in lst)
            {

                sum = sum + x;
            }
            avg = sum / lst.Count;
            Console.WriteLine("the average is {0}",avg);
            Console.WriteLine("the sum is {0}",sum);
        }
    }
}
