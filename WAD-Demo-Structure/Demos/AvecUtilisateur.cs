namespace WAD_Demo_Structure.Demos
{
    // -- AVEC L'UTILISATEUR --
    // on réaffecte une propriété avec ce que l'utilisateur tape
    internal static class AvecUtilisateur
    {
        public static void RepeindreLaVoitureDemo()
        {
            Console.WriteLine("-- repeindre la voiture --");

            Voiture voiture = new("BMW", "Rouge");

            Console.WriteLine($"la couleur de la voiture est {voiture.Couleur}");
            Console.WriteLine("Avec quelle couleur voulez-vous repeindre votre voiture ?");

            // vous pouvez réaffecter une nouvelle valeur dans la propriété d'une voiture
            // ReadLine peut renvoyer null, donc ?? pour garder l'ancienne couleur dans ce cas
            string nouvelleCouleur = Console.ReadLine() ?? voiture.Couleur;
            voiture.Couleur = nouvelleCouleur;

            Console.WriteLine();
            Console.WriteLine($"vous avez changé de couleur, votre voiture est maintenant {voiture.Couleur}");
            Console.WriteLine();
        }
    }
}
