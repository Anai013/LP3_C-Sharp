using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
{
    class Quadrado : Forma
    {
        private double lado;

        public Quadrado(double lado)
        {
            Console.WriteLine("\n**********Quadrado**********");
            base.setCor("Azul");
            this.lado = lado;
            Console.WriteLine("Area do 1° Quadrado: " + this.calcularArea() + "\n");
        }

        public Quadrado(double lado, string cor)
        {
            base.setCor(cor);
            this.lado = lado;
            Console.WriteLine("Area do 2° Quadrado: " + this.calcularArea());
        }

        public override double calcularArea()
        {
            return lado * lado;
        }
    }
}
