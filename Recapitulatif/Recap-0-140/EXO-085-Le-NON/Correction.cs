// ===================================================================================
//  CORRECTION — EXO 085 — Le NON : !
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : prédictions
        //    !true  -> False  (le contraire de vrai, c'est faux)
        //    !false -> True   (le contraire de faux, c'est vrai)
        Console.WriteLine(!true);
        Console.WriteLine(!false);

        // consigne 2 : le magasin n'est pas fermé
        bool estFerme = false;

        // consigne 3 : !estFerme se lit « pas fermé » -> !false = true, donc on entre dans le if
        if (!estFerme)
        {
            Console.WriteLine("Le magasin est ouvert, entrez !");
        }
    }
}
