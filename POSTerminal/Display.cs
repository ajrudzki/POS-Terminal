using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminal
{
    public class Display
    {
        public static List<Product> DisplayMenu(List<Product> menuItems)
        {
            Console.WriteLine("\t\t ~~~~~~~~ Any Time Items ~~~~~~~~\n");
            int count = menuItems.Count;
            List<Product> generic = new List<Product>();
            List<Product> other = new List<Product>();
            int itemcount = 1;

            for (int i = count - 1; i >= 0; i--)
            {
                if (menuItems[i].Category == Category.Generic)
                {
                    Console.WriteLine($"{itemcount}: {menuItems[i].Name}: {menuItems[i].Description} - {menuItems[i].Price:C2}");
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
            string Meal = other[0].Category.ToString();
            Console.WriteLine($"\t\t ~~~~~~~~ {other[0].Category} Items ~~~~~~~~\n");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{itemcount}: {other[i].Name}: {other[i].Description} - {other[i].Price:C2}");
                itemcount++;
            }
            Console.WriteLine();
            Console.WriteLine($"{itemcount}: Ready to checkout?");
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
            Console.WriteLine();
            Console.WriteLine($"Your subtotal is ··· {total:C2}");
            decimal salestax = total * (decimal)tax;
            salestax = salestax / 10;
            decimal grandTotal = total + salestax;
            Console.WriteLine($"Sales Tax ·········· {salestax:C2}");
            Console.WriteLine($"Your Grand total is: {grandTotal:C2}\n");
            Console.WriteLine("\n ~~~~~ We are only accepting cash payments at this time ~~~~~ \n");
            return grandTotal;
        }

        public static void DisplayChange(decimal change)
        {
            Console.WriteLine();
            Console.WriteLine($"Thank you! Your change is: {change:C2}");
            Console.Write("\nPress enter to continue and display the reciept.");
            Console.ReadLine();
        }

        public static void DisplayCustomerOrder(List<Product> customerOrder)
        {
            int count = customerOrder.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                Console.WriteLine($"Qty - {customerOrder[i].Quantity,-4} Items - {customerOrder[i].Name,-26} Price - {customerOrder[i].Price*customerOrder[i].Quantity,-12:C2}");
            }
        }

        public static void DisplayReciept(List<Product> customerOrder, decimal subTotal, double TAX, decimal grandTotal, decimal tendered, decimal change)
        {
            Console.Clear();
            Console.WriteLine("\n\t ~~~~~~~~ Thank you for your patronage ~~~~~~~~\n");
            Console.WriteLine("You ordered:");
            Display.DisplayCustomerOrder(customerOrder);
            Display.DisplayGrandTotal(subTotal, TAX);
            Console.WriteLine();
            Console.WriteLine($"Amount tendered: {tendered:C2}");
            Console.WriteLine($"Your change is {change:C2}");
            Console.WriteLine();
            Console.WriteLine($"\t ~~~~~~~~ See you again soon! ~~~~~~~~ ");
        }
    }
}
