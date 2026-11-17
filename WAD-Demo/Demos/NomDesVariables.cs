namespace WAD_Demo.Demos
{
    // -- LE NOM DES VARIABLES --  déclarer, casse, camelCase, var
    internal static class NomDesVariables
    {
        public static void DeclarerUneVariableTypeIdentifiantValeurDemo()
        {
            Console.WriteLine("-- déclarer une variable --");

            // -- Déclarer une variable --
            // Type Identifiant = valeur;
            // Identifiant = nom de la variable

            string villeDuClient = "Bruxelles"; // Variable en camelCase
            // (minuscule pour la première lettre, puis une majuscule à chaque nouveau mot)
            Console.WriteLine($"ville du client : {villeDuClient}");
            Console.WriteLine();
        }

        public static void SensibleALaCasseMajusculeMinusculeDemo()
        {
            Console.WriteLine("-- sensible à la casse --");

            // Les variables sont sensibles à la casse (majuscules / minuscules) :
            // il faut exactement le même nom pour que C# les considère comme la même variable.
            // Ici, ce sont donc 3 variables différentes :
            int age = 20;
            int Age = 25;
            int AGE = 35;
            Console.WriteLine($"age = {age}, Age = {Age}, AGE = {AGE}");

            // Erreur de compilation : la variable AGE existe déjà, on ne peut pas la redéclarer
            // int AGE = 40;
            Console.WriteLine();
        }

        public static void ConventionCamelCaseDemo()
        {
            Console.WriteLine("-- convention camelCase --");

            // Convention en C# : les variables locales s'écrivent en camelCase
            // (première lettre en minuscule, puis une majuscule à chaque nouveau mot)
            // ex : prenom, compteBancaire, estMajeur
            string nom = "Rossi";

            // Mauvais exemple : nOm fonctionne, mais ne respecte pas la convention
            string nOm = "Rossi";
            Console.WriteLine($"nom : {nom}, nOm : {nOm} (les deux marchent, mais seul nom est propre)");
            Console.WriteLine();
        }

        public static void ChangerLaValeurSansRemettreLeTypeDemo()
        {
            Console.WriteLine("-- changer la valeur --");

            int age = 19;
            Console.WriteLine($"âge avant son anniversaire : {age}");

            // On peut changer la valeur d'une variable déjà déclarée (sans remettre le type)
            age = 20;
            Console.WriteLine($"âge après son anniversaire : {age}");
            Console.WriteLine();
        }

        public static void VarLaisseCSharpDevinerLeTypeDemo()
        {
            Console.WriteLine("-- var --");

            // var permet de ne pas préciser le type : c'est C# qui le déduit à partir de la valeur
            // Attention : très déconseillé
            // Ça reste fortement typé
            var nombreDeJoursDansUneSemaine = 7; // C# devine que c'est un int

            // fortement typé = une fois que C# a choisi int, ça reste un int pour toujours
            // nombreDeJoursDansUneSemaine = "sept"; // ERREUR : on ne peut pas ranger du texte dans un int
            Console.WriteLine($"jours dans une semaine : {nombreDeJoursDansUneSemaine}");
            Console.WriteLine();
        }
    }
}
