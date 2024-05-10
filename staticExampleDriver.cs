using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class staticExampleDriver
    {
        public static void Main(string[]args)
        {
            staticExample s = new staticExample();
            s.display();
            Console.WriteLine("*******************");
            staticExample s1 = new staticExample();
            s1.display();
            Console.WriteLine("*********************");
            Console.WriteLine(s.num2);
            Console.WriteLine(staticExample.num1);
        }
    }
}
