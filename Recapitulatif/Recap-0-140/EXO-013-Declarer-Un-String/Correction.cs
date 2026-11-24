// ===================================================================================
//  CORRECTION — EXO 013 — Déclarer un string
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : un texte se met toujours entre guillemets " "
        string ville = "Bruxelles";

        // consigne 2 : la phrase avec la variable
        Console.WriteLine($"J'habite à {ville}");
    }
}
