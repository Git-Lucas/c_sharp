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
        //O 1 não é incrementado na declaração, porque primeiro deve multiplicar o coeficiente pelo installmentNumber, para depois adicionar o 1 e multiplicar o amount
        public double MonthlyInterest { get; protected set; } = 0.01;
        //O 1 já é incrementado pelo fato de ser uma taxa final do pagamento: será ele mesmo + a taxa
        public double PaymentFee { get; protected set; } = 1.02;

        //Implementa o método da interface, com a forma de cálculo própria, a partir de seus valores de juros
        public double CalculationInstallments(double amount, int installmentNumber)
        {
            return (amount * (MonthlyInterest * installmentNumber + 1)) * PaymentFee;
        }
    }
}
