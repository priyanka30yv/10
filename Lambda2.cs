using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics { 
        delegate void del1();
delegate int del2(int x);
    internal class Lambda2
    {

        public static void Main(string[] args)
    {
            del1 obj1 = () => { Console.WriteLine("hello"); };
            del2 obj2 = (p) => p * p ;
            obj1();
            int sq = obj2(10);
            Console.WriteLine("the square is {0}",sq);

    }

    }
}
