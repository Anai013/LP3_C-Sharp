using System;

namespace Aula13
{
    class Program
    {
        static void mostrarArea(IForma forma)
        {
            Console.WriteLine("Área a forma: " + forma.calcularArea());
        }

        static void Main(string[] args)
        {
            IForma forma = new Quadrado(10.0);
            mostrarArea(forma);

            forma = new Retangulo(5.0, 7.5);
            mostrarArea(forma);

            forma = new Triangulo(10.0, 15.5);
            mostrarArea(forma);

            forma = new Circulo(13.0);
            mostrarArea(forma);
        }
    }
}
