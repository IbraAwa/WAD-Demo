namespace WAD_Demo_Conversion.Demos
{
    // -- AVEC L'UTILISATEUR --  Parse / TryParse sur Console.ReadLine()
    internal static class AvecUtilisateur
    {
        public static void ParseSansVerifierPlanteSiLUtilisateurTapeDuTexteDemo()
        {
            Console.WriteLine("-- Parse sur une saisie --");

            // manière de convertir une donnée reçue par l'utilisateur sans la vérifier
            // problème : ça crash s'il nous envoie une chaîne de caractères (essayez de taper "abc")
            Console.WriteLine("Veuillez écrire votre âge");
            // (Visual Studio souligne en vert : ReadLine peut donner null, encore une raison de préférer TryParse)
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"votre âge est {age}");
            Console.WriteLine();
        }

        public static void TryParseVerifieLaSaisieDeLUtilisateurDemo()
        {
            Console.WriteLine("-- TryParse sur une saisie --");

            // la bonne manière : TryParse ne plante jamais
            Console.WriteLine("Veuillez écrire votre âge");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine($"Votre conversion est réussie : {age}");
            }
            else
            {
                Console.WriteLine("Votre conversion est ratée");
            }
            Console.WriteLine();
        }
    }
}
