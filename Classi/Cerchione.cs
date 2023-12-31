using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    class Cerchione : Componente
    {
        // attributi
        private double _pollici;
        private string _materiale;
        private double _prezzo;

        // metodi accessor
        public double Pollici
        {
            get { return _pollici; }
            set { _pollici = value; }
        }
        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }
        public double Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }

        // costruttore
        public Cerchione(double _pollici, string _materiale, double _prezzo)
        {
            Pollici = _pollici;
            Materiale = _materiale;
            Prezzo = _prezzo;
        }

        // metodi
        public override double Costo()
        {
            return Prezzo;
        }

        public override string Descrizione()
        {
            return $"Cerchione - Pollici: {Pollici}, Materiale: {Materiale}, Prezzo: {Prezzo}";
        }
    }
}
