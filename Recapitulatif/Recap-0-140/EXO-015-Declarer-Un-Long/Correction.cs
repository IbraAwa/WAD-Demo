// ===================================================================================
//  CORRECTION — EXO 015 — Déclarer un long
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : 8 milliards ne tient pas dans un int (max ≈ 2,1 milliards) → long
        long populationMondiale = 8000000000;
        Console.WriteLine($"Population mondiale : {populationMondiale}");

        // consigne 2 : ERREUR PROVOQUÉE
        // CS0266 : impossible de convertir implicitement le type 'long' en 'int'.
        // 8000000000 est trop grand pour un int, donc C# le voit comme un long,
        // et il refuse de le ranger tout seul dans un int (il ne rentre pas dedans).
        //int populationEnInt = 8000000000;
    }
}
