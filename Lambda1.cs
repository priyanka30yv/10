using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Lambda1
    {
        delegate void add(int a, int b);    
        public static void Main(string[]args)
        {
            add obj = (p, q) => { int ans = p + q;Console.WriteLine(ans); };
            obj(12, 25);
        }
        }
    }

