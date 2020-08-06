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

            for (int i = count - 1; i >= 0; i--)
            {
                if (menuItems[i].Category == Category.generic)
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
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{itemcount}:  {other[i].Name}: {other[i].Description}      {other[i].Price}");
                itemcount++;
            }
            Console.WriteLine($"{itemcount}:  Ready to checkout?");
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

        public static void DisplayTotal(string quest, decimal total)
        {
            Console.WriteLine("\n" + quest + total);
        }

        public static decimal DisplayGrandTotal(decimal total, double tax)
        {
            Console.WriteLine($"Your subtotal is ··· {total:C2}");
            decimal salestax = total * (decimal)tax;
            salestax = salestax / 10;
            decimal grandTotal = total + salestax;
            Console.WriteLine($"Sales Tax ·········· {salestax:C2}");
            Console.WriteLine($"Your Grand total is: {grandTotal:C2}");
            Console.WriteLine("We are only accepting cash payments at this time.");
            return grandTotal;
        }

        public static void DisplayChange(decimal change)
        {
            Console.WriteLine($"\nThank you! Your change is {change:C2}");
        }

        public static void DisplayCustomerOrder(List<Product> customerOrder)
        {
            int count = customerOrder.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                Console.WriteLine($"Items:{customerOrder[i].Name,-20}Qty:{customerOrder[i].Quantity,-20}Price:{customerOrder[i].Price*customerOrder[i].Quantity}");
            }
        }

        public static void DisplayReciept(List<Product> customerOrder, decimal subTotal, double TAX, decimal grandTotal, decimal tendered, decimal change)
        {
            Console.WriteLine("Thank you for your patronage");
            Console.WriteLine("You ordered");
            Display.DisplayCustomerOrder(customerOrder);
            Display.DisplayGrandTotal(subTotal, TAX);

            Console.WriteLine($"Amount tendered: {tendered}");
            Console.WriteLine($"Your change is {change:C2}");
            Console.WriteLine($"See you again soon!");
        }
    }
}
