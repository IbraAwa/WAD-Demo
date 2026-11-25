namespace WAD_Demo_Methode.Demos
{
    // -- REF --
    // par défaut, un paramètre reçoit une COPIE de la valeur (pour les types valeur : int, decimal, bool, struct...)
    // -> si la méthode modifie le paramètre, la variable d'origine ne change PAS
    //
    // avec ref, la méthode reçoit la RÉFÉRENCE (l'adresse en mémoire) de la variable
    // -> elle modifie directement la variable d'origine, à son adresse
    //
    // ref s'écrit à DEUX endroits : dans la déclaration ET à l'appel
    //   static void Doubler(ref int nombre)      Doubler(ref nombre);
    internal static class Ref
    {
        // ----- les procédures utilisées dans les démos -----

        private static void DoublerSansRef(int nombre)
        {
            // nombre est une COPIE : on double la copie, pas la variable d'origine
            nombre *= 2;
            Console.WriteLine($"   dans la méthode : {nombre}");
        }

        private static void Doubler(ref int nombre)
        {
            // je garde la référence de la variable passée en paramètre
            // et je la modifie directement à son adresse
            nombre *= 2;
        }

        private static void Echanger(ref int a, ref int b)
        {
            int temporaire = a;
            a = b;
            b = temporaire;
        }

        // ----- les démos -----

        public static void SansRefLaVariableNeChangePasDemo()
        {
            Console.WriteLine("-- sans ref : la variable ne change pas --");

            // le paramètre est bien doublé, mais pas la variable nombre du code qui appelle
            int nombre = 10;
            DoublerSansRef(nombre);
            Console.WriteLine($"   après l'appel   : {nombre}"); // toujours 10
            Console.WriteLine();
        }

        public static void AvecRefLaVariableEstModifieeDemo()
        {
            Console.WriteLine("-- avec ref : la variable est modifiée --");

            int nombre = 10;
            Doubler(ref nombre);
            Console.WriteLine($"la valeur du nombre est : {nombre}"); // 20

            Doubler(ref nombre);
            Console.WriteLine($"la valeur du nombre est : {nombre}"); // 40
            Console.WriteLine();
        }

        public static void EchangerDeuxVariablesAvecRefDemo()
        {
            Console.WriteLine("-- échanger deux variables avec ref --");

            // l'exemple classique : une méthode qui échange le contenu de deux variables
            // sans ref, elle échangerait seulement ses copies
            int verreDeGauche = 1;
            int verreDeDroite = 2;
            Console.WriteLine($"avant : gauche = {verreDeGauche}, droite = {verreDeDroite}");

            Echanger(ref verreDeGauche, ref verreDeDroite);
            Console.WriteLine($"après : gauche = {verreDeGauche}, droite = {verreDeDroite}");
            Console.WriteLine();
        }

        public static void PiegeRefLesErreursDemo()
        {
            Console.WriteLine("-- piège : les erreurs avec ref --");

            // 1) oublier ref à l'appel -> erreur CS1620 "l'argument doit être passé avec le mot-clé ref"
            int nombre = 10;
            //Doubler(nombre);

            // 2) une variable passée avec ref doit déjà avoir une valeur -> erreur CS0165
            //int pasEncoreDeValeur;
            //Doubler(ref pasEncoreDeValeur);

            // 3) on ne peut pas passer une valeur "en dur" : il faut une VARIABLE
            //Doubler(ref 10);

            // décommenter une ligne à la fois pour voir l'erreur
            Console.WriteLine($"rien n'a changé : {nombre}");
            Console.WriteLine();
        }
    }
}
