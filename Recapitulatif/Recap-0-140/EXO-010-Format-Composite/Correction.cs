// ===================================================================================
//  CORRECTION — EXO 010 — Le format composite {0} {1}
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : deux emplacements ; "Léa" va dans {0}, 30 va dans {1}
        Console.WriteLine("{0} a {1} ans", "Léa", 30);

        // consigne 2 : trois emplacements ; "Léa" → {0}, "Namur" → {1}, 5 → {2}
        Console.WriteLine("{0} habite à {1} depuis {2} ans", "Léa", "Namur", 5);
    }
}
