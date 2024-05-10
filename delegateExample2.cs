using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class delegateExample2
    {
        delegate void yourDelegate(int num);
        public static void Main(string[] args)
        {

            yourDelegate obj;
            Console.WriteLine("enter the number");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice % 2 == 0)
                obj = new yourDelegate(even);
            else
                obj = new yourDelegate(odd);
            obj(choice);
            

        }

        static void odd(int num)
        {
            Console.WriteLine("{0} is an odd number", num);
        }
        static void even(int num)
        {
            Console.WriteLine("{0} is an even number", num);
        }
    }
}
