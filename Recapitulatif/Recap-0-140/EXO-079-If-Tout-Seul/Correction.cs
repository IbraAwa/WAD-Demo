// ===================================================================================
//  CORRECTION — EXO 079 — Le if tout seul
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : l'âge
        int age = 20;

        // consigne 2 : le bloc ne s'exécute QUE si la condition est vraie
        if (age >= 18)
        {
            Console.WriteLine("Tu peux voter");
        }

        // consigne 3 : en dehors du bloc -> s'affiche dans tous les cas
        Console.WriteLine("Fin du programme");

        // consigne 4 : avec age = 15, la condition 15 >= 18 est fausse :
        //    « Tu peux voter » ne s'affiche plus, il ne reste que « Fin du programme ».
    }
}
