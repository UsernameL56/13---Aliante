﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Aliante : Componente
    {
        // attributi
        List<Componente> _componenti = new List<Componente>();

        // metodi accessor
        public List<Componente> Componenti
        {
            get { return _componenti; }
            set { _componenti = value; }
        }

        // costruttore
        public Aliante(List<Componente> _componenti)
        {
            Componenti = _componenti;
        }

        // metodi
        public override void Add(Componente componente)
        {
           Componenti.Add(componente);
        }
        public override void Remove(int indice)
        {
            if(indice >=0 && indice < Componenti.Count)
                Componenti.RemoveAt(indice);
        }
        public override Componente getChild(int indice)
        {
            if (indice < Componenti.Count)
            {
                return Componenti[indice];
            }
            else
            {
                return null;
            }
        }
        public override double Costo()
        {
            double prezzoTot = 0;

            foreach(Componente componente in Componenti)
            {
                prezzoTot += componente.Costo();
            }
            return prezzoTot;
        }
        public override string Descrizione()
        {
            string stringa = "";
            foreach(Componente componente in Componenti)
            {
                stringa += componente.Descrizione() + "\n";
            }
            return $"Aliante - {stringa}";
        }
    }
}
