namespace WAD_Demo_Recap1.Demos
{
    // -- TYPES DE VARIABLES --  string char bool int long decimal float double + var
    internal static class TypesDeVariables
    {
        public static void TousLesTypesDeBaseDemo()
        {
            Console.WriteLine("-- les types de base --");

            string nom = "Dupont";         // chaîne de caractères (phrase, des mots, des chiffres etc..) toujours entre "
            char groupe = 'B';             // UNIQUEMENT un seul caractère, toujours entre '
            bool estInscrit = true;        // soit true soit false ou une condition
            int age = 20;                  // un entier négatif ou positif entre -2,1 milliards et +2,1 milliards environ
            long numeroCarteEtudiant = 20260001234; // négatif ou positif mais entre -9 trillions et +9 trillions environ
            decimal minerval = 835.00m;    // nombre à virgule ultra précis (pour l'argent)
            float tailleEnMetre = 1.75f;   // nombre à virgule le moins précis
            double moyenne = 14.5;         // nombre à virgule par défaut, plus précis que float mais moins que decimal

            Console.WriteLine($"{nom} (groupe {groupe}), {age} ans, inscrit : {estInscrit}");
            Console.WriteLine($"carte étudiant : {numeroCarteEtudiant}, minerval : {minerval} euros");
            Console.WriteLine($"taille : {tailleEnMetre} m, moyenne : {moyenne}/20");
            Console.WriteLine();
        }

        public static void VarLaisseCSharpDeterminerLeTypeDemo()
        {
            Console.WriteLine("-- var --");

            // on a le var qui est utilisé pour laisser C# déterminer le type
            var exemple0 = "18"; // C# va le typer en string
            var exemple1 = 18;   // C# va le typer en int

            // GetType().Name donne le nom du type que C# a choisi
            Console.WriteLine($"\"18\" est un {exemple0.GetType().Name}, 18 est un {exemple1.GetType().Name}");
            Console.WriteLine();
        }

        public static void PiegeVarAvecUnPetitNombrePensantAvoirUnLongDemo()
        {
            Console.WriteLine("-- piège : var et long --");

            // DISCLAIMER
            // Si vous vouliez un long mais que vous mettez un petit chiffre
            // C# va penser que c'est un int
            var nombreDeVues = 1500;   // int !
            var nombreDeVuesL = 1500L; // le L force le long
            Console.WriteLine($"1500 est un {nombreDeVues.GetType().Name}, 1500L est un {nombreDeVuesL.GetType().Name}");
            Console.WriteLine();
        }
    }
}
