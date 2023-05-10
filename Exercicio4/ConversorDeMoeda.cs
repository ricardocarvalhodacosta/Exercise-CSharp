using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class ConversorDeMoeda
    {
        public double ValorDolar;
        public double DolarQuantidade;

        public double ComprarDolar ()
        {
            double Iof = (DolarQuantidade * 6) / 100;
            return ValorDolar * (DolarQuantidade + Iof);
        }
    }
}
