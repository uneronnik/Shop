using System.Collections.Generic;

namespace _08_10_2021
{
    partial class Program
    {
        class Shop
        {
            List<Category> _categories;

            void AddCategory(Category category)
            {
                _categories.Add(category);
            }

            Category TryGetCategory(string name)
            {
                foreach (var category in _categories)
                {
                    if (category.Name == name)
                        return category;
                }
                return null;
            }
            public override string ToString()
            {
                string stringToReturn = "";
                foreach (var category in _categories)
                {
                    stringToReturn += $"{category.Name}\n";
                }
                return stringToReturn;
            }
        }
    }
}
