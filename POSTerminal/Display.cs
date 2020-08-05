using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminal
{
    public class Display
    {
        public static List<Product> DisplayMenu(List<Product> menuItems)
        {
            Console.WriteLine("Any time items");
            int count = menuItems.Count;
            List<Product> generic = new List<Product>();
            List<Product> other = new List<Product>();
            int itemcount = 1;
            
            for(int i = count-1; i >= 0; i--)
            {
                if(menuItems[i].Category == Category.generic)
                {
                    Console.WriteLine($"{itemcount}:  {menuItems[i].Name}: {menuItems[i].Description}      {menuItems[i].Price}");
                    generic.Add(menuItems[i]);
                    itemcount++;
                }
                else
                {
                    other.Add(menuItems[i]);
                }
            }
            count = other.Count;
            Console.WriteLine("\n");
            Console.WriteLine($"{other[0].Category} items");
            for (int i= 0; i< count; i++)
            {
                Console.WriteLine($"{itemcount}:  {other[i].Name}: {other[i].Description}      {other[i].Price}");
                itemcount++;
            }
            menuItems.Clear();
            foreach (Product item in generic)
            {
                menuItems.Add(item);
            }
            foreach (Product item in other)
            {
                menuItems.Add(item);
            }

            return menuItems;
        }




    }
}
