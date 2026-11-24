// ===================================================================================
//  CORRECTION — EXO 043 — Les suffixes L, F, D, M et U
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le suffixe à la fin du nombre force son type
        var a = 5L;      // L = long    (System.Int64)
        var b = 3.14F;   // F = float   (System.Single)
        var c = 3.14D;   // D = double  (System.Double)
        var d = 9.99M;   // M = decimal (System.Decimal)
        var e = 5U;      // U = uint    (System.UInt32, un entier sans signe : jamais négatif)

        // consigne 2 : le texte avant la flèche est écrit à la main (le suffixe ne s'affiche pas tout seul)
        Console.WriteLine($"5L    -> {a.GetType()}");
        Console.WriteLine($"3.14F -> {b.GetType()}");
        Console.WriteLine($"3.14D -> {c.GetType()}");
        Console.WriteLine($"9.99M -> {d.GetType()}");
        Console.WriteLine($"5U    -> {e.GetType()}");
    }
}
