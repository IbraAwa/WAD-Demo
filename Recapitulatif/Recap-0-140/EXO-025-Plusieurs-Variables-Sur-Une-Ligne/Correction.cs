// ===================================================================================
//  CORRECTION — EXO 025 — Déclarer plusieurs variables sur une ligne
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le type une seule fois, les variables séparées par une virgule, un seul ;
        int largeur = 10, hauteur = 20;

        // consigne 2 : afficher avec les deux variables
        Console.WriteLine($"Tableau de {largeur} cm sur {hauteur} cm");
    }
}
