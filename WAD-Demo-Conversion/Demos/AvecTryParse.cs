namespace WAD_Demo_Conversion.Demos
{
    // -- TRYPARSE --  int.TryParse(texte, out int resultat)
    // manière de convertir avec sa vérification (tryParse)
    // il donne un bool : true si la conversion a réussi, false sinon (et il ne plante jamais)
    // le résultat de la conversion sort par le 'out'
    internal static class AvecTryParse
    {
        // ici on fait comme si l'utilisateur avait tapé "25" (la vraie saisie est dans AvecUtilisateur.cs)

        public static void PremiereManiereOutIntDansLaParentheseDemo()
        {
            Console.WriteLine("-- première manière : out int dans la parenthèse --");

            string saisie = "25";
            bool conversionReussie = int.TryParse(saisie, out int age);
            if (conversionReussie)
            {
                Console.WriteLine($"Votre conversion est réussie : {age}");
            }
            else
            {
                Console.WriteLine("Conversion non réussie");
            }
            Console.WriteLine();
        }

        public static void DeuxiemeManiereVariableDeclareeAvantDemo()
        {
            Console.WriteLine("-- deuxième manière : variable déclarée avant --");

            string saisie = "25";
            int age;
            // age = 25
            bool conversionReussie = int.TryParse(saisie, out age);
            if (conversionReussie)
            {
                Console.WriteLine($"Votre conversion est réussie : {age}");
            }
            else
            {
                Console.WriteLine("Conversion non réussie");
            }
            Console.WriteLine();
        }

        public static void TroisiemeManiereDirectementDansLeIfDemo()
        {
            Console.WriteLine("-- troisième manière : directement dans le if --");

            // la plus courte et la plus utilisée
            string saisie = "25";
            if (int.TryParse(saisie, out int age))
            {
                Console.WriteLine($"Votre conversion est réussie : {age}");
            }
            else
            {
                Console.WriteLine("Votre conversion est ratée");
            }
            Console.WriteLine();
        }

        public static void TryParseQuiRateNePlantePasDemo()
        {
            Console.WriteLine("-- TryParse qui rate --");

            // l'utilisateur a tapé son âge en lettres
            string saisie = "vingt-cinq";
            if (int.TryParse(saisie, out int age))
            {
                Console.WriteLine($"Votre conversion est réussie : {age}");
            }
            else
            {
                // pas de plantage, on passe juste dans le else (et age vaut 0)
                Console.WriteLine($"Votre conversion est ratée (age vaut {age})");
            }
            Console.WriteLine();
        }
    }
}
