namespace WAD_Demo_Methode.Demos
{
    // -- PARAMS --
    // params permet de donner N'IMPORTE QUEL NOMBRE d'arguments (0, 1, 2, 50...)
    // dans la méthode, ils arrivent sous la forme d'un TABLEAU
    //
    //   static int Addition(params int[] nombres)
    //
    // exemple : vous voulez faire une somme, mais vous ne savez pas à l'avance combien de nombres il y aura
    //
    // règles :
    // - params doit être le DERNIER paramètre
    // - il ne peut y avoir qu'UN SEUL params par méthode
    internal static class Params
    {
        // ----- les fonctions utilisées dans les démos -----

        private static int Addition(params int[] nombres)
        {
            int somme = 0;
            for (int i = 0; i < nombres.Length; i++)
            {
                somme += nombres[i];
            }

            return somme;
        }

        // un paramètre "normal" d'abord, le params en dernier
        private static string FormerPhrase(string separateur, params string[] mots)
        {
            return string.Join(separateur, mots);
        }

        // ----- les démos -----

        public static void ParamsAutantDArgumentsQuOnVeutDemo()
        {
            Console.WriteLine("-- params : autant d'arguments qu'on veut --");

            // la même méthode, appelée avec 3, 2, 5 nombres
            Console.WriteLine($"la somme de 10 + 5 + 25 est : {Addition(10, 5, 25)}");
            Console.WriteLine($"la somme de 1 + 2 est : {Addition(1, 2)}");
            Console.WriteLine($"la somme de 1 + 2 + 3 + 4 + 5 est : {Addition(1, 2, 3, 4, 5)}");

            // et même avec 0 argument -> le tableau est vide, la somme vaut 0
            Console.WriteLine($"la somme de rien du tout est : {Addition()}");
            Console.WriteLine();
        }

        public static void ParamsAvecUnTableauDemo()
        {
            Console.WriteLine("-- params : on peut aussi envoyer un tableau --");

            // si on a déjà un tableau, on peut le donner directement
            int[] nombres = [5, 15, 30];
            Console.WriteLine($"la somme du tableau est : {Addition(nombres)}");
            Console.WriteLine();
        }

        public static void ParamsAvecUnParametreAvantDemo()
        {
            Console.WriteLine("-- params après un paramètre normal --");

            // le 1er argument va dans separateur, TOUS les suivants vont dans le tableau mots
            Console.WriteLine(FormerPhrase(" ", "Les", "méthodes", "c'est", "génial"));
            Console.WriteLine(FormerPhrase(" - ", "lundi", "mardi", "mercredi"));
            Console.WriteLine();
        }

        public static void PiegeParamsPasEnDernierDemo()
        {
            Console.WriteLine("-- piège : params pas en dernier --");

            // params doit être le dernier paramètre -> erreur CS0231
            // (sinon C# ne saurait pas où s'arrête la liste des mots)
            // décommenter pour voir l'erreur
            //static string FormerPhraseMalEcrite(params string[] mots, string separateur)
            //{
            //    return string.Join(separateur, mots);
            //}

            Console.WriteLine("règle : params toujours en dernier, et un seul params par méthode");
            Console.WriteLine();
        }
    }
}
