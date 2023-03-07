using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Lista_Pedidos.Entities
{
    internal class Product
    {
        public string Name { get; set; } //Propriedade para gravar o nome do produto
        public double Price { get; set;} //Propriedade para gravar o preço do produto

        public Product() { } //Metodo Construtor Normal

        public Product(string name, double price) //Metodo Construtor Com SobreCarga
        {
            Name = name;
            Price = price;
        }
    }
}
