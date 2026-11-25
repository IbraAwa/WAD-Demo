namespace WAD_Demo_Boucle.Demos
{
    // -- FOR --
    // on l'utilise quand :
    // - on est sûr du nombre de fois qu'on va répéter l'action
    // - on veut aller chercher un élément dans un tableau via son index
    //
    //   initialiseur  condition  itérateur
    // for(int i = 0 ; i < 5     ; i++)
    //
    // initialiseur = exécuté UNE seule fois, au début
    // condition    = vérifiée AVANT chaque tour, si elle est fausse on sort de la boucle
    // itérateur    = exécuté à la FIN de chaque tour
    internal static class For
    {
        public static void ForCompterDe0A4Demo()
        {
            Console.WriteLine("-- for de 0 à 4 --");

            // i commence à 0 et s'arrête AVANT 5 -> 5 tours (0, 1, 2, 3, 4)
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"je suis au numéro {i}");
            }
            Console.WriteLine();
        }

        public static void ForToursDeCircuitF1Demo()
        {
            Console.WriteLine("-- tours de circuit F1 --");

            // je suis un pilote de F1 et je dois faire 5 tours de circuit pour la compétition
            // ici on commence à 1 et on utilise <= pour afficher les tours de 1 à 5
            int nombreDeTours = 5;

            for (int tour = 1; tour <= nombreDeTours; tour++)
            {
                Console.WriteLine($"mon pilote est au tour {tour}");
            }
            Console.WriteLine();
        }

        public static void PiegeUnTourEnTropAvecInferieurOuEgalDemo()
        {
            Console.WriteLine("-- piège : un tour en trop --");

            // on commence à 0 ET on utilise <= ...
            // 0, 1, 2, 3, 4, 5 -> 6 tours au lieu de 5 !
            // règle : départ 0 -> <       départ 1 -> <=
            int nombreDeTours = 5;
            int toursFaits = 0;

            for (int tour = 0; tour <= nombreDeTours; tour++)
            {
                toursFaits++;
            }
            Console.WriteLine($"le pilote a fait {toursFaits} tours au lieu de {nombreDeTours}"); // 6
            Console.WriteLine();
        }

        public static void ForDecompteFuseeDemo()
        {
            Console.WriteLine("-- décompte de la fusée --");

            // un décompte de 10 -> 0 pour lancer notre fusée
            // on part du haut, on continue tant que i >= 0, et on fait i-- (on descend)
            Console.WriteLine("Départ de la fusée dans...");
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Décollage !");
            Console.WriteLine();
        }

        public static void ForParcourirUnTableauAvecLIndexDemo()
        {
            Console.WriteLine("-- parcourir un tableau avec l'index --");

            string[] pilotes = ["Hamilton", "Verstappen", "Leclerc"];

            // le premier index est 0, le dernier est Length - 1
            // donc i < pilotes.Length (et PAS <=)
            for (int i = 0; i < pilotes.Length; i++)
            {
                Console.WriteLine($"position {i + 1} : {pilotes[i]}");
            }
            Console.WriteLine();
        }

        public static void PiegeIndexEnDehorsDuTableauDemo()
        {
            Console.WriteLine("-- piège : index en dehors du tableau --");

            string[] pilotes = ["Hamilton", "Verstappen", "Leclerc"];

            // avec <= on va jusqu'à pilotes[3] qui n'existe pas (le dernier est pilotes[2])
            // -> IndexOutOfRangeException, le programme plante
            // décommenter pour voir le crash
            //for (int i = 0; i <= pilotes.Length; i++)
            //{
            //    Console.WriteLine(pilotes[i]);
            //}

            Console.WriteLine($"{pilotes.Length} pilotes -> index de 0 à {pilotes.Length - 1}");
            Console.WriteLine();
        }
    }
}
