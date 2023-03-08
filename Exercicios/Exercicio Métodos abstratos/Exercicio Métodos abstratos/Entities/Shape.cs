using Exercicio_Métodos_abstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Métodos_abstratos.Entities
{
    abstract class Shape //para conter um metodo abstract a classe tbm deve ser abstract
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract Double Area(); //Nao tem como eu fazer um calculo em um metodo tão generico, entao ela deve ser abstrata
        
    }
}
