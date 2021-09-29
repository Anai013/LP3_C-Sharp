using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
{
    class Retangulo : Forma
    {
        private double altura;
        private double largura;

        public Retangulo(double altura, double largura)
        {
            Console.WriteLine("\n**********Retangulo**********");
            base.setCor("Vermelho");
            this.altura = altura;
            this.largura = largura;
            Console.WriteLine("Area do 1° Retangulo: " + this.calcularArea() + "\n");
        }

        public Retangulo(double altura, double largura, string cor)
        {
            base.setCor(cor);
            this.altura = altura;
            this.largura = largura;
            Console.WriteLine("Area do 2° Retangulo: " + this.calcularArea());
        }

        public override double calcularArea()
        {
            return altura * largura;    
        }
    }
}
