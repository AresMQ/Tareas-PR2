using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Equilatero : Triangulo
    {
        public Equilatero(float tria_base, float lado1, float lado2, float altura, string color) : base(tria_base, lado1, lado2, altura, color)
        { 

        }

        public override double GetArea()
        {
            return base.GetArea();
        }
        public override double GetPerimetro()
        {
            return base.GetPerimetro();
        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un triángulo equilátero de color {GetColor()}, área {GetArea()} y perímetro {GetPerimetro()}");
        }
    }
}