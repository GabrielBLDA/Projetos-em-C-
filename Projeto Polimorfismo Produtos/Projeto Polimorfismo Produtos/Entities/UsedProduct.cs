using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Polimorfismo.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime Date { get; set; }

        public UsedProduct() { } //Construtor padrao

        public UsedProduct(string name, double price, DateTime date) : base(name, price) //Construtor com sobrecarga + polimorfismo
        {
            Date = date;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price} (Manufacture date: {Date})";
        }
    }
}
