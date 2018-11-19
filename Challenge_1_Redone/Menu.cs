using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1_Redone
{
    public class Menu
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string Ingredients { get; set; }
        public decimal MealPrice { get; set; }

        public Menu(int mealNumber, string mealName, string mealDescription, string ingredientsList, decimal mealPrice)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            Ingredients = ingredientsList;
            MealPrice = mealPrice;
        }
        public Menu()
        { }
    }
}
