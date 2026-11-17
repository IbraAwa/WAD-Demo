namespace WAD_Demo.Demos
{
    // -- AFFICHER DES VARIABLES --  +   $""   {0}
    // 3 façons de mettre une variable dans un texte
    internal static class AfficherDesVariables
    {
        public static void ConcatenationAvecLePlusDemo()
        {
            Console.WriteLine("-- concaténation (+) --");

            string prenom = "Marco";
            string nom = "Rossi";

            // le + colle les textes ensemble (attention aux espaces)
            Console.WriteLine("Votre prénom est : " + prenom + " " + nom);
            Console.WriteLine();
        }

        public static void InterpolationLaFavoriteDemo()
        {
            Console.WriteLine("-- interpolation ($) --");

            string prenom = "Marco";
            string nom = "Rossi";

            // La favorite, très utilisée (interpolation de chaîne)
            // le $ devant les guillemets permet de mettre les variables entre { }
            Console.WriteLine($"Votre prénom est {prenom} {nom}");
            Console.WriteLine();
        }

        public static void FormatAvecDesNumerosPourLesLogsDemo()
        {
            Console.WriteLine("-- format avec numéros ({0}) --");

            string prenom = "Marco";
            string nom = "Rossi";

            // Utilisée pour les logs
            // {0} = la première variable après le texte, {1} = la deuxième...
            Console.WriteLine("Votre prénom est {0} {1}", prenom, nom);
            Console.WriteLine();
        }
    }
}
