using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public MenuItem(string name, double price, string description, string category)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
        }
        public static void Print(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object o)
        {
            if (o == null)
                return false;
            if (o.GetType() != typeof(MenuItem))
                return false;
            return Equals((MenuItem)o);
        }
        public bool Equals(MenuItem menuItem)
        {
            if (menuItem == null)
            {
                return false;
            }

            return menuItem.Name == this.Name;
        }

        public override int GetHashCode()
        {
           return Name.GetHashCode();
        }

        public int GetHashCode(MenuItem menuItem)
        {
            return menuItem.Name.GetHashCode();
        }

    }

    public class Menu
    {
        public Dictionary<MenuItem, DateTime> MenuItems { get; set; }
        private DateTime LastUpdatedUtc;
        public string MenuType;
        public DateTime LastUpdated
        {
            get { return LastUpdatedUtc.ToLocalTime(); }
        }

        private const int NewInDays = 14;

        public void AddMenuItem(MenuItem menuItem)
        {
            if(!MenuItems.ContainsKey(menuItem))
            {
                LastUpdatedUtc = DateTime.UtcNow;
                this.MenuItems.Add(menuItem, LastUpdatedUtc);
            }
        }

        public void RemoveMenuItem(MenuItem menuItem)
        {
            this.MenuItems.Remove(menuItem);
        }

        private bool IsNew(DateTime dateAdded)
        {
            return DateTime.UtcNow < dateAdded.AddDays(NewInDays);
        }


        public List<MenuItem> GetNewMenuItems()
        {
            List<MenuItem> newItems = new List<MenuItem>();
            foreach(KeyValuePair<MenuItem, DateTime> item in MenuItems)
            {
                if (IsNew(item.Value))
                    newItems.Add(item.Key);
            }

            return newItems;
        }

        public static void PrintMenu(Menu menu)
        {
            throw new NotImplementedException();
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
