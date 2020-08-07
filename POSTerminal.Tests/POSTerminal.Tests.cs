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
            Product item = new Product(Category.Test, "testCat", "testA", .99m);
            Product gitem = new Product(Category.Generic, "testGen", "testB", 1.00m);
            List<Product> test1 = new List<Product>();
            test1.Add(item);
            test1.Add(gitem);
            Assert.Equal(test1, Product.GetMenu(Category.Test));
        }

        [Fact]
        public void SubTotalCalcTest1qty()
        {
            Product item = new Product(Category.Test, "test", "test", .99m);
            Product gitem = new Product(Category.Generic, "test", "test", 1.00m);
            List<Product> test2 = new List<Product>();
            test2.Add(item);
            test2.Add(gitem);
            test2[0].Quantity = 1;
            test2[1].Quantity = 1;
            decimal total = (test2[0].Price * test2[0].Quantity) + (test2[1].Price * test2[1].Quantity);
            Assert.Equal(total, TerminalFlow.CalculateSubTotal(test2));
        }

        [Fact]
        public void SubTotalCalcTest0qty()
        {
            Product itemtest3 = new Product(Category.Test, "test31", "Whiy is this test making the previous test fail!!!!", .99m);
            Product itemtest3G = new Product(Category.Generic, "test32", "Please stop failing", 1.00m);
            //Product item = new Product(Category.Test, "test3", "test", .99m);
            //Product gitem = new Product(Category.Generic, "test3", "test", 1.00m);
            List<Product> test3 = new List<Product>();
            test3.Add(itemtest3);
            test3.Add(itemtest3G);
            test3[0].Quantity = 0;
            test3[1].Quantity = 0;
            decimal total = test3[0].Price * test3[0].Quantity + test3[1].Price * test3[1].Quantity;
            Assert.Equal(total, TerminalFlow.CalculateSubTotal(test3));
        }

    }
}
