namespace WAD_Demo_Collection.Demos
{
    // -- LES DICTIONNAIRES --  Dictionary<TKey, TValue>  [clé]  Add  ContainsKey  TryGetValue  Remove
    // un Dictionary range des paires CLÉ -> VALEUR
    // la clé est UNIQUE (pas de doublon) et on retrouve une valeur grâce à sa clé (plus avec un index)
    // imaginons mon programme gère le stock de fruits d'un magasin
    internal static class Dictionnaire
    {
        public static void InitialiserUnDictionnaireDemo()
        {
            Console.WriteLine("-- initialiser un Dictionary --");

            // Dictionary<type de la clé, type de la valeur>
            Dictionary<string, int> fruitStocks = new()
            {
                ["pommes"] = 12,
                ["bananes"] = 5
            };

            // .Count donne le nombre de paires clé -> valeur
            Console.WriteLine($"{fruitStocks.Count} fruits différents en stock");
            Console.WriteLine();
        }

        public static void ParcourirAvecKeyEtValueDemo()
        {
            Console.WriteLine("-- parcourir avec .Key et .Value --");

            Dictionary<string, int> fruitStocks = new()
            {
                ["pommes"] = 12,
                ["bananes"] = 5
            };

            foreach (var fruitStock in fruitStocks)
            {
                // récupérer la clé : nom de la variable.Key
                // récupérer la valeur associée à la clé : nom de la variable.Value
                Console.WriteLine($"on possède {fruitStock.Value} {fruitStock.Key}");
            }
            Console.WriteLine();
        }

        public static void CrochetsCreeOuRemplaceLaValeurDemo()
        {
            Console.WriteLine("-- [clé] = valeur crée ou remplace --");

            Dictionary<string, int> fruitStocks = new() { ["pommes"] = 12 };

            // la clé "kiwis" n'existe pas : elle est CRÉÉE avec la valeur 8
            fruitStocks["kiwis"] = 8;
            Console.WriteLine($"kiwis : {fruitStocks["kiwis"]}");

            // la clé "kiwis" existe déjà : la valeur est REMPLACÉE par 15
            fruitStocks["kiwis"] = 15;
            Console.WriteLine($"kiwis : {fruitStocks["kiwis"]}");
            Console.WriteLine();
        }

        public static void PlusEgalAjouteALaValeurDemo()
        {
            Console.WriteLine("-- [clé] += ajoute à la valeur --");

            Dictionary<string, int> fruitStocks = new() { ["kiwis"] = 8 };

            // fait la somme de la valeur actuelle + la valeur 7
            fruitStocks["kiwis"] += 7; // fruitStocks["kiwis"] = fruitStocks["kiwis"] + 7 -> 15
            Console.WriteLine($"kiwis : {fruitStocks["kiwis"]}");
            Console.WriteLine();
        }

        public static void PiegeAddPlanteSiLaCleExisteDejaDemo()
        {
            Console.WriteLine("-- piège : Add() plante si la clé existe déjà --");

            Dictionary<string, int> fruitStocks = new() { ["pommes"] = 12 };

            // Add() ajoute une nouvelle clé
            fruitStocks.Add("fraises", 20);

            // mais plante si la clé existe déjà : ArgumentException
            //fruitStocks.Add("fraises", 30);

            Console.WriteLine($"fraises : {fruitStocks["fraises"]}");
            Console.WriteLine();
        }

        public static void PiegeLireUneCleQuiNExistePasPlanteDemo()
        {
            Console.WriteLine("-- piège : lire une clé qui n'existe pas --");

            Dictionary<string, int> fruitStocks = new() { ["pommes"] = 12 };

            // la clé "ananas" n'existe pas : KeyNotFoundException
            //Console.WriteLine(fruitStocks["ananas"]);

            Console.WriteLine("pour éviter ça : ContainsKey() ou TryGetValue()");
            Console.WriteLine();
        }

        public static void ContainsKeyPourVerifierAvantDeLireDemo()
        {
            Console.WriteLine("-- ContainsKey() pour vérifier avant de lire --");

            Dictionary<string, int> fruitStocks = new() { ["pommes"] = 12 };

            if (fruitStocks.ContainsKey("ananas"))
            {
                Console.WriteLine($"on a {fruitStocks["ananas"]} ananas");
            }
            else
            {
                Console.WriteLine("pas d'ananas en stock");
            }
            Console.WriteLine();
        }

        public static void TryGetValueVerifieEtLitEnUneFoisDemo()
        {
            Console.WriteLine("-- TryGetValue() vérifie et lit en une fois --");

            Dictionary<string, int> fruitStocks = new() { ["pommes"] = 12 };
            int livraisonOranges = 10;

            // renvoie true  si la clé existe, et met la valeur dans la variable out
            // renvoie false si la clé n'existe pas, et met la valeur par défaut (0 pour un int)
            bool estPossede = fruitStocks.TryGetValue("oranges", out int quantite);

            if (estPossede)
            {
                fruitStocks["oranges"] = quantite + livraisonOranges;
                Console.WriteLine($"j'avais {quantite} oranges, j'en ai rajouté {livraisonOranges}");
            }
            else
            {
                fruitStocks["oranges"] = 0;
                Console.WriteLine("je n'ai pas d'oranges dans mon stock, mais j'initialise à 0");
            }
            Console.WriteLine();
        }

        public static void RemoveRetireUneCleDemo()
        {
            Console.WriteLine("-- Remove() retire une clé --");

            Dictionary<string, int> fruitStocks = new()
            {
                ["pommes"] = 12,
                ["bananes"] = 5
            };

            // retire la clé ET sa valeur
            fruitStocks.Remove("bananes");

            foreach (var fruitStock in fruitStocks)
            {
                Console.WriteLine($"on possède {fruitStock.Value} {fruitStock.Key}");
            }
            Console.WriteLine();
        }
    }
}
