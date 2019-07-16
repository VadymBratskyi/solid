using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.SOLID.SingleResponsibility.Report
{
    class Report
    {
        public string Text { get; set; }

        public void GoToFirstPage() {
            Console.WriteLine("Go first page");
        }

        public void GoToLastPage()
        {
            Console.WriteLine("Go last page");
        }
        public void GoToPage(int pageNumber)
        {
            Console.WriteLine("Go to page "+pageNumber);
        }
        public void Print(IPrint printer)
        {
            printer.Print(Text);
        }

    }
}
