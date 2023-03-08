using Exercicio_Polimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Polimorfismo_Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of product: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char op = Convert.ToChar(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                switch (op)
                {
                    case 'c':
                        list.Add(new Product { Name = name, Price = price });
                        break;

                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime date = Convert.ToDateTime(Console.ReadLine());
                        list.Add(new UsedProduct { Name = name, Price = price, Date = date });
                        break;

                    case 'i':
                        Console.Write("Custom fee: ");
                        double cf = Convert.ToDouble(Console.ReadLine());
                        list.Add(new ImportedProduct { Name = name, Price = price, CustomFee = cf });
                        break;
                }
            }

            Console.WriteLine();
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }

            Console.ReadKey();

        }
    }
}
