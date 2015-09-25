using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Gerente : Funcionario
    {


        public string AreaAtuacao { get; set; }



        public override double vale()
        {
            double valeal = _salario * (6.5 / 100);
            return valeal;

        }
    }
}