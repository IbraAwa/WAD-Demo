namespace WAD_Demo_Conversion.Demos
{
    // -- BOXING / UNBOXING --  object
    // tout est objet dans C#
    // string c'est objet
    // int c'est objet
    // class Voiture est objet
    internal static class BoxingUnboxing
    {
        public static void BoxingRangerDansUnObjectDemo()
        {
            Console.WriteLine("-- boxing --");

            // boxing : on passe d'un type précis à imprécis donc on s'en fiche
            // car int est objet de toute manière
            // comme une voiture est un véhicule de toute manière
            int quantite = 3;
            object quantiteBoxee = quantite; // pas besoin de cast
            Console.WriteLine($"quantité dans un object : {quantiteBoxee}");
            Console.WriteLine();
        }

        public static void UnboxingIlFautPreciserLeTypeDemo()
        {
            Console.WriteLine("-- unboxing --");

            // unboxing : on passe d'un type imprécis à un type précis donc
            // on doit le dire à C#
            // comme un véhicule : on ne sait pas si c'est une voiture, un camion, un vélo ou autre
            // on doit le préciser à la personne
            object quantiteBoxee = 15;
            int quantite = (int)quantiteBoxee;
            Console.WriteLine($"quantité sortie de l'object : {quantite}");
            Console.WriteLine();
        }

        public static void PiegeUnboxingVersLeMauvaisTypePlanteDemo()
        {
            Console.WriteLine("-- piège : unboxing vers le mauvais type --");

            // on doit sortir de la boîte EXACTEMENT le type qu'on y a mis
            // 15 a été rangé comme un int, on ne peut pas le sortir directement en double
            object quantiteBoxee = 15;
            //double quantite = (double)quantiteBoxee; // plante (InvalidCastException)

            // solution : d'abord le bon type (int), ensuite convertir en double
            double quantite = (int)quantiteBoxee;
            Console.WriteLine($"quantité en double : {quantite}");
            Console.WriteLine();
        }
    }
}
