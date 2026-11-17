namespace WAD_Demo_Conversion.Demos
{
    // -- CONVERSION IMPLICITE --
    // C# convertit tout seul, sans qu'on demande rien
    // seulement quand il est SÛR de ne rien perdre (du plus petit vers le plus grand)
    internal static class ConversionImplicite
    {
        public static void IntVersLongSansRisqueDemo()
        {
            Console.WriteLine("-- int vers long --");

            // conversion implicite possible
            // car jamais un int ne dépassera la valeur maximale ou minimale du long
            int quantite = 3;
            long stock = quantite;
            Console.WriteLine($"stock : {stock}");
            Console.WriteLine();
        }

        public static void LongVersIntInterditDemo()
        {
            Console.WriteLine("-- long vers int : interdit --");

            // conversion implicite interdite long vers int
            // car possibilité qu'un jour le long devienne trop grand pour le int
            long quantite = 3_000;
            //int stock = quantite; // ERREUR de compilation

            // il faut alors une conversion explicite (voir ConversionExplicite.cs)
            int stock = (int)quantite;
            Console.WriteLine($"stock : {stock}");
            Console.WriteLine();
        }

        public static void CharVersIntDonneLeCodeAsciiDemo()
        {
            Console.WriteLine("-- char vers int --");

            // conversion implicite possible
            // car C# va transformer le char en sa valeur ascii (chaque lettre a un numéro)
            char lettre = 'a';
            int lettreNombre = lettre;
            Console.WriteLine($"'{lettre}' vaut {lettreNombre}"); // 97
            Console.WriteLine();
        }
    }
}
