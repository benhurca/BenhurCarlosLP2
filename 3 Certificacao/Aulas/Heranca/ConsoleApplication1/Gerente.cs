using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Gerente:Funcionario
    {
        public string AreaGerenciada { get; set; }
        public double Adicional { get; set; }

        public double STotal()
        {
            return Salario + Adicional;
        }
        
    }
}
