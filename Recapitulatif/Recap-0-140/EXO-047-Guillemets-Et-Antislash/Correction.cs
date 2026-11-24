// ===================================================================================
//  CORRECTION — EXO 047 — Afficher des guillemets et un antislash
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : \" = un guillemet à l'intérieur du texte
        Console.WriteLine("Il a dit \"bonjour\"");

        // consigne 2 : \\ = un antislash
        Console.WriteLine("C:\\Users\\Lea\\Documents");

        // consigne 3 : \' = une apostrophe à l'intérieur d'un char
        char apostrophe = '\'';
        Console.WriteLine(apostrophe);
    }
}
