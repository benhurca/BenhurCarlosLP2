using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio10
{
    public partial class Form1 : Form
    {
        private List<Carro> _carros;
        public Form1()
        {
            InitializeComponent();
            _carros = new List<Carro>();
        }

        private void Registar_Botao_Click(object sender, EventArgs e)
        {
            var erros = "";

            if (Modelo_Box.Text == "")
            {
                erros += "Valor para modelo não pode ser vazio!\n";
            }
            if (Placa_Box.Text == "")
            {
                erros += "Valor para placa não pode ser vazio!\n";
            }
            if (Marca_Box.Text == "")
            {
                erros += "Valor para marca não pode ser vazio!\n";
            }

            if (Ano_Box.Text != "")
            {
                try
                {
                    int.Parse(Ano_Box.Text);
                }
                catch
                {
                    erros += "Ano precisa ser um número inteiro!\n";
                }
            }
            else
            {
                erros += "Valor para ano não pode ser vazio!\n";
            }

            if (Kilometragem_Box.Text != "")
            {
                try
                {
                    float.Parse(Kilometragem_Box.Text);
                }
                catch
                {
                    erros += "Kilometragem precisa ser um número!\n";
                }
            }
            else
            {
                erros += "Valor para kilometragem não pode ser vazio!\n";
            }

            if (Capacidade_Box.Text != "")
            {
                try
                {
                    float.Parse(Capacidade_Box.Text);
                }
                catch
                {
                    erros += "Capacidade precisa ser um número!\n";
                }
            }
            else
            {
                erros += "Valor para capacidade não pode ser vazio!\n";
            }

            if (Potencia_Box.Text != "")
            {
                try
                {
                    float.Parse(Potencia_Box.Text);
                }
                catch
                {
                    erros += "Potência precisa ser um número!\n";
                }
            }
            else
            {
                erros += "Valor para potência não pode ser vazio!\n";
            }

            if (erros != "")
            {
                MessageBox.Show(erros);
                return;
            }

            _carros.Add(new Carro
            {
                Modelo = Modelo_Box.Text,
                Placa = Placa_Box.Text,
                Marca = Marca_Box.Text,
                Ano = int.Parse(Ano_Box.Text),
                Kilometragem = float.Parse(Kilometragem_Box.Text),
                CapacidadeCombustivel = float.Parse(Capacidade_Box.Text),
                Potencia = float.Parse(Potencia_Box.Text)
            });

            Modelo_Box.Clear();
            Placa_Box.Clear();
            Marca_Box.Clear();
            Ano_Box.Clear();
            Kilometragem_Box.Clear();
            Capacidade_Box.Clear();
            Potencia_Box.Clear();
        }

        private void Pesquisar_Botao_Click(object sender, EventArgs e)
        {
            var placa = Pesquisar_Box.Text;

            for (var i = 0; i < _carros.Count; i++)
            {
                if (_carros[i].Placa == placa)
                {
                    var linhas = "Veículo encontrado!";
                    linhas += "\nMarca: " + _carros[i].Marca;
                    linhas += "\nModelo: " + _carros[i].Modelo;
                    linhas += "\nAno: " + _carros[i].Ano;
                    linhas += "\nKilometragem: " + _carros[i].Kilometragem + " km";
                    linhas += "\nPotência: " + _carros[i].Potencia + " CV";
                    linhas += "\nCapacidade tanque: " + _carros[i].CapacidadeCombustivel + " L";

                    MessageBox.Show(linhas);
                    break;
                }
            }
        }
    }
}
