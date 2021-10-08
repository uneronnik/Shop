using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _08_10_2021
{
    partial class Program
    {
        


        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Category category = new Category("Milk products");
            category.AddProduct(new Milk(1, "Бежин луг"));
            shop.AddCategory(category);
            WriteLine(shop);
            Category milkCategory = shop.TryGetCategory("Milk products");
            WriteLine(milkCategory);
            WriteLine(milkCategory.BuyProduct(1));
            ReadKey();
        }
    }
}
