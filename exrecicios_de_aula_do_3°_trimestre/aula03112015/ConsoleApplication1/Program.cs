using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Feito por Benhur e Edson

          int n = int.Parse(Console.ReadLine());

          for (int i = 0; i < n; i++)
          {
              string tipoConta = Console.ReadLine();

              while (tipoConta.ToLower() != "bancaria" && tipoConta.ToLower() != "espeial" && tipoConta.ToLower() != "poupança")
              {
                  Console.WriteLine("Tipo inválido.");
                  tipoConta = Console.ReadLine();
              }

              CriarConta(tipoConta);

              string escolha = "";

              while (escolha.ToLower() != "sair")
              {
                  Console.WriteLine("Escreva 'sacar', 'depositar' ou 'sair'");
                  escolha = Console.ReadLine();

                  if (escolha.ToLower() == "sacar")
                  {
                      string numConta = Console.ReadLine();
                  }
              }
          }
        }

        static void CriarConta(string tipoConta)
        {
            if (tipoConta.ToLower() == "bancaria")
            {
                ContaBancaria conta = new ContaBancaria();
                conta.Cliente = Console.ReadLine();
                conta.Num_conta = Console.ReadLine();
                conta.Saldo = double.Parse(Console.ReadLine());
            }

            else if (tipoConta.ToLower() == "especial")
            {
                ContaEspecial conta = new ContaEspecial();
                conta.Cliente = Console.ReadLine();
                conta.Num_conta = Console.ReadLine();
                conta.Saldo = double.Parse(Console.ReadLine());
                conta.Limite = double.Parse(Console.ReadLine());
            }

            else
            {
                ContaPoupanca conta = new ContaPoupanca();
                conta.Cliente = Console.ReadLine();
                conta.Num_conta = Console.ReadLine();
                conta.Saldo = double.Parse(Console.ReadLine());
                int dia = int.Parse(Console.ReadLine());
                int mes = int.Parse(Console.ReadLine());
                int ano = int.Parse(Console.ReadLine());
                conta.DiaDeRendimento = new DateTime(ano, mes, dia);
            }
        }
    }
}
