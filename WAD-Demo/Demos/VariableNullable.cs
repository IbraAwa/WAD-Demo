namespace WAD_Demo.Demos
{
    // -- VARIABLE NULLABLE --  string?  int?
    // null veut dire "pas de valeur du tout" (ce n'est pas pareil que "" ou 0)
    // exemple connu : tout le monde n'a pas de surnom, un élève n'a pas encore de note
    internal static class VariableNullable
    {
        public static void NonInitialiseeVideOuNullDemo()
        {
            Console.WriteLine("-- sans valeur, vide ou null --");

            // déclarée sans valeur : on ne peut pas l'utiliser
            string surnom1;
            // Console.WriteLine(surnom1); // ERREUR : la variable n'a pas encore de valeur

            // une valeur vide : c'est un texte, mais il ne contient rien
            string surnom2 = "";

            // Le '?' permet de dire qu'une variable peut être nulle
            string? surnom3 = null; // le client n'a pas de surnom

            // à l'écran on voit '' pour les deux : null ne s'affiche pas, mais ce n'est pas la même chose
            Console.WriteLine($"surnom2 : '{surnom2}', surnom3 : '{surnom3}'");
            Console.WriteLine($"surnom2 est null : {surnom2 == null}, surnom3 est null : {surnom3 == null}");
            Console.WriteLine();
        }

        public static void IntNullableEstUnRaccourciDeNullableIntDemo()
        {
            Console.WriteLine("-- int? --");

            // Nullable<int> => int? grâce au sucre syntaxique
            // (sucre syntaxique = une écriture plus courte pour la même chose)
            Nullable<int> noteExamen1 = null; // l'élève n'a pas encore passé l'examen
            int? noteExamen2 = null;           // exactement la même chose, en plus court

            // un int normal ne peut PAS être null
            // int noteExamen3 = null; // ERREUR
            Console.WriteLine($"note 1 : '{noteExamen1}', note 2 : '{noteExamen2}'");
            Console.WriteLine();
        }

        public static void ValueSansVerifierPeutPlanterDemo()
        {
            Console.WriteLine("-- .Value sans vérifier --");

            int? noteExamen = 15;

            // attention on ne vérifie pas s'il y a bien une valeur dans la variable
            // si pas de valeur cela peut casser
            Console.WriteLine(noteExamen.Value);

            // si noteExamen était null, .Value ferait planter le programme (InvalidOperationException)
            Console.WriteLine();
        }

        public static void HasValuePourVerifierAvantDUtiliserDemo()
        {
            Console.WriteLine("-- .HasValue pour vérifier --");

            int? noteExamen = null;

            if (noteExamen.HasValue)
            {
                // on est sûr que la variable n'est pas nulle, elle a une valeur
                Console.WriteLine(noteExamen.Value);
            }
            else
            {
                Console.WriteLine("pas encore de note");
            }
            Console.WriteLine();
        }
    }
}
