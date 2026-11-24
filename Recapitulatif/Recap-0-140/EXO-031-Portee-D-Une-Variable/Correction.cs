// ===================================================================================
//  CORRECTION — EXO 031 — La portée d'une variable
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : a est créée en dehors de tout bloc
        int a = 1;

        // consigne 2 : un bloc qui ne s'exécute que si a est plus grand que 0
        if (a > 0)
        {
            // consigne 3 : b est créée DANS les accolades
            int b = 2;
            Console.WriteLine(a + b);
        }

        // consigne 4 et 5 : ERREUR PROVOQUÉE
        // CS0103 : le nom 'b' n'existe pas dans le contexte actuel.
        // b a été créée dans les accolades du if : après l'accolade fermante, elle n'existe plus.
        //Console.WriteLine(b);

        // consigne 6 : on lance → 3 s'affiche (1 + 2).

        // a) Une variable n'existe que dans les accolades { } où elle a été déclarée (sa portée).
        //    a est déclarée à l'extérieur du if, donc elle existe aussi à l'intérieur.
        //    b est déclarée à l'intérieur du if, donc elle disparaît dès qu'on en sort.
    }
}
