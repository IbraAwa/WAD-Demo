namespace WAD_Demo_Conversion.Demos
{
    // -- CONVERSION EXPLICITE --
    // on doit le dire à C# nous-mêmes : avec Convert ou avec un cast (le type entre parenthèses)
    // exemple : 8 commandes, 2 livrées -> quel pourcentage est livré ? (la bonne réponse : 25 %)
    internal static class ConversionExplicite
    {
        public static void PiegeDivisionEntreIntDonneUnMauvaisPourcentageDemo()
        {
            Console.WriteLine("-- piège : sans conversion --");

            // sans conversion C# implicitement donne un entier alors qu'on attend
            // un nombre à virgule
            int nbCommandes = 8;
            int nbLivrees = 2;
            int pct = 100 / nbCommandes * nbLivrees; // 100 / 8 = 12 (et pas 12,5) puis 12 * 2 = 24
            Console.WriteLine($"{pct} %");
            // 24 % au lieu de 25 % !
            Console.WriteLine();
        }

        public static void ConvertToDecimalPourLeBonPourcentageDemo()
        {
            Console.WriteLine("-- avec Convert.ToDecimal --");

            // besoin de conversion explicite
            int nbCommandes = 8;
            int nbLivrees = 2;
            decimal pct = Convert.ToDecimal(100) / Convert.ToDecimal(nbCommandes) * Convert.ToDecimal(nbLivrees);
            Console.WriteLine($"{pct} %");
            // 25 % cette fois !
            Console.WriteLine();
        }

        public static void CastSurUnSeulNombreOuSurToutLeCalculDemo()
        {
            Console.WriteLine("-- cast : sur un nombre ou sur tout le calcul --");

            // conversion explicite avec un cast
            int nbCommandes = 8;
            int nbLivrees = 2;

            //(int) s'applique au nombre juste après donc ici à 100f
            int pct1 = (int)100f / nbCommandes * nbLivrees;
            Console.WriteLine($"{pct1} %"); // 24 %

            //(int) s'applique à tout le calcul
            int pct2 = (int)(100f / nbCommandes * nbLivrees);
            Console.WriteLine($"{pct2} %"); // 25 %
            Console.WriteLine();
        }

        public static void CastCoupeLaVirguleSansArrondirDemo()
        {
            Console.WriteLine("-- cast : coupe la virgule --");

            // CAST explicite : n'arrondit pas
            // mon (int) donc cast explicite a coupé la virgule, il ne l'a pas arrondi
            int prix = (int)9.99;
            Console.WriteLine($"le prix est {prix}"); // 9 et pas 10 !
            Console.WriteLine();
        }

        public static void MathRoundPourArrondirDemo()
        {
            Console.WriteLine("-- Math.Round pour arrondir --");

            // si on veut arrondir il faut utiliser Math.Round()
            // qui arrondit à son plus proche entier
            decimal prix = 9.50m;

            int prixArrondi = (int)Math.Round(prix);
            Console.WriteLine($"le prix arrondi est {prixArrondi}"); // 10

            // attention : quand on est pile au milieu (,5) Math.Round va vers le nombre PAIR
            // Math.Round(9.5) = 10  mais  Math.Round(10.5) = 10 (arrondi "du banquier")
            Console.WriteLine($"Math.Round(10.5m) = {Math.Round(10.5m)}");
            Console.WriteLine();
        }
    }
}
