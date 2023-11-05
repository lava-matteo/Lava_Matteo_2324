namespace Gestione_Videogiochi
{
    public class Console
    {
        private string nome;

        public Console(string nome)
        {
            this.Nome = nome;
        }

        public Console()
        {
            this.nome = "PC";
        }

        public string Nome
        {
            get { return this.nome; }
            set 
            { 
                if (value.Length < 1)
                {
                    throw new Exception("Il nome della console deve essere lungo almeno un carattere");
                }
                else
                {
                    this.nome = value;
                }
            }
        }
    }
}
