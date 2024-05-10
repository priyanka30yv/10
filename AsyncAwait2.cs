using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace CSharpBasics
{
    internal class AsyncAwait2
    {
        static void Main(string[]args)
        {
            callMethod();
            Console.ReadKey();
        }
        public static async void callMethod()
        {
            Task<int> obj = method1();
            int count = await obj;
            Console.WriteLine("the count is"+count);
        }
        public static async Task<int> method1()
        {
            int count = 0;
            await Task.Run(() =>
                {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("method 1");
                    count++;
                }
            });
            return count;
        }    }
    
}
