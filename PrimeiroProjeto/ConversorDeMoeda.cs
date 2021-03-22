using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto
{
    class ConversorDeMoeda
    {
        static double Iof = 1.06;
        public static double ConverteMoeda(double cotacaoDolar, double dolares)
        {
            return Iof * (cotacaoDolar * dolares);
        }
    }
}
