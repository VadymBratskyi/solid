using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestSOLID.Models.SOLID.SingleResponsibility.Phone
{
    class TextFileSaver : IPhoneSaver
    {
        public void Save(Phone phone, string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                new Exception("invalid file name");
            }

            using(var writer = new StreamWriter(fileName, true)) {

                writer.WriteLine(phone.Model);
                writer.WriteLine(phone.Price);

            }
        }
    }
}
