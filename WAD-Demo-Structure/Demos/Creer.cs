namespace WAD_Demo_Structure.Demos
{
    // -- CRÉER UNE STRUCTURE (instancier) --
    // instancier = créer un objet à partir du plan (la struct)
    // Voiture = le plan, voiture = un objet construit avec ce plan
    // on accède à une propriété avec le point : objet.Propriete
    internal static class Creer
    {
        public static void InstancierSansConstructeurDemo()
        {
            Console.WriteLine("-- instancier sans constructeur --");

            // je crée mon objet voiture en mettant directement les valeurs dans ses propriétés
            // les { } = initialiseur d'objet
            Voiture voiture = new()
            {
                Marque = "VW",
                Couleur = "Rouge"
            };

            Console.WriteLine($"la voiture est une {voiture.Marque} de couleur {voiture.Couleur}");
            Console.WriteLine();
        }

        public static void InstancierPuisRemplirLesProprietesDemo()
        {
            Console.WriteLine("-- instancier puis remplir les propriétés --");

            // je crée mon objet
            Voiture voiture = new();

            // ensuite j'insère une valeur dans ses propriétés
            // (Visual Studio propose de "simplifier" : c'est la version avec { } de la démo d'avant)
            voiture.Marque = "Mercedes";
            voiture.Couleur = "Vert";

            Console.WriteLine($"la voiture est une {voiture.Marque} de couleur {voiture.Couleur}");
            Console.WriteLine();
        }

        public static void InstancierAvecConstructeurDemo()
        {
            Console.WriteLine("-- instancier avec constructeur --");

            // les valeurs sont données dans l'ordre des paramètres du constructeur
            // Voiture(string marque, string couleur) -> d'abord la marque, ensuite la couleur
            Voiture voiture = new("Audi", "Vert");

            Console.WriteLine($"la voiture est une {voiture.Marque} de couleur {voiture.Couleur}");
            Console.WriteLine();
        }

        public static void StructAvecPlusieursTypesDemo()
        {
            Console.WriteLine("-- struct avec plusieurs types --");

            // Article mélange des string et un int
            Article article = new()
            {
                Nom = "Pomme",
                Categorie = "Fruit",
                Stock = 15
            };

            Console.WriteLine($"{article.Nom} ({article.Categorie}) : {article.Stock} en stock");
            Console.WriteLine();
        }

        public static void PiegeNewSansArgumentIgnoreLeConstructeurDemo()
        {
            Console.WriteLine("-- piège : new() sans argument ignore le constructeur --");

            // avec une struct, new() sans argument compile TOUJOURS, même si on a écrit un constructeur
            // le constructeur n'est PAS appelé : chaque propriété reçoit sa valeur par défaut
            // string -> null    int -> 0    bool -> false
            Voiture voiture = new();
            Article article = new();

            Console.WriteLine($"marque : '{voiture.Marque}'");                    // '' car null
            Console.WriteLine($"marque : {voiture.Marque ?? "pas de marque"}");  // pas de marque
            Console.WriteLine($"stock  : {article.Stock}");                       // 0
            Console.WriteLine();
        }
    }
}
