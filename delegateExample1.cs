using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class delegateExample1
    {
        delegate void mydelegate();
        public static void Main(string[]args)
        {
            mydelegate obj;
           Console.WriteLine("do you want to travel card and greeting card");
            string choice = Console.ReadLine();
            choice = choice.ToUpper();

            if(choice=="GREET")
                obj = new mydelegate(greet);
            else
                obj = new mydelegate(travel);
                obj();
            

        }
        static void greet()
        {
            Console.WriteLine("i like delegate");
        }
        static void travel()
        {
            Console.WriteLine("where will you travel for work!!!!");
        }
    }
}
