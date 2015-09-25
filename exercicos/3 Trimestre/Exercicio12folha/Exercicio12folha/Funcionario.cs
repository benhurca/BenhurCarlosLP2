using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Funcionario
    {
        public string _nome { get; set; }
        public string _cpf { get; set; }
        public string _nascimento { get; set; }
        public string _matricula { get; set; }
        public double _salario { get; set; }
        public double _vale { get; set; }



        public virtual double vale()
        {
            double valea = _salario * 0.08;
            return valea;
        }
    }
}
