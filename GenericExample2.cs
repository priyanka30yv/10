using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class GenericExample2
    {
        public static void Main(string[]args)
        {
            List<Icons> lst = new List<Icons>();
            lst.Add(new Icons { IconName = "whatsapp", imgPath = "one.jpg" });
            lst.Add(new Icons { IconName = "instagram", imgPath = "int.jpg" });
            lst.Add(new Icons { IconName = "linkedin", imgPath = "lin.jpg" });
            lst.Add(new Icons { IconName = "snapchat", imgPath = "snap.jpg" });
            lst.Add(new Icons { IconName = "facebook", imgPath = "fac.jpg" });
            foreach(Icons x in lst)
            {
                Console.WriteLine(x.IconName
                    + ":"+ x.imgPath);
            }
        }
    }
    public class Icons
    {
        public string IconName { get; set; }
        public string imgPath { get; set; }
    }
}
