// ===================================================================================
//  CORRECTION — EXO 082 — Les 6 opérateurs de comparaison
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : la note
        int note = 12;

        // consigne 3 : prédictions (note vaut 12)
        //    note == 12 -> True   (12 est égal à 12)
        //    note != 12 -> False  (12 n'est pas différent de 12)
        //    note < 10  -> False  (12 n'est pas plus petit que 10)
        //    note <= 12 -> True   (12 est égal à 12, donc « plus petit OU égal » est vrai)
        //    note > 15  -> False  (12 n'est pas plus grand que 15)
        //    note >= 10 -> True   (12 est plus grand que 10)

        // consignes 2 et 4 : chaque comparaison donne un bool, qu'on affiche directement
        Console.WriteLine($"note == 12 : {note == 12}");
        Console.WriteLine($"note != 12 : {note != 12}");
        Console.WriteLine($"note < 10  : {note < 10}");
        Console.WriteLine($"note <= 12 : {note <= 12}");
        Console.WriteLine($"note > 15  : {note > 15}");
        Console.WriteLine($"note >= 10 : {note >= 10}");
    }
}
