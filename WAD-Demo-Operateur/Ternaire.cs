namespace WAD_Demo_Operateur
{
    // -- TERNAIRE --  condition ? siVrai : siFaux
    // un if...else en une seule ligne pour ranger une valeur
    // (aussi vu dans la démo des conditions)
    internal static class Ternaire
    {
        public static void TernaireSimpleDemo()
        {
            Console.WriteLine("-- ternaire simple --");

            double montantCommande = 42;

            // livraison gratuite à partir de 50 euros sinon 4,95
            //                      condition             ? SIVRAI : SIFAUX
            double fraisLivraison = montantCommande >= 50 ? 0 : 4.95;
            Console.WriteLine($"frais de livraison : {fraisLivraison}");
            Console.WriteLine();
        }

        public static void TernaireAvecModuloPourPairOuImpairDemo()
        {
            Console.WriteLine("-- ternaire avec modulo --");

            int nombre = 7;
            string parite = nombre % 2 == 0 ? "pair" : "impair";
            Console.WriteLine($"{nombre} est {parite}");
            Console.WriteLine();
        }

        public static void TernaireImbriqueAvecPlusieursConditionsDemo()
        {
            Console.WriteLine("-- ternaire imbriqué --");

            // on peut mettre un ternaire dans le SIFAUX d'un autre ternaire
            // à partir de 100 euros : gratuit, à partir de 50 : 2,50, sinon 4,95
            double montantCommande = 75;

            double fraisLivraison = montantCommande >= 100 ? 0
                                  : montantCommande >= 50  ? 2.50
                                  : 4.95;
            Console.WriteLine($"frais de livraison : {fraisLivraison}");

            // ça devient vite illisible : au-delà de 2 conditions on préfère un if...else if...else
            Console.WriteLine();
        }
    }
}
