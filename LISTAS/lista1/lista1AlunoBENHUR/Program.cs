using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace lista1AlunoBENHUR
    
{
    class Program
    {
           // ~~~~~~~~~~      exercício 1     ~~~~~~~~~~

  static void Main (string[ ] args)
{
}

static void exercicio1( )
{
  int n = 0;
  int fatorial = 1;
  Console.WriteLine("Digite o número :"); 
  n = int.Parse(Console.ReadLine( ) );
  for (int i = n; i > 0; i --)
{
     fatorial *= i;
}
Console.WriteLine(" O fatorial de {0} é: {1}");
}

//~~~~~~~~~~     exercício 2     ~~~~~~~~~~

static void exercício2( )
{
   int fator = 1;
   int n = 0;
   Console.WriteLine("Digite o número");
   n = int.Parse (Console.ReadLine ( ) );
   for (int i = 1; i <= n; i++)
{
   if(i % 2 == 0)
{ 
  Console.Write (" -{0} / {1} ", i, fator);
}
  else 
{
  Console.Write("  {0} / {1}  ", i, fator);
} 
  fator = fator *2+1;
  }
}

//~~~~~~~~~     exercício 3     ~~~~~~~~~~

static void  exercicio3( )
{ 
   int num = 1;
   Console.WriteLine("Digite o número de funcionários: ");
   int n = int.Parse(Console.ReadLine ( ) );
   if (n > 0 )
{
   string[ ] funcionario = new string[n];
   int [ ] salario = new int [n];
   for (int i = 0; i < n; i++)
{
   Console.WriteLine("Digite o nome do funcionario : {0}", num);
    funcionario[i] = Console.ReadLine();
   num ++;
   }
   for ( int j = 0; j < n; j ++)
   {
   Console.Write("Funcionário {0}" , funcionario [j] );
   Console.WriteLine( "O salário atual é de {0}", salario [j]);
   if (salario [j]<3000)
   {
   salario [j] = salario [j] + salario [j]/4;
   Console.WriteLine(" O Salário com ajuste d@ {0} será de : {1}", funcionario [j], salario [j]);
    Console.WriteLine( );
}
    else if ( salario [j] > 2999 && salario [j] < 4000)
{
    salario [j] = salario [j] + salario [j] / 5;
    }
  } 
}

//~~~~~~~~~~     exercício 5     ~~~~~~~~~~

static void exercio5( ) 

{
double distancia = 600;
double litros = 50;
double percurso = 0;
double litrosconsumidos = 0;
     while (distancia > percurso)  
{
  Console.WriteLine("Digite a distância que foi percorrida do começo do trajeto até agora:");
  percurso + (double.Parse(Console.Readline());
litrosconsumidos +-(double.Parse(Console.ReadLine());
if ( litrosconsumidos > litros)
{
  Console.WriteLine(" O carro parou antes de chegar ao destino.");
  percurso = 601;
  }
}
if ( litrosconsumidos <= litros)
{
Console.WriteLine(" O carro chegou ao seu destino. ");
  }
}


//~~~~~~~~~~     exercício 6      ~~~~~~~~~~

static void exercicio6() 
{

SortedList m = new SortedList();
String nome = "";
int cm = 0;

int pmaioraltura = 0;

int smaioraltura = 0;

int mocas = 0;

while ( nome != "FIM")
{
Console.Write(" nome : ");
nome = Console.ReadLine( );
}
if (nome != "FIM")
{
Console.Write ("Altura em cm :");
cm = int.Parse (Console.ReadLine ( ) );

m.add (nome, cm);
}
foreach (DictionaryEntry valor m)

{
Console.WriteLine("nome = {0}, altura = {1}", valor.key, valor.Value);

if (pmaioraltura == 0)
{
pmaioraltura = (int) valor.Value;
}
else if (smaioraltura == 0)
{
smaioraltura = (int) valor.Value;
}

else if ((int) valor.Value >= pmaioraltura && smaioraltura < pmaioraltura)
{
smaioraltura = pmaioraltura;
}
else if ( ( int) valor.Value >= pmaioraltura)
{
pmaioraltura = (int) valor.Value;
}
else if ( ( int) valor.Value >= smaioraltura)
{
smaioraltura = (int) valor.Value;
   }
}


        }
    }
}
