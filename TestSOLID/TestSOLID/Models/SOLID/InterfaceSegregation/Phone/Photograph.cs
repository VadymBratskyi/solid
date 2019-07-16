using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.SOLID.InterfaceSegregation.Phone
{
    class Photograph
    {
        public void TakePhoto(IPhoto phone) {
            phone.TakePhoto();
        }
    }
}
