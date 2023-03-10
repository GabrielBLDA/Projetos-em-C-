using Projeto_Método_Abstrato.Intities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Método_Abstrato.Intities
{
    abstract class Contribuintes // -> mudar para abstract tambem (OBRIGATÓRIO)
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Posit Tipo { get; set; }

        public Contribuintes() { }

        public Contribuintes(string nome, double rendaAnual, Posit tipo)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
            Tipo = tipo;
        }

        public abstract double ImpostoPago(); //abstract pois o Método é generico 
        
    }
}
