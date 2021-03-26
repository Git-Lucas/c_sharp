using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesPayer
{
    class CompanyPayer : Payer
    {
        //Instanciação do atributo específico do CompanyPayer, mais a definição dos valores estáticos de impostos, considerados no cálculo
        public int NumberEmployees { get; protected set; }
        //Private, pela segurança da taxa de juros não poder ser alterada em nenhuma parte do sistema (apenas nesta classe)
        public static double LowerTaxDeduction { get; private set; } = 0.14;
        public static double HigherTaxDeduction { get; private set; } = 0.16;

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
                totalTaxes = AnualIncome * LowerTaxDeduction;
            }
            else
            {
                totalTaxes = AnualIncome * HigherTaxDeduction;
            }

            return totalTaxes;
        }
    }
}
