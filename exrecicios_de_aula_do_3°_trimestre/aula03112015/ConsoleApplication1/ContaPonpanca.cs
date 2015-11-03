using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ContaPoupanca : ContaBancaria
    {
        public DateTime DiaDeRendimento { get; set; }

        public void CalcularNovoSaldo(double TaxaRendimento)
        {
            Saldo += (Saldo * TaxaRendimento)/100;
        }
    }
}
