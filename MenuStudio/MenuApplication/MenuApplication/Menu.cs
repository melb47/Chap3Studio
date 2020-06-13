using System;
using System.Collections.Generic;
using System.Text;

namespace MenuApplication
{
    class Menu
    {
        public DateTime LastUpdated { get; }
        public List<MenuItem> MenuItems { get; set; }

        public Menu (DateTime dateUpdated, List<MenuItem> menuItem)
        {
            LastUpdated = dateUpdated;
            MenuItems = menuItem;
        }
    }
}
