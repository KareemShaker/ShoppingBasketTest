using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingBasketTest
{
    [TestClass]
    public class TestItem
    {
        Item i2;
       [TestInitialize]
        public void Setup()
        {
            i2=new Item(10, "Tissue", 1.00m);
        }
        [TestMethod]
        public void TestCreatingAnItem()
        {
            Item i1 = new Item(10, "Milk", 1.60m);
            Assert.AreEqual(10,i1.Code);
            Assert.AreEqual("Milk",i1.Name );
            Assert.AreEqual( 1.60m,i1.Price);

        }

        [TestMethod]
        public void TestChangePrice()
        {
            
            i2.ChangePrice(1.05m);
            Assert.AreEqual( 1.05m,i2.Price);
        }
        [TestMethod]
        public void TestChangeName()
        {
            
            i2.ChangeName("TissueBox");
            Assert.AreEqual("TissueBox", i2.Name);
        }
        [TestMethod]
        public void TestChangeCode()
        {
            
            i2.ChangeCode(101);
            Assert.AreEqual(101, i2.Code);
        }
    }
}
