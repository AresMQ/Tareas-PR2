using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Triangulo : Figura
    {
        private float _base;
        private float _lado1;
        private float _lado2;
        private float _altura;

        public Triangulo(float tria_base, float lado1, float lado2, float altura, string color) : base(color)
        {
            _base = tria_base;
            _lado1 = lado1;
            _lado2 = lado2;
            _altura = altura;
        }
        public override double GetArea()
        {
            return (_base * _altura) / 2;
        }
        public override double GetPerimetro()
        {
            return _base+_lado1+_lado2;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"Soy un triángulo de color {GetColor()}, área {GetArea()} y perímetro {GetPerimetro()}");
        }
    }
}
