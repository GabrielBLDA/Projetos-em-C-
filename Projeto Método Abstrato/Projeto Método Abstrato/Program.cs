using Projeto_Método_Abstrato.Intities;
using Projeto_Método_Abstrato.Intities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Método_Abstrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contribuintes> list = new List<Contribuintes>(); //Lista

            Console.Write("Enter the number of tax payers: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Tax Player #1 data:");
                Console.Write("Individual or company (i/c)? ");
                Posit level = (Posit)Enum.Parse(typeof(Posit), Console.ReadLine());
                char ch = Convert.ToChar(level);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double ganhoAnual = Convert.ToDouble(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double he = Convert.ToDouble(Console.ReadLine());
                    list.Add(new PessoaFisica(he, name, ganhoAnual, level));
                }
                else if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int ne = Convert.ToInt32(Console.ReadLine());
                    list.Add(new PessoaJuridica(name, ganhoAnual, level, ne));
                }
            }

            foreach (Contribuintes pessoa in list)
            {
                Console.WriteLine($"{pessoa.Nome}: {pessoa.ImpostoPago()}");
            }

            Console.ReadKey();
        }
    }
}
