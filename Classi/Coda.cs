using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Coda : Componente
    {
        // attributi
        private double _lunghezza;
        private double _prezzo;

        // metodi accessor
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
        public Coda(double _lunghezza, double _prezzo)
        {
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
            return $"Coda - Lunghezza: {Lunghezza}, Prezzo: {Prezzo}";
        }
    }
}
