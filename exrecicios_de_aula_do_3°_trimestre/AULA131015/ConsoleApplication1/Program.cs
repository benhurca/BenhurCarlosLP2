using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            Console.Write("Adicionar(1) , consultar dados(2) , sair(3): ");
            int op = int.Parse(Console.ReadLine());
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            conn.Open();

            while (op != 1 && op != 2 && op != 3)
            {
                Console.Write("Escolha 1 , 2 ou 3: ");
                op = int.Parse(Console.ReadLine());

            }
                while (op != 3 && op == 1 || op == 2)
                {
                    if (op == 1)
                    {
                        Pessoa x = new Pessoa();
                        Console.Write("Nome: "); x.nome = Console.ReadLine();
                        Console.Write("Sobrenome: "); x.sobrenome = Console.ReadLine();
                        Console.Write("Peso: "); x.peso = double.Parse(Console.ReadLine());
                        Console.Write("Altura: "); x.altura = double.Parse(Console.ReadLine());
                        Console.Write("Telefone: "); x.telefone = Console.ReadLine();
                        string q = string.Format(new CultureInfo("en"), "INSERT INTO Pessoa(nome,sobrenome,peso,altura,telefone) VALUES('{0}','{1}',{2},{3},'{4}')", x.nome, x.sobrenome, x.peso, x.altura, x.telefone);
                        command.CommandText = q;
                        command.ExecuteNonQuery();
                        pessoas.Add(x);
                        op = 0;
                    }

                    if (op == 2)
                    {
                        string w = String.Format("SELECT * from pessoa");
                        command.CommandText = w;

                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("Nome: {0}", reader.GetString(1));
                            } 
                        }
                        op = 0;
                        reader.Close();
                    }


                    while (op != 1 && op != 2 && op != 3)
                    {
                        Console.Write("Escolha 1 , 2 ou 3: ");
                        op = int.Parse(Console.ReadLine());

                    }
                }




                Console.ReadKey();
            conn.Close();

        }
    }
}


    


    
