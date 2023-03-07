using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Lista_Pedidos.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; } //Propriedade que grava quantidade de produto
        public double Price { get; set; } //Propriedade que grava o preço do produto
        public Product Product { get; set; } 


        public OrderItem() { } //Metodo Construtor Padrao

        public OrderItem(int quantity, double price) //Metodo Construtor com sobrecarga
        {
            Quantity = quantity;
            Price = price;
        }

        public void SetProduct(Product product)
        {
            Product = product;
        }

        public double SubTotal()
        {
            return Math.Round(Price * Quantity,4);
        }

    }
}
