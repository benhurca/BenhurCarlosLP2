using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace exercicio13BENHUR
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            int vc = 0;
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            conn.Open();

            while (op != 1 && op != 2)
            {
                Console.Write("Cadastro e consulta de pessoas: Digite 1 para CADASTRAR e Digite 2 caso queira CONSULTAR: ");
                op = int.Parse(Console.ReadLine());
                Pessoa x = new Pessoa();

                if (op == 1)
                {
                    Console.Write("Nome: ");
                    x.nome = Console.ReadLine();
                    Console.Write("Sobrenome: ");
                    x.sobrenome = Console.ReadLine();
                    Console.Write("Peso: ");
                    x.peso = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    x.altura = double.Parse(Console.ReadLine());
                    Console.Write("Telefone: ");
                    x.telefone = Console.ReadLine();

                    Console.WriteLine("Seu Cadastro foi feito.");
                    string q = string.Format(new CultureInfo("en"), "INSERT INTO Pessoa(nome,sobrenome,peso,altura,telefone) VALUES('{0}','{1}',{2},{3},'{4}')", x.nome, x.sobrenome, x.peso, x.altura, x.telefone);
                    command.CommandText = q;
                    command.ExecuteNonQuery();
                    op = 0;
                }
                else if (op == 2)
                {
                    int opconsulta = 0;
                    string consultani;

                    string i = String.Format("SELECT * from pessoa");
                    command.CommandText = i;
                    MySqlDataReader reader = command.ExecuteReader();


                    while (opconsulta != 1 && opconsulta != 2)
                    {
                        Console.Write("Digite 1 para consultar por NOME ou 2 para consultar por ID: ");
                        opconsulta = int.Parse(Console.ReadLine());
                       
                        if (opconsulta == 2)
                        {
                            Console.Write("Escolha o id a consultar: ");
                            consultani = Console.ReadLine();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (reader.GetInt32(0) == Convert.ToInt32(consultani))
                                    {
                                        Console.WriteLine("ID: {0}, Nome: {1}, Sobrenome: {2}, Peso: {3}, Altura: {4}, Telefone: {5}",
                                        reader.GetInt32(0),
                                        reader.GetString(1),
                                        reader.GetString(2),
                                        reader.GetDouble(3),
                                        reader.GetDouble(4),
                                        reader.GetString(5));
                                        vc++;
                                    }
                                }
                                if (vc == 0)
                                {
                                    Console.WriteLine("Não existe nenhum registro do id digitado.");
                                }
                            }
                        }
                        else if (opconsulta == 1)
                        {
                            Console.Write("Escolha o NOME a consultar: ");
                            consultani = Console.ReadLine();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (reader.GetString(1) == consultani)
                                    {
                                        Console.WriteLine("\nID: {0}, Nome: {1}, Sobrenome: {2}",
                                        reader.GetInt32(0),
                                        reader.GetString(1),
                                        reader.GetString(2));
                                        vc++;

                                    }
                                }
                                if (vc == 0)
                                {
                                    Console.WriteLine("Não existe nenhum registro do nome digitado.");
                                }
                            }
                        }
                       
                    }

                    reader.Close();
                    op = 0;
                }
               
                else
                {
                    Console.WriteLine("número invalido digite outro. Digite 1 para cadastrar ou digite 2 para consultar.");
                }

                vc = 0;
            }
        }
    }
}
