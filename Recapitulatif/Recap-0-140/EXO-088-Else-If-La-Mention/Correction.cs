// ===================================================================================
//  CORRECTION — EXO 088 — if ... else if ... else
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : la note
        int note = 14;

        // consigne 2 : on commence par le cas le plus exigeant, C# s'arrête au PREMIER cas vrai
        if (note >= 16)
        {
            Console.WriteLine("Très bien");
        }
        else if (note >= 14)
        {
            Console.WriteLine("Bien");
        }
        else if (note >= 10)
        {
            Console.WriteLine("Réussi");
        }
        else
        {
            Console.WriteLine("Échec");
        }

        // consigne 3 :
        //    note = 17 -> Très bien
        //    note = 14 -> Bien
        //    note = 11 -> Réussi
        //    note = 5  -> Échec
    }
}
