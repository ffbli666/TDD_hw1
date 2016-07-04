using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Tests
{
    [TestClass()]
    public class StatisticsTests
    {
        [TestMethod()]
        public void sumTest_Order型態_3筆一組_取得欄位Cost總和()
        {
            //arrange
            var target = new Statistics<Order>(getOrderMockData());

            //act
            var actual = target.sum("Cost", 3);

            //assert
            var expected = new int[] { 6, 15, 24, 21 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void sumTest_Order型態_4筆一組_取得欄位Revenue總和()
        {
            //arrange
            var target = new Statistics<Order>(getOrderMockData());

            //act
            var actual = target.sum("Revenue", 4);

            //assert
            var expected = new int[] { 50, 66, 60 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void sumTest_Product型態_3筆一組_取得欄位Cost總和()
        {
            //arrange
            var target = new Statistics<Product>(getProductMockData());

            //act
            var actual = target.sum("Cost", 3);

            //assert
            var expected = new int[] { 6, 15, 24, 21 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void sumTest_Product型態_4筆一組_取得欄位Revenue總和()
        {
            //arrange
            var target = new Statistics<Product>(getProductMockData());

            //act
            var actual = target.sum("Revenue", 4);

            //assert
            var expected = new int[] { 50, 66, 60 };

            CollectionAssert.AreEqual(expected, actual);
        }

        private List<Order> getOrderMockData()
        {
            return new List<Order>
            {
                new Order { Id=1,  Cost=1,  Revenue=11, SellPrice=21},
                new Order { Id=2,  Cost=2,  Revenue=12, SellPrice=22},
                new Order { Id=3,  Cost=3,  Revenue=13, SellPrice=23},
                new Order { Id=4,  Cost=4,  Revenue=14, SellPrice=24},
                new Order { Id=5,  Cost=5,  Revenue=15, SellPrice=25},
                new Order { Id=6,  Cost=6,  Revenue=16, SellPrice=26},
                new Order { Id=7,  Cost=7,  Revenue=17, SellPrice=27},
                new Order { Id=8,  Cost=8,  Revenue=18, SellPrice=28},
                new Order { Id=9,  Cost=9,  Revenue=19, SellPrice=29},
                new Order { Id=10, Cost=10, Revenue=20, SellPrice=30},
                new Order { Id=11, Cost=11, Revenue=21, SellPrice=31},
            };
        }

        private List<Product> getProductMockData()
        {
            return new List<Product>
            {
                new Product { Id=1,  Cost=1,  Revenue=11, SellPrice=21},
                new Product { Id=2,  Cost=2,  Revenue=12, SellPrice=22},
                new Product { Id=3,  Cost=3,  Revenue=13, SellPrice=23},
                new Product { Id=4,  Cost=4,  Revenue=14, SellPrice=24},
                new Product { Id=5,  Cost=5,  Revenue=15, SellPrice=25},
                new Product { Id=6,  Cost=6,  Revenue=16, SellPrice=26},
                new Product { Id=7,  Cost=7,  Revenue=17, SellPrice=27},
                new Product { Id=8,  Cost=8,  Revenue=18, SellPrice=28},
                new Product { Id=9,  Cost=9,  Revenue=19, SellPrice=29},
                new Product { Id=10, Cost=10, Revenue=20, SellPrice=30},
                new Product { Id=11, Cost=11, Revenue=21, SellPrice=31},
            };
        }
    }

    internal class Order
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }

    internal class Product
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }
}