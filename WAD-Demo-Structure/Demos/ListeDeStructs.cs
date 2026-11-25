namespace WAD_Demo_Structure.Demos
{
    // -- UNE LIST DE STRUCTS --
    // une struct est un type comme un autre : on peut en faire une List<Voiture>
    // imaginons un garage qui range plusieurs voitures
    internal static class ListeDeStructs
    {
        public static void ListeDeVoituresDemo()
        {
            Console.WriteLine("-- List<Voiture> --");

            List<Voiture> garage = new()
            {
                new("BMW", "Rouge"),
                new("Audi", "Vert")
            };

            // ajouter une voiture après coup
            garage.Add(new Voiture { Marque = "VW", Couleur = "Bleu" });

            // on utilise un FOREACH car on veut juste lire chaque voiture une par une
            foreach (Voiture voiture in garage)
            {
                Console.WriteLine($"- {voiture.Marque} {voiture.Couleur}");
            }
            Console.WriteLine($"{garage.Count} voiture(s) dans le garage");
            Console.WriteLine();
        }

        public static void PiegeModifierUneStructDansUneListeDemo()
        {
            Console.WriteLine("-- piège : modifier une struct dans une List --");

            List<Voiture> garage = new()
            {
                new("BMW", "Rouge"),
                new("Audi", "Vert")
            };

            // garage[0] nous donne une COPIE de la voiture (type valeur)
            // modifier la copie ne servirait à rien, donc le compilateur refuse
            // décommenter pour voir l'erreur
            //garage[0].Couleur = "Noir";

            // pareil dans un foreach : la variable 'voiture' est une copie en lecture seule
            //foreach (Voiture voiture in garage)
            //{
            //    voiture.Couleur = "Noir";
            //}

            // la solution : 1. je récupère la copie  2. je la modifie  3. je la remets dans la liste
            Voiture voitureARepeindre = garage[0];
            voitureARepeindre.Couleur = "Noir";
            garage[0] = voitureARepeindre;

            Console.WriteLine($"la {garage[0].Marque} est maintenant {garage[0].Couleur}"); // Noir
            Console.WriteLine();
        }
    }
}
