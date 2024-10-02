using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public enum TypeofProduct
    {
        IPhone,
        IPad,
        MacBook
    }

    public class Product
    {
        public TypeofProduct TypeofProduct { get; }
        public Product(TypeofProduct typeofProduct)
        {
            TypeofProduct = typeofProduct;
        }
    }
}
