namespace WAD_Demo_Boucle.Demos
{
    // -- FOREACH --
    // récupère la valeur de chaque élément d'une collection (tableau, List...), un par un
    // attention : il ne récupère pas l'index (si on a besoin de l'index -> for)
    // pas de condition, pas de compteur : il s'arrête tout seul à la fin de la collection
    internal static class Foreach
    {
        public static void ForeachFruitsEtLegumesDemo()
        {
            Console.WriteLine("-- fruits et légumes --");

            string[] fruitsLegumes = ["Pomme", "Poire", "Banane", "Brocoli", "Tomate", "Haricot"];

            // "pour chaque fruitLegume dans fruitsLegumes"
            // convention : la collection au pluriel, l'élément au singulier
            foreach (string fruitLegume in fruitsLegumes)
            {
                Console.WriteLine(fruitLegume);
            }
            Console.WriteLine();
        }

        public static void ForeachNotesReussiOuEchoueDemo()
        {
            Console.WriteLine("-- notes : réussi ou échoué --");

            int[] notesEleves = [12, 15, 18, 9, 7, 2, 12, 10];

            // on peut mettre un if dans une boucle
            foreach (int noteEleve in notesEleves)
            {
                if (noteEleve >= 10)
                {
                    Console.WriteLine($"vous avez réussi avec la note de {noteEleve}");
                }
                else
                {
                    Console.WriteLine($"vous avez échoué avec la note de {noteEleve}");
                }
            }
            Console.WriteLine();
        }

        public static void ForeachCalculerLaMoyenneDemo()
        {
            Console.WriteLine("-- calculer la moyenne --");

            int[] notesEleves = [12, 15, 18, 9, 7, 2, 12, 10];

            // on déclare la somme AVANT la boucle, sinon elle repartirait à 0 à chaque tour
            int somme = 0;
            foreach (int noteEleve in notesEleves)
            {
                somme += noteEleve;
            }

            // (double) sinon division entière : 85 / 8 = 10 au lieu de 10,625
            double moyenne = (double)somme / notesEleves.Length;
            Console.WriteLine($"somme : {somme}  moyenne : {moyenne:0.00}");
            Console.WriteLine();
        }

        public static void PiegeForeachEnLectureSeuleDemo()
        {
            Console.WriteLine("-- piège : foreach en lecture seule --");

            int[] notesEleves = [12, 15, 9];

            // la variable du foreach est en LECTURE SEULE : on ne peut pas la modifier
            // décommenter pour voir l'erreur de compilation
            //foreach (int noteEleve in notesEleves)
            //{
            //    noteEleve = noteEleve + 1;
            //}

            // pour modifier le tableau, il faut l'index -> for
            for (int i = 0; i < notesEleves.Length; i++)
            {
                notesEleves[i] = notesEleves[i] + 1;
            }
            Console.WriteLine($"notes avec 1 point bonus : {string.Join(", ", notesEleves)}");
            Console.WriteLine();
        }
    }
}
