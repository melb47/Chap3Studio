using System;
using System.Collections.Generic;
using System.Text;

namespace MenuApplication
{
    class MenuItem
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem (double price, string description, string category, bool isNew)
        {
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }
        public string IsThisNew()
        {
            if (IsNew)
            {
                return "This item is new!";
            }
            else
            {
                return "This items is not new";
            }
        }

        public override bool Equals(object obj)
        {
            return obj is MenuItem item &&
                   Description == item.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Description);
        }
        public override string ToString()
        {
            return $"Description: {Description}\nPrice: {Price}\nCategory: {Category}\nThis is new: {IsNew}\n";
        }
    }
}
