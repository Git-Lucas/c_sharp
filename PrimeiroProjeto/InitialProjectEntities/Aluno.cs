using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto
{
    class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public override string ToString()
        {
            if (NotaFinal() > 60.0)
                return $"\nNOTA FINAL = {NotaFinal():F2)}\nAPROVADO";
            else
                return $"\nNOTA FINAL = {NotaFinal()}\nREPROVADO\nFALTARAM {(60 - NotaFinal()):F2)} PONTOS";
        }
    }
}
