using System;
using Xunit;
using POSTerminal;
using System.Collections.Generic;

namespace POSTerminal.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void MenuTest()
        {
            Product item = new Product(Category.Test, "test", "test", 0m);
            Product gitem = new Product(Category.Generic, "test", "test", 0m);
            List<Product> test = new List<Product>();
            test.Add(item);
            test.Add(gitem);
            Assert.Equal(test, Product.GetMenu(Category.Test));
        }
    }
}
