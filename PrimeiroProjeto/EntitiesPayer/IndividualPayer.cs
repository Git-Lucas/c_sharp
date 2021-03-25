using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesPayer
{
    class IndividualPayer : Payer
    {
        public double HealthExpenditures { get; protected set; }

        public IndividualPayer(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double CalculatesTaxes()
        {
            double totalTaxes = 0;

            if (AnualIncome < 20000)
            {
                totalTaxes = (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                totalTaxes = (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }

            return totalTaxes;
        }
    }
}
