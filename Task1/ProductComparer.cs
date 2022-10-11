using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    // wanted to use such a class to compare objects
    class ProductComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product x, Product y)
        {
            if (x.Name == y.Name && x.Price == y.Price)
                return true;
            return false;
        }

        public int GetHashCode(Product obj)
        {
            throw new NotImplementedException();
        }
    }
}
