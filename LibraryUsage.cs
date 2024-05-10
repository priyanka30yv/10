using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
namespace CSharpBasics
{
    internal class LibraryUsage
    {
        public static void Main(string[]args)
        {
            MusicalIntrument obj = new MusicalIntrument();
            obj.instrumentName = "casio";
            obj.price = 5000;
            double ans;
            ans = obj.RevisedPrice(0.1);
            Console.WriteLine("{0} aving price {1} is now available for {2}", obj.instrumentName, obj.price,ans);
          
        }
    }
}
