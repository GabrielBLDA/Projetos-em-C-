using Projeto_Método_Abstrato.Intities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Método_Abstrato.Intities
{
    internal class PessoaJuridica : Contribuintes
    {
        public int NumeroFuncionarios { get; set;}

        public PessoaJuridica(string nome, double rendaAnual, Posit tipo, int numeroFuncionarios) :base(nome, rendaAnual, tipo) {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double ImpostoPago()
        {
            double totalImposto = 0.0;
            if (NumeroFuncionarios > 10)
            {
                totalImposto = RendaAnual * 0.14;
            }
            else
            {
                totalImposto = RendaAnual * 0.16;
            }

            return totalImposto;
        }
    }
}
