using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal abstract class Project
    {
        public string ProjectGuide;
        public void ProjectDetails()
        {
            Console.WriteLine("i having the topic onlineshopping for my project");
        }
        public abstract void ProjectHours();
    }
    internal class ProjectInTraining : Project
    {
        
        public override void ProjectHours()
        {
            Console.WriteLine("we will divide the work and complete the hours");
        }
        public void AdditionFeature()
        {
            Console.WriteLine("i will add 10 additional feature to my project");
            Console.WriteLine("the time is {0}", DateTime.Now);
        }
    }
   

}
