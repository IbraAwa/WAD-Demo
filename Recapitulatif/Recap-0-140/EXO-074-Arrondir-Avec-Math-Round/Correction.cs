// ===================================================================================
//  CORRECTION — EXO 074 — Arrondir avec Math.Round
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : Math.Round arrondit, puis (int) transforme le double en entier
        Console.WriteLine((int)Math.Round(9.44));   // 9
        Console.WriteLine((int)Math.Round(9.99));   // 10

        // consigne 2 : Convert.ToInt32 arrondit lui aussi (il ne coupe pas comme le cast)
        Console.WriteLine(Convert.ToInt32(9.99));   // 10

        // consigne 3 : le PIÈGE de 2.5
        // Par défaut, Math.Round arrondit un « pile au milieu » (,5) vers le nombre PAIR le plus proche :
        // 2.5 -> 2 (et 3.5 -> 4). C'est « l'arrondi du banquier ».
        Console.WriteLine(Math.Round(2.5));         // 2

        // Avec MidpointRounding.AwayFromZero, on obtient l'arrondi de l'école : ,5 s'éloigne de zéro.
        Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));   // 3
    }
}
