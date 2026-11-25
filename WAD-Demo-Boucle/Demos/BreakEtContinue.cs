namespace WAD_Demo_Boucle.Demos
{
    // -- BREAK ET CONTINUE --  marchent dans toutes les boucles (for, while, do while, foreach)
    // break    = on SORT de la boucle tout de suite
    // continue = on SAUTE la suite de ce tour et on passe au tour suivant
    internal static class BreakEtContinue
    {
        public static void BreakTrouverLePremierEchecDemo()
        {
            Console.WriteLine("-- break : trouver le premier échec --");

            int[] notesEleves = [12, 15, 18, 9, 7, 2];

            // dès qu'on trouve une note sous 10, pas besoin de regarder la suite
            foreach (int noteEleve in notesEleves)
            {
                Console.WriteLine($"je regarde la note {noteEleve}");
                if (noteEleve < 10)
                {
                    Console.WriteLine($"premier échec trouvé : {noteEleve}");
                    break; // 7 et 2 ne sont jamais regardés
                }
            }
            Console.WriteLine();
        }

        public static void ContinueIgnorerLesEchecsDemo()
        {
            Console.WriteLine("-- continue : ignorer les échecs --");

            int[] notesEleves = [12, 15, 18, 9, 7, 2];

            // on veut afficher seulement les réussites
            foreach (int noteEleve in notesEleves)
            {
                if (noteEleve < 10)
                {
                    continue; // on passe directement à la note suivante
                }
                Console.WriteLine($"réussi avec {noteEleve}");
            }
            Console.WriteLine();
        }
    }
}
