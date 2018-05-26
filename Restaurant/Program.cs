using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class MenuItem
    {
        public string Name;
        public double Price;
        public string Description;
        public string Category;
        public DateTime DateAddedToMenu;

        public MenuItem(string name, double price, string description, string category)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
        }
        public string printMenuItem()
        {
            return String.Format("{0} {1} {2}", Name, Description, Price);
        }

        public override bool Equals(Object o)
        {
            if (o == null)
            {
                return false;
            }

            if (o.GetType() != GetType())
            {
                return false;
            }

            MenuItem menuObject = o as MenuItem;
            return Name == menuObject.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

    }

    public class Menu
    {
        public List<MenuItem> menuItems;
        public DateTime LastUpdated;
        public string MenuType;


        public Menu(MenuItem item, string menuType)
        {
            menuItems.Add(item);
            MenuType = menuType;
            LastUpdated = DateTime.Now;
            item.DateAddedToMenu = DateTime.Now;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


}
