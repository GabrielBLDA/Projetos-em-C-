using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Polimorfismo.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }


        public Product() { } //Metodo construtor comum

        public Product(string name, double price) //Metodo Construtor com sobrecarga 
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag() //Virtual permite que metodos herdados sejam alterados
        {
            return $"{Name} $ {Price}";
        }

    }
}
