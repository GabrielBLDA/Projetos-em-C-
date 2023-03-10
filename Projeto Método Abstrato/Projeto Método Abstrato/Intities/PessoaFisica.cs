using Projeto_Método_Abstrato.Intities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Método_Abstrato.Intities
{
     class PessoaFisica : Contribuintes
    {
        public double GastoSaude {get; set;}

        public PessoaFisica(double gastoSaude, string nome, double rendaAnual, Posit tipo) : base(nome, rendaAnual, tipo) 
        {
            GastoSaude = gastoSaude;
        }

        public override double ImpostoPago()
        {
            double impostoTotal = 0.0;

            if (GastoSaude >= 0.01)
            {
                if (RendaAnual <= 20000)
                {
                    impostoTotal = (RendaAnual * 0.15) - (GastoSaude * 0.05);
                    
                }
                else if (RendaAnual > 20000)
                {
                    impostoTotal = (RendaAnual * 0.25) - (GastoSaude * 0.05); ;
                }
            }
            else if (GastoSaude == 0)
            {
                if (RendaAnual <= 20000)
                {
                    impostoTotal = (RendaAnual * 0.15);
                }
                else if (RendaAnual > 20000)
                {
                    impostoTotal = (RendaAnual * 0.25);
                }
            }
            else { Console.WriteLine("ERROR"); }

            return impostoTotal;
        }
    }
}
