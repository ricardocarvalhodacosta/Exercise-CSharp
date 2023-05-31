using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public bool Resultado ()
        {
            if (NotaFinal() >= 60)
            {
                return true;

            } else
            {
                return false;
            }
        }

        public double NotaRestante ()
        {
            if (Resultado())
            {
                return 0.0;
            } else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}
