using System;
using System.Collections.Generic;
using System.Globalization;

namespace Funcionários
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());
            List<Funcionarios> list = new List<Funcionarios>();
            Funcionarios a;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionário #" + (i + 1) + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionarios(id, nome, sal));
                Console.WriteLine("---------------------------");

            }

            Console.Write("Id do funcionário que receberá aumento: ");
            int searchid = int.Parse(Console.ReadLine());

            Funcionarios emp = list.Find(x => x.Id == searchid);

            if (emp == null)
            {
                Console.WriteLine("Esse id não existe!");
                Console.WriteLine();

                foreach (Funcionarios obj in list)
                {
                    Console.WriteLine(obj);
                }
            }
            else
            {
                Console.Write("Porcentagem do aumento do salário: ");
                double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.aumentarSalario(perc);
                Console.WriteLine();

                foreach (Funcionarios obj in list)
                {
                    Console.WriteLine(obj);
                }
            }

            
        }
    }
}
