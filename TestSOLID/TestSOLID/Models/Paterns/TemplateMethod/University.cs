using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.OpenClose.TemplateMethod
{
    class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Pass enters examens");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Get hight's diploma");
        }

        public override void Study()
        {
            Console.WriteLine("Go to lections");
            Console.WriteLine("Go to practics");
        }
    }
}
