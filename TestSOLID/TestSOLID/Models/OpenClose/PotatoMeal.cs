using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.OpenClose
{
    class PotatoMeal : MealBase //IMeal
    {
        //public void Make()
        //{
        //    Console.WriteLine("Чистим картошку");
        //    Console.WriteLine("Ставим почищенную картошку на огонь");
        //    Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
        //    Console.WriteLine("Посыпаем пюре специями и зеленью");
        //    Console.WriteLine("Картофельное пюре готово");
        //}

        protected override void Cook()
        {
            Console.WriteLine("Ставим почищенную картошку на огонь");
            Console.WriteLine("Варим около 30 минут");
            Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
        }

        protected override void FinalSteps()
        {
            Console.WriteLine("Посыпаем пюре специями и зеленью");
            Console.WriteLine("Картофельное пюре готово");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Чистим и моем картошку");
        }
    }
}
