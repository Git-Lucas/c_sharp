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

        //Price não participa do construtor, pois esta variável é preenchida apenas na função SubTotal()
        public OrderItem(int quantidade, Product product)
        {
            Quantity = quantidade;
            Product = product;
        }

        //Calcula o subtotal de cada produto, e armazena em Price
        public double SubTotal()
        {
            Price = 0;
            Price = Product.Price * Quantity;
            return Price;
        }
    }
}
