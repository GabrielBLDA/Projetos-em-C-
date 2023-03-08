using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercicio_Polimorfismo.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }


        public ImportedProduct() { } //Metodo construtor padrao

        public ImportedProduct(string name, double price, double customFee) : base(name, price) //Metodo costrutor com sobrecarga + Polimorfismo
        {
            CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {totalPrice()} (Customs fee: ${CustomFee})";
        }

        public double totalPrice()
        {
            return Price + CustomFee;
        }

    }
}
