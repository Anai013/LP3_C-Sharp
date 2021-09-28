using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Anfibio : Animal
    {
        public Anfibio()
        {
            this.Comunicacao();
        }

        protected override void Comunicacao()
        {
            base.Comunicacao();
            Console.WriteLine("Anfíbios: ");
            Console.WriteLine("A maioria dos anfíbios se comunicam através da vocalização (termo usado para emissão de voz).\n");
        }
    }
}
