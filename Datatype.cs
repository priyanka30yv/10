using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Datatype
    {
        public static void Main(string[]args)
        {
            uint a= 12;
            uint b = 13;
            simpleinterest obj = new simpleinterest();
            string c = a.ToString() + b.ToString();

            Console.WriteLine(c);
            Console.WriteLine(System.UInt32.MinValue);
            Console.WriteLine(System.UInt32.MaxValue);
            Console.WriteLine(System.Char.MinValue);
            Console.WriteLine(System.Double.MaxValue);
            Console.WriteLine(typeof(uint));
            Console.WriteLine(sizeof(char));
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Type x = obj.GetType();
            Console.WriteLine(x.ToString());
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(obj.ToString());
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(obj);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");


        }
    }
}
