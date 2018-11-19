using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1_Redone
{
   public class MenuRepository
    {
        List<Menu> _menuRepo = new List<Menu>();

        public void AddMenuToList(Menu menu)
        {
            _menuRepo.Add(menu);
        }
        public List<Menu> GetMenuList()
        {
            return _menuRepo;
        }
        public void RemoveFoodItemFromList(int menuNumber)
        {
            for (int i = 0; i < _menuRepo.Count; i++)
            {
                Menu menuItem = _menuRepo[i];
                if (menuItem.MealNumber == menuNumber)
                {
                    _menuRepo.Remove(menuItem);
                }
            }
        }
    }
}
