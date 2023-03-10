using Projeto_LINQ___Manipulação_de_arquivos.Entities;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Globalization;

namespace Projeto_LINQ___Manipulação_de_arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionarios> list = new List<Funcionarios>(); //Criando a lista de funcionar
            string path = @"C:\Users\DEVELOPER-07\Desktop\Projetos C#\Projeto LINQ + Manipulação de arquivos\funcionarios.txt"; //Criando o caminho até o arquivo


            using (StreamReader sr = File.OpenText(path)) { //comando para ler o arquivo a partir de um caminho (enquanto o sr não terminar de ler o conteudo do arquivo)
                while (!sr.EndOfStream) { //enquanto não terminar de ler
                    string[] rec = sr.ReadLine().Split(','); //Irá estanciar valores para o vetor, apartir de um , exemplo ola,mundo  [0] = ola [1] = mundo
                    string name = rec[0];
                    string email = rec[1];
                    double salary = Convert.ToDouble(rec[2],CultureInfo.InvariantCulture);
                    list.Add(new Funcionarios(name,email, salary));
                }
            }

            Console.WriteLine("Insira um valor de salario: ");
            double resp = Convert.ToDouble(Console.ReadLine());

            var r1 = list.Where(x => x.Salary > resp).OrderBy(x => x.Email).Select(x => x.Email);

            var r2 = list.Where(x => x.Name[0] == 'M').Sum(x => x.Salary);

            Console.WriteLine($"Email das pessoas que possuem um salario acima de {resp}:");
            foreach (string email in r1)
            {
                Console.WriteLine(email);
            }
            Console.WriteLine("Soma dos salarios das pessoas que começam com a letra M: ");
           
            Console.WriteLine(r2);
           
            Console.ReadKey();
        }
    }
}
