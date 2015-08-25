using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula25_08_15
{
    class Atleta
    {
        public string Nome { get; set; }
        public string Nomes { get; set; }
        public int TempoCs { get; set; }
         public string TempoFormat
        {
            get
            {
               return String.Format ("{0}:{1}:{2}", TempoCs/6000,(TempoCs%6000)/100,(TempoCs%6000)%100);
               
            }
        }

    }
}
