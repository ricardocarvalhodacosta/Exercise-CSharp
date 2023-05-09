using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Digite o nome do Funcionário: ");
            func.Nome = Console.ReadLine();
            Console.WriteLine("Qual o valor do Salário Bruto dele?");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Digite o Imposto Salarial: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + func) ;
            Console.WriteLine();

            Console.Write("Digite a Porcentagem para aumentar o Salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);

            Console.WriteLine("Dados Atualizados: " + func);
            Console.ReadLine();
        }
    }
}
