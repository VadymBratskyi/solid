using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Phone
{
    interface IPhoneValidator
    {
        bool IsValid(Phone phone);
    }
}
