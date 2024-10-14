using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Seller
    {
        private Product iPhone = new Product(TypeofProduct.IPhone); // модификаторы доступа
        private Product iPad = new Product(TypeofProduct.IPad);
        private Product macBook = new Product(TypeofProduct.MacBook);

        private List<Product> products = new List<Product>(); 

        public void AddProducts()
        {
            products.Add(iPhone);
            products.Add(iPad);
            products.Add(macBook);
        }

        public void SellProduct(Product product)
        {
            products.Remove(product);
        }

        public void ShowProductsAvailable()
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product.TypeofProduct.ToString());
            }
        }
    }
}
