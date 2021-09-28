using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Animal
    {
        protected virtual void Comunicacao()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Tipos de Comunicação");
            Console.WriteLine("--------------------------------------");
        }
    }
}
