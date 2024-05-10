using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class GenericExample3
    {
        public static void Main(string[]args)
        {
            emp<int, string> obj1 = new emp<int, string>();
            obj1.age = 12;
            obj1.name = "A";
            obj1.designation = "PM";
            Console.WriteLine($"{obj1.age}--{obj1.name}--{obj1.designation}");
            emp<float, char> obj2 = new emp<float, char> { age = 12.5f, name = 'c',designation= 'm' };
            Console.WriteLine($"{obj2.age}--{obj2.name}--{obj2.designation}"); 
        }
    }
    class emp<A, B>
    {
        public A age;
        public B name;
        public B designation;

    }

}
