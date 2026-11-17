namespace WAD_Demo_String.Demos
{
    // -- STRING IMMUABLE --
    // String est immuable
    // ça veut dire qu'une variable de type string n'est pas modifiable
    internal static class Immuable
    {
        public static void PlusEgalCreeUnNouveauStringDemo()
        {
            Console.WriteLine("-- += crée un nouveau string --");

            // on a créé une variable titre
            string titre = "Le Seigneur des anneaux";

            // on a ajouté un texte qui a, sans le savoir, créé
            // une nouvelle variable avec l'ancien texte + le nouveau
            titre += " : La Communauté de l'anneau";

            Console.WriteLine(titre);
            Console.WriteLine();
        }

        public static void PreuveLeStringDOrigineNeChangePasDemo()
        {
            Console.WriteLine("-- preuve : le string d'origine ne change pas --");

            string titre = "Harry Potter";

            // ToUpper() met en majuscules... mais il ne touche PAS à titre
            // il crée un NOUVEAU string qu'il faut ranger quelque part
            titre.ToUpper();
            Console.WriteLine(titre); // toujours "Harry Potter"

            string titreEnMajuscules = titre.ToUpper();
            Console.WriteLine(titreEnMajuscules); // "HARRY POTTER"
            Console.WriteLine();
        }
    }
}
