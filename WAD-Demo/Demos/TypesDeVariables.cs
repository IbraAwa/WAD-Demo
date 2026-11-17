namespace WAD_Demo.Demos
{
    // -- LES TYPES DE VARIABLES --  string int long decimal double float bool
    internal static class TypesDeVariables
    {
        public static void StringPourDuTexteDemo()
        {
            Console.WriteLine("-- string --");

            // string : une chaîne de caractères (du texte)
            // toujours entre guillemets " "
            string prenom = "Marco";
            Console.WriteLine($"prénom du client : {prenom}");
            Console.WriteLine();
        }

        public static void IntPourUnNombreEntierDemo()
        {
            Console.WriteLine("-- int --");

            // int : nombre entier entre environ -2 milliards et +2 milliards
            int age = 19;
            Console.WriteLine($"âge du client : {age}");
            Console.WriteLine();
        }

        public static void LongPourUnTresGrandNombreEntierDemo()
        {
            Console.WriteLine("-- long --");

            // long : nombre entier entre environ -9 trillions et +9 trillions
            // (9 suivi de 18 chiffres)
            // la population mondiale (8 milliards) est trop grande pour un int
            long populationMondiale = 8_100_000_000;
            Console.WriteLine($"population mondiale : {populationMondiale}");
            Console.WriteLine();
        }

        public static void DecimalPourLArgentDemo()
        {
            Console.WriteLine("-- decimal --");

            // decimal : nombre à virgule le plus précis (28-29 chiffres significatifs)
            // Calculs exacts en base 10 : à utiliser pour l'argent
            // Le suffixe m est obligatoire
            decimal prixBaguette = 1.20m;
            Console.WriteLine($"prix d'une baguette : {prixBaguette} euros");
            Console.WriteLine();
        }

        public static void DoublePourUnNombreAVirguleParDefautDemo()
        {
            Console.WriteLine("-- double --");

            // double : nombre à virgule par défaut en C# (15-17 chiffres significatifs)
            // Rapide, mais de petites erreurs d'arrondi possibles (0.1 + 0.2 != 0.3)
            double temperature = 21.5;
            Console.WriteLine($"température du magasin : {temperature} degrés");
            Console.WriteLine();
        }

        public static void PiegeDoubleImprecisAvecZeroVirguleUnPlusZeroVirguleDeuxDemo()
        {
            Console.WriteLine("-- piège : 0.1 + 0.2 avec double et decimal --");

            double resultatDouble = 0.1 + 0.2;
            decimal resultatDecimal = 0.1m + 0.2m;
            Console.WriteLine($"double  : 0.1 + 0.2 = {resultatDouble}");  // 0,30000000000000004
            Console.WriteLine($"decimal : 0.1 + 0.2 = {resultatDecimal}"); // 0,3
            // c'est pour ça qu'on utilise le decimal pour l'argent
            Console.WriteLine();
        }

        public static void FloatLeMoinsPrecisDemo()
        {
            Console.WriteLine("-- float --");

            // float : nombre à virgule le moins précis (6-9 chiffres significatifs)
            // Prend moins de mémoire (jeux, graphisme, gros tableaux)
            // Le suffixe f est obligatoire
            float positionJoueurX = 12.5f; // la position d'un personnage dans un jeu vidéo
            Console.WriteLine($"position du joueur : {positionJoueurX}");
            Console.WriteLine();
        }

        public static void BoolVraiOuFauxDemo()
        {
            Console.WriteLine("-- bool --");

            // bool : un booléen, ne peut valoir que true (vrai) ou false (faux)
            bool estMajeur = true;
            bool estMineur = false;
            Console.WriteLine($"est majeur : {estMajeur}, est mineur : {estMineur}");
            Console.WriteLine();
        }
    }
}
