using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class staticExample
    {

        public static int num1;
        public int num2;
        public staticExample()
        {
            num1++;
            num2++;

        }
        public void display()
        {
            System.Console.WriteLine("num1 {0}", num1);
            System.Console.WriteLine("num2 {0}", num2);
        } 
    }
}
