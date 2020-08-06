using System;
using System.Collections.Generic;

namespace POSTerminal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SeedMenu();
            while (true)
            {
                TerminalFlow.TerminalStart();
                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the main menu or type exit to close");
                string input = Console.ReadLine().ToLower();
                if(input == "exit")
                {
                    break;
                }
                Console.Clear();
            }
            

        }

        public static void SeedMenu()
        {
            Product pancakes = new Product(Category.Breakfast, "Pancakes", "Four fluffy flap jacks served with butter and maple syrup", 4.99m);
            Product bgravy = new Product(Category.Breakfast, "Biscuits and Gravy", "Two southern biscuits with sausage gravy", 2.99m);
            Product becombo = new Product(Category.Breakfast, "Bacon and Eggs", "Your choice eggs and 2 strips of bacon", 3.99m);
            Product waffle = new Product(Category.Breakfast, "Belguim Waffles", "Light and crisp, deep pocket waffles served with fruit topping", 5.29m);

            Product sscombo = new Product(Category.Lunch, "Soup and Sandwich", "Your choice of soup with a club sandwich", 4.50m);
            Product caesar = new Product(Category.Lunch, "Caesar Salad", "Served with romaine, croutons, parmesan cheese and ceasar dressing", 5.79m);
            Product ctenders = new Product(Category.Lunch, "Chicken Tenders", "Moist white meat chicken served with your choice of dipping sauce", 2.79m);

            Product sandt = new Product(Category.Dinner, "Surf and Turf", "Fresh caught lobster, 4oz ny strip", 14.99m);
            Product ribeye = new Product(Category.Dinner, "Ribeye", "8oz bone in ribeye", 12.99m);
            Product lamb = new Product(Category.Dinner, "Lamb", "6oz braised lamb shank with port wine reduction sauce", 13.50m);
            Product salmon = new Product(Category.Dinner, "Salmon", "6oz wild caught Alaskan Sockeye on a bed of white rice with lemon herb butter", 12.50m);
            Product kcrab = new Product(Category.Dinner, "Alaskan King Crab Legs", "Our most popular item! 1lb of crab served hot with drawn butter", 17.50m);

            Product mcheese = new Product(Category.Generic, "Mac and Cheese", "Creamy mac and cheese with bread crumbs on top", 3.50m);
            Product ffries = new Product(Category.Generic, "French Fries", "Crispy golden brown steak fries", 1.50m);

            Drink coke = new Drink(Category.Generic, "Coke", Size.large, "Soft drink", 1.00m);
            Drink water = new Drink(Category.Generic, "Water", Size.large, "Natural spring water", 0.00m);
            Drink coffee = new Drink(Category.Generic, "Coffee", Size.medium, "French roast blend, Clove and bittersweet chocolate", 1.49m);
        }


    }
}
