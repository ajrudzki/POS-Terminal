using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminal
{
    class UserInput
    {
        public static int GetOrderItem(int numItems)
        {
            int userChoice;
            bool isValid = false;

            while (true)
            {
                Console.WriteLine();
                Console.Write("What item would you like: ");
                isValid = int.TryParse(Console.ReadLine(), out userChoice);
                if(isValid && userChoice <= numItems + 1 && userChoice > 0)
                {
                    return userChoice;
                }
            }
        }

        public static int HowMany(Product Thing)
        {
            int qty;
            bool isValid;
            while (true)
            {
                Console.WriteLine();
                Console.Write("How many would you like?: ");
                isValid = int.TryParse(Console.ReadLine(), out qty);
                if (isValid && qty >= 0)
                {
                    return qty;
                }
            }
        }

        public static Category GetMenu()
        {
            while (true)
            {
                Console.WriteLine($" ~~~~~~~~ Welcome to Sunny Day Café ~~~~~~~~ \n");
                Console.Write($"Chose Your Menu: Breakfast, Lunch or Dinner?: ");
                string entry = Console.ReadLine().ToLower();
                if (entry == "breakfast")
                {
                    return Category.Breakfast;
                }
                else if (entry == "lunch")
                {
                    return Category.Lunch;
                }
                else if (entry == "dinner")
                {
                    return Category.Dinner;
                }

            }
        }

        public static decimal TenderedAmount()
        {
            decimal tendered= 0m;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write("Amount Tendered: $");
                isValid = decimal.TryParse(Console.ReadLine(), out tendered);
            }
            return tendered;
        }
    }
}
