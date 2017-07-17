namespace ShoppingBasketTest
{
    internal class Item
    {
        public decimal Price { get; private set; }
        public string Name { get; private set; }
        public int Code { get; private set; }

        public Item(int code,string name,decimal price)
        {
            Code = code;
            Name = name;
            Price = price;
        }
        public void ChangePrice(decimal price)
        {
            Price = price;
        }
        public void ChangeName(string name)
        {
            Name = name;
        }
        public void ChangeCode(int code)
        {
            Code = code;
        }
    }
}