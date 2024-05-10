using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class AnonymousTypes
    {
        public static void Main(string[] args)
        {
            var z = new { name = "ABC", company = "microsoft" };
            Console.WriteLine(z.name);
            Console.WriteLine(z.company);
            Console.WriteLine(z.ToString());

        }

    }
}
