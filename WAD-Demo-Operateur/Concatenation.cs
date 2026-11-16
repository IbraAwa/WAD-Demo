namespace WAD_Demo_Operateur
{
    // -- CONCATÉNATION --  +
    internal static class Concatenation
    {
        public static void ConcatenationDeDeuxStringDemo()
        {
            Console.WriteLine("-- concaténation de deux string --");

            // le + entre deux string colle les textes
            string prenom = "Léa";
            string message = "Bonjour " + prenom;
            Console.WriteLine(message);
            Console.WriteLine();
        }

        public static void PiegeConcatenationStringPuisNombresDemo()
        {
            Console.WriteLine("-- piège : string + nombres --");

            // ATTENTION le + se lit de gauche à droite
            // dès qu'il rencontre un string tout devient du texte
            Console.WriteLine("Total : " + 10 + 5); // "Total : 105" et pas 15 !
            Console.WriteLine();
        }

        public static void CorrigerLePiegeAvecParenthesesOuInterpolationDemo()
        {
            Console.WriteLine("-- corriger le piège --");

            // les parenthèses forcent le calcul AVANT de coller le texte
            Console.WriteLine("Total : " + (10 + 5)); // "Total : 15"

            // le plus propre : l'interpolation
            Console.WriteLine($"Total : {10 + 5}");   // "Total : 15"
            Console.WriteLine();
        }
    }
}
