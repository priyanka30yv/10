using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class delegateExample4 
    { 

    delegate int Sumdeletagte(int a, int b);
    delegate int suaredelegate(int a);
    public static void Main(string[]args)
    {

        Sumdeletagte obj1 = new Sumdeletagte(add);
        suaredelegate obj2 = new suaredelegate(square);
        int num1 = obj1(12, 13);
        int num2 = obj2(4);
        Console.WriteLine($"the result for addition is {num1}");
        Console.WriteLine($"the result for square is {num2}");
    }
  
    
        static int add(int a,int b)
        {
            return a + b;
        }
        static int square(int num)
        {
            return num * num;
        }
    }
}
