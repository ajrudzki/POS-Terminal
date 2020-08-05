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
                Console.Write("What item would you like: ");
                isValid = int.TryParse(Console.ReadLine(), out userChoice);
                if(isValid && userChoice < numItems && userChoice > 0)
                {
                    return userChoice;
                }
            }
        }
    }
}
