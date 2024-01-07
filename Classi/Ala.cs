using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Ala : Componente
    {
        // attributi
        private double _lunghezza;
        private double _apertura;
        private double _prezzo;

        // metodi accessor
        public double Lunghezza
        {
            get { return _lunghezza; }
            set 
            { 
                if(value > 0)
                    _lunghezza = value;
            }
        }
        public double Apertura
        {
            get { return _apertura; }
            set 
            {
                if (_apertura > 0)
                    _apertura = value;
            }
        }
        public double Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }

        // costruttore
        public Ala(double _lunghezza, double _apertura, double _prezzo)
        {
            Lunghezza = _lunghezza;
            Apertura = _apertura;
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
            return $"Ala - Lunghezza: {Lunghezza}, Apertura: {Apertura}, Prezzo: {Prezzo}";
        }
    }
}
