using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesPayer
{
    //Class abstract: não será possível instanciar uma classe Payer, mas uma lista do tipo Payer pode armazenar todas as subclasses, e o polimorfismo será aproveitado
    abstract class Payer
    {
        public string Name { get; protected set; }
        public double AnualIncome { get; protected set; }
                
        protected Payer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        //A implementação da classe será feita apenas nas subclasses
        public abstract double CalculatesTaxes();
    }
}
