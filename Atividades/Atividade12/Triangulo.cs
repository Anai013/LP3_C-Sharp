using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
{
    class Triangulo : Forma
    {
        private double Base;
        private double altura;

        public Triangulo(double Base, double altura)
        {
            Console.WriteLine("\n**********Triangulo**********");
            base.setCor("Rosa");
            this.Base = Base;
            this.altura = altura;
            Console.WriteLine("Area do 1° Triangulo: " + this.calcularArea() + "\n");
        }

        public Triangulo(double Base, double altura, string cor)
        {
            base.setCor(cor);
            this.Base = Base;
            this.altura = altura;
            Console.WriteLine("Area do 2° Triangulo: " + this.calcularArea());
        }

        public override double calcularArea()
        {
            return (Base * altura) / 2;
        }
    }
}
