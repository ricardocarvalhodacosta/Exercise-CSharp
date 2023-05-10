using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorDeMoeda conv = new ConversorDeMoeda();

            Console.Write("Qual a cotação do dólar? ");
            conv.ValorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares você vai comprar? ");
            conv.DolarQuantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em reais = " + conv.ComprarDolar().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
