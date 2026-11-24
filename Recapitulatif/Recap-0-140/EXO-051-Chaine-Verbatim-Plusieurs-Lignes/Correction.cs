// ===================================================================================
//  CORRECTION — EXO 051 — La chaîne verbatim @ sur plusieurs lignes
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : avec @, les retours à la ligne tapés avec Entrée font partie du texte.
        // Les lignes 2 et 3 sont collées tout à gauche : sinon les espaces du début seraient affichés.
        string adresse = @"Léa Dupont
Rue de la Gare 12
5000 Namur";

        // consigne 2 : un seul WriteLine affiche les 3 lignes
        Console.WriteLine(adresse);
    }
}
