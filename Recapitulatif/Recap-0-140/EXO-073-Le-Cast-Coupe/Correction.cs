// ===================================================================================
//  CORRECTION — EXO 073 — Le cast coupe, il n'arrondit pas
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : prédictions
        //    (int)9.44 -> 9
        //    (int)9.99 -> 9   (et pas 10 !) : le cast COUPE tout ce qui est après la virgule,
        //                     il n'arrondit jamais.

        // consigne 2 : affichage
        Console.WriteLine((int)9.44);
        Console.WriteLine((int)9.99);
    }
}
