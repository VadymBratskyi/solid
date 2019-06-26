using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Phone
{
    interface IPhoneBinder
    {
        Phone CretePhone(string[] data);
    }
}
