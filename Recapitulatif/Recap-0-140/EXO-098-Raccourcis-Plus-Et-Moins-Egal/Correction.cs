// ===================================================================================
//  CORRECTION — EXO 098 — Les raccourcis += et -=
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : de l'argent → decimal (le suffixe m sur les nombres à virgule)
        decimal total = 0m;

        // consigne 2 : += ajoute à ce qui est déjà dans total
        total += 12.50m;   // pareil que : total = total + 12.50m;
        total += 7.99m;
        total += 20m;

        // consigne 3
        Console.WriteLine("Total panier : " + total);

        // consigne 4 : -= retire
        total -= 5m;       // pareil que : total = total - 5m;
        Console.WriteLine("Après le bon : " + total);
    }
}
