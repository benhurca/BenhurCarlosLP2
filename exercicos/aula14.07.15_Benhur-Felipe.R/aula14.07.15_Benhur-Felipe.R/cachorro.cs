using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula14._07._15_Benhur_Felipe.R
{
    class cachorro
    {
        private string _nome;
        private double _peso;
        public double tamanhoCm;
        private double _RacaoDiariaKg;

        public void SetNome(string nome)
        {
            _nome = nome; 
        }

        public string GetNome () 
        {
            return _nome;
        }

        public void SetPeso(double peso)
        {
            _peso = peso;
        }

        public double GetPeso()
        {
            return _peso;
        }

        public void SetRacaoDiariaKg(double RDK) 
        {
            RDK = (_peso * _peso) / ( tamanhoCm * tamanhoCm);
            _RacaoDiariaKg = RDK;
        }

        public double GetRacaoDiariaKg() 
        {
            return _RacaoDiariaKg;
        }
    }
}
