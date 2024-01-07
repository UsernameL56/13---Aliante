﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    class Ruota : Componente
    {
        // attributi
        private Cerchione _cerchione;
        private Gomma _gomma;

        // metodi accessor
        public Cerchione Cerchione
        {
            get { return _cerchione; }
            set { _cerchione = value; }
        }
        public Gomma Gomma
        {
            get { return _gomma; }
            set { _gomma = value; }
        }

        // costruttore
        public Ruota(Cerchione _cerchione, Gomma _gomma)
        {
            Cerchione = _cerchione;
            Gomma = _gomma;
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
            return _cerchione.Costo() + _gomma.Costo();
        }
        public override string Descrizione()
        {
            return $"Ruota - {_cerchione.Descrizione()}, {_gomma.Descrizione()}";
        }
    }
}
