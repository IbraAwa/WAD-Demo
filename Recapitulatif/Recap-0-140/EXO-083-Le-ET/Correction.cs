// ===================================================================================
//  CORRECTION — EXO 083 — Le ET : &&
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 2 : tarif normal si au moins 18 ET moins de 65
        int age = 30;

        if (age >= 18 && age < 65)
        {
            Console.WriteLine("Tarif normal");
        }
        else
        {
            Console.WriteLine("Tarif réduit");
        }

        // consigne 3 :
        //    age = 30 -> 30 >= 18 vrai  ET 30 < 65 vrai  -> Tarif normal
        //    age = 12 -> 12 >= 18 FAUX                   -> Tarif réduit
        //    age = 70 -> 70 >= 18 vrai  ET 70 < 65 FAUX  -> Tarif réduit
        //    (avec &&, il suffit qu'UNE condition soit fausse pour que tout soit faux)
    }
}
