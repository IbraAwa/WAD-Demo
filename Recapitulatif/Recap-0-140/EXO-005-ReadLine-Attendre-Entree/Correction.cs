// ===================================================================================
//  CORRECTION — EXO 005 — ReadLine : attendre la touche Entrée
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le message
        Console.WriteLine("Appuie sur Entrée pour continuer...");

        // consigne 2 : pause jusqu'à ce que l'utilisateur appuie sur Entrée
        // (on ne garde pas ce qu'il tape : on ne range le résultat dans aucune variable)
        Console.ReadLine();

        // consigne 3 : la suite ne s'affiche qu'après Entrée
        Console.WriteLine("Merci, on continue !");

        // consigne 4 : en lançant, on voit que le programme attend sur ReadLine
        //              tant qu'on n'a pas appuyé sur Entrée.
    }
}
