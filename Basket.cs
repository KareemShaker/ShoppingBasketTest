using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasketTest
{
    class Basket
    {
        private List<Item> ItemList = new List<Item>();

        public int ItemCount()
        {
            return ItemList.Count();
        }
        public bool BasketCountains(Item item)
        {
            return ItemList.Contains(item);
        }
        public bool BasketIsEmpty()
        {
            if (ItemCount() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddItem(Item item)
        {
            ItemList.Add(item);
        }

        public void AddItems(params Item[] items)
        {
            ItemList.AddRange(items);
        }

        public string RemoveItem(Item item)
        {
            if (!BasketIsEmpty())
            {
                if (ItemList.Remove(item))
                {
                     return item.Name+ " removed!";
                }
                else
                {
                    return item.Name + " is not removed!";
                }
            }
            else
            {
                return "basket is Empty. can't remove items!!";
                //return "";
            }

            
        }

        public string RemoveItems(params Item[] items)
        {
            string message="";
            if (BasketIsEmpty())
            {
                message= "basket is Empty. can't remove items!!";
            }
            else
            {
                foreach (Item item in items)
                {
                    if (ItemList.Remove(item))
                    {
                        message= item.Name + " removed!";
                    }
                    else
                    {
                        message= item.Name + " is not removed!";
                    }
                }
                
            }
            return message;  
        }
        public void ClearBasket()
        {
            ItemList.Clear();
        }
    }
}
