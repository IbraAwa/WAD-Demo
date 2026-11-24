namespace WAD_Demo_Collection.Demos
{
    // -- LES TABLEAUX (ARRAY) --  int[]  new int[5]  { }  [ ]  ..
    // un tableau range plusieurs valeurs du MÊME type dans une seule variable
    // sa taille est FIXE : une fois créé, on ne peut plus ajouter ou retirer de case
    internal static class Tableau
    {
        public static void InitialiserAvecUneTailleDemo()
        {
            Console.WriteLine("-- initialiser un tableau avec une taille (new) --");

            // quand vous utilisez le new avant le type,
            // ce que vous mettez entre les crochets
            // est le nombre de cases disponibles dans votre tableau
            int[] notes = new int[5];

            // .Length donne le nombre de cases du tableau
            Console.WriteLine($"mon tableau contient {notes.Length} cases");
            Console.WriteLine();
        }

        public static void ValeurParDefautDesCasesDemo()
        {
            Console.WriteLine("-- valeur par défaut des cases --");

            // il y aura 5 cases avec la valeur 0
            // car 0 est la valeur par défaut d'un int
            // string -> null    bool -> false    double -> 0
            int[] notes = new int[5];

            foreach (int note in notes)
            {
                Console.WriteLine(note);
            }
            Console.WriteLine();
        }

        public static void InsererAvecLIndexQuiCommenceAZeroDemo()
        {
            Console.WriteLine("-- insérer une valeur avec son index --");

            int[] notes = new int[5];

            // pour insérer des notes dans notes, j'utilise les crochets [] avec l'INDEX (la position)
            // un tableau commence TOUJOURS à l'index 0
            // donc pour 5 cases, les index disponibles sont : 0, 1, 2, 3, 4
            // l'index maximum est toujours : Length - 1
            notes[0] = 12; // première case
            notes[4] = 15; // dernière case

            foreach (int note in notes)
            {
                Console.WriteLine(note);
            }
            Console.WriteLine();
        }

        public static void PiegeIndexEnDehorsDuTableauPlanteDemo()
        {
            Console.WriteLine("-- piège : un index qui n'existe pas --");

            int[] notes = new int[5];

            // ça ne fonctionnera pas : IndexOutOfRangeException (index en dehors du tableau)
            //notes[6] = 15;

            // ça ne fonctionnera pas non plus
            // car un tableau commence toujours par 0
            // donc le maximum d'index disponible est 4
            //notes[5] = 15;

            Console.WriteLine($"index disponibles : de 0 à {notes.Length - 1}");
            Console.WriteLine();
        }

        public static void LireUneCaseAvecSonIndexDemo()
        {
            Console.WriteLine("-- lire une case avec son index --");

            int[] notes = { 12, 8, 17, 10, 15 };

            Console.WriteLine($"première note : {notes[0]}");
            Console.WriteLine($"dernière note : {notes[notes.Length - 1]}");

            // raccourci : ^1 veut dire "la première en partant de la fin"
            Console.WriteLine($"dernière note avec ^1 : {notes[^1]}");
            Console.WriteLine();
        }

        public static void ParcourirAvecForPourAvoirLIndexDemo()
        {
            Console.WriteLine("-- parcourir avec un for --");

            int[] notes = { 12, 8, 17, 10, 15 };

            // on utilise un FOR quand on a besoin de l'index (la position)
            for (int index = 0; index < notes.Length; index++)
            {
                Console.WriteLine($"élève n°{index + 1} : {notes[index]}");
            }
            Console.WriteLine();
        }

        public static void ParcourirAvecForeachPourLireDemo()
        {
            Console.WriteLine("-- parcourir avec un foreach --");

            int[] notes = { 12, 8, 17, 10, 15 };

            // on utilise un FOREACH quand on veut juste LIRE tous les éléments
            foreach (int note in notes)
            {
                Console.WriteLine(note);
            }
            Console.WriteLine();
        }

        public static void InitialiserAvecDesValeursAccoladesDemo()
        {
            Console.WriteLine("-- initialiser avec des valeurs { } (ancienne manière) --");

            // différence avec le new :
            // le new [5] donne le NOMBRE de cases à l'intérieur du tableau
            // les accolades donnent la possibilité de directement mettre des VALEURS
            // (la taille est calculée automatiquement)
            // fonctionne avec tous les types
            string[] jours = { "lundi", "mardi", "mercredi", "jeudi", "vendredi" };
            int[] notesEleve = { 15, 25, 35, 45, 50 };

            // string.Join() affiche tous les éléments séparés par ce qu'on veut (ici ", ")
            Console.WriteLine($"jours : {string.Join(", ", jours)}");
            Console.WriteLine($"notes : {string.Join(", ", notesEleve)}");
            Console.WriteLine();
        }

        public static void InitialiserAvecDesCrochetsDemo()
        {
            Console.WriteLine("-- initialiser avec des valeurs [ ] (nouvelle manière C# 12) --");

            // nouvelle manière d'écrire depuis C# 12 : l'expression de collection
            string[] joursSemaine = ["lundi", "mardi", "mercredi", "jeudi", "vendredi"];
            string[] joursWeekend = ["samedi", "dimanche"];

            Console.WriteLine($"semaine : {string.Join(", ", joursSemaine)}");
            Console.WriteLine($"weekend : {string.Join(", ", joursWeekend)}");
            Console.WriteLine();
        }

        public static void SpreadPourFusionnerDeuxTableauxDemo()
        {
            Console.WriteLine("-- spread .. pour fusionner deux tableaux --");

            string[] joursSemaine = ["lundi", "mardi", "mercredi", "jeudi", "vendredi"];
            string[] joursWeekend = ["samedi", "dimanche"];

            // SPREAD possible grâce à l'utilisation des crochets
            // le .. "étale" tous les éléments d'un tableau dans un autre
            string[] semaineComplete = [.. joursSemaine, .. joursWeekend];

            Console.WriteLine($"semaine complète : {string.Join(", ", semaineComplete)}");
            Console.WriteLine();
        }

        public static void AppendNeModifiePasLeTableauDemo()
        {
            Console.WriteLine("-- Append() pour ajouter un élément --");

            int[] notes = { 12, 8, 17, 10, 15 };

            // un tableau a une taille FIXE : on ne peut pas lui ajouter de case
            // Append() ne modifie PAS le tableau d'origine
            // il crée une NOUVELLE séquence avec l'élément en plus
            IEnumerable<int> nouvellesNotes = notes.Append(14);

            Console.WriteLine($"tableau d'origine : {notes.Length} notes -> {string.Join(", ", notes)}");
            Console.WriteLine($"nouvelle séquence : {nouvellesNotes.Count()} notes -> {string.Join(", ", nouvellesNotes)}");
            Console.WriteLine();
        }

        public static void SpreadPourAjouterUneValeurDemo()
        {
            Console.WriteLine("-- spread .. pour ajouter une valeur --");

            int[] notes = [12, 8, 17, 10, 15];

            // on crée un NOUVEAU tableau avec les anciennes valeurs + la nouvelle
            // si on doit souvent ajouter / retirer : on utilise plutôt une List (Liste.cs)
            int[] notesAvecNouvelEleve = [.. notes, 14];

            Console.WriteLine($"avec le nouvel élève : {string.Join(", ", notesAvecNouvelEleve)}");
            Console.WriteLine();
        }
    }
}
