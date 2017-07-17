using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingBasketTest
{
    [TestClass]
    public class TestItem
    {
        Item i2;
       [TestInitialize]
        public void setup()
        {
            i2=new Item(10, "Tissue", 1.00m);
        }
        [TestMethod]
        public void TestCreatingAnItem()
        {
            Item i1 = new Item(10, "Milk", 1.60m);
            Assert.AreEqual(i1.Code, 10);
            Assert.AreEqual(i1.Name, "Milk");
            Assert.AreEqual(i1.Price, 1.60m);

        }

        [TestMethod]
        public void TestChangePrice()
        {
            //Item i1 = new Item(10, "Tissue", 1.00m);
            i2.ChangePrice(1.05m);
            Assert.AreEqual(i2.Price, 1.05m);
        }
        [TestMethod]
        public void TestChangeName()
        {
            //Item i1 = new Item(10, "Tissue", 1.00m);
            i2.ChangeName("TissueBox");
            Assert.AreEqual(i2.Name, "TissueBox");
        }
        [TestMethod]
        public void TestChangeCode()
        {
            //Item i1 = new Item(10, "Tissue", 1.00m);
            i2.ChangeCode(101);
            Assert.AreEqual(i2.Code, 101);
        }
    }
}
