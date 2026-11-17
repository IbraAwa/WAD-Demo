namespace WAD_Demo_Conversion.Demos
{
    // -- PARSE --  int.Parse()  double.Parse()  bool.Parse() ...
    // transforme un string en un autre type
    internal static class AvecParse
    {
        public static void ParseTransformeUnTexteEnNombreDemo()
        {
            Console.WriteLine("-- int.Parse --");

            int quantite = int.Parse("42");
            Console.WriteLine($"parse '42' en nombre {quantite}");
            Console.WriteLine();
        }

        public static void PiegeParsePlanteSiCeNestPasUnNombreDemo()
        {
            Console.WriteLine("-- piège : Parse plante si ce n'est pas un nombre --");

            // Parse ne vérifie rien : si le texte n'est pas un nombre, le programme plante
            //int quantite = int.Parse("quarante-deux"); // plante (FormatException)

            // c'est surtout un problème avec ce que l'utilisateur tape (voir AvecUtilisateur.cs)
            // la solution : TryParse (voir AvecTryParse.cs)
            Console.WriteLine("int.Parse(\"quarante-deux\") ferait planter le programme");
            Console.WriteLine();
        }
    }
}
