﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.OpenClose.TemplateMethod
{
    abstract class AbstractClass
    {
        public void TemplateMethod() {
            Operation1();
            Operation2();
        }

        public abstract void Operation1();
        public abstract void Operation2();
    }
}
