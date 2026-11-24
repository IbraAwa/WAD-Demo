// ===================================================================================
//  CORRECTION — EXO 122 — L'ordre de priorité des calculs (slide 141 n°5)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : prédictions
        //    2 + 3 * 4               → la multiplication d'abord : 2 + 12 = 14
        //    (2 + 3) * 4             → les parenthèses d'abord : 5 * 4 = 20
        //    10 - 2 * 3 + 8 / 4 % 3  → d'abord * / % de gauche à droite :
        //                                2 * 3 = 6 ; 8 / 4 = 2 ; 2 % 3 = 2
        //                              puis + - de gauche à droite : 10 - 6 + 2 = 6

        // consigne 2
        Console.WriteLine(2 + 3 * 4);
        Console.WriteLine((2 + 3) * 4);
        Console.WriteLine(10 - 2 * 3 + 8 / 4 % 3);
    }
}
