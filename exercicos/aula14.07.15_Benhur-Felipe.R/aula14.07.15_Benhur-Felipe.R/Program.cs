using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula14._07._15_Benhur_Felipe.R
{
    class Program
    {
        static void Main(string[] args)
        {
            
        cachorro fido = new cachorro();
        fido.tamanhoCm = 95;
        fido.SetNome("Fido");
        fido.SetPeso (42.3);

        Console.WriteLine("Nome: {0}", fido.GetNome());
        Console.WriteLine("Peso: {0}", fido.GetPeso());
        Console.WriteLine("Tamanho (m): {0}", fido.tamanhoCm);

        Console.WriteLine("Quantidade diaria de ração: {0}", fido.GetRacaoDiariaKg());
        }
    }
}
