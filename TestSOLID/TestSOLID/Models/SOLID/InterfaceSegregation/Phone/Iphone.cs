using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.SOLID.InterfaceSegregation.Phone
{
    interface IPhone
    {
        void Call();
        void TakePhoto();
        void MakeVideo();
        void BrowseInternet();
    }
}
