﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models
{
    class ConsolePrinter2 : IPrint
    {
        public void Print(string text)
        {
            Console.WriteLine($"Console prined2: {text}");
        }
    }
}
