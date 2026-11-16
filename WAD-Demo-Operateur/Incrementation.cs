namespace WAD_Demo_Operateur
{
    // -- INCRÉMENTATION / DÉCRÉMENTATION --  ++ --
    internal static class Incrementation
    {
        public static void IncrementationAjouteUnDemo()
        {
            Console.WriteLine("-- incrémentation (++) --");

            // ++ ajoute 1
            // x++ c'est la même chose que x += 1 ou x = x + 1
            int commandes = 0;
            commandes++; // 1
            commandes++; // 2
            commandes++; // 3
            Console.WriteLine($"nombre de commandes : {commandes}");
            Console.WriteLine();
        }

        public static void DecrementationRetireUnDemo()
        {
            Console.WriteLine("-- décrémentation (--) --");

            // -- retire 1
            int commandes = 3;
            commandes--; // 2 (une commande annulée)
            Console.WriteLine($"nombre de commandes : {commandes}");
            Console.WriteLine();
        }

        // PIÈGE : pré ou post incrémentation
        // la différence c'est QUAND la variable change de valeur
        // tout seul sur une ligne (commandes++;) pas de différence
        // le piège arrive seulement quand on l'utilise dans une affectation

        public static void PreIncrementationAugmenteAvantUtilisationDemo()
        {
            Console.WriteLine("-- pré-incrémentation (++x) --");

            // ++x (pré) : x augmente D'ABORD, puis on l'utilise
            int x = 5;
            int a = ++x;
            Console.WriteLine($"a = {a}, x = {x}"); // a = 6, x = 6
            Console.WriteLine();
        }

        public static void PostIncrementationAugmenteApresUtilisationDemo()
        {
            Console.WriteLine("-- post-incrémentation (y++) --");

            // y++ (post) : on utilise y D'ABORD, puis il augmente
            int y = 5;
            int b = y++;
            Console.WriteLine($"b = {b}, y = {y}"); // b = 5, y = 6
            Console.WriteLine();
        }
    }
}
