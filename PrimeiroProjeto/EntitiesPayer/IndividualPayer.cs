using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesPayer
{
    class IndividualPayer : Payer
    {
        //Instanciação do atributo específico do IndividualPayer, mais a definição dos valores estáticos de impostos, considerados no cálculo
        public double HealthExpenditures { get; protected set; }
        //Private, pela segurança da taxa de juros não poder ser alterada em nenhuma parte do sistema (apenas nesta classe)
        public static double Roof { get; private set; } = 20000;
        public static double LowerTaxDeduction { get; private set; } = 0.15;
        public static double HigherTaxDeduction { get; private set; } = 0.25;
        public static double TaxHealthExpenditures { get; private set; } = 0.5;

        public IndividualPayer(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double CalculatesTaxes()
        {
            double totalTaxes = 0;

            if (AnualIncome < Roof)
            {
                totalTaxes = (AnualIncome * LowerTaxDeduction) - (HealthExpenditures * TaxHealthExpenditures);
            }
            else
            {
                totalTaxes = (AnualIncome * HigherTaxDeduction) - (HealthExpenditures * TaxHealthExpenditures);
            }

            return totalTaxes;
        }
    }
}
