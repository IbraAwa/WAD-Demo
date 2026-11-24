// ===================================================================================
//  CORRECTION — EXO 050 — La chaîne verbatim @ pour un chemin
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : chaîne normale → chaque \ doit être doublé
        string chemin1 = "C:\\Users\\Lea\\cours";

        // consigne 2 : chaîne verbatim (@) → le \ s'écrit tel quel, une seule fois
        string chemin2 = @"C:\Users\Lea\cours";

        // consigne 3 : oui, les deux textes sont identiques
        Console.WriteLine(chemin1);
        Console.WriteLine(chemin2);

        // consigne 4 : avec @, un guillemet s'écrit en le doublant ("")
        Console.WriteLine(@"Il a dit ""bonjour""");
    }
}
