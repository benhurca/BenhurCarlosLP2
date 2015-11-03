using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ContaEspecial : ContaBancaria 
    {
        public double Limite { get; set; }

        public override string Sacar(double saque)
        {
            if (saque >= 0)
            {
                if (Saldo - saque >= -Limite)
                {
                    Saldo -= saque;
                    return "O SAQUE DE R$" + saque + " FOI REALIZADO COM SUCESSO.";
                }
            }
            return "SAQUE INVÁLIDO.";
        }
    }
}
