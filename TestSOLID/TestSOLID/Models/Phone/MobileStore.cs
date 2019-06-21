using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestSOLID.Models.Phone
{
    class MobileStore
    {
        List<Phone> phones = new List<Phone>();

        IPhoneReader Reader { get; set; }
        IPhoneBinder Binder { get; set; }
        IPhoneValidator Validator { get; set; }
        IPhoneSaver Saver { get; set; }

        public MobileStore(IPhoneReader reader, IPhoneBinder binder, IPhoneValidator validator, IPhoneSaver saver) {
            Reader = reader;
            Binder = binder;
            Validator = validator;
            Saver = saver;
        } 

        public void Process()
        {
            string[] data = Reader.GetInputData();
            Phone phone = Binder.CretePhone(data);
            if (Validator.IsValid(phone))
            {
                phones.Add(phone);
                Saver.Save(phone, "store.txt");
                Console.WriteLine("Finished successful");
            }
            else {
                Console.WriteLine("Data is invalid");
            }
        }


        //public void Process() {

        //    Console.WriteLine("Enter the model phone:");
        //    string model = Console.ReadLine();
        //    Console.WriteLine("Enter the phone's price:");
        //    int price = 0;
        //    bool result = Int32.TryParse(Console.ReadLine(), out price);

        //    if (result == false || price <= 0 || String.IsNullOrEmpty(model))
        //    {
        //        throw new Exception("not valid values");
        //    }
        //    else {
        //        phones.Add(new Phone() { Model = model, Price = price });

        //        using (StreamWriter writer = new StreamWriter("store.txt", true)) {
        //            writer.WriteLine(model);
        //            writer.WriteLine(price);
        //        }
        //        Console.WriteLine("Successful");
        //    }
        //}
    }
}
