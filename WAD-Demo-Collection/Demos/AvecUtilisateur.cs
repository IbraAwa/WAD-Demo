namespace WAD_Demo_Collection.Demos
{
    // -- AVEC L'UTILISATEUR --  remplir une collection avec ce que l'utilisateur tape
    internal static class AvecUtilisateur
    {
        public static void RemplirUnTableauDeNotesSaisiesDemo()
        {
            Console.WriteLine("-- remplir un tableau de notes --");

            int[] notes = new int[5];

            // on utilise un FOR car on a besoin de l'index pour savoir dans quelle case écrire
            for (int index = 0; index < notes.Length; index++)
            {
                Console.Write($"quelle note voulez-vous attribuer à l'élève n°{index + 1} ? ");

                int noteAttribuee;
                // tant que l'utilisateur ne tape pas un nombre, on redemande
                while (!int.TryParse(Console.ReadLine(), out noteAttribuee))
                {
                    Console.Write("ce n'est pas un nombre valide, recommencez : ");
                }

                notes[index] = noteAttribuee;
            }

            Console.WriteLine($"notes encodées : {string.Join(", ", notes)}");
            Console.WriteLine();
        }

        public static void RemplirUneListeJusquaFinDemo()
        {
            Console.WriteLine("-- remplir une List jusqu'à 'fin' --");

            // avec une List, pas besoin de connaître la taille à l'avance
            List<string> courses = new();

            Console.Write("article à ajouter ('fin' pour arrêter) : ");
            string? article = Console.ReadLine();

            while (article != "fin")
            {
                if (!string.IsNullOrWhiteSpace(article))
                {
                    courses.Add(article);
                }

                Console.Write("article à ajouter ('fin' pour arrêter) : ");
                article = Console.ReadLine();
            }

            Console.WriteLine($"{courses.Count} article(s) : {string.Join(", ", courses)}");
            Console.WriteLine();
        }
    }
}
