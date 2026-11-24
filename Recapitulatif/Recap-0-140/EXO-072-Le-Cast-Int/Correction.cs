// ===================================================================================
//  CORRECTION — EXO 072 — Le cast (int)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : les deux variables
        int nbCommandes = 8;
        int nbLivrees = 2;

        // consigne 2 : avec 100f, le calcul donne un float (12,5 * 2 = 25,0)
        // ERREUR CS0266 : Impossible de convertir implicitement le type 'float' en 'int'.
        //                 Une conversion explicite existe (un cast est-il manquant ?)
        // int pct = 100f / nbCommandes * nbLivrees;

        // consigne 3 : le cast (int) porte sur TOUT le calcul grâce aux parenthèses
        // (écrit (int)100f / ..., il ne porterait que sur 100f et on retomberait sur 24 %)
        int pct = (int)(100f / nbCommandes * nbLivrees);
        Console.WriteLine($"{pct} %");
    }
}
