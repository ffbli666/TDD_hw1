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
            var target = new Statistics();

            //act
            var actual = target.sum(getOrderMockData(), "Cost", 3);

            //assert
            var expected = new int[] { 6, 15, 24, 21 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void sumTest_Order型態_4筆一組_取得欄位Revenue總和()
        {
            //arrange
            var target = new Statistics();

            //act
            var actual = target.sum(getOrderMockData(), "Revenue", 4);

            //assert
            var expected = new int[] { 50, 66, 60 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void sumTest_Product型態_3筆一組_取得欄位pCost總和()
        {
            //arrange
            var target = new Statistics();

            //act
            var actual = target.sum(getProductMockData(), "pCost", 3);

            //assert
            var expected = new int[] { 6, 15, 24, 21 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void sumTest_Product型態_4筆一組_取得欄位pRevenue總和()
        {
            //arrange
            var target = new Statistics();

            //act
            var actual = target.sum(getProductMockData(), "pRevenue", 4);

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
                new Product { pId=1,  pCost=1,  pRevenue=11, pSellPrice=21},
                new Product { pId=2,  pCost=2,  pRevenue=12, pSellPrice=22},
                new Product { pId=3,  pCost=3,  pRevenue=13, pSellPrice=23},
                new Product { pId=4,  pCost=4,  pRevenue=14, pSellPrice=24},
                new Product { pId=5,  pCost=5,  pRevenue=15, pSellPrice=25},
                new Product { pId=6,  pCost=6,  pRevenue=16, pSellPrice=26},
                new Product { pId=7,  pCost=7,  pRevenue=17, pSellPrice=27},
                new Product { pId=8,  pCost=8,  pRevenue=18, pSellPrice=28},
                new Product { pId=9,  pCost=9,  pRevenue=19, pSellPrice=29},
                new Product { pId=10, pCost=10, pRevenue=20, pSellPrice=30},
                new Product { pId=11, pCost=11, pRevenue=21, pSellPrice=31},
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
        public int pId { get; set; }
        public int pCost { get; set; }
        public int pRevenue { get; set; }
        public int pSellPrice { get; set; }
    }
}