// ===================================================================================
//  CORRECTION — EXO 062 — Parse : int.Parse, double.Parse, bool.Parse
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : int.Parse → on veut obtenir un int
        int a = int.Parse("42");
        Console.WriteLine(a);

        // consigne 2 : double.Parse → on veut obtenir un double ("3,14" avec une virgule : PC en français)
        double b = double.Parse("3,14");
        Console.WriteLine(b);

        // consigne 3 : bool.Parse → on veut obtenir un bool (il accepte "true" ou "True")
        bool c = bool.Parse("true");
        Console.WriteLine(c);
    }
}
