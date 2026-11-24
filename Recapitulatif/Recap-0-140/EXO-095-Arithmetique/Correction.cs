// ===================================================================================
//  CORRECTION — EXO 095 — Les opérateurs + - * / %
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : deux variables entières
        int a = 17;
        int b = 5;

        // consigne 3 : prédictions (écrites AVANT de lancer)
        //    a / b → 3   (deux int : division entière, 17 / 5 = 3 et la partie après la virgule disparaît)
        //    a % b → 2   (le reste : 17 = 5 * 3 + 2)

        // consigne 2 : une ligne par opération, en utilisant a et b
        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        Console.WriteLine($"{a} * {b} = {a * b}");
        Console.WriteLine($"{a} / {b} = {a / b}");
        Console.WriteLine($"{a} % {b} = {a % b}");
    }
}
