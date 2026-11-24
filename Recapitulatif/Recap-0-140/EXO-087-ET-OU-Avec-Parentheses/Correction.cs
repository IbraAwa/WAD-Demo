// ===================================================================================
//  CORRECTION — EXO 087 — Mélanger && et || avec des parenthèses
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 2 : 17 ans, il a sa carte, il est VIP
        int age = 17;
        bool aSaCarteDIdentite = true;
        bool estVip = true;

        // consigne 3 : VIP OU (majeur ET carte) -> les parenthèses regroupent la partie « majeur ET carte »
        if (estVip || (age >= 18 && aSaCarteDIdentite))
        {
            Console.WriteLine("Entrée autorisée");
        }
        else
        {
            Console.WriteLine("Entrée refusée");
        }

        // consigne 4 :
        //    17 ans, carte, VIP       -> estVip est vrai, ça suffit           -> Entrée autorisée
        //    17 ans, carte, pas VIP   -> pas VIP, et 17 >= 18 est faux        -> Entrée refusée
        //    20 ans, carte, pas VIP   -> pas VIP, mais majeur ET carte : vrai -> Entrée autorisée
    }
}
