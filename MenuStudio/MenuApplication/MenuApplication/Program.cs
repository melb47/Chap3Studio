using System;
using System.Collections.Generic;

namespace MenuApplication
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            MenuItem item1 = new MenuItem(3.49, "Cheese Sticks", "Appetizer", false);
            MenuItem item2 = new MenuItem(12.99, "Shrimp Quesadilla", "Main Course", true);
            MenuItem item3 = new MenuItem(4.75, "Fried Oreos", "Dessert", true);
            MenuItem item4 = new MenuItem(3.99, "Side Salad", "Appetizer", false);
            MenuItem item5 = new MenuItem(14.99, "Ribeye Steak", "Main Course", false);
            MenuItem item6 = new MenuItem(5.99, "Cheesecake", "Dessert", false);

            List<MenuItem> startingMenu = new List<MenuItem> { item1, item2, item3, item4, item5 };
            Menu newMenu = new Menu(startingMenu);
            newMenu.AddMenuItem(item6);

            //newMenu.PrintEntireMenu();

            //newMenu.PrintItem(item3);

            newMenu.RemoveMenuItem(item4);

            newMenu.PrintEntireMenu();
        }
    }
}
