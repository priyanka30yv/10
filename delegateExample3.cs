using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class delegateExample3
    {
        delegate void delGreetings();
        public static void Main(string[]args)
        {
            delGreetings delobj = new delGreetings(INDIA);
            delobj();
            Console.WriteLine("*****************************");
                delobj+= USA;
            delobj += UK;
            delobj += SPAIN;
            delobj += FRANCE;
            delobj();
            Console.WriteLine("*****************************");
            delobj -= UK;
            delobj -= SPAIN;
            delobj();

        }
        static void USA()
        {
            Console.WriteLine("HIII");
        }
        static void FRANCE()
        {
            Console.WriteLine("BONJOUR");
        }
       
        static void INDIA()
        {
            Console.WriteLine("NAMASTE");
        }
        static void UK()
        {
            Console.WriteLine("HELLO");
        }
        static void SPAIN()
        {
            Console.WriteLine("HOLA");
        }
    }
        }
    
