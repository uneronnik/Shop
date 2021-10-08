namespace _08_10_2021
{
    partial class Program
    {
        class Milk : IProduct
        {
            public int Price { get => Price; set => Price = value; }
            public string Name { get => Name; set => Name = value; }

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
