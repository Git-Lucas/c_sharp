using PrimeiroProjeto.EntitiesAccount.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesAccount
{
    class Account
    {
        //Number e Holder são informações "menos importantes", que terão suas alterações facilitadas na classe Principal
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        
        //Balance e WithdrawLimit são definições mais importantes pelas regras de negócio, então só podem ser alteradas através dos métodos internos da classe, ou no construtor (WithdrawLimit);
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
            //Verifica se o objeto Account possui saldo insuficiente
            if (amount > Balance)
            {
                //Instancia um erro na ApplicationException
                throw new DomainException("Not enough balance.");
            }
            //Veririca se o valor de saque é maior do que o limite definido para o objeto Account
            if (amount > WithdrawLimit)
            {
                //Instancia um erro na ApplicationException
                throw new DomainException("The amount exceeds withdraw limit.");
            }

            //Como o "throw new" corta a execução do método, esta linha somente será executada, após falha nas 2 verificações de erro nas regras de negócio
            Balance -= amount;
        }
    }
}
