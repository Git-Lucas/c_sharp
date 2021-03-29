using PrimeiroProjeto.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.Contracts.Services
{
    interface IPaymentService
    {
        //A interface não possui atributos (se necessários, estes serão implementados nas classes filhas)
        //O método definido nesta interface, deverá ser sobrescrito (e não sobrecarregado) nas classes que implementam esta interface (isto garante que na definição do PaymentService (Paypal ou outro), na instanciação do objeto PaymentService, o UpCasting será feito, e o método CalculationInstallments será executado na classe filha (com suas especificidades))
        public double CalculationInstallments(double amount, int installment);
    }
}
