using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.SOLID.SingleResponsibility.Phone
{
    class GeneralPhoneBinder : IPhoneBinder
    {
        public Phone CretePhone(string[] data)
        {
            if (data.Length == 2)
            {
                int price = 0;
                if (Int32.TryParse(data[1], out price))
                {
                    return new Phone() { Model = data[0], Price = price };
                }
                else
                {
                    throw new Exception("not valid Price");
                }
            }
            else
            {
                throw new Exception("Doesn't enough arguments");
            }
        }
    }
}
