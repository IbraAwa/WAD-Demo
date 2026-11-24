// ===================================================================================
//  CORRECTION — EXO 061 — Convert qui plante : FormatException
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 et 2 : EXCEPTION System.FormatException
        // (message : « The input string 'abc' was not in a correct format. »)
        // "abc" ne ressemble pas à un nombre : Convert.ToInt32 ne sait pas quoi en faire, le programme plante.
        // int nombre = Convert.ToInt32("abc");

        // consigne 3
        Console.WriteLine("Convert ne sait pas convertir abc");
    }
}
