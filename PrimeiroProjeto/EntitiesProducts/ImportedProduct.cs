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
            return base.PriceTag() + $" (Customs fee: R${CustomsFee:F2})";
        }
    }
}
