using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Jacare : Reptil
    {
        public Jacare()
        {
            // this.Comunicacao();
        }

        protected override void Comunicacao()
        {
            base.Comunicacao();
            Console.WriteLine("Os jacarés se comunicam com tosses, grunhidos e outras vocalizações (termo usado para emissão de voz). \n\n");
        }
    }
    
}
