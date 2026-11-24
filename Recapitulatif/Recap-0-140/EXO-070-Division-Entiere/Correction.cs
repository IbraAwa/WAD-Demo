// ===================================================================================
//  CORRECTION — EXO 070 — int / int : la virgule disparaît
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : prédictions
        //    a) 100 / 8   -> 12    (int / int = int : la partie après la virgule est perdue)
        //    b) 100.0 / 8 -> 12,5  (un double dans le calcul : le résultat est un double)
        //    c) 100f / 8  -> 12,5  (un float dans le calcul : le résultat est un float)

        // a) les deux sont des entiers : division entière
        Console.WriteLine(100 / 8);

        // b) 100.0 est un double
        Console.WriteLine(100.0 / 8);

        // c) 100f est un float (suffixe f)
        Console.WriteLine(100f / 8);

        // (la virgule s'affiche « , » parce que l'ordinateur est réglé en français)
    }
}
