using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class NullableExample
    {
        public static void Main(string[]args)
        {
            int num1 = 12;
            int? num2 = null;
            Console.WriteLine("num1 is :{0}", num1);
            if (num2.HasValue == true)
            {
                Console.WriteLine("num2 : ", num2.Value);

            }
            else
                Console.WriteLine("num2 is null");
        }
    }
}
