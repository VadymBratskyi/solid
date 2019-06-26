using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.OpenClose
{
    class Cook
    {
        public string Name { get; set; }

        public Cook(string name) {
            this.Name = name;
        }

        public void MakeDinner(MealBase[] menu)
        {
            foreach (MealBase meal in menu) {
                meal.Make();
            }
            
        }
    }
}
