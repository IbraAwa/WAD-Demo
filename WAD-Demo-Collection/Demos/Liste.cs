namespace WAD_Demo_Collection.Demos
{
    // -- LES LISTES --  List<T>  Add  AddRange  Insert  Remove  RemoveAt  RemoveRange ...
    // une List range plusieurs valeurs du MÊME type, comme un tableau
    // MAIS sa taille est DYNAMIQUE : elle grandit et rétrécit quand on ajoute ou retire
    // (la classe s'appelle Liste pour ne pas la confondre avec List<T> de C#)
    internal static class Liste
    {
        public static void InitialiserUneListeDemo()
        {
            Console.WriteLine("-- initialiser une List --");

            // entre les chevrons < > on indique le type des éléments
            List<string> semaine = new()
            {
                "lundi", "mardi", "mercredi", "jeudi", "vendredi"
            };

            // pour une List on utilise .Count (et pas .Length comme pour un tableau)
            Console.WriteLine($"{semaine.Count} jours : {string.Join(", ", semaine)}");
            Console.WriteLine();
        }

        public static void AddAjouteUneValeurDemo()
        {
            Console.WriteLine("-- Add() ajoute une valeur à la fin --");

            List<string> semaine = new() { "lundi", "mardi", "mercredi", "jeudi", "vendredi" };

            // rajouter une valeur à la fois
            semaine.Add("samedi");
            semaine.Add("dimanche");

            Console.WriteLine(string.Join(", ", semaine));
            Console.WriteLine();
        }

        public static void AddRangeAjoutePlusieursValeursDemo()
        {
            Console.WriteLine("-- AddRange() ajoute plusieurs valeurs --");

            List<string> semaine = new() { "lundi", "mardi", "mercredi", "jeudi", "vendredi" };
            List<string> weekend = new() { "samedi", "dimanche" };

            // rajouter plusieurs valeurs directement dans semaine
            semaine.AddRange(weekend);

            Console.WriteLine(string.Join(", ", semaine));
            Console.WriteLine();
        }

        public static void ListeAccepteLesDoublonsDemo()
        {
            Console.WriteLine("-- une List accepte les doublons --");

            List<string> semaine = new() { "lundi", "mardi", "samedi", "dimanche" };

            // "samedi" et "dimanche" seront présents 2 fois
            semaine.Add("samedi");
            semaine.Add("dimanche");

            Console.WriteLine(string.Join(", ", semaine));
            Console.WriteLine();
        }

        public static void InsertAjouteAUnIndexPrecisDemo()
        {
            Console.WriteLine("-- Insert() ajoute à un index précis --");

            List<string> semaine = new() { "mardi", "mercredi", "jeudi" };

            // Insert(index, valeur) : les autres éléments sont décalés
            semaine.Insert(0, "lundi");

            Console.WriteLine(string.Join(", ", semaine));
            Console.WriteLine();
        }

        public static void RemoveRetireLaPremiereValeurTrouveeDemo()
        {
            Console.WriteLine("-- Remove() retire une valeur --");

            List<string> semaine = new() { "lundi", "mardi", "mercredi", "jeudi", "mercredi" };

            // retirer une valeur
            // ATTENTION : Remove() retire seulement la PREMIÈRE valeur trouvée
            semaine.Remove("mercredi");

            Console.WriteLine(string.Join(", ", semaine));
            Console.WriteLine();
        }

        public static void RemoveAtRetireAUnIndexPrecisDemo()
        {
            Console.WriteLine("-- RemoveAt() retire à un index précis --");

            List<string> semaine = new() { "lundi", "mardi", "mercredi", "jeudi", "vendredi" };

            // retirer la valeur qui se trouve à l'index 3 (jeudi)
            semaine.RemoveAt(3);

            Console.WriteLine(string.Join(", ", semaine));
            Console.WriteLine();
        }

        public static void RemoveRangeRetirePlusieursValeursDemo()
        {
            Console.WriteLine("-- RemoveRange() retire plusieurs valeurs --");

            List<string> semaine = new() { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };

            // retirer plusieurs éléments en même temps
            // RemoveRange(index de départ, nombre d'éléments à retirer)
            semaine.RemoveRange(1, 4); // retire mardi, mercredi, jeudi, vendredi

            Console.WriteLine(string.Join(", ", semaine));
            Console.WriteLine();
        }

        public static void LireEtModifierAvecLIndexDemo()
        {
            Console.WriteLine("-- lire et modifier avec l'index --");

            List<string> semaine = new() { "lundi", "mardi", "mercredi" };

            // comme un tableau, une List commence à l'index 0
            Console.WriteLine($"premier jour : {semaine[0]}");

            semaine[0] = "LUNDI";
            Console.WriteLine(string.Join(", ", semaine));
            Console.WriteLine();
        }

        public static void ContainsEtIndexOfPourChercherDemo()
        {
            Console.WriteLine("-- Contains() et IndexOf() pour chercher --");

            List<string> semaine = new() { "lundi", "mardi", "mercredi" };

            // Contains() : true si la valeur est présente
            Console.WriteLine($"contient mardi ? {semaine.Contains("mardi")}");

            // IndexOf() : la position de la valeur (-1 si elle n'existe pas)
            Console.WriteLine($"index de mardi : {semaine.IndexOf("mardi")}");
            Console.WriteLine($"index de samedi : {semaine.IndexOf("samedi")}");
            Console.WriteLine();
        }

        public static void ClearVideLaListeDemo()
        {
            Console.WriteLine("-- Clear() vide la liste --");

            List<string> semaine = new() { "lundi", "mardi", "mercredi" };

            semaine.Clear();

            Console.WriteLine($"il reste {semaine.Count} élément(s)");
            Console.WriteLine();
        }
    }
}
