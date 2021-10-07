﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    class Circulo : IForma
    {
        private double raio;

        public Circulo(double raio)
        {
            Console.WriteLine("\n**********Circulo**********");
            this.raio = raio;
        }

        public double calcularArea()
        {
            return 3.14 * (Math.Pow(raio, 2));
        }
    }
}
