using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.OpenClose.TemplateMethod
{
    abstract class Education : Learning
    {
        public sealed override void Learn() {
            Enter();
            Study();
            PassExams();
            GetDocument();
        }

        public abstract void Enter();
        public abstract void Study();
        public virtual void PassExams() {
            Console.WriteLine("Pass an exam");
        }
        public abstract void GetDocument();
    }
}
