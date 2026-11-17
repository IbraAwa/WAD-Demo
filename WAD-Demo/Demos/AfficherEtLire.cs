namespace WAD_Demo.Demos
{
    // -- AFFICHER ET LIRE DANS LA CONSOLE --  WriteLine Write Clear
    // (ReadLine attend que l'utilisateur tape quelque chose, il est dans AvecUtilisateur.cs)
    internal static class AfficherEtLire
    {
        public static void WriteLineEcritPuisRevientALaLigneDemo()
        {
            Console.WriteLine("-- WriteLine --");

            // Toujours utiliser le WriteLine (il revient à la ligne après le texte)
            Console.WriteLine("Salut, je suis un WriteLine");
            Console.WriteLine("et moi je suis donc sur la ligne suivante");
            Console.WriteLine();
        }

        public static void WriteEcritSansRevenirALaLigneDemo()
        {
            Console.WriteLine("-- Write --");

            // Write écrit sans revenir à la ligne
            Console.Write("Salut, je suis un Write");
            Console.Write(" et je reste sur la même ligne");
            Console.WriteLine(); // un WriteLine vide pour revenir à la ligne
            Console.WriteLine();
        }

        public static void AstuceCwPuisTabDemo()
        {
            Console.WriteLine("-- astuce cw --");

            // Astuce : taper "cw" puis Tab (ou Entrée) génère Console.WriteLine();
            Console.WriteLine("On peut écrire Console.WriteLine juste en tapant cw puis Tab");
            Console.WriteLine();
        }

        public static void ClearEffaceLaConsoleDemo()
        {
            Console.WriteLine("-- Clear --");

            Console.WriteLine("Je vais disparaître avec le Clear");

            // Clear efface tout ce qui a été affiché dans la console avant son appel
            Console.Clear();

            // Ce texte s'affiche car il est écrit après l'appel de la méthode Clear
            Console.WriteLine("J'apparais après le Clear car je suis après l'appel de la méthode");
            Console.WriteLine();
        }
    }
}
