using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Collection1
    {
        public static void Main(string[]args)
        {
            Car obj1 = new Car();
            obj1.modelName = "bajaj";
            obj1.price = 2500000;
           AccountHolder obj2=new AccountHolder();
            obj2.Name = " BOI";
            obj2.AccName = 121234667;
            obj2.AccType="saving";
            ArrayList lst = new ArrayList();
            lst.Add(obj1);
            lst.Add(obj2);
           
            for(int i=0;i<lst.Count;i++)
            {
                Console.WriteLine(lst [i]);
                Type x = lst[i].GetType();
                Console.WriteLine(x);
                Console.WriteLine("***********************");

                if(x.ToString()== "CSharpBasics.Car")
                {
                    Car ans = (Car)lst[i];
                    Console.WriteLine(ans.modelName);
                    Console.WriteLine(ans.price);

                }
                if (x.ToString() == "CSharpBasics.AccountHolder")
                {
                    AccountHolder ans = (AccountHolder)lst[i];
                    Console.WriteLine(ans.Name);
                    Console.WriteLine(ans.AccName);
                    Console.WriteLine(ans.AccType);
                }
            }
         


        }
    }
    class Car {
        public string modelName;
        public int price;
    }
    class AccountHolder {

        public string Name;
        public long AccName;
        public string AccType;


    }


}
