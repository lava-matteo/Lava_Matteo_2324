namespace Gestione_Videogiochi
{
    public class Videogioco
    {
        private string titolo;
        private double prezzo;
        private DateOnly dataAquisto;
        private Console console;

        public Videogioco(string titolo, double prezzo, DateOnly dataAquisto, Console console)
        {
            this.Titolo = titolo;
            this.Prezzo = prezzo;
            this.DataAquisto = dataAquisto;
            this.Console = console;
        }

        public Videogioco(string titolo, double prezzo, DateOnly dataAquisto, string console)
        {
            this.Titolo = titolo;
            this.Prezzo = prezzo;
            this.DataAquisto = dataAquisto;
            this.Console = new Console(console);
        }

        public Videogioco(string titolo, double prezzo, DateOnly dataAquisto)
        {
            this.Titolo = titolo;
            this.Prezzo = prezzo;
            this.DataAquisto = dataAquisto;
            this.Console = new Console();
        }

        public Videogioco(Videogioco gioco)
        {
            this.titolo = gioco.Titolo;
            this.prezzo = gioco.Prezzo;
            this.console = gioco.Console;
            this.dataAquisto = gioco.DataAquisto;
        }

        public string Titolo
        {
            get { return this.titolo; }
            set 
            {
                if (value.Length < 1)
                {
                    throw new Exception("Il titolo del videogioco deve essere lungo almeno un carattere");
                }
                else
                {
                    this.titolo = value;
                }
            }
        }

        public double Prezzo
        {
            get { return this.prezzo; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Il prezzo deve essere maggiore o uguale a 0€");
                }
                else
                {
                    this.prezzo = value;
                }
            }
        }

        public DateOnly DataAquisto
        {
            get { return this.dataAquisto; }
            set
            {
                if (value.CompareTo(DateOnly.FromDateTime(DateTime.Now)) > 0)
                {
                    throw new Exception("La data di acquisto non può essere nel futuro");
                }
                else
                {
                    this.dataAquisto = value;
                }
                
            }
        }

        public Console Console
        {
            get { return this.console; }
            set
            {
                this.console = value;
            }
        }
    }
}
