// ===================================================================================
//  CORRECTION — EXO 096 — Le modulo pour savoir si c'est pair
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le reste de 8 / 2 puis de 7 / 2
        Console.WriteLine(8 % 2);   // 0 : 8 = 2 * 4, il ne reste rien
        Console.WriteLine(7 % 2);   // 1 : 7 = 2 * 3 + 1

        // consigne 2 : un nombre est pair quand le reste de sa division par 2 vaut 0
        int nombre = 7;
        if (nombre % 2 == 0)
        {
            Console.WriteLine("pair");
        }
        else
        {
            Console.WriteLine("impair");
        }
    }
}
