using PrimeiroProjeto.EntitiesAccount.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesAccount
{
    class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account(int number, string holder, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance.");
            }
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit.");
            }

            Balance -= amount;
        }
    }
}
