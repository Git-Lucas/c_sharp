using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto {
    class Produto {
        private string _nome;
        public double Preco{ get; private set; }
        public int Quantidade{ get; private set; }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;
        }

        public string Nome {
            get {
                return _nome;
            }

            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                } else {
                    _nome = "(O nome digitado foi inválido!)";
                }

            }
        }

        public void AdicionaProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoveProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return $"{_nome}, R$ {Preco.ToString("F2")}, {Quantidade} unidades. Total = R$ {(Quantidade * Preco).ToString("F2")}";
        }
    }
}
