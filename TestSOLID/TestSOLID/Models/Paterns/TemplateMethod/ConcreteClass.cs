using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.OpenClose.TemplateMethod
{
    class ConcreteClass: AbstractClass
    {
        public override void Operation1()
        {
            Console.WriteLine("Operation1");
        }

        public override void Operation2()
        {
            Console.WriteLine("Operation2");
        }
    }
}
