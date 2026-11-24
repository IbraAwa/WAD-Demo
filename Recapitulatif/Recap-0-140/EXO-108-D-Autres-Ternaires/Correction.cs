// ===================================================================================
//  CORRECTION — EXO 108 — D'autres ternaires (slide 122)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : au moins un article → stock >= 1 (ou stock > 0)
        int stock = 0;
        Console.WriteLine(stock >= 1 ? "En stock" : "Rupture");

        // consigne 2 : avant 12h → heure < 12
        int heure = 14;
        Console.WriteLine(heure < 12 ? "Bonjour" : "Bon après-midi");

        // consigne 3 : le ternaire renvoie ici un nombre (les deux branches sont des double)
        double prix = 120;
        double remise = prix >= 100 ? prix * 0.1 : 0;
        Console.WriteLine("Remise : " + remise);
    }
}
