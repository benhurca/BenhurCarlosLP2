using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {


            string tipofuncionario;
            Console.WriteLine("numero de funcionarios: ");
            int funcionariosnumero = int.Parse(Console.ReadLine());
            Terceirizado terceirizado = new Terceirizado();
            Trabalhador trabalhador = new Trabalhador();
            Gerente gerente = new Gerente();
            List<Terceirizado> terceirizados = new List<Terceirizado>();
            List<Trabalhador> trabalhadores = new List<Trabalhador>();
            List<Gerente> gerentes = new List<Gerente>();
            double folhaempresa = 0;

            for (int i = 0; i < funcionariosnumero; i++)
            {
                Console.Write("1 = trabalhador 2 = gerente 3 = terceirizado: ");
                tipofuncionario = Console.ReadLine();
                Console.WriteLine();

                if (tipofuncionario == "1")
                {
                    Console.WriteLine("informe o nome:");
                    trabalhador._nome = Console.ReadLine();
                    Console.WriteLine("informe o CPF:");
                    trabalhador._cpf = Console.ReadLine();
                    Console.WriteLine("informe  a data de nascimento:");
                    trabalhador._nascimento = Console.ReadLine();
                    Console.WriteLine("informe a matricula:");
                    trabalhador._matricula = Console.ReadLine();
                    Console.WriteLine("informe o salário:");
                    trabalhador._salario = int.Parse(Console.ReadLine());
                    trabalhador._vale = trabalhador.vale();
                    trabalhadores.Add(trabalhador);
                    folhaempresa += trabalhador._salario + trabalhador._vale;
                }

                else if (tipofuncionario == "2")
                {
                    Console.WriteLine("informe o nome:");
                    gerente._nome = Console.ReadLine();
                    Console.WriteLine("informe o CPF:");
                    gerente._cpf = Console.ReadLine();
                    Console.WriteLine("informe  a data de nascimento:");
                    gerente._nascimento = Console.ReadLine();
                    Console.WriteLine("informe a matricula:");
                    gerente.AreaAtuacao = Console.ReadLine();
                    Console.WriteLine("informe o salário:");
                    gerente._salario = int.Parse(Console.ReadLine());
                    gerente._vale = gerente.vale();
                    gerentes.Add(gerente);
                    folhaempresa += gerente._salario + gerente._vale;
                }
                else if (tipofuncionario == "3")
                {
                    Console.WriteLine("informe o nome:");
                    terceirizado._nome = Console.ReadLine();
                    Console.WriteLine("informe o CPF:");
                    terceirizado._cpf = Console.ReadLine();
                    Console.WriteLine("informe  a data de nascimento:");
                    terceirizado._nascimento = Console.ReadLine();
                    Console.WriteLine("informe a matricula:");
                    terceirizado._matricula = Console.ReadLine();
                    Console.WriteLine("informe o cnpj:");
                    terceirizado._cnpj = Console.ReadLine();
                    Console.WriteLine("informe o salário:");
                    terceirizado._salario = int.Parse(Console.ReadLine());
                    terceirizados.Add(terceirizado);
                    folhaempresa += terceirizado._salario;
                }
            }

            Console.WriteLine("folha da empresa: " + folhaempresa);

            Console.ReadKey();
        }
    }
}
