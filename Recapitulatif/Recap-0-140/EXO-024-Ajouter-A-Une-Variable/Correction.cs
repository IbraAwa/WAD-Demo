// ===================================================================================
//  CORRECTION — EXO 024 — Ajouter quelque chose à une variable
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : au départ, 0 point
        int points = 0;
        Console.WriteLine($"Points : {points}");

        // consigne 2 : première pièce → C# calcule d'abord points + 10 avec l'ancienne valeur (0 + 10),
        //              puis range le résultat (10) dans points
        points = points + 10;
        Console.WriteLine($"Points : {points}");

        // consigne 3 : deuxième pièce → 10 + 10 = 20
        points = points + 10;
        Console.WriteLine($"Points : {points}");
    }
}
