using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    class Fusoliera : Componente
    {
        // attributi
        private string _materiale;
        private double _lunghezza;
        private double _prezzo;

        // metodi accessor
        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }
        public double Lunghezza
        {
            get { return _lunghezza; }
            set
            {
                if (_lunghezza > 0)
                    _lunghezza = value;
            }
        }
        public double Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }

        // costruttore
        public Fusoliera(string _materiale, double _lunghezza, double _prezzo)
        {
            Materiale = _materiale;
            Lunghezza = _lunghezza;
            Prezzo = _prezzo;
        }

        // metodi

        public override void Add(Componente componente)
        {
            throw new NotImplementedException();
        }
        public override void Remove(Componente componente)
        {
            throw new NotImplementedException();
        }
        public override Componente getChild(int indice)
        {
            return null;
        }
        public override double Costo()
        {
            return Prezzo;
        }

        public override string Descrizione()
        {
            return $"Fusoliera - Materiale: {Materiale}, Lunghezza: {Lunghezza}, Prezzo: {Prezzo}";
        }
    }
}
