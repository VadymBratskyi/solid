using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Phone
{
    class ConsolePhoneReader : IPhoneReader
    {
        public string[] GetInputData()
        {
            Console.WriteLine("Enter the model phone:");
            string model = Console.ReadLine();
            Console.WriteLine("Enter the phone's price:");
            string price = Console.ReadLine();
            return new string[] { model, price };
        }
    }
}
