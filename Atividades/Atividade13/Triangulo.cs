using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    class Triangulo : IForma
    {
        private double base_triangulo;
        private double altura;

        public Triangulo(double base_triangulo, double altura)
        {
            Console.WriteLine("\n**********Triangulo**********");
            this.base_triangulo = base_triangulo;
            this.altura = altura;
        }

        public double calcularArea()
        {
            return (base_triangulo * altura) / 2;
        }
    }
}
