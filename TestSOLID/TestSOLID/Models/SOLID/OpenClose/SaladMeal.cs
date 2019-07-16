using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.SOLID.OpenClose
{
    class SaladMeal : MealBase //IMeal
    {
        //public void Make()
        //{
        //    Console.WriteLine("Нарезаем помидоры и огурцы");
        //    Console.WriteLine("Посыпаем зеленью, солью и специями");
        //    Console.WriteLine("Поливаем подсолнечным маслом");
        //    Console.WriteLine("Салат готов");
        //}

        protected override void Cook()
        {
            Console.WriteLine("Нарезаем помидоры и огурцы");
            Console.WriteLine("Посыпаем зеленью, солью и специями");
        }

        protected override void FinalSteps()
        {
            Console.WriteLine("Поливаем подсолнечным маслом");
            Console.WriteLine("Салат готов");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Моем помидоры и огурцы");
        }
    }
}
