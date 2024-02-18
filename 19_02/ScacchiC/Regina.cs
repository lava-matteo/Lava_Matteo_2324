using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScacchiC
{
    public class Regina : Pedina
    {
        public Regina(string colore, int riga, int colonna, Scacchiera scacchiera) : base(colore, riga, colonna, scacchiera)
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
                if (nuovaRiga != riga && nuovaColonna != colonna)
                {
                    throw new ArgumentException("Mossa non valida");
                }
                if (nuovaColonna != colonna)
                {
                    if (nuovaColonna > colonna)
                    {
                        for (int i = colonna + 1; i <= nuovaColonna; i++)
                        {
                            if (scacchiera.getPedina(riga, i) != null)
                            {
                                throw new ArgumentException("Pedina nel mezzo");
                            }
                        }
                    }
                    if (nuovaColonna < colonna)
                    {
                        for (int i = colonna - 1; i >= nuovaColonna; i--)
                        {
                            if (scacchiera.getPedina(riga, i) != null)
                            {
                                throw new ArgumentException("Pedina nel mezzo");
                            }
                        }
                    }
                }
                if (nuovaRiga != riga)
                {
                    if (nuovaRiga > riga)
                    {
                        for (int i = riga + 1; i <= nuovaRiga; i++)
                        {
                            if (scacchiera.getPedina(i, colonna) != null)
                            {
                                throw new ArgumentException("Pedina nel mezzo");
                            }
                        }
                    }
                    if (nuovaRiga < riga)
                    {
                        for (int i = riga - 1; i >= nuovaRiga; i--)
                        {
                            if (scacchiera.getPedina(i, colonna) != null)
                            {
                                throw new ArgumentException("Pedina nel mezzo");
                            }
                        }
                    }
                }
            }
            int passo = -1;
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
            return "q";
        }
    }
}
