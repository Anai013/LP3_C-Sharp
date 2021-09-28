using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Cachorro : Mamifero
    {
        public Cachorro()
        {
            // this.Comunicacao();
        }
        protected override void Comunicacao()
        {
            base.Comunicacao();
            Console.WriteLine("O cachorro se comunica através da linguagem gestual. No entanto, existe também uma forma vocal bem conhecida, os famosos latidos. \n\n");
        }
    }
}