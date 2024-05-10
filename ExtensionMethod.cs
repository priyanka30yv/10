using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{

    internal static class ExtensionMethod
    {
        public static void Main(string[] args)
        {
            string s = "lata bhambwani";
            string ans1 = s.UserId();

            int ans2 = s.Flength();
            Console.WriteLine(ans1);
            Console.WriteLine(ans2);
            string str3 = s.Emailid("outlook.com");
       Console.WriteLine(str3);
            string str4 = s.Emailid("greysoft.com");
            Console.WriteLine(str4);
        }
        public static string UserId(this string name)
        {
            string str = name.Substring(0, 2);
            return str;
        }
        public static int Flength(this string name)
        {
            string[] arr = name.Split(' ');
            return arr[0].Length;
        }
        public static string Emailid(this string x,string dn)
        {
            string[] a = x.Split(' ');
            string email = a[0] + "." + a[1] + "@" + dn;
            return email;


        }


    }
}
