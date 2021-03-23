using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesProducts
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} R${TotalPrice():F2} (Customs fee: R${CustomsFee:F2})";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
