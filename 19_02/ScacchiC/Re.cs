using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScacchiC
{
    public class Re : Pedina
    {
        public Re(string colore, int riga, int colonna, Scacchiera scacchiera) : base(colore, riga, colonna, scacchiera)
        {

        }

        public override void mangia(int r, int c)
        {
            throw new NotImplementedException();
        }

        public override void trasforma(Pedina p)
        {
            throw new NotImplementedException();
        }

        public override void muovi(int nuovaRiga, int nuovaColonna)
        {
            base.muovi(nuovaRiga, nuovaColonna);
            if ((nuovaRiga > riga + 1 || nuovaRiga < riga - 1) || (nuovaColonna > colonna + 1 || nuovaColonna < colonna - 1))
            {
                throw new ArgumentException("Mossa non valida");
            }
            scacchiera.rimuoviPedina(riga, colonna);
            riga = nuovaRiga;
            colonna = nuovaColonna;
            scacchiera.posizionaPedina(riga, colonna, this);
        }

        public override string stampa()
        {
            return "k";
        }
    }
}
