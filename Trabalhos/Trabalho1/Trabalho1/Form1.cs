using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho1
{
    public partial class Form1 : Form
    {
        private List<Carro> _carros = new List<Carro>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Cadastrar_button_Click(object sender, EventArgs e)
        {
            if (Modelo_textbox.Text == "")
            {
                MessageBox.Show("Modelo não pode ser vazio!");
                return;
            }

            if (Marca_textbox.Text == "")
            {
                MessageBox.Show("Marca não pode ser vazio!");
                return;
            }
            
            if(Placa_textbox.Text == "")
            {
                MessageBox.Show("Placa não pode ser vazio!");
                return;
            }

            if (Capacidade_textbox.Text == "")
            {
                MessageBox.Show("Capacidade de Passageiros não pode ser vazio!");
                return;
            }
            else
            {
                try
                {
                    int capacidade = int.Parse(Capacidade_textbox.Text);

                    if (capacidade <= 0)
                    {
                        MessageBox.Show("Capacidade deve ser maior que 0");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Capacidade deve ser um número inteiro!");
                    return;
                }
            }


            Carro carro = new Carro();
            carro.ID = _carros.Count + 1;
            carro.CapacidadeDePassageiros = int.Parse(Capacidade_textbox.Text);
            carro.Placa = Placa_textbox.Text;
            carro.Modelo = Modelo_textbox.Text;
            carro.Marca = Marca_textbox.Text;

            _carros.Add(carro);
            ListboxAtualiza();
        }

        private void ListboxAtualiza()
        {
            listBox1.Items.Clear();

            for (int i = 0; i < _carros.Count; i++)
            {
                listBox1.Items.Add("Carro Nº " + _carros[i].ID);
                listBox1.Items.Add(" Placa : " + _carros[i].Placa);
                listBox1.Items.Add(" Modelo: " + _carros[i].Modelo);
                listBox1.Items.Add(" Marca : " + _carros[i].Marca);
                int vagas = _carros[i].CapacidadeDePassageiros - _carros[i].QuantidadeDePassageiros;
                listBox1.Items.Add(" Vagas : " + vagas.ToString());
                listBox1.Items.Add(" --------------------- ");
            }
        }

        //Obs.: Professor, nessa parte eu pedi ajuda pro gabriel para saber
        //como apertar enter dentro da textbox para nao ter que usar um botao
        //ele me disse o metodo pra usar e o if pra ver se é enter
        private void ID_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(Keys.Return))
            {
                return;
            }

            if (ID_textbox.Text == "")
            {
                return;
            }

            int id;

            try
            {
                id = int.Parse(ID_textbox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("ID deve ser um número inteiro!");
                ID_textbox.Clear();
                return;
            }

            for (int i = 0; i < _carros.Count; i++)
            {
                Carro carro = _carros[i];

                if (carro.ID == id)
                {
                    if (carro.CapacidadeDePassageiros > carro.QuantidadeDePassageiros)
                    {
                        carro.QuantidadeDePassageiros++;
                        ListboxAtualiza();
                        ID_textbox.Clear();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Carro lotado!");
                        ID_textbox.Clear();
                        return;
                    }
                }
            }

            MessageBox.Show("ID inválido!");
            ID_textbox.Clear();
            return;
        }

    }
}
