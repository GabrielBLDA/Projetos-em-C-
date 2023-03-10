using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LINQ___Manipulação_de_arquivos.Entities
{
    internal class Funcionarios
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Funcionarios(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
