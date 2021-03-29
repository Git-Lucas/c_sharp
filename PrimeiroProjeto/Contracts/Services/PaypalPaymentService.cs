using PrimeiroProjeto.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.Contracts.Services
{
    //Classe que implementa a interface IPaymentService (e portanto, será possível instanciar um objeto do tipo PaypalPaymentService, na instanciação do PaymentService)
    class PaypalPaymentService : IPaymentService
    {
        //Atributos desta classe, inerentes às taxas do PayPal
        public double MonthlyInterest { get; protected set; } = 0.01;
        public double PaymentFee { get; protected set; } = 1.02;

        //Implementa o método da interface, com a forma de cálculo própria, a partir de seus valores de juros
        public double CalculationInstallments(double amount, int installment)
        {
            return (amount * (MonthlyInterest * installment + 1)) * PaymentFee;
        }
    }
}
