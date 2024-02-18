using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScacchiC
{
    public class Alfiere : Pedina
    {
        public Alfiere(string colore, int riga, int colonna, Scacchiera scacchiera) : base(colore, riga, colonna, scacchiera)
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

            if (riga - nuovaRiga != colonna - nuovaColonna)
            {
                throw new ArgumentException("Mossa non valida");
            }
            int passo = - 1;
            if (riga < nuovaRiga)
            {
                passo = 1;
            }
            int c = colonna + passo;
            for (int r = riga + passo; r != nuovaRiga; r = r + passo)
            {
                if (scacchiera.getPedina(r, c) != null)
                {
                    throw new Exception("Pedina nel mezzo");
                }
                c = c + passo;
            }

            scacchiera.rimuoviPedina(riga, colonna);
            riga = nuovaRiga;
            colonna = nuovaColonna;
            scacchiera.posizionaPedina(riga, colonna, this);
        }

        public override string stampa()
        {
            return "b";
        }
    }
}
