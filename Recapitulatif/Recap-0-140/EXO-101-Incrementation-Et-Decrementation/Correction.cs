// ===================================================================================
//  CORRECTION — EXO 101 — ++ et --
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1
        int commandes = 0;

        // consigne 2 : ++ ajoute exactement 1
        commandes++;
        commandes++;
        commandes++;
        Console.WriteLine("Commandes : " + commandes);

        // consigne 3 : -- retire exactement 1
        commandes--;
        Console.WriteLine("Commandes : " + commandes);
    }
}
