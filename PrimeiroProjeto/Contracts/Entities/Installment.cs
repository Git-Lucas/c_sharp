using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.Contracts.Entities
{
    class Installment
    {
        public int Number { get; protected set; }
        public DateTime DueDate { get; protected set; }
        public double Amount { get; set; }

        public Installment(int installmentNumber, DateTime dueDate, double amount)
        {
            Number = installmentNumber;
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Installment {Number} - {DueDate.ToString("dd/MM/yyyy")} - R${Amount:F2}";
        }
    }
}
