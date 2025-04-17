using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace lab_1_KPZ
{
    public class Warehouse
    {
        private List<(Product, int)> products = new List<(Product, int)>();

        public void AddProduct(Product product, int quantity)
        {
            products.Add((product, quantity));
        }

        public void ShowInventory()
        {
            Console.WriteLine("Склад містить:");
            foreach (var (product, quantity) in products)
            {
                Console.Write($"{product.Name}: {quantity} шт. по ціні ");
                product.Price.Show();
            }
        }
    }
}
