using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Interface.Entities
{
    internal class Contract
    {
        public int NumeroContrato { get; set; }
        public DateTime DataContrato { get; set;}
        public double ValorContrato { get; set;}
        public List<Installment> Installments { get; set; }

        public Contract(int numeroContrato, DateTime dataContrato, double valorContrato)
        {
            NumeroContrato = numeroContrato;
            DataContrato = dataContrato;
            ValorContrato = valorContrato;
            Installments = new List<Installment>();
        }


    }
}
