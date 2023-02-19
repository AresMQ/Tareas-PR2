using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Cuadrado: Rectangulo
    {
        public Cuadrado(float lado, string color) : base (lado, lado, color)
        {
          
        }
        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un cuadrado de color {GetColor()}, área {GetArea()}, perímetro {GetPerimetro()}");
        }
    }
}
