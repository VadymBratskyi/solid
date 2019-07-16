﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.SOLID.DependencyInversion
{
    class Book
    {
        public string Text { get; set; }
        public IPrinter Printer { get; set; }

        public Book(IPrinter printer) {
            this.Printer = printer;
        }

        public void Print()
        {
            Printer.Print(Text);
        }
    }
}
