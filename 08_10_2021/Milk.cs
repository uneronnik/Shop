namespace _08_10_2021
{
    partial class Program
    {
        class Milk : IProduct
        {
            int _price;
            string _name;
            public Milk(int price, string name)
            {
                _price = price;
                _name = name;
            }

            public int Price { get => _price; }
            public string Name { get => _name; }

            public event BuyHandler Purchased;

            public void Buy()
            {
                Purchased?.Invoke();
            }
            public override string ToString()
            {
                return $"Milk: {Name} ${Price}";
            }
        }
    }
}
