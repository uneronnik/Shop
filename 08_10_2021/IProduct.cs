namespace _08_10_2021
{
    partial class Program
    {
        delegate void BuyHandler();
        interface IProduct
        {
            event BuyHandler Purchased;
            int Price { get; }
            string Name { get; }
            void Buy();
        }
    }
}
