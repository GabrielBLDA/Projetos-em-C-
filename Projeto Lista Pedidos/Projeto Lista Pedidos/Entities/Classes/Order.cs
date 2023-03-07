using Projeto_Lista_Pedidos.Entities.ENUMS;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Lista_Pedidos.Entities.Classes
{
    internal class Order
    {
        public DateTime Date { get; set; } //Propriedade que verificará o momento em que foi feito o pedido
        public OrderStatus Status { get; set;} //Propriedade que verificará as condições dos items
        public List<OrderItem> Items { get; set; } = new List<OrderItem>(); //lista dos items
        public List<Client> Clients { get; set; } = new List<Client>(); //Lista Cliente

        public Order() { } // Construtor padrão

        public Order(DateTime date, OrderStatus status) //Construtor com sobrecarga 
        {
            Date = date;
            Status = status;
        }

        public void AddClient(Client client)
        {
            Clients.Add(client);
        }

        public void AddItem(OrderItem item) //Metodo para adicionar items na lista de items
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) //Metodo para remover items da lista de itens
        {
            Items.Remove(item);
        }


        public double Total() {
            double total = 0.0;
            foreach (OrderItem product in Items)
            {
                total += product.Price;
            }
            return Math.Round(total,4);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order Moment: {Date}");
            sb.AppendLine($"Order Status: {Status}");
            foreach (Client c in Clients)
            {
                sb.Append(c.Name);
                sb.Append(c.BirthDate);
                sb.Append(" - ");
                sb.Append(c.Email);
            }
            sb.AppendLine("Order items:");
            foreach (OrderItem ci in Items)
            {
                sb.Append($"{ci.Product.Name}, ");
                sb.Append($"${ci.Price}, ");
                sb.Append($"Quantity: {ci.Quantity}, ");
                sb.Append($"Subtotal: ${ci.SubTotal()} ");
                sb.AppendLine();             
            }
            sb.AppendLine($"Total Price: ${Total()}");
            return sb.ToString();
        }
    }
}
