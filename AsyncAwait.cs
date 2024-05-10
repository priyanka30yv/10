using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class AsyncAwait
    {
        public static void Main(string[] args)
        {
            callMethod();
        }
        public static async void callMethod()
        {
            Task<int> obj = Task.Factory.StartNew<int>(Method1);
            
            obj.Wait();
            int count = await obj;
            Console.WriteLine(count);

        }
        public static Task<int> Method1()
        {
         return 12;
        }
    }
}
