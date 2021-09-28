using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Sapo : Anfibio
    {
        public Sapo()
        {
            // this.Comunicacao();
        }
        protected override void Comunicacao()
        {
            base.Comunicacao();
            Console.WriteLine("Os sapos se comunicam por meio do coaxado, ou da vocalização (termo usado para emissão de voz).\n\n");
        }
    }
}
