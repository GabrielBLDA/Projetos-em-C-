using Projeto_Lista_Pedidos.Entities;
using Projeto_Lista_Pedidos.Entities.Classes;
using Projeto_Lista_Pedidos.Entities.ENUMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Lista_Pedidos
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            try
            {
                Order cClient = new Order();
                //Inicio Cadastro Cliente (escrevendo em ingles para praticar!)
                Console.WriteLine("Enter Client data:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Birth date (DD/MM/YYYY): ");
                DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
                Client client = new Client(name, email, birthDate); // Instaciando as informações do cliente em um objeto da classe Client
                cClient.AddClient(client);
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: {e.Message}");
            }

            //Inicio ORDER
            Console.WriteLine("Enter order data:");
            DateTime dateOrder = DateTime.Now;
            Console.Write("Status (PENDING_PAYMENT, PROCESSING, SHIPPED or DELIVERED): ");
            OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            Order order = new Order(dateOrder, orderStatus);
            Console.WriteLine("How many items to this order?");
            int resp = Convert.ToInt32(Console.ReadLine());

            //Inicio Cadastro de itens
            for (int i = 0; i < resp; i++)
            {
                Console.WriteLine($"Enter {i} item data: ");
                Console.Write("Product Name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product Price: ");
                double priceProduct = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantityProduct = Convert.ToInt32(Console.ReadLine());

                OrderItem items = new OrderItem(quantityProduct, priceProduct);//Adicionando PRODUTOS na lista de Pedidos ORDER -> ORDERITEM
                order.AddItem(items);        
                
                Product products = new Product(nameProduct, priceProduct); //Adicionando PRODUTO na lista de produto ORDERITEM -> PRODUCT
                items.SetProduct(products);
            }

            Console.WriteLine(order);
            Console.ReadKey();

        }
    }
}
