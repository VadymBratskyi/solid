using System;
using System.Text;
using TestSOLID.Models;
using TestSOLID.Models.OpenClose;
using TestSOLID.Models.Phone;

namespace TestSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            MealBase[] menu = new MealBase[] {
                new PotatoMeal(),
                new SaladMeal()
            };
            Cook bob = new Cook("bob");
            bob.MakeDinner(menu);
            
            //Cook cook = new Cook("Bob");
            //cook.MakeDinner(new PotatoMeal());
            //Console.WriteLine();
            //cook.MakeDinner(new SaladMeal());

            //IPhoneReader reader = new ConsolePhoneReader();
            //IPhoneBinder binder = new GeneralPhoneBinder();
            //IPhoneValidator validator = new GeneralPhoneValidator();
            //IPhoneSaver saver = new TextFileSaver();
            //MobileStore store = new MobileStore(reader, binder, validator, saver);
            //store.Process();

            //IPrint print = new ConsolePrinter();
            //var report = new Report();
            //report.Text = "Hello Report";
            //report.Print(print);


            Console.ReadKey();
        }
    }
}
