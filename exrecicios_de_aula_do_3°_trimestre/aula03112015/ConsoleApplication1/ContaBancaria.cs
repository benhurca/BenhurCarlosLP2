using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ContaBancaria
    {
        public string Cliente { get; set; }
        public string Num_conta { get; set; }
        public double Saldo { get; set; }

        public string Sacar(double saque)
        {
            if (saque >= 0)
            {
                if (Saldo - saque >= 0)
                {
                    Saldo -= saque;
                    return "O saque de R$" + saque + " foi realizado com sucesso.";
                }
            }
            return "Saque inválido.";
        }

        public string depositar(double deposito)
        {
            if (deposito >= 0)
            {
                Saldo += deposito;
                return "O depósito de R$" + deposito + " foi realizado com sucesso.";
            }
            return "Depósito inválido.";
        }
        public string Tranferencia(double valor, ContaBancaria conta)
        {
            if (Saldo > 0)
            {
                if (Saldo > 0 && Saldo >= valor)
                {
                    Saldo -= valor;
                    conta.Saldo += valor;
                    return "A transferência de R$" + valor + " foi realizado com sucesso.";
                }
            }
            return "Transferência inválida.";
        }
    }
}
