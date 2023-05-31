using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empregados> list = new List<Empregados>();

            Empregados empregados;

            Console.Write("How many employees will be registered? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++) 
            {
                Console.WriteLine();
                Console.WriteLine($"Emplyoee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Empregados(id, nome, salario));
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());
            Empregados emp = list.Find(x => x.Id == searchId);
            if (emp != null) 
            {
                Console.Write("Enter the percentage: ");
                double porcentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.aumentoSalario(porcentual);
            } 
            else
            {
                Console.WriteLine("This id does not exist!");
            }


            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");

            foreach (Empregados obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}