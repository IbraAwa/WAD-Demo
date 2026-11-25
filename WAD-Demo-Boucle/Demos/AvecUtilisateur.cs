namespace WAD_Demo_Boucle.Demos
{
    // -- AVEC L'UTILISATEUR --
    // on mélange tout : saisie + TryParse + for / while / do while
    internal static class AvecUtilisateur
    {
        public static void DecompterEntreDeuxNombresSaisisDemo()
        {
            Console.WriteLine("-- décompter entre deux nombres --");

            // choisir le nombre de fois qu'on va répéter la boucle
            // tant que l'utilisateur ne tape pas un nombre, on redemande
            Console.WriteLine("À partir de quel nombre voulez-vous décompter ?");
            int nombreDeDepart;
            while (!int.TryParse(Console.ReadLine(), out nombreDeDepart))
            {
                Console.WriteLine("ce n'est pas un nombre valide, recommencez");
            }

            Console.WriteLine("Et jusqu'à quel nombre voulez-vous qu'on décompte ?");
            int nombreDeFin;
            while (!int.TryParse(Console.ReadLine(), out nombreDeFin))
            {
                Console.WriteLine("ce n'est pas un nombre valide, recommencez");
            }
            Console.WriteLine();

            // si nombreDeDepart < nombreDeFin, la condition est fausse dès le départ -> rien ne s'affiche
            Console.WriteLine($"Vous avez choisi de décompter de {nombreDeDepart} jusqu'à {nombreDeFin}");
            for (int i = nombreDeDepart; i >= nombreDeFin; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        public static void DireBonjourAvecWhileDemo()
        {
            Console.WriteLine("-- dire bonjour (while) --");

            // je veux que mon enfant apprenne à dire "bonjour"
            // tant qu'il ne dit pas bonjour, je continue à lui demander de le dire
            Console.WriteLine("Cher enfant, peux-tu dire 'bonjour' ?");
            string? reponse = Console.ReadLine();

            // attention : "Bonjour" != "bonjour" (sensible à la casse)
            // ToLower() met tout en minuscules, ?. évite le crash si reponse est null
            while (reponse?.ToLower() != "bonjour")
            {
                Console.WriteLine("Non, ce n'est pas comme ça qu'on dit bonjour... dis 'bonjour'");
                reponse = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Merci d'avoir dit bonjour");
            Console.WriteLine();
        }

        public static void MenuAvecFritesDoWhileDemo()
        {
            Console.WriteLine("-- menu avec des frites (do while) --");

            // dans notre menu, le client doit absolument prendre des frites
            // tant qu'il ne prend pas de frites, on continue à lui demander
            // do while car il faut poser la question au moins une fois
            string? choixUtilisateur;
            do
            {
                Console.WriteLine("Que veux-tu dans ton menu ?");
                choixUtilisateur = Console.ReadLine();
            } while (choixUtilisateur != "frites");

            Console.WriteLine("Bon appétit !");
            Console.WriteLine();
        }
    }
}
