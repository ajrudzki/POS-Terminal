using System;
using Xunit;
using POSTerminal;
using System.Collections.Generic;

namespace POSTerminal.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void MenuTest1()
        {
            Product item = new Product(Category.Test, "testCat", "testA", .99m);
            List<Product> test = new List<Product>();
            test.Add(item);
            Assert.Equal(test, Product.GetMenu(Category.Test, test));
        }

        [Fact]
        public void MenuTest2()
        {
            Product item = new Product(Category.Test, "MenuTest2.test", "item", .99m);
            Product gitem = new Product(Category.Generic, "MenuTest2.Generic", "gitem", 1.00m);
            List<Product> test = new List<Product>();
            test.Add(item);
            test.Add(gitem);
            Assert.Equal(test, Product.GetMenu(Category.Test, test));
        }

        [Fact]
        public void MenuTest3()
        {
            Product item = new Product(Category.Test, "MenuTest3.Test", "item", .99m);
            Product gitem = new Product(Category.Generic, "MenuTest3.Generic", "gitem", 1.00m);
            Product bitem = new Product(Category.Breakfast, "MenuTest3.Breakfast", "bitem", 4.00m);
            List<Product> test = new List<Product>();
            List<Product> expected = new List<Product>();
            test.Add(item);
            expected.Add(item);
            test.Add(gitem);
            expected.Add(gitem);
            test.Add(bitem);
            Assert.Equal(expected, Product.GetMenu(Category.Test, test));
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
            decimal total = test2[0].Price + test2[1].Price;
            Assert.Equal(total, TerminalFlow.CalculateSubTotal(test2));
        }

        [Fact]
        public void SubTotalCalcTest0qty()
        {
            Product item = new Product(Category.Test, "test.Test", "Test category item", .99m);
            Product genericItem = new Product(Category.Generic, "gernericItem.Generic", "Generic category", 1.00m);
            List<Product> test3 = new List<Product>();
            test3.Add(item);
            test3.Add(genericItem);
            Assert.Equal(0, TerminalFlow.CalculateSubTotal(test3));
        }

        [Fact]
        public void AddItemTest_FirstItem()
        {
            Product item = new Product(Category.Test, "MenuTest3.Test", "item", .99m);

            List<Product> testorder = new List<Product>();
            List<Product> expected = new List<Product>();
            expected.Add(item);

            Assert.Equal(expected, TerminalFlow.AddItem(item, 1, testorder));
        }

        [Fact]
        public void AddItem_QtyItem()
        {
            Product item = new Product(Category.Test, "MenuTest3.Test", "item", .99m);

            List<Product> testorder = new List<Product>();
            List<Product> expected = new List<Product>();
            expected.Add(item);
            expected[0].Quantity = 2;

            Assert.Equal(expected, TerminalFlow.AddItem(item, 2, testorder));
        }

        [Fact]
        public void AddItemToExistingList()
        {
            Product item = new Product(Category.Test, "MenuTest3.Test", "item", .99m);

            List<Product> testorder = new List<Product>();
            List<Product> expected = new List<Product>();
            expected.Add(item);
            expected[0].Quantity = 2;
            testorder.Add(item);
            testorder[0].Quantity = 2;
            expected.Add(item);

            Assert.Equal(expected, TerminalFlow.AddItem(item, 1, testorder));
        }

        [Fact]
        public void SubTotalCalcTestmultiqty()
        {
            Product item = new Product(Category.Test, "test", "test", .99m);
            Product gitem = new Product(Category.Generic, "test", "test", 1.00m);
            List<Product> test2 = new List<Product>();
            test2.Add(item);
            test2.Add(gitem);
            test2[0].Quantity = 1;
            test2[1].Quantity = 5;
            decimal total = (test2[0].Price * test2[0].Quantity) + (test2[1].Price * test2[1].Quantity);
            Assert.Equal(total, TerminalFlow.CalculateSubTotal(test2));
        }

    }
}
