namespace WAD_Demo_Boucle.Demos
{
    // -- DO WHILE --
    // EFFECTUE l'action PUIS REGARDE LA CONDITION
    // donc le do while s'exécute TOUJOURS au moins une fois
    // pratique pour poser une question : on doit la poser au moins une fois avant de vérifier la réponse
    // attention au ; après le while ( ... );
    internal static class DoWhile
    {
        public static void DoWhileServirDesClientsDemo()
        {
            Console.WriteLine("-- servir des clients --");

            int clientsDansLaFile = 3;

            do
            {
                Console.WriteLine($"je sers un client, il en reste {clientsDansLaFile - 1}");
                clientsDansLaFile--;
            } while (clientsDansLaFile > 0);

            Console.WriteLine("plus personne dans la file");
            Console.WriteLine();
        }

        public static void DoWhileSExecuteAuMoinsUneFoisDemo()
        {
            Console.WriteLine("-- do while : au moins une fois --");

            // la file est vide dès le départ, la condition est fausse...
            // ... mais le do s'exécute quand même une fois (contrairement au while)
            int clientsDansLaFile = 0;

            do
            {
                Console.WriteLine("j'ouvre le guichet"); // affiché une fois !
            } while (clientsDansLaFile > 0);

            Console.WriteLine();
        }
    }
}
