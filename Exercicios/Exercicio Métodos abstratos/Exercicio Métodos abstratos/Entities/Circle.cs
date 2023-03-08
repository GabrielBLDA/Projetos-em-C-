using Exercicio_Métodos_abstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Métodos_abstratos.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double Radios, Color color) : base(color){
            Radius = Radios;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
