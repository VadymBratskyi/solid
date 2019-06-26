using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Phone
{
    interface IPhoneSaver
    {
        void Save(Phone phone, string fileName);
    }
}
