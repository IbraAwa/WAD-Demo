namespace WAD_Demo_Methode.Demos
{
    // -- VERSION COURTE (=>) --
    // quand une méthode tient en UNE seule instruction, on peut l'écrire sur une ligne avec =>
    // (on appelle ça une méthode "expression-bodied")
    //
    // version longue (4 lignes)              version courte (1 ligne)
    //   static int Multiplication(int a, int b)    static int Multiplication(int a, int b) => a * b;
    //   {
    //       return a * b;
    //   }
    //
    // - pour une fonction : pas de return, pas d'accolades, ce qui est à droite de => EST la valeur renvoyée
    // - pour une procédure : à droite de => on met l'instruction à exécuter
    // - si votre logique prend plusieurs lignes -> version longue obligatoire
    internal static class VersionCourte
    {
        // ----- les méthodes utilisées dans les démos -----

        // 4 lignes pour la version longue
        private static int MultiplicationLongue(int a, int b)
        {
            return a * b;
        }

        // 1 ligne pour la version courte
        private static int MultiplicationCourte(int a, int b) => a * b;

        private static bool EstPair(int nombre) => nombre % 2 == 0;

        private static string PasserLeBonjourA(string prenom) => $"Bonjour {prenom}";

        // une procédure en version courte
        private static void DireAuRevoir() => Console.WriteLine("Au revoir !");

        // ----- les démos -----

        public static void VersionLongueEtVersionCourteDemo()
        {
            Console.WriteLine("-- version longue et version courte --");

            // les deux font exactement la même chose
            Console.WriteLine($"version longue : 6 x 7 = {MultiplicationLongue(6, 7)}");
            Console.WriteLine($"version courte : 6 x 7 = {MultiplicationCourte(6, 7)}");
            Console.WriteLine();
        }

        public static void FonctionsCourtesDemo()
        {
            Console.WriteLine("-- d'autres fonctions courtes --");

            Console.WriteLine($"4 est pair ? {EstPair(4)}");
            Console.WriteLine($"7 est pair ? {EstPair(7)}");
            Console.WriteLine(PasserLeBonjourA("Myriam"));
            Console.WriteLine();
        }

        public static void ProcedureCourteDemo()
        {
            Console.WriteLine("-- une procédure courte --");

            DireAuRevoir();
            Console.WriteLine();
        }
    }
}
