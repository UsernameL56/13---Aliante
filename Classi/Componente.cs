using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public abstract class Componente
    {
        public abstract double Costo();
        public abstract string Descrizione();
        public abstract void Add(Componente componente);
        public abstract void Remove(Componente componente);
        public abstract Componente getChild(int indice);

    }
}
