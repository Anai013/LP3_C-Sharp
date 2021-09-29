using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
{
    class Circulo : Forma
    {
        private double raio;

        public Circulo(double raio)
        {
            Console.WriteLine("**********Circulo**********");
            base.setCor("Roxo");
            this.raio = raio;
            Console.WriteLine("Area do 1° Circulo: " + this.calcularArea()+"\n");
        }

        public Circulo(double raio, string cor)
        {
            base.setCor(cor);
            this.raio = raio;
            Console.WriteLine("Area do 2° Circulo: " + this.calcularArea());
        }

        public override double calcularArea()
        {
            return 3.14 * (raio * raio);
        }

    }
}
