using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_10_2021
{
    partial class Program
    {
        class Category
        {
            List<IProduct> _products = new List<IProduct>();

            public Category(string name)
            {
                Name = name;
            }

            public Category(string name, List<IProduct> products)
            {
                Name = name;
                _products = products;
            }
            string _name; 
            public string Name { get => _name; set => _name = value; }
            public override string ToString()
            {
                string stringToReturn = "";
                int i = 0;
                foreach (var product in _products)
                {
                    stringToReturn += $"{i+1}. {product}\n";
                    i++;
                }
                return stringToReturn;
            }
            public IProduct BuyProduct(int index)
            {
                IProduct product = null;
                try
                {
                    product = _products.ElementAt(index - 1);
                }
                catch (Exception ex)
                {
                    return null;
                }
                _products.Remove(product);
                product.Buy();
                return product;
                
            }
            public void AddProduct(IProduct product)
            {
                _products.Add(product);
            }
        }
    }
}
