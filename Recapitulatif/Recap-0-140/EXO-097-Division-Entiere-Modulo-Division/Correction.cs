// ===================================================================================
//  CORRECTION — EXO 097 — Division entière, modulo et division (slide 141 n°1)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : deux variables entières
        int a = 5;
        int b = 2;

        // consigne 2 : division entière (int / int) et reste (modulo)
        Console.WriteLine("Division entière : " + a / b);   // 5 / 2 = 2, la virgule disparaît
        Console.WriteLine("Modulo : " + a % b);             // 5 = 2 * 2 + 1, il reste 1

        // consigne 3 : la vraie division. On caste a en double AVANT de diviser :
        // double / int donne un double, donc on garde la virgule.
        // (attention : (double)(a / b) donnerait 2, car la division entière est déjà faite)
        Console.WriteLine("Division : " + (double)a / b);
    }
}
