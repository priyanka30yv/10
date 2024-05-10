using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class MarksheetExample
    {
        public static void Main(string[] args)
        {
            Marksheet m = new Marksheet();
            m.sub1 = 12;
            m.sub2 = 13;
                m.sub3 = 14;
            Console.WriteLine(m.avg);
            Console.WriteLine(m.t);
            Console.WriteLine(m.sub1);
            Console.WriteLine(m.sub2);
            Console.WriteLine(m.sub2);
        }
    }
}
