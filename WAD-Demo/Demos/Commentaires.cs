namespace WAD_Demo.Demos
{
    // -- LES COMMENTAIRES --  //  /* */
    // un commentaire est ignoré par C#, il sert à expliquer le code aux humains
    internal static class Commentaires
    {
        public static void CommentaireSurUneLigneDemo()
        {
            Console.WriteLine("-- commentaire sur une ligne (//) --");

            // Commentaire sur une ligne
            Console.WriteLine("Bienvenue au magasin"); // un commentaire peut aussi être en fin de ligne
            Console.WriteLine();
        }

        public static void CommentaireSurPlusieursLignesDemo()
        {
            Console.WriteLine("-- commentaire sur plusieurs lignes (/* */) --");

            /*
             Commentaire
             sur
             plusieurs
             lignes
            */
            Console.WriteLine("tout ce qui est entre /* et */ est ignoré");
            Console.WriteLine();
        }

        public static void CommenterDuCodePourNePasLExecuterDemo()
        {
            Console.WriteLine("-- commenter du code --");

            // on peut aussi commenter du code pour qu'il ne s'exécute pas
            // raccourci Visual Studio : Ctrl+K puis Ctrl+C pour commenter
            //                           Ctrl+K puis Ctrl+U pour décommenter
            Console.WriteLine("je m'affiche");
            //Console.WriteLine("je suis commenté donc je ne m'affiche pas");
            Console.WriteLine();
        }
    }
}
