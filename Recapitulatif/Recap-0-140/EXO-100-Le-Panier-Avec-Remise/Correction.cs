// ===================================================================================
//  CORRECTION — EXO 100 — Le panier avec remise (slide 121 n°1)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : double imposé (pour voir son défaut)
        double total = 0;

        // consigne 2 : trois articles
        total += 12.50;
        total += 7.99;
        total += 20;

        // consigne 3 : 10 % de remise = multiplier par 0,9
        total *= 0.9;
        Console.WriteLine("Total : " + total);

        // consigne 4 : un bon de 5
        total -= 5;
        Console.WriteLine("Après le bon : " + total);

        // a) Le double range les nombres en binaire (base 2). Beaucoup de nombres à virgule
        //    comme 7,99 ou 0,9 ne peuvent pas y être écrits exactement : il garde une valeur
        //    TRÈS proche, avec une minuscule erreur. Les calculs accumulent ces erreurs et on
        //    finit par les voir : 31,441000000000003 au lieu de 31,441.
        //    C'est pour ça qu'on utilise decimal pour l'argent (EXO 098 et 099).
    }
}
