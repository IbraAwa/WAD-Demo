namespace WAD_Demo_Boucle.Demos
{
    // -- WHILE --  tant que la condition est vraie, on répète
    // WHILE est utilisé quand on ne compte pas forcément quelque chose
    // WHILE peut être utilisé pour une condition autre qu'un chiffre (un mot, un bool...)
    // la condition est vérifiée AVANT chaque tour : si elle est fausse dès le départ, on n'entre jamais dans la boucle
    internal static class While
    {
        public static void WhileRemplirLeReservoirDemo()
        {
            Console.WriteLine("-- remplir le réservoir --");

            // on ne sait pas d'avance combien de fois on va remettre de l'essence
            // on continue TANT QUE le réservoir n'est pas plein
            int reservoir = 10;
            int capacite = 50;

            while (reservoir < capacite)
            {
                reservoir += 10;
                Console.WriteLine($"j'ajoute 10 litres, le réservoir contient {reservoir} litres");
            }
            Console.WriteLine("le réservoir est plein");
            Console.WriteLine();
        }

        public static void WhileConditionFausseDesLeDepartDemo()
        {
            Console.WriteLine("-- while : condition fausse dès le départ --");

            // le réservoir est déjà plein -> on n'entre JAMAIS dans la boucle
            int reservoir = 50;
            int capacite = 50;

            while (reservoir < capacite)
            {
                Console.WriteLine("j'ajoute de l'essence"); // jamais affiché
                reservoir += 10;
            }
            Console.WriteLine("aucun passage dans le while");
            Console.WriteLine();
        }

        public static void PiegeBoucleInfinieDemo()
        {
            Console.WriteLine("-- piège : boucle infinie --");

            // si on oublie de modifier la variable de la condition dans la boucle,
            // la condition reste vraie pour toujours -> le programme ne s'arrête jamais
            // décommenter pour voir (Ctrl + C pour arrêter)
            int reservoir = 12;
            //while (reservoir < 50)
            //{
            //    Console.WriteLine("j'ajoute de l'essence"); // oublié : reservoir += 10;
            //}

            Console.WriteLine($"toujours modifier '{nameof(reservoir)}' dans la boucle !");
            Console.WriteLine();
        }
    }
}
