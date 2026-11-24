// ===================================================================================
//  CORRECTION — EXO 059 — Convert.ToInt32 : du texte vers un nombre
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : "42" entre guillemets, c'est du TEXTE
        string quantiteTexte = "42";

        // consigne 2 : prédiction → 421.
        // Avec un texte, le + COLLE : "42" + 1 donne le texte "421" (pas un calcul).
        Console.WriteLine(quantiteTexte + 1);

        // consigne 3 : Convert.ToInt32 transforme le texte "42" en vrai nombre 42
        int quantite = Convert.ToInt32(quantiteTexte);

        // consigne 4 : prédiction → 43. Cette fois, ce sont deux nombres : le + ADDITIONNE.
        Console.WriteLine(quantite + 1);
    }
}
