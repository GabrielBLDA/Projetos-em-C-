using Exercicio_Métodos_abstratos.Entities;
using Exercicio_Métodos_abstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Métodos_abstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.WriteLine("Enter the number of shapes: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i + 1} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.WriteLine("Radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine().ToString(),CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();

            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString(),CultureInfo.InvariantCulture);
            }

            Console.ReadKey();
        }
    }
}
