using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class InterfaceExample
    {
        public static void Main(string[] args)
        {
            Interest obj;
            string choice;
            Console.WriteLine("enter a choice");
            choice = Console.ReadLine();
             
            switch (choice.ToLower())
            {
                case "simple":
                    obj = new simpleinterest();
                    break;
                case "compound":
                    obj = new compoundinterest();
                    break;
                default:
                    obj = null;
                    Console.WriteLine("invalid choice");
                    break;
            }
            obj.calcinterest(100);
        }
    }
}
