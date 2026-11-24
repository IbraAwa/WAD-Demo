// ===================================================================================
//  CORRECTION — EXO 045 — Le séparateur _ pour les grands nombres
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : 8 milliards dépasse le maximum d'un int (environ 2,1 milliards) → long
        long populationMondiale = 8_000_000_000;

        // consigne 2 : 1 250 000 tient dans un int
        int habitantsBruxelles = 1_250_000;

        // consigne 3 : de l'argent → decimal (avec le suffixe m)
        decimal prixVoiture = 24_999.99m;

        // consigne 4 : une par ligne
        Console.WriteLine(populationMondiale);
        Console.WriteLine(habitantsBruxelles);
        Console.WriteLine(prixVoiture);

        // a) Non : le _ sert seulement à rendre le nombre lisible DANS LE CODE.
        //    C# l'ignore, il ne fait pas partie de la valeur et ne s'affiche pas.
    }
}
