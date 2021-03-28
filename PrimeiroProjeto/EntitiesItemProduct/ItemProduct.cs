using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesItemProduct
{
    class ItemProduct
    {
        public string Name { get; private set; }
        public double UnitPrice { get; private set; }
        public double Amount { get; private set; }

        public ItemProduct(string name, double unitPrice, double amount)
        {
            Name = name;
            UnitPrice = unitPrice;
            Amount = amount;
        }

        public double Total()
        {
            return UnitPrice * Amount;
        }
    }
}
