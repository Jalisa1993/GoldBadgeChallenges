using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1_Redone
{
   public class ProgramUI
    {
        MenuRepository _menuRepo = new MenuRepository();

        public void Run()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose an action:" +
                    "\n1. Create new food item" +
                    "\n2. See Menu" +
                    "\n3. Delete" +
                    "\n4. Exit");

                int response = int.Parse(Console.ReadLine());
                switch (response)
                {
                    case 1:
                        CreateFoodItem();
                        break;
                    case 2:
                        SeeMenu();
                        break;
                    case 3:
                        Remove();
                        break;
                    case 4:
                        isRunning = false;
                        Console.WriteLine("Thanks, come again.");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid response.");
                        Console.ReadLine();
                        break;
                }

                void CreateFoodItem()
                {
                    Menu newMenu = new Menu();

                    Console.WriteLine("Make meal number:");
                    newMenu.MealNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter meal name:");
                    newMenu.MealName = Console.ReadLine();

                    Console.WriteLine("Enter meal description:");
                    newMenu.MealDescription = Console.ReadLine();


                    Console.WriteLine("What are the ingredients?");
                    newMenu.Ingredients = Console.ReadLine();

                    Console.WriteLine("Enter a price:");
                    newMenu.MealPrice = decimal.Parse(Console.ReadLine());

                    _menuRepo.AddMenuToList(newMenu);

                }
            }
        }

        private void SeeMenu()
        {
            foreach (Menu menu in _menuRepo.GetMenuList())
            {
                Console.WriteLine($"Hello  {menu.MealNumber}\n" +
                    $"{menu.MealName}\n" +
                    $"{menu.MealDescription}\n" +
                    $"{menu.Ingredients}\n" +
                    $"{menu.MealPrice}");
            }
            Console.ReadLine();
        }

        private void Remove()
        {

            Console.WriteLine("Enter the number of the item that you would you like to remove");
            int mealNumber = int.Parse(Console.ReadLine());

            _menuRepo.RemoveFoodItemFromList(mealNumber);


        }
    }
}
