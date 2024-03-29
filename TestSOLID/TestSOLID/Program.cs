﻿using System;
using System.Text;
using System.Threading;
using TestSOLID.Models;
using TestSOLID.Models.Paterns.Decorator.Pizza;
using TestSOLID.Models.Paterns.Factory.Building;
using TestSOLID.Models.Paterns.Factory.Cars;
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

            Pizza pizza1 = new ItalianPizza();
            pizza1 = new TomatoPizza(pizza1); // итальянская пицца с томатами
            Console.WriteLine("Название: {0}", pizza1.Name);
            Console.WriteLine("Цена: {0}", pizza1.GetCost());

            Pizza pizza2 = new ItalianPizza();
            pizza2 = new CheesePizza(pizza2);// итальянская пиццы с сыром
            Console.WriteLine("Название: {0}", pizza2.Name);
            Console.WriteLine("Цена: {0}", pizza2.GetCost());

            Pizza pizza3 = new BulgerianPizza();
            pizza3 = new TomatoPizza(pizza3);
            pizza3 = new CheesePizza(pizza3);// болгарская пиццы с томатами и сыром
            Console.WriteLine("Название: {0}", pizza3.Name);
            Console.WriteLine("Цена: {0}", pizza3.GetCost());


            //CarFactory factory = new BmwFactory("BMW Factory");
            //Car car1 = factory.BuildCar("i3");
            //Car car2 = factory.BuildCar("m4");

            //factory = new ToyotaFactory("Toyota Factory");
            //Car car3 = factory.BuildCar("rav 4");
            //Car car4 = factory.BuildCar("corola");
            //Car car5 = factory.BuildCar("camry");

            //Console.WriteLine();
            //car2.Configuration();

            //Developer dev = new PanelDeveloper("OOO KirpichBuild");
            //House house = dev.CreateHouse();

            //dev = new WoodDeveloper("OOO DerevoBuild");
            //House house2 = dev.CreateHouse();


            //var newArgs2 = new NewsAggregator2();

            //var twitterWidget2 = new TwitterWidget2(newArgs2);
            //var lentaWidget2 = new LentaWidget2(newArgs2);
            //var tvWidget2 = new TvWidget2(newArgs2);

            //newArgs2.NotifyObserver();
            //Console.WriteLine();
            //newArgs2.NotifyObserver();

            //var newsAgr = new NewsAggregator();

            //var twitterWidget = new TwitterWidget(newsAgr);
            //var lentaWidget = new LentaWidget(newsAgr);
            //var tvWidget = new TvWidget(newsAgr);

            //newsAgr.NotifyObserver();
            //Console.WriteLine();
            //newsAgr.NotifyObserver();


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
