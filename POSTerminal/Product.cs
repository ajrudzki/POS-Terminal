using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminal
{
    public enum Category
    {
        breakfast,
        lunch,
        dinner,
        generic,
        test
    }
    public enum Size
    {
        small,
        medium,
        large
    }
    public class Product
    {
        //private string _name;
        public string Name { get; set; }

        //private Category _category;
        public Category Category { get; set; }

        //private string _description;
        public string Description { get; set; }

        //private decimal _price;

        public decimal Price { get; set; }

        public static List<Product> allProducts = new List<Product>();

        public Product(Category aCategory, string aName,  string aDescription, decimal aPrice)
        {
            Name = aName;
            Category = aCategory;
            Description = aDescription;
            Price = aPrice;
            allProducts.Add(this);
        }

        public static List<Product> GetMenu(Category Menu)
        {
            List<Product> menuItems = new List<Product>();

            foreach (Product item in allProducts)
            {
                if (item.Category == Menu || item.Category == Category.generic)
                {
                    menuItems.Add(item);
                }
            }
            return menuItems;
        }
    }
    public class Drink : Product
    {
        private Size _size;
        public Drink(Category aCategory, string aName, Size aSize, string aDescription, decimal aPrice) : base(aCategory, aName, aDescription, aPrice)
        {
            _size = aSize;
        }
    }

}
