using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesProducts
{
    class Product
    {
        public string Name { get; protected set; }
        public double Price { get; protected set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return $"{Name} R${Price:F2}";
        }
    }
}
