namespace WAD_Demo.Demos
{
    // -- LES TYPES LITTÉRAUX --  les suffixes m D f L
    // un littéral c'est une valeur écrite directement dans le code (15.50m, "Marco", 42...)
    // le suffixe (la lettre après le nombre) dit à C# de quel type est ce nombre
    internal static class TypesLitteraux
    {
        // les nombres à virgule

        public static void DecimalAvecLeSuffixeMDemo()
        {
            Console.WriteLine("-- decimal : suffixe m --");

            // quand une variable est de type decimal
            // mettre un 'm' après le nombre
            decimal prixPizza = 15.50m;

            // decimal prixPizza2 = 15.50; // ERREUR : sans le m, 15.50 est un double
            Console.WriteLine($"prix de la pizza : {prixPizza}");
            Console.WriteLine();
        }

        public static void DoubleAvecLeSuffixeDFacultatifDemo()
        {
            Console.WriteLine("-- double : suffixe D (facultatif) --");

            // quand une variable est de type double
            // mettre un 'D' après le nombre
            // mais non obligatoire (un nombre à virgule est un double par défaut)
            double distanceKm1 = 16.25;
            double distanceKm2 = 16.25D;
            Console.WriteLine($"{distanceKm1} km et {distanceKm2} km");
            Console.WriteLine();
        }

        public static void FloatAvecLeSuffixeFDemo()
        {
            Console.WriteLine("-- float : suffixe f --");

            // quand une variable est de type float
            // mettre un 'F' (ou 'f') après le nombre
            float vitesseJoueur = 16.25f;
            Console.WriteLine($"vitesse du joueur : {vitesseJoueur}");
            Console.WriteLine();
        }

        // de même pour les nombres sans virgule

        public static void LongAvecLeSuffixeLDemo()
        {
            Console.WriteLine("-- long : suffixe L --");

            // si vous créez une variable avec un petit nombre
            // susceptible de devenir un trop gros nombre
            // mettre 'L' après le nombre le fait devenir long
            var nombreDeVues1 = 1515155;  // C# pense que c'est un int
            var nombreDeVues2 = 1515155L; // grâce au L, c'est un long (une vidéo peut dépasser 2 milliards de vues)

            // GetType().Name donne le nom du type que C# a choisi
            Console.WriteLine($"{nombreDeVues1} vues ({nombreDeVues1.GetType().Name})");
            Console.WriteLine($"{nombreDeVues2} vues ({nombreDeVues2.GetType().Name})");
            Console.WriteLine();
        }
    }
}
