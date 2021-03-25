using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesPayer
{
    class CompanyPayer : Payer
    {
        public int NumberEmployees { get; protected set; }

        public CompanyPayer(string name, double anualIncome, int numberEmployees)
            : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double CalculatesTaxes()
        {
            double totalTaxes = 0;

            if(NumberEmployees > 10)
            {
                totalTaxes = AnualIncome * 0.14;
            }
            else
            {
                totalTaxes = AnualIncome * 0.16;
            }

            return totalTaxes;
        }
    }
}
