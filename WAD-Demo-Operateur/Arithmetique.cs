namespace WAD_Demo_Operateur
{
    // -- ARITHMÉTIQUE --  + - * / %
    internal static class Arithmetique
    {
        public static void AdditionDemo()
        {
            Console.WriteLine("-- addition (+) --");

            int prixTshirt = 15;
            int prixCasquette = 4;

            int total = prixTshirt + prixCasquette; // 19
            Console.WriteLine($"15 + 4 = {total}");
            Console.WriteLine();
        }

        public static void SoustractionDemo()
        {
            Console.WriteLine("-- soustraction (-) --");

            int prixTshirt = 15;
            int reduction = 4;

            int prixFinal = prixTshirt - reduction; // 11
            Console.WriteLine($"15 - 4 = {prixFinal}");
            Console.WriteLine();
        }

        public static void MultiplicationDemo()
        {
            Console.WriteLine("-- multiplication (*) --");

            int prixTshirt = 15;
            int quantite = 4;

            int prixTotal = prixTshirt * quantite; // 60
            Console.WriteLine($"prix total : {prixTotal} euros");
            Console.WriteLine();
        }

        public static void DivisionEntreDeuxIntCoupeLaVirguleDemo()
        {
            Console.WriteLine("-- division (/) entre deux int --");

            // ATTENTION division entre deux int
            // C# donne un int donc il coupe la virgule (il n'arrondit pas)
            int prixTshirt = 15;
            int quantite = 4;

            int division = prixTshirt / quantite; // 3 et pas 3,75 !
            Console.WriteLine($"15 / 4 = {division}");
            Console.WriteLine();
        }

        public static void DivisionAvecVirguleDemo()
        {
            Console.WriteLine("-- division (/) avec virgule --");

            // si on veut la virgule il faut qu'au moins un des deux soit un nombre a virgule
            double divisionAvecVirgule = 15.0 / 4; // 3,75
            Console.WriteLine($"15.0 / 4 = {divisionAvecVirgule}");

            // on peut aussi faire un cast (vu dans la démo conversion)
            int prixTshirt = 15;
            int quantite = 4;
            double divisionCast = (double)prixTshirt / quantite; // 3,75
            Console.WriteLine($"(double)15 / 4 = {divisionCast}");
            Console.WriteLine();
        }

        public static void ModuloResteDeLaDivisionDemo()
        {
            Console.WriteLine("-- modulo (%) --");

            // le modulo % donne le reste d'une division
            // 15 / 4 = 3 et il reste 3 (4 * 3 = 12, 15 - 12 = 3)
            int modulo = 15 % 4; // 3
            Console.WriteLine($"15 % 4 = {modulo}");
            Console.WriteLine();
        }

        public static void ModuloPourSavoirSiPairOuImpairDemo()
        {
            Console.WriteLine("-- modulo (%) pair ou impair --");

            // très utilisé pour savoir si un nombre est pair ou impair
            // un nombre pair divisé par 2 a toujours un reste de 0
            Console.WriteLine($"8 % 2 = {8 % 2}"); // 0 donc pair
            Console.WriteLine($"7 % 2 = {7 % 2}"); // 1 donc impair
            Console.WriteLine();
        }

        public static void PrioriteDesOperateursCommeEnMathDemo()
        {
            Console.WriteLine("-- priorité des opérateurs --");

            // priorité comme en math : * / % passent avant + -
            int resultat1 = 2 + 3 * 4;   // 14 car 3 * 4 en premier
            int resultat2 = (2 + 3) * 4; // 20 car les parenthèses en premier
            Console.WriteLine($"2 + 3 * 4 = {resultat1}");
            Console.WriteLine($"(2 + 3) * 4 = {resultat2}");
            Console.WriteLine();
        }
    }
}
