using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeroDeCarros = int.Parse(Console.ReadLine());
            var carros = new Carro[numeroDeCarros];

            for (var i = 0; i < numeroDeCarros; i++)
            {
                var carro = new Carro();
                carro.ID = i + 1;
                Console.WriteLine("Carro {0}:", i+1);

                Console.Write("Modelo: ");
                carro.Modelo = Console.ReadLine();

                Console.Write("Marca: ");
                carro.Marca = Console.ReadLine();

                Console.Write("Placa: ");
                carro.Placa = Console.ReadLine();

                Console.Write("Capacidade de passageiros: ");
                carro.CapacidadeDePassageiros = int.Parse(Console.ReadLine());

                carros[i] = carro;
            }

            var espacoRestante = CalculaEspacoRestante(carros);

            while (espacoRestante > 0)
            {
                var entrada = int.Parse(Console.ReadLine());

                if (entrada == -1)
                {
                    break;
                }

                var carro = PegaCarro(entrada, carros);

                if (carro == null)
                {
                    Console.WriteLine("Carro inválido");
                    continue;
                }

                if (CalculaEspacoRestante(carro) > 0)
                {
                    carro.QuantidadeDePassageiros++;
                }
                else
                {
                    Console.WriteLine("Carro {0} lotado", carro.ID);
                }

                espacoRestante = CalculaEspacoRestante(carros);
            }

            for (var i = 0; i < carros.Length; i++)
            {
                var carro = carros[i];
                Console.WriteLine("Carro {0}: {1} - {2} ({3})", carro.ID, carro.Modelo, carro.Marca, carro.Placa);
                Console.WriteLine("Passageiros: {0}", carro.QuantidadeDePassageiros);

                if (carro.CapacidadeDePassageiros - carro.QuantidadeDePassageiros > 0)
                {
                    Console.WriteLine("Vagas restantes: {0}", carro.CapacidadeDePassageiros - carro.QuantidadeDePassageiros);
                }
                else
                {
                    Console.WriteLine("Carro lotado");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static int CalculaEspacoRestante(Carro[] carros)
        {
            var espacoRestante = 0;

            for (var i = 0; i < carros.Length; i++)
            {
                espacoRestante += carros[i].CapacidadeDePassageiros - carros[i].QuantidadeDePassageiros;
            }

            return espacoRestante;
        }

        static int CalculaEspacoRestante(Carro carro)
        {
            return carro.CapacidadeDePassageiros - carro.QuantidadeDePassageiros;
        }

        static Carro PegaCarro(int ID, Carro[] carros)
        {
            for (var i = 0; i < carros.Length; i++)
            {
                if (carros[i].ID == ID)
                {
                    return carros[i];
                }
            }

            return null;
        }
    }
}
