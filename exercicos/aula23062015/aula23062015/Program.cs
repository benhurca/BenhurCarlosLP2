﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula23062015
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Solucao1();
            Solucao2();

            Console.ReadKey();
        }

        static void Solucao2()
        {
            var numeroDeFuncionarios = int.Parse(Console.ReadLine());
            var funcionarios = new Funcionario[numeroDeFuncionarios];

            for (var i = 0; i < funcionarios.Length; i++)
            {
                funcionarios[i] = new Funcionario
                {
                    CPF = Console.ReadLine(),
                    Nome = Console.ReadLine(),
                    Nascimento = DateTime.Parse(Console.ReadLine()),
                    Admissao = DateTime.Parse(Console.ReadLine()),
                    Salario = decimal.Parse(Console.ReadLine())
                };
            }

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine("Nome: {0}", funcionario.Nome);
                Console.WriteLine("CPF: {0}", funcionario.CPF);
                Console.WriteLine("Nascimento: {0}", funcionario.Nascimento.ToShortDateString());
                Console.WriteLine("Admissao: {0}", funcionario.Admissao.ToShortDateString());
                Console.WriteLine("Salario atual: {0}", funcionario.Salario);
                Console.WriteLine("Novo salario: {0}", funcionario.CalculaNovoSalario());
            }
        }

        static void Solucao1()
        {
            Console.WriteLine("digite o numero de funcionarios :");
            int workersinfo = int.Parse(Console.ReadLine());
            int[] cpf = new int[workersinfo];
            int[] borndate = new int[workersinfo];
            int[] entrydate = new int[workersinfo];
            double[] salary = new double[workersinfo];
            double[] Newsalary = new double[workersinfo];
            string[] name = new string[workersinfo];

            for (int i = 0; i < workersinfo; i++)
            {
                Console.WriteLine("digite o nome do funcionario :");
                name[i] = Console.ReadLine();
                Console.WriteLine("digite o cpf do funcionario :");
                cpf[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("digite a data de nascimento do funcionario :");
                borndate[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("digite a data de entrada do funcionario na firma :");
                entrydate[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o salario do funcionario :");
                salary[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                if (entrydate[i] >= 2014)
                {
                    Newsalary[i] = salary[i] + 423.45;
                }
                else if (entrydate[i] >= 2010 && entrydate[i] <= 2013)
                {
                    Newsalary[i] = salary[i] + (salary[i] * 9.84 / 100);
                }
                else if (entrydate[i] >= 2000 && entrydate[i] <= 2010)
                {
                    Newsalary[i] = salary[i] + (salary[i] * 16.4 / 100);
                }
                else if (entrydate[i] < 2000)
                {
                    Newsalary[i] = salary[i] + (salary[i] * 22.6 / 100);
                }
            }

            for (int i = 0; i < workersinfo; i++)
            {
                Console.WriteLine("CPF: " + cpf[i]);
                Console.WriteLine("Nome: " + name[i]);
                Console.WriteLine("Nasc: " + borndate[i]);
                Console.WriteLine("Admins: " + entrydate[i]);
                Console.WriteLine("Salario Atual: " + salary[i]);
                Console.WriteLine("Novo Salario: " + Newsalary[i]);


            }
        }
    }
}
