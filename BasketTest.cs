using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingBasketTest
{
    [TestClass]
    public class BasketTest
    {
        Basket b1;
        Item i1,i2;
        [TestInitialize]
        public void Setup()
        {
            b1 = new Basket();
            i1= new Item(101, "Chocolate", 0.65m);
            i2 = new Item(102, "Orange Juice", 1.05m);
        }
        [TestMethod]
        public void AddItemTest()
        {   //testing AddItem method in class basket
            b1.AddItem(i1);//adding an item to the basket
            Assert.AreEqual(b1.ItemCount(), 1); //checking the number of items in the list
            Assert.IsTrue(b1.BasketCountains(i1));//checking the item is correctly added to the list
        }
        [TestMethod]
        public void AddItemsTest()
        {//testing the AddItems method
            b1.AddItems(i1,i2);//adding two items at once
            Assert.IsTrue(b1.BasketCountains(i1)& b1.BasketCountains(i2));//checking the list contaiins the two items added
            Assert.AreEqual(b1.ItemCount(), 2);//checking the number of items in the list
        }
        [TestMethod]
        public void RemoveItemTest()
        {//testing the RemoveItem Method
            Assert.AreEqual(b1.RemoveItem(i1), "basket is Empty. can't remove items!!");//checking removing items frm an empty basket
            b1.AddItems(i1,i2);//adding two items
        
            Assert.AreEqual(b1.RemoveItem(i1), i1.Name + " removed!");//checking the message returned after removing an item
            Assert.AreEqual(b1.ItemCount(), 1);//checking the number of items in the list
            Assert.IsFalse(b1.BasketCountains(i1));//checking item removed is not in the list       
        }

        [TestMethod]
        public void RemoveItemsTest()
        {// Testing RemoveItems method
            Assert.AreEqual(b1.RemoveItems(i1), "basket is Empty. can't remove items!!");
            b1.AddItems(i1, i2);
            Assert.AreEqual(b1.ItemCount(), 2);
          
            Assert.AreEqual(b1.RemoveItems(i2, i1), i1.Name + " removed!");
            Assert.AreEqual(b1.ItemCount(), 0);
           
        }
        [TestMethod]
        public void ClearBasketTest()
        {
            
            b1.AddItems(i1, i2);
            b1.ClearBasket();
            Assert.IsFalse(b1.BasketCountains(i1) & b1.BasketCountains(i2));
            Assert.AreEqual(b1.ItemCount(), 0);
        }
    }
}
