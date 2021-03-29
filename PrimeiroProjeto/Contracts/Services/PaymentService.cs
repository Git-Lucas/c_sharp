using PrimeiroProjeto.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.Contracts.Services
{
    class PaymentService
    {
        //A classe pai da interface, implementará um atributo do tipo da interface, ou outros se for o caso
        //O atributo da classe, será a interface (qualquer mudança na forma de pagamento, não obriga a alteração nesta classe, pois as outras formas de pagamento precisarão seguir as ordens de implementação da interface IPaymentService)
        public IPaymentService _PaymentService { get; protected set; }

        //O construtor da classe poderá receber como parâmetro, a instanciação de qualquer objeto que implemente a interface IPaymentService (UpCasting)
        public PaymentService(IPaymentService paymentService)
        {
            _PaymentService = paymentService;
        }

        //A classe pai da interface, implementará uma função que terá como parâmetro, um objeto da classe da entidade que possui as informações pertinentes para o método
        public void ProcessInstallments(Contract contract)
        {
            //O método será executado para cada Installment do Contract
            foreach (Installment i in contract.Installments)
            {
                //Atualiza o valor Amout da Installment em questão, chamando o método da interface (isso significa que esta classe está pronta para qualquer outro ServicePayment, com suas próprias taxas, desde que recebem o amount e o installmentNumber)
                i.Amount = _PaymentService.CalculationInstallments(i.Amount, i.Number);
            }
        }
    }
}
