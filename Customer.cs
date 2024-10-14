using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Customer
    {
        private List<Product> purchasedItems = new List<Product>(); // модификатор доступа

        public void AddPurchasedItem(Product product)
        {
            purchasedItems.Add(product);
        }
    }
}
