using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Ruota : Componente
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
        public Ruota(List<Componente> _componenti)
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
            throw new NotImplementedException();
        }
        public override Componente getChild(int indice)
        {
            return null;
        }
        public override double Costo()
        {
            double prezzo = 0;
            foreach(Componente componente in Componenti)
            {
                prezzo += componente.Costo();
            }
            return prezzo;
        }
        public override string Descrizione()
        {
            string stringa = "";
            foreach (Componente componente in Componenti)
            {
                stringa += componente.Descrizione() + "\n";
            }
            return $"Ruota - {stringa}";
        }
    }
}
