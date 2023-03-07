using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Lista_Pedidos.Entities.Classes
{
    internal class Client
    {
        public string Name{ get; set;} //Propriedade para gravar o nome do CLIENTE
        public string Email { get; set; } //Propriedade para gravar o email do CLIENTE
        public DateTime BirthDate { get; set; } //Propriedade para gravar o aniversario do CLIENTE


        public Client() { } //Metodo Construtor Comum

        public Client(string name, string email, DateTime birthDate) //Metodo Construtor com sobrecarga
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
