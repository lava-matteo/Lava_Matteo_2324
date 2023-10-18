namespace Televisione
{
    public class Programma
    {
        public static void Main(string[] args)
        {
            Televisione Sony;
            Sony = new Televisione("Sony", "BRAVIA KD-32W800", 200, 0, 100, true);

            Televisione Mivar;
            Mivar = new Televisione("Mivar", "17BN2L", false);

            Televisione Philips;
            Philips = new Televisione("Philips", "32PFL5403D", 70, 0, 75, true);

            Console.WriteLine($"{Sony.marca} - {Mivar.modello} - {Philips.aColori} - {Mivar.numeroMassimoCanali}");

            Sony.accendi();
            Console.WriteLine(Sony.isAccesa());

            Console.WriteLine(Sony.volumeCorrente());
            Sony.alzaVolume(60);
            Console.WriteLine(Sony.volumeCorrente());

            Sony.abbassaVolume();
            Console.WriteLine(Sony.volumeCorrente());

            Sony.alzaVolume(60);
            Console.WriteLine(Sony.volumeCorrente());

            Sony.abbassaVolume(120);
            Console.WriteLine(Sony.volumeCorrente());

            Sony.alzaVolume();
            Console.WriteLine(Sony.volumeCorrente());

            Sony.spegni();
            Console.WriteLine(Sony.isAccesa());

            Console.WriteLine(Sony.informazioni());

            Sony.accendi();

            Console.WriteLine(Sony.canaleCorrente());
            Sony.incrementaCanale();
            Console.WriteLine(Sony.canaleCorrente());

            Sony.decrementaCanale();
            Console.WriteLine(Sony.canaleCorrente());

            Sony.decrementaCanale();
            Console.WriteLine(Sony.canaleCorrente());

            Mivar.copiaInfoTelevisione(Sony);
            Console.WriteLine(Sony.informazioni());

            Console.WriteLine(Sony.isAccesa());
            Sony.accendi();
            Console.WriteLine(Sony.isAccesa());

            Sony.alzaVolume(60);
            Console.WriteLine(Sony.volumeCorrente());
        }
    }
}