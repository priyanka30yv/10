using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Marksheet
    {
        public int s1,s2,s3,t,a;
        public int sub1
        {
            get
            {
                return s1;

            }
            set
            {
                s1 = value;
            }
            
        }
        public int sub2
        {
            get
            {
                return s1;
            }
            set
            {
                s2 = value;
            }
        }
        public int sub3
        {
            get
            {
                return s1;
            }
            set
            {
                s3=value;
            }
        }
        public int total
        {
            get
            {
                t = s1 + s2 + s3;
                return t;
            }
        }
        public int avg
        {
            get
            {

                int a = (s1 + s2 + s3)/3;
                return a;
            }
        }
     
    }
}
