namespace WAD_Demo.Demos
{
    // -- AVEC L'UTILISATEUR --  ReadLine
    internal static class AvecUtilisateur
    {
        public static void ReadLineLitCeQueLUtilisateurTapeDemo()
        {
            Console.WriteLine("-- ReadLine --");

            // WriteLine : écrire dans la console
            Console.WriteLine("Tapez votre prénom");

            // ReadLine : lire dans la console ce que l'utilisateur a écrit (jusqu'à Entrée)
            // ReadLine donne un string? (nullable) car il peut ne rien recevoir
            string? prenom = Console.ReadLine();

            Console.WriteLine($"Bonjour {prenom}");
            Console.WriteLine();
        }

        // Exemple général sur les variables
        public static void PrenomEtNomSaisisAffichesDeTroisFaconsDemo()
        {
            Console.WriteLine("-- prénom et nom saisis --");

            Console.WriteLine("Pouvez-vous écrire votre prénom s'il vous plaît ?");
            string? prenomChoice = Console.ReadLine();
            Console.WriteLine("Pouvez-vous écrire votre nom s'il vous plaît ?");
            string? nomChoice = Console.ReadLine();

            Console.WriteLine("Votre prénom est : " + prenomChoice + " " + nomChoice);
            Console.WriteLine();
            // La favorite, très utilisée (interpolation de chaîne)
            Console.WriteLine($"Votre prénom est {prenomChoice} {nomChoice}");
            Console.WriteLine();
            // Utilisée pour les logs
            Console.WriteLine("Votre prénom est {0} {1}", prenomChoice, nomChoice);
            Console.WriteLine();
        }
    }
}
