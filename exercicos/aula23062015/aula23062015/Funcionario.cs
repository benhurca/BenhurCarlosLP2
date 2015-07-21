using System;
using System.Runtime.InteropServices.ComTypes;

namespace aula23062015
{
    public class Funcionario
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime Admissao { get; set; }
        public decimal Salario { get; set; }

        public decimal CalculaNovoSalario()
        {
            var anoAdmisissao = Admissao.Year;

            if (anoAdmisissao >= 2014)
            {
                return Salario + 423.45m;
            }

            if (anoAdmisissao >= 2010 && anoAdmisissao <= 2013)
            {
                return Salario + (Salario * 9.84m / 100);
            }

            if (anoAdmisissao >= 2000 && anoAdmisissao <= 2010)
            {
                return Salario + (Salario * 16.4m / 100);
            }

            if (anoAdmisissao < 2000)
            {
                return Salario + (Salario * 22.6m / 100);
            }

            return Salario;
        }
    }
}