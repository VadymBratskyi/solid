using System;
using System.Text;
using System.Threading;
using TestSOLID.Models;
using TestSOLID.Models.Paterns.Observer.Bank;
using TestSOLID.Models.Paterns.Observer.News;
using TestSOLID.Models.Paterns.Observer.News.Widgets;
using TestSOLID.Models.Paterns.Observer.News2;
using TestSOLID.Models.Paterns.Observer.News2.Widgets;
using TestSOLID.Models.Paterns.Singleton.Computer;
using TestSOLID.Models.SOLID.DependencyInversion;
using TestSOLID.Models.SOLID.InterfaceSegregation.Phone;
using TestSOLID.Models.SOLID.LiscovSubsitutions;
using TestSOLID.Models.SOLID.OpenClose;
using TestSOLID.Models.SOLID.SingleResponsibility.Phone;
using TestSOLID.Models.SOLID.SingleResponsibility.Report;

namespace TestSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var newArgs2 = new NewsAggregator2();

            var twitterWidget2 = new TwitterWidget2();
            var lentaWidget2 = new LentaWidget2();
            var tvWidget2 = new TvWidget2();

            newArgs2.NewsChange += twitterWidget2.Update;
            newArgs2.NewsChange += lentaWidget2.Update;
            newArgs2.NewsChange += tvWidget2.Update;

            newArgs2.NewNewsAvailable();
            Console.WriteLine();
            newArgs2.NewNewsAvailable();

            //var newsAgr = new NewsAggregator();

            //var twitterWidget = new TwitterWidget(newsAgr);
            //var lentaWidget = new LentaWidget(newsAgr);
            //var tvWidget = new TvWidget(newsAgr);

            //newsAgr.NotifyObserver();
            //Console.WriteLine();
            //newsAgr.NewNewsAvailable();


            //Stock stock = new Stock();
            //Bank bank = new Bank("ЮнитБанк", stock);
            //Broker broker = new Broker("Иван Иваныч", stock);
            //// имитация торгов
            //stock.Market();
            //// брокер прекращает наблюдать за торгами
            //broker.StopTrade();
            //// имитация торгов
            //stock.Market();


            //(new Thread(() =>
            //{
            //    Computer comp = new Computer();
            //    comp.Lounch("windos 10");
            //    Console.WriteLine(comp.OS.Name);
            //})
            //).Start();

            //Computer comp = new Computer();
            //comp.Lounch("windos 10");
            //Console.WriteLine(comp.OS.Name);

            //comp.OS = OS.getInstance("linux");
            //Console.WriteLine(comp.OS.Name);



            //Photograph photograph = new Photograph();
            //Camera camera = new Camera();
            //Models.InterfaceSegregation.Phone.Phone iphone = new Models.InterfaceSegregation.Phone.Phone();
            //photograph.TakePhoto(iphone);
            //photograph.TakePhoto(camera);


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
