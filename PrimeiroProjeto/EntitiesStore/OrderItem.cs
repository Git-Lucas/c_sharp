using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesStore
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; private set; }
        public Product Product { get; set; }

        public OrderItem(int quantidade, Product product)
        {
            Quantity = quantidade;
            Product = product;
        }

        public double SubTotal()
        {
            Price = 0;
            Price = Product.Price * Quantity;
            return Price;
        }
    }
}
