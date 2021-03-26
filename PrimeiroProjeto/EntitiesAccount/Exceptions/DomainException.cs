using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesAccount.Exceptions
{
    class DomainException : ApplicationException
    {
        //O construtor da classe apenas envia a descrição do erro para a classe ApplicationException, preenchendo o atributo Message que existe nela
        public DomainException(string message) : base(message)
        {
        }
    }
}
