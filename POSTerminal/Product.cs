﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminal
{
    public enum Category
    {
        Breakfast,
        Lunch,
        Dinner,
        Generic,
        Test
    }

    public enum Size
    {
        small,
        medium,
        large
    }

    public class Product
    {
        // one private variable made and then made a public getter and setter
        // The lab says to do this way however Jeff taught us a better way
        // other properties are done in the way Jeff taught us.
        private string _name;
        public string Name 
        {
            get 
            {
                return _name;
            }
            set
            {
                _name = value;
            } 
        }

        //private Category _category;
        public Category Category { get; set; }

        //private string _description;
        public string Description { get; set; }

        //private decimal _price;
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        //public static List<Product> allProducts = new List<Product>();

        public Product(Category aCategory, string aName,  string aDescription, decimal aPrice)
        {
            Name = aName;
            Category = aCategory;
            Description = aDescription;
            Price = aPrice;
            //allProducts.Add(this);
            Quantity = 0;
        }

        public static List<Product> GetMenu(Category Menu, List<Product> allProducts)
        {
            List<Product> menuItems = new List<Product>();

            foreach (Product item in allProducts)
            {
                if (item.Category == Menu || item.Category == Category.Generic)
                {
                    menuItems.Add(item);
                }
            }
            return menuItems;
        }

        public override string ToString()
        {
            return _name;
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
