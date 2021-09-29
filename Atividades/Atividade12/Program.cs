using System;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo c1 = new Circulo(5.5);
            Circulo c2 = new Circulo(5.5, "Marrom");

            Quadrado q1 = new Quadrado(15.0);
            Quadrado qq2 = new Quadrado(10.0, "Branco");

            Retangulo r1 = new Retangulo(6.0, 11.5);
            Retangulo r2 = new Retangulo(2.0, 4.0, "Amarelo");

            Triangulo t1 = new Triangulo(5.0, 6.5);
            Triangulo t2 = new Triangulo(10.0, 15.5, "Verde");

        }
    }
}
