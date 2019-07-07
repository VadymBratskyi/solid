using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.OpenClose.TemplateMethod
{
    class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Go to first class");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Get atestat");
        }

        public override void Study()
        {
            Console.WriteLine("Go to lesson and make homework");
        }

        public override void PassExams()
        {
            Console.WriteLine("Pass school an exam");
        }
    }
}
