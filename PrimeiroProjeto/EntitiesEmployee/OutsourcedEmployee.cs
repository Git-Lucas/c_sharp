using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesEmployee
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        //Método que calcula o Payment do Employee que é Outsourced: Payment da classe Employee + regra de negócio
        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }
    }
}
