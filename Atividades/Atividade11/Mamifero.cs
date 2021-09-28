using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Mamifero: Animal
    {
        public Mamifero()
        {
            this.Comunicacao();
        }
        protected override void Comunicacao()
        {
            base.Comunicacao();
            Console.WriteLine("Mamíferos: ");
            Console.WriteLine("Não diferente dos outros animais, os mamíferos se comunicam através de sons ou gestos.\n");
        }
    }
}
