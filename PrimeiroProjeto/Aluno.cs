using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto {
    class Aluno {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }

        public override string ToString() {
            if (NotaFinal() > 60.0)
                return $"\nNOTA FINAL = {NotaFinal().ToString("F2")}\nAPROVADO";
            else
                return $"\nNOTA FINAL = {NotaFinal()}\nREPROVADO\nFALTARAM {(60 - NotaFinal()).ToString("F2")} PONTOS";
        }
    }
}
