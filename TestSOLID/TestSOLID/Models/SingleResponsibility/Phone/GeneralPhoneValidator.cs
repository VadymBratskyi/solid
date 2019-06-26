using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Phone
{
    class GeneralPhoneValidator : IPhoneValidator
    {
        public bool IsValid(Phone phone)
        {
            if (string.IsNullOrEmpty(phone.Model) || phone.Price <= 0) {
                return false;
            }

            return true;
        }
    }
}
