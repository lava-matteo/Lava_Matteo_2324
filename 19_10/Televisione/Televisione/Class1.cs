namespace Televisione
{
    public class Televisione
    {
        public string marca;
        public string modello;
        public int numeroMassimoCanali = 100;
        public int VolumeMinimo = 0;
        public int VolumeMassimo = 50;
        public bool aColori;

        private bool accesa = false;
        private int canale = 0;
        private int volume;


        /*costruttore con tutte le variabili*/
        public Televisione(string marca, string modello, int numeroMassimoCanali, int VolumeMinimo, int VolumeMassimo, bool aColori)
        {
            this.marca = marca;
            this.modello = modello;
            this.numeroMassimoCanali = numeroMassimoCanali;
            this.VolumeMinimo = VolumeMinimo;
            this.VolumeMassimo = VolumeMassimo;
            this.aColori = aColori;

            volume = VolumeMinimo;
    }

        /*costruttore con solo le variabili essenziali*/
        public Televisione(string marca, string modello, bool aColori)
        {
            this.marca = marca;
            this.modello = modello;
            this.aColori = aColori;

            volume = VolumeMinimo;
        }

        public void accendi()
        {
            accesa = true;
        }

        public void spegni()
        {
            accesa = false;
        }
        public void alzaVolume()
        {
            if (accesa == true)
            {
                if (volume < VolumeMassimo)
                {
                    volume++;
                }
            }
        }
        public void abbassaVolume()
        {
            if (accesa == true)
            {
                if (volume > VolumeMinimo)
                {
                    volume--;
                }
            }
        }
        public void alzaVolume(int n)
        {
            if (accesa == true)
            {
                if (volume + n < VolumeMassimo)
                {
                    volume = volume + n;
                }
                else
                {
                    volume = VolumeMassimo;
                }
            }
        }
        public void abbassaVolume(int n)
        {
            if (accesa == true)
            {
                if (volume - n > VolumeMinimo)
                {
                    volume = volume - n;
                }
                else
                {
                    volume = VolumeMinimo;
                }
            }
        }

        public void incrementaCanale()
        {
            if (accesa == true)
            {
                if (canale < numeroMassimoCanali)
                {
                    canale++;
                }
            }
        }
        public void decrementaCanale()
        {
            if (accesa == true)
            {
                if (canale > 0)
                {
                    canale--;
                }
            }
        }

        public bool isAccesa()
        {
            return accesa;
        }

        public int canaleCorrente()
        {
            return canale;
        }

        public int volumeCorrente()
        {
            return volume;
        }

        public string informazioni()
        {
            return $"{marca}, {modello}, {numeroMassimoCanali}, {VolumeMinimo}, {VolumeMassimo}, {aColori},";
        }

        public void copiaInfoTelevisione(Televisione daSovrascrivere)
        {
            daSovrascrivere.marca = this.marca;
            daSovrascrivere.modello = this.modello;
            daSovrascrivere.numeroMassimoCanali = this.numeroMassimoCanali;
            daSovrascrivere.VolumeMinimo = this.VolumeMinimo;
            daSovrascrivere.VolumeMassimo = this.VolumeMassimo;
            daSovrascrivere.aColori = this.aColori;

            daSovrascrivere.accesa = this.accesa;
            daSovrascrivere.canale = this.canale;
            daSovrascrivere.volume = this.volume;
        }
    }
}
