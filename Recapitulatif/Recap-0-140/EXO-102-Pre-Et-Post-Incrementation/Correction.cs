// ===================================================================================
//  CORRECTION — EXO 102 — ++x ou x++ ?
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le code de support
        int x = 5;
        int a = ++x;
        int y = 5;
        int b = y++;

        // consigne 2 : prédictions
        //    ++x (pré-incrémentation) : on ajoute 1 D'ABORD, puis on donne la valeur
        //        → x devient 6, et a reçoit 6
        //    y++ (post-incrémentation) : on donne la valeur D'ABORD, puis on ajoute 1
        //        → b reçoit 5, puis y devient 6
        //    Donc : a = 6, x = 6, b = 5, y = 6

        // consigne 3 : affichage sur deux lignes
        Console.WriteLine($"a = {a}, x = {x}");
        Console.WriteLine($"b = {b}, y = {y}");
    }
}
