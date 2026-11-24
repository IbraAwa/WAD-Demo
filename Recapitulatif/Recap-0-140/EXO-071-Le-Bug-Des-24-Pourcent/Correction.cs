// ===================================================================================
//  CORRECTION — EXO 071 — Le bug des 24 % au lieu de 25 %
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : les deux variables
        int nbCommandes = 8;
        int nbLivrees = 2;

        // consigne 2 : d'abord 100 / nbCommandes, puis * nbLivrees
        int pct = 100 / nbCommandes * nbLivrees;

        // consigne 3 : affichage
        Console.WriteLine($"{pct} %");

        // consigne 4 : pourquoi 24 % ?
        //    étape 1 : 100 / 8 -> les deux sont des int, donc division ENTIÈRE : 12 (et pas 12,5).
        //              Le 0,5 est perdu dès cette étape.
        //    étape 2 : 12 * 2 = 24.
        //    Avec la vraie valeur, on aurait eu 12,5 * 2 = 25 : on a perdu 0,5 x 2 = 1 %.
    }
}
