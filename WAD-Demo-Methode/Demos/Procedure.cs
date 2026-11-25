namespace WAD_Demo_Methode.Demos
{
    // -- PROCÉDURE --
    // une procédure est une méthode qui FAIT quelque chose (afficher, modifier...)
    // mais qui ne RENVOIE rien -> son type de retour est void (= "rien")
    //
    //   static   void          Bonjour   ()
    //   mot-clé  type retour   nom       paramètres (ici aucun)
    //
    // - le nom d'une méthode commence par une MAJUSCULE et décrit une action (un verbe) : Afficher, Calculer, DireBonjour...
    // - dans une static class, la méthode doit aussi être static
    //   (dans Program.cs on peut écrire une méthode directement, sans static ni class)
    // - DÉCLARER une méthode ne l'exécute pas : il faut l'INVOQUER (l'appeler) avec son nom + ()
    internal static class Procedure
    {
        // ----- les procédures utilisées dans les démos -----

        private static void Bonjour()
        {
            Console.WriteLine("Bonjour");
        }

        private static void DireBonjourA(string prenom)
        {
            Console.WriteLine($"Bonjour {prenom} !");
        }

        private static void AfficherSeparateur(char caractere, int longueur)
        {
            for (int i = 0; i < longueur; i++)
            {
                Console.Write(caractere);
            }
            Console.WriteLine();
        }

        private static void PreparerUnCafe()
        {
            // cette variable n'existe QUE dans la méthode PreparerUnCafe
            string boisson = "café";
            Console.WriteLine($"je prépare un {boisson}");
        }

        // ----- les démos -----

        public static void DeclarerEtInvoquerUneProcedureDemo()
        {
            Console.WriteLine("-- déclarer et invoquer une procédure --");

            // la procédure Bonjour est déclarée plus haut (dans la class)
            // pour l'invoquer (l'appeler) : son nom + ()
            Bonjour();
            Console.WriteLine();
        }

        public static void InvoquerUneProcedurePlusieursFoisDemo()
        {
            Console.WriteLine("-- invoquer plusieurs fois --");

            // tout l'intérêt d'une méthode : on écrit le code UNE fois
            // et on peut l'appeler autant de fois qu'on veut
            Bonjour();
            Bonjour();
            Bonjour();
            Console.WriteLine();
        }

        public static void ProcedureAvecUnParametreDemo()
        {
            Console.WriteLine("-- procédure avec un paramètre --");

            // un paramètre = une information qu'on DONNE à la méthode quand on l'appelle
            // paramètre = la variable dans la déclaration (string prenom)
            // argument  = la valeur qu'on envoie à l'appel ("Myriam")
            DireBonjourA("Myriam");
            DireBonjourA("Eva");
            DireBonjourA("Léa");

            // on peut aussi envoyer une variable
            string prenom = "Clem";
            DireBonjourA(prenom);
            Console.WriteLine();
        }

        public static void ProcedureAvecPlusieursParametresDemo()
        {
            Console.WriteLine("-- procédure avec plusieurs paramètres --");

            // les paramètres sont séparés par des virgules
            // à l'appel : on donne les arguments DANS LE MÊME ORDRE et avec LE BON TYPE
            AfficherSeparateur('=', 20);
            AfficherSeparateur('*', 10);
            AfficherSeparateur('-', 30);

            // AfficherSeparateur(20, '=');   -> erreur : mauvais ordre (un int à la place d'un char)
            // AfficherSeparateur('=');       -> erreur : il manque un argument
            Console.WriteLine();
        }

        public static void PiegeUneVariableDeLaMethodeNExistePasDehorsDemo()
        {
            Console.WriteLine("-- piège : la portée d'une variable --");

            PreparerUnCafe();

            // la variable boisson a été déclarée DANS PreparerUnCafe
            // elle n'existe que entre les { } de cette méthode -> ici elle est inconnue
            // décommenter pour voir l'erreur (CS0103 : le nom 'boisson' n'existe pas dans le contexte actuel)
            //Console.WriteLine(boisson);

            // si on a besoin d'une valeur calculée dans une méthode -> c'est le rôle d'une FONCTION (return)
            Console.WriteLine();
        }

        public static void PiegeUneProcedureNeRenvoieRienDemo()
        {
            Console.WriteLine("-- piège : une procédure ne renvoie rien --");

            // Bonjour est void : elle ne renvoie RIEN, on ne peut donc rien ranger dans une variable
            // décommenter pour voir l'erreur (impossible de convertir 'void' en 'string')
            //string texte = Bonjour();

            Console.WriteLine("void = la méthode fait une action, mais ne donne pas de résultat");
            Console.WriteLine();
        }
    }
}
