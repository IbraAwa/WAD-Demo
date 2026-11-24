// ===================================================================================
//  CORRECTION — EXO 123 — Priorité : && passe avant ||
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : prédictions
        //    true || false && false   → le && passe d'abord : false && false = false,
        //                               puis true || false = True
        //    (true || false) && false → les parenthèses d'abord : true || false = true,
        //                               puis true && false = False

        // consigne 2
        Console.WriteLine(true || false && false);
        Console.WriteLine((true || false) && false);
    }
}
