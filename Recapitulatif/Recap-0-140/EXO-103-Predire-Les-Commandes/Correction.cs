// ===================================================================================
//  CORRECTION — EXO 103 — Prédire commandes++ et ++commandes (slide 121 n°2)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : les lignes de support
        int commandes = 2;
        int a = commandes++;
        int b = ++commandes;

        // consigne 2 : prédictions
        //    a = commandes++ : a reçoit l'ancienne valeur (2), PUIS commandes passe à 3
        //    b = ++commandes : commandes passe D'ABORD à 4, puis b reçoit 4
        //    Donc : a = 2, b = 4, commandes = 4

        // consigne 3
        Console.WriteLine($"a = {a}, b = {b}, commandes = {commandes}");
    }
}
