namespace Playlist_musica
{
    internal class Brano
    {
        private string titolo;
        private string autore;
        private int durata;
        private bool ghost_track;
        private string album;
        private int tracce;

        public Brano()
        {
            this.Titolo = "titolo";
            this.Autore = "autore";
            this.Durata = 0;
            this.Ghost_track = false;
            this.Album = "album";
            this.Tracce = 1;
        }

        public Brano(string titolo, string autore, int durata, bool ghost_track, string album, int tracce)
        {
            this.Titolo = titolo;
            this.Autore = autore;
            this.Durata = durata;
            this.Ghost_track = ghost_track;
            this.Album = album;
            this.Tracce = tracce;
        }

        public Brano(string titolo, string autore, int durata, string album, int tracce)
        {
            this.Titolo = titolo;
            this.Autore = autore;
            this.Durata = durata;
            this.Ghost_track = false;
            this.Album = album;
            this.Tracce = tracce;
        }

        public Brano(string titolo, string autore, int durata, bool ghost_track, string album)
        {
            this.Titolo = titolo;
            this.Autore = autore;
            this.Durata = durata;
            this.Ghost_track = ghost_track;
            this.Album = album;
            this.Tracce = 1;
        }

        public Brano(string titolo, string autore, int durata, string album)
        {
            this.Titolo = titolo;
            this.Autore = autore;
            this.Durata = durata;
            this.Ghost_track = false;
            this.Album = album;
            this.Tracce = 1;
        }

        public string Titolo
        {
            get { return titolo; }
            set
            {
                titolo = value;
            }
        }


        public bool Ghost_track
        {
            get { return ghost_track; }
            set { ghost_track = value; }
        }

        public string Autore
        {
            get { return autore; }
            set
            {
                autore = value;
            }
        }

        public int Durata
        {
            get { return durata; }
            set
            {  
                durata = value;
            }
        }

        public string Album
        {
            get { return album; }
            set
            {

                album = value;
            }
        }

        public int Tracce
        {
            get { return tracce; }
            set
            {
                tracce = value;
            }
        }



        public string Informazioni()
        {
            return ($"{this.titolo} - {this.autore} - {this.album}");
        }

        public void Modifica(string titolo, string autore, string album, int durata, int tracce, bool ghost_track)
        {
            this.Titolo = titolo;
            this.Autore = autore;
            this.Album = album;
            this.Durata = durata;
            this.Tracce = tracce;
            this.Ghost_track = ghost_track;
        }
    }
}
