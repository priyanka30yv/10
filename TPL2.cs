using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class TPL2
    {
        public static string thestring="";

        public static void Main(string[] args)
        {
            Task<string> t = Task.Factory.StartNew(() => slowmethod());
            Console.WriteLine("waiting for slow method to finish");
            System.Threading.Thread.Sleep(1000);
            thestring=t.Result;
 Console.WriteLine("finished at {0}", thestring);
            Console.ReadLine(); 
        }
        static string slowmethod()
        {
            {
                System.Threading.Thread.Sleep(3000);
                return DateTime.Now.ToString();
            }
        }
    }

}
