using System;
using System.Text;
using TestSOLID.Models;
using TestSOLID.Models.DependencyInversion;
using TestSOLID.Models.LiscovSubsitutions;
using TestSOLID.Models.OpenClose;
using TestSOLID.Models.OpenClose.Strategy;
using TestSOLID.Models.OpenClose.TemplateMethod;
using TestSOLID.Models.Phone;

namespace TestSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Rectangle r = new Square();          
            //Console.WriteLine(TestRectangleArea(r));

            //Education school = new University();
            //school.Learn();

            //var concreteClass = new ConcreteClass();
            //concreteClass.TemplateMethod();

            //var contex = new Context(new ContextStrategy2());
            //contex.ExecuteAlgorihtm();

            //--------------------------------
            //MealBase[] menu = new MealBase[] {
            //    new PotatoMeal(),
            //    new SaladMeal()
            //};
            //Cook bob = new Cook("bob");
            //bob.MakeDinner(menu);

            //Cook cook = new Cook("Bob");
            //cook.MakeDinner(new PotatoMeal());
            //Console.WriteLine();
            //cook.MakeDinner(new SaladMeal());


            //------------------------------
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

        public static int TestRectangleArea(Rectangle rect) {
            rect.width = 5;
            rect.height = 10;
            var rez = rect.GetArea();
            if (rect.GetArea() != 50) {
                throw new Exception("Not correct area");
            }

            return rez;
            //Производный класс, который может делать меньше, чем базовый, обычно нельзя подставить вместо базового,
            //и поэтому он нарушает принцип подстановки Лисков.
        }

    }
}
