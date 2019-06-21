using System;
using TestSOLID.Models;
using TestSOLID.Models.Phone;

namespace TestSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            IPhoneReader reader = new ConsolePhoneReader();
            IPhoneBinder binder = new GeneralPhoneBinder();
            IPhoneValidator validator = new GeneralPhoneValidator();
            IPhoneSaver saver = new TextFileSaver();
            MobileStore store = new MobileStore(reader, binder, validator, saver);
            store.Process();

            Console.ReadKey();
        }
    }
}
