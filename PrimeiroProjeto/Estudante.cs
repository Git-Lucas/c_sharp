using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto {
    class Estudante {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public int NumQuarto { get; private set; }

        public Estudante (string nome, string email, int numQuarto) {
            Nome = nome;
            Email = email;
            NumQuarto = numQuarto;
        }

        public override string ToString() {
            return $"Quarto {NumQuarto}: {Nome}, {Email}";
        }
    }
}
