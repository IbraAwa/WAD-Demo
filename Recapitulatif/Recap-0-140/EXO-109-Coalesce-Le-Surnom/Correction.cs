// ===================================================================================
//  CORRECTION — EXO 109 — Coalesce ?? : une valeur de secours (slide 126 n°1)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : string? → le texte a le droit de valoir null
        string? surnom = null;
        // test de la consigne 3 : avec ce surnom, on voit   Lulu
        // string? surnom = "Lulu";

        // consigne 2 : la valeur de gauche, ou celle de droite si la gauche est null
        Console.WriteLine(surnom ?? "Pas de surnom");
    }
}
