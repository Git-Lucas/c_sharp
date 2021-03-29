using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.Contracts.Entities
{
    class Contract
    {
        public int Number { get; protected set; }
        public DateTime Date { get; protected set; }
        public double Value { get; protected set; }
        public List<Installment> Installments { get; protected set; }

        public Contract(int number, DateTime date, double value)
        {
            Number = number;
            Date = date;
            Value = value;
        }

        //Função que adiciona as parcelas ao contrato
        public void AddInstallments(int installmentsNumber)
        {
            //Instancia a lista de parcelas
            Installments = new List<Installment>();
            for (int i = 0; i < installmentsNumber; i++)
            {
                //O objeto Installment é instanciado com (número da parcela, data (contrato + (1 + indíce) meses), valor da parcela (sem juros)), e adicionado à lista de parcelas deste Contract
                Installments.Add(new Installment(i + 1, Date.AddMonths(i + 1), Value / installmentsNumber));
            }
        }

        //Função que exibe como cabeçalho o número deste Contract, e as parcelas do mesmo (formatadas as linhas na classe Installment)
        public string ToStringInstallments()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nContract Installments {Number}: ");

            foreach (Installment i in Installments)
            {
                sb.AppendLine(i.ToString());
            }

            return sb.ToString();
        }
    }
}
