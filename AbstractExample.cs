using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class AbstractExample
    {
        public static void Main(string[] args)
        {
            ProjectInTraining obj = new ProjectInTraining();
            obj.ProjectGuide = "abc";
            Console.WriteLine("our project guide is {0}", obj.ProjectGuide);
            obj.ProjectHours();
            obj.ProjectDetails();
            obj.AdditionFeature();
        }
    }
}
