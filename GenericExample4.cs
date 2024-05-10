using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpBasics
{
    internal class GenericExample4
    {
        public static void Main(string[] args)
        {
            int a = 12, b=13;
            Console.WriteLine("a is {0} and b is {1}", a, b);
            swap<int>(ref a, ref b);
            Console.WriteLine("a is {0} and b is {1}", a, b);
            string p = "amogh";
            string q = "shivam";
            Console.WriteLine("a is {0} and b is {1}", p, q);
            swap<string>(ref p, ref q);
            Console.WriteLine("a is {0} and b is {1}", p, q);
        }
        static void swap<X>(ref X a, ref X b)
        {
            Console.WriteLine("you send a swap method a{0}", typeof(X));
            X temp;
            temp = a;
            a = b;
            b = temp;

        }
    }
}
