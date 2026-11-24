// ===================================================================================
//  CORRECTION — EXO 067 — Conversion implicite : C# le fait tout seul
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : un int
        int quantite = 3;

        // consigne 2 : int -> long, sans rien écrire de spécial
        // (un long est plus « grand » qu'un int : aucun risque de perte, C# convertit tout seul)
        long stock = quantite;

        // consigne 3 : int -> double, puis int -> decimal (même chose, aucun risque de perte)
        double quantiteDouble = quantite;
        decimal quantiteDecimal = quantite;

        // consigne 4 : affichage
        Console.WriteLine(stock);
        Console.WriteLine(quantiteDouble);
        Console.WriteLine(quantiteDecimal);
    }
}
