namespace WAD_Demo_Structure_Conditionnelle.Demos
{
    // -- IF...ELSE IF...ELSE --
    // plusieurs conditions à la suite : C# s'arrête à la PREMIÈRE qui est vraie
    // exemple connu : la mention selon la note sur 20
    internal static class IfElseIfElse
    {
        public static void MentionSelonLaNoteDemo()
        {
            Console.WriteLine("-- mention selon la note --");

            int noteEleve = 15;

            if (noteEleve >= 18)
            {
                Console.WriteLine("Mention très bien");
            }
            else if (noteEleve >= 16)
            {
                Console.WriteLine("Mention bien");
            }
            else if (noteEleve >= 14)
            {
                Console.WriteLine("Mention"); // celle-ci : 15 >= 14
            }
            else if (noteEleve >= 10)
            {
                Console.WriteLine("Réussi sans mention");
            }
            else
            {
                Console.WriteLine("Raté");
            }
            Console.WriteLine();
        }

        public static void PiegePlusieursIfSeparesAuLieuDeElseIfDemo()
        {
            Console.WriteLine("-- piège : plusieurs if séparés --");

            // avec des if séparés (sans else), C# teste TOUS les if un par un
            // donc avec 19 on affiche deux mentions !
            int noteEleve = 19;

            if (noteEleve >= 18)
            {
                Console.WriteLine("Mention très bien");
            }

            if (noteEleve > 16)
            {
                Console.WriteLine("Mention bien");
            }

            // avec else if, C# s'arrête dès qu'une condition est vraie
            Console.WriteLine();
        }
    }
}
