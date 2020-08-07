using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminal
{
    public class TerminalFlow
    {
        public static void TerminalStart()
        {
            List<Product> customerOrder = new List<Product>();
            decimal subTotal;
            decimal grandTotal;
            decimal tendered;
            decimal change;
            const double TAX = .6;
            Category Menu = UserInput.GetMenu();

            while (true)
            {
                Console.Clear();
                List<Product> menutime = Product.GetMenu(Menu);
                menutime = Display.DisplayMenu(menutime);
                subTotal = CalculateSubTotal(customerOrder);
                Display.DisplayTotal("Your current total is: ", subTotal);
                int choice = UserInput.GetOrderItem(menutime.Count) - 1;
                if (choice == menutime.Count)
                {
                    break;
                }
                int qty = UserInput.HowMany(menutime[choice]);
                customerOrder = AddItem(menutime[choice], qty, customerOrder);
            }
            grandTotal = Display.DisplayGrandTotal(subTotal, TAX);
            tendered = UserInput.TenderedAmount();
            change = tendered - grandTotal;
            Display.DisplayChange(change);
            Display.DisplayReciept(customerOrder, subTotal, TAX, grandTotal, tendered, change);
        }

        public static List<Product> AddItem(Product Item, int Amount, List<Product> customerOrder)
        {
            if (Amount == 0)
            {
                return customerOrder;
            }
            customerOrder.Add(Item);
            customerOrder[customerOrder.Count - 1].Quantity = Amount;
            return customerOrder;
        }

        public static decimal CalculateSubTotal(List<Product> order)
        {
            decimal total = 0m;
            foreach (Product item in order)
            {
                total = total + (item.Price * item.Quantity);
            }
            return total;
        }
    }
}
