namespace WAD_Demo_Methode.Demos
{
    // -- OUT --
    // out permet de faire SORTIR une valeur de la méthode, en plus de son return
    // très utile quand une méthode doit donner PLUSIEURS résultats
    //
    // on l'utilise déjà sans le savoir : int.TryParse("12", out int resultat)
    //   -> le return dit SI la conversion a réussi (bool)
    //   -> le out donne le RÉSULTAT de la conversion
    //
    // règles :
    // - out s'écrit dans la déclaration ET à l'appel
    // - la méthode DOIT donner une valeur au paramètre out avant de se terminer
    // - la variable n'a pas besoin d'avoir une valeur avant l'appel (on peut même la déclarer dans l'appel)
    //
    // ref ou out ?
    // ref -> la valeur ENTRE dans la méthode et peut être modifiée (la variable doit déjà avoir une valeur)
    // out -> la valeur SORT seulement de la méthode (la méthode est obligée de la remplir)
    internal static class Out
    {
        // ----- les fonctions utilisées dans les démos -----

        // on doit tester si la division est possible ET en même temps redonner le résultat
        private static bool Diviser(int a, int b, out decimal resultat)
        {
            // le out doit recevoir une valeur sur TOUS les chemins, même quand ça rate
            resultat = 0m;

            // seule la division PAR zéro est impossible
            // (0 / 5 = 0, ça marche très bien !)
            if (b == 0)
            {
                return false;
            }

            // (decimal) sinon int / int = division entière : 10 / 4 donnerait 2 au lieu de 2,5
            resultat = (decimal)a / b;
            return true;
        }

        private static decimal DiviserMalEcrit(int a, int b)
        {
            // a / b : deux int -> division ENTIÈRE, la partie décimale est perdue AVANT d'arriver dans le decimal
            decimal resultat = a / b;
            return resultat;
        }

        // une méthode qui renvoie DEUX résultats : la plus petite et la plus grande note
        private static void TrouverMinEtMax(int[] notes, out int min, out int max)
        {
            min = notes[0];
            max = notes[0];

            foreach (int note in notes)
            {
                if (note < min)
                {
                    min = note;
                }

                if (note > max)
                {
                    max = note;
                }
            }
        }

        // ----- les démos -----

        public static void OutDansTryParseDemo()
        {
            Console.WriteLine("-- out dans TryParse --");

            // "salut" n'est pas un nombre -> estConverti vaut false et resultat vaut 0
            bool estConverti = int.TryParse("salut", out int resultat);
            Console.WriteLine($"\"salut\" -> converti ? {estConverti}, résultat : {resultat}");

            estConverti = int.TryParse("42", out resultat);
            Console.WriteLine($"\"42\"    -> converti ? {estConverti}, résultat : {resultat}");
            Console.WriteLine();
        }

        public static void OutDivisionDemo()
        {
            Console.WriteLine("-- out : une division qui peut échouer --");

            bool estDivisible = Diviser(10, 4, out decimal resultat);
            if (estDivisible)
            {
                Console.WriteLine($"10 / 4 : ma division donne {resultat}");
            }
            else
            {
                Console.WriteLine("10 / 4 : ma division est impossible");
            }

            // on peut aussi mettre l'appel directement dans le if
            if (Diviser(10, 0, out decimal resultat2))
            {
                Console.WriteLine($"10 / 0 : ma division donne {resultat2}");
            }
            else
            {
                Console.WriteLine("10 / 0 : ma division est impossible");
            }
            Console.WriteLine();
        }

        public static void OutRenvoyerPlusieursValeursDemo()
        {
            Console.WriteLine("-- out : renvoyer plusieurs valeurs --");

            // return ne peut renvoyer qu'UNE valeur, mais on peut avoir plusieurs out
            int[] notes = [12, 8, 17, 14];
            TrouverMinEtMax(notes, out int plusPetite, out int plusGrande);

            Console.WriteLine($"la plus petite note est {plusPetite}, la plus grande est {plusGrande}");
            Console.WriteLine();
        }

        public static void PiegeDivisionEntiereDansLaMethodeDemo()
        {
            Console.WriteLine("-- piège : division entière dans la méthode --");

            // même si la méthode renvoie un decimal, a / b avec deux int fait une division entière
            Console.WriteLine($"mal écrit : 10 / 4 = {DiviserMalEcrit(10, 4)}"); // 2
            Diviser(10, 4, out decimal resultat);
            Console.WriteLine($"bien écrit : 10 / 4 = {resultat}");             // 2,5
            Console.WriteLine();
        }

        public static void PiegeOutPasRempliDemo()
        {
            Console.WriteLine("-- piège : oublier de remplir le out --");

            // une méthode qui ne donne pas de valeur à son paramètre out -> erreur CS0177
            // "le paramètre de sortie 'resultat' doit être assigné avant que le contrôle quitte la méthode actuelle"
            // décommenter pour voir l'erreur
            //static bool DiviserSansRemplirLeOut(int a, int b, out decimal resultat)
            //{
            //    if (b == 0)
            //    {
            //        return false; // <- ici resultat n'a reçu aucune valeur
            //    }
            //    resultat = (decimal)a / b;
            //    return true;
            //}

            Console.WriteLine("règle : le out doit recevoir une valeur sur TOUS les chemins");
            Console.WriteLine();
        }
    }
}
