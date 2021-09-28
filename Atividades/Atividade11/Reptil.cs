using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Reptil : Animal
    {
        public Reptil()
        {
            this.Comunicacao();
        }

        protected override void Comunicacao()
        {
            base.Comunicacao();
            Console.WriteLine("Répteis: ");
            Console.WriteLine("Os répteis geralmente tendem a se comunicar por meio da emissão de sonidos, tais como grunhidos e bramidos, ainda, outros optam pela comunicação através de movimentos realizados com o corpo.\n");
        }
    }
}
