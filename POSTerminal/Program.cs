using System;
using System.Collections.Generic;

namespace POSTerminal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SeedMenu();
            List<Product> customerOrder = new List<Product>();

            List<Product> menutime = Product.GetMenu(Category.breakfast);
            menutime = Display.DisplayMenu(menutime);
            Display.CustomerItems(customerOrder);
            int choice = UserInput.GetOrderItem(menutime.Count);
            customerOrder.Add(menutime[choice]);


            Console.WriteLine(menutime.Count);
        }
        public static void SeedMenu()
        {
            Product pancakes = new Product(Category.breakfast, "pancakes", "four fluffy flap jacks served with butter and maple syrup", 4.99m);
            Product bgravy = new Product(Category.breakfast, "biscuits and gravy", "two southern biscuits with sausage gravy", 2.99m);
            Product becombo = new Product(Category.breakfast, "bacon and eggs", "your choice eggs and 2 strips of bacon", 3.99m);

            Product sscombo = new Product(Category.lunch, "soup and sandwich", "your choice of soup with a club sandwich", 4.50m);
            Product caesar = new Product(Category.lunch, "caesar salad", "served with romaine, croutons, parmesan cheese and ceasar dressing", 5.79m);

            Product sandt = new Product(Category.dinner, "surf and turf", "fresh caught lobster, 4oz ny strip", 14.99m);
            Product ribeye = new Product(Category.dinner, "ribeye", "8oz bone in ribeye", 12.99m);
            Product lamb = new Product(Category.dinner, "lamb", "6oz braised lamb shank with port wine reduction sauce", 13.50m);

            Product mcheese = new Product(Category.generic, "mac and cheese", "creamy mac and cheese with bread crumbs on top", 3.50m);
            Product ffries = new Product(Category.generic, "french fries", "crispy golden brown steak fries", 1.50m);

            Drink coke = new Drink(Category.generic, "coke", Size.large, "soft drink", 1.00m);
            Drink water = new Drink(Category.generic, "water", Size.large, "natural spring water", 0.00m);
        }

    }
}
