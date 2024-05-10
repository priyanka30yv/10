using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class PartialExample
    {
        public static void Main(string[] args) {
            Calculator obj = new Calculator();
            obj.num1 = 10;
            obj.num2 = 20;
            obj.num3 = 30;
            obj.num4 = 40;
            int res = obj.num1 + obj.num2 + obj.num3 + obj.num4;
Console.WriteLine(res);

        }
    }
}
