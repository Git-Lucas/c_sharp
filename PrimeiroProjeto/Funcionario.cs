using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto {
    class Funcionario {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario (int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AtualizaSalario(double porcentagem) {
            Salario *= (1 + (porcentagem / 100));
        }

        public override string ToString() {
            return $"({Id}), {Nome}, R${Salario.ToString("F2")}";
        }
    }
}
