using System;
using System.Collections.Generic;
using System.Text;

namespace MenuApplication
{
    class Menu
    {
        public DateTime LastUpdated { get; set; }
        public List<MenuItem> MenuItems { get; set; }

        public Menu (List<MenuItem> menuItem)
        {
            LastUpdated = DateTime.Today;
            MenuItems = menuItem;
        }
        public List<MenuItem> AddMenuItem(MenuItem item)
        {
            MenuItems.Add(item);
            LastUpdated = DateTime.Today;
            return MenuItems;
        }
        public List<MenuItem> RemoveMenuItem(MenuItem item)
        {
            for (int i = 0; i < MenuItems.Count; i++)
            {
                if (MenuItems[i].Equals(item))
                {
                    MenuItems.RemoveAt(i);
                }
            }
            return MenuItems;
        }
        public string MenuUpdate()
        {
            return $"The Menu was last updated on {LastUpdated}";
        }
        public void PrintItem(MenuItem item)
        {
            Console.WriteLine(item.ToString());
        }
        public void PrintEntireMenu()
        {
            foreach (MenuItem entry in MenuItems)
            {
                Console.WriteLine(entry.ToString());
            }
        }
    }
}
