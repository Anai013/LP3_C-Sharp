using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Gato : Mamifero
    {
        public Gato()
        {
            // this.Comunicacao();
        }
        protected override void Comunicacao()
        {
            base.Comunicacao();
            Console.WriteLine("Os miados são a marca registrada dos gatos. Mas, os gatos também se comunicam por seus movimentos, como o balançar do rabo e o ato de se esfregar nas pernas dos donos. \n\n");
        }
    }
}
