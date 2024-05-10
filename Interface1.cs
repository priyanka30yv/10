using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    interface Interest    {
        void calcinterest(int amt);
    }
    class simpleinterest:Interest {
    public void calcinterest(int amt)
        {
            Console.WriteLine("will calculate simple interest for amount" + amt);
        }
    }
    class compoundinterest : Interest {
        public void calcinterest(int amt )
        {
            Console.WriteLine("will calculate compound interest for amount" + amt);
        }
    }


}
