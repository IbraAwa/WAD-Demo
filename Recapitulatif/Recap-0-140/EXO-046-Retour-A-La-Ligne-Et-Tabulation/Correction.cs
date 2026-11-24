// ===================================================================================
//  CORRECTION — EXO 046 — Retour à la ligne et tabulation dans un texte
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : \n passe à la ligne au milieu du texte
        Console.WriteLine("Ligne 1\nLigne 2");

        // consigne 2 : \t met une tabulation entre le produit et le prix, \n passe à la ligne
        Console.WriteLine("Pain\t1,20\nLait\t0,95");
    }
}
