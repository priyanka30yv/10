using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class TPL1
    {
        public static string thestring = "";
        public static void Main(string[] args)
        {
            Task t = new Task(threadfun);
            t.Start();
            Console.WriteLine("waiting {0}", System.DateTime.Now.ToString());
            t.Wait();
            Console.WriteLine("finished at {0}",thestring);
        }
        static void slowmethod(ref string value)
        {
            System.Threading.Thread.Sleep(3000);
            value=DateTime.Now.ToString();  
        }
        public static void threadfun()
        {
            slowmethod(ref thestring);
        }
    }
}
