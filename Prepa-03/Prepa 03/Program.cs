using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura _circulo = new Circulo(2, "negro");
            Rectangulo rectangulo_cuadrado = new Cuadrado(5, "azul");
            Rectangulo rectangulo = new Rectangulo(2,3, "blanco");
            Triangulo tria_isos = new Isosceles(5, 3, 3, 4, "celeste");
            Triangulo tria_esca = new Escaleno(6, 3, 4, 3, "rojo");
            Triangulo tria_equi = new Equilatero(2, 2, 2, 4, "morado");

            Figura figura1 = rectangulo_cuadrado;
            Figura figura2 = rectangulo;
            Figura figura3 = _circulo;
            Figura figura4 = tria_isos;
            Figura figura5 = tria_esca;
            Figura figura6 = tria_equi;

            figura1.MostrarDatos();
            figura2.MostrarDatos();
            figura3.MostrarDatos();
            figura4.MostrarDatos();
            figura5.MostrarDatos();
            figura6.MostrarDatos();


            //Console.WriteLine($" Area {figura3.GetArea()}, Perimetro {figura3.GetPerimetro()}");

            Console.ReadLine();
           
            
        }
    }
}
