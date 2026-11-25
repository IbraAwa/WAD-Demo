namespace WAD_Demo_Methode.Demos
{
    // -- FONCTION --
    // une fonction est une méthode qui RENVOIE une valeur grâce au mot-clé return
    // avant son nom, on écrit le TYPE de la valeur renvoyée (à la place de void)
    //
    //   static   int           Addition   (int a, int b)
    //   mot-clé  type retour   nom        paramètres
    //
    // - return renvoie la valeur ET arrête la méthode tout de suite
    // - la valeur renvoyée doit être du type annoncé (une addition de int renvoie un int)
    // - on récupère le résultat dans une variable, ou on l'utilise directement
    internal static class Fonction
    {
        // ----- les fonctions utilisées dans les démos -----

        private static int Addition(int a, int b)
        {
            // version longue : on range le résultat dans une variable, puis on la renvoie
            int resultat = a + b;
            return resultat;

            // version plus simple, sans variable : return a + b;
        }

        // une fonction peut avoir plusieurs paramètres, de types différents
        private static decimal Soustraction(int a, decimal b)
        {
            // int - decimal -> decimal (conversion implicite du int)
            return a - b;
        }

        // string? car cette fonction peut renvoyer null
        private static string? Signe(int nombre)
        {
            if (nombre > 0)
            {
                return "Positif";
            }

            if (nombre < 0)
            {
                return "Négatif";
            }

            // ni positif, ni négatif (c'est 0) -> on renvoie null
            // sans ce dernier return : erreur CS0161 "tous les chemins de code ne retournent pas nécessairement une valeur"
            return null;
        }

        private static string PasserLeBonjourA(string prenom, string nom)
        {
            return $"Bonjour {prenom} {nom}";
        }

        private static bool EstMajeur(int age)
        {
            if (age >= 18)
            {
                return true; // on sort ici, la suite n'est pas exécutée
            }

            return false;
        }

        // ----- les démos -----

        public static void DeclarerEtInvoquerUneFonctionDemo()
        {
            Console.WriteLine("-- déclarer et invoquer une fonction --");

            // on invoque la fonction et on récupère ce qu'elle renvoie dans une variable
            int resultat = Addition(5, 5);
            Console.WriteLine($"5 + 5 = {resultat}");
            Console.WriteLine();
        }

        public static void UtiliserLeResultatDirectementDemo()
        {
            Console.WriteLine("-- utiliser le résultat directement --");

            // pas obligé de passer par une variable : l'appel "devient" la valeur renvoyée
            Console.WriteLine($"2 + 3 = {Addition(2, 3)}");

            // on peut même donner le résultat d'une fonction comme argument d'une autre
            // Addition(1, 2) vaut 3, puis Addition(3, 10) vaut 13
            Console.WriteLine($"1 + 2 + 10 = {Addition(Addition(1, 2), 10)}");
            Console.WriteLine();
        }

        public static void FonctionAvecDesParametresDeTypesDifferentsDemo()
        {
            Console.WriteLine("-- paramètres de types différents --");

            // chaque paramètre déclaré doit recevoir un argument à CHAQUE appel
            // (sauf les paramètres facultatifs, voir le chapitre suivant)
            // et dans le bon ordre : d'abord le int, puis le decimal
            decimal difference = Soustraction(10, 5.50m);
            Console.WriteLine($"10 - 5,50 = {difference}");
            Console.WriteLine();
        }

        public static void TousLesCheminsDoiventRenvoyerUneValeurDemo()
        {
            Console.WriteLine("-- tous les chemins doivent renvoyer une valeur --");

            // quand vous écrivez une fonction, faites toujours en sorte que TOUS les chemins du code renvoient une valeur
            // dans Signe : si > 0 -> return, si < 0 -> return, sinon -> return null
            // je veux savoir si mon nombre est positif ou négatif
            string? signeTrouve = Signe(-9);
            Console.WriteLine($"-9 est {signeTrouve}");
            Console.WriteLine($"5 est {Signe(5)}");
            Console.WriteLine();
        }

        public static void FonctionQuiPeutRenvoyerNullAvecCoalesceDemo()
        {
            Console.WriteLine("-- une fonction qui peut renvoyer null + ?? --");

            // Signe(0) renvoie null
            // utilisation de ?? (coalesce) : si c'est null, on prend la valeur de droite
            string signeTrouve = Signe(0) ?? "Zéro n'est ni négatif ni positif";
            Console.WriteLine(signeTrouve);
            Console.WriteLine();
        }

        public static void FonctionQuiRenvoieUnTexteDemo()
        {
            Console.WriteLine("-- une fonction qui renvoie un texte --");

            // cette fonction prépare le bonjour pour quelqu'un en particulier
            // elle n'AFFICHE rien : elle RENVOIE le texte, c'est nous qui décidons quoi en faire
            string bonjourJohn = PasserLeBonjourA("John", "Doe");
            string bonjourBernard = PasserLeBonjourA("Bernard", "Lechèvre");

            Console.WriteLine(bonjourJohn);
            Console.WriteLine(bonjourBernard);
            Console.WriteLine();
        }

        public static void ReturnArreteLaMethodeDemo()
        {
            Console.WriteLine("-- return arrête la méthode --");

            // dans EstMajeur, si l'âge est >= 18, le premier return sort de la méthode
            // le "return false" n'est alors jamais atteint
            Console.WriteLine($"20 ans -> majeur ? {EstMajeur(20)}");
            Console.WriteLine($"15 ans -> majeur ? {EstMajeur(15)}");
            Console.WriteLine();
        }

        public static void PiegeOublierDeRecupererLeResultatDemo()
        {
            Console.WriteLine("-- piège : oublier de récupérer le résultat --");

            // ceci compile... mais le résultat (10) est calculé puis PERDU : on n'en fait rien
            Addition(5, 5);

            // il faut le ranger dans une variable ou l'utiliser directement
            int resultat = Addition(5, 5);
            Console.WriteLine($"cette fois on a gardé le résultat : {resultat}");
            Console.WriteLine();
        }
    }
}
