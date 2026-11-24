// ===================================================================================
//  CORRECTION — EXO 099 — Les raccourcis *= /= et %=
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : de l'argent → decimal
        decimal total = 40m;

        // consigne 2 : retirer 10 %, c'est garder 90 % → multiplier par 0,9
        total *= 0.9m;     // pareil que : total = total * 0.9m;
        Console.WriteLine("Après remise : " + total);
        // (le decimal garde le chiffre après la virgule de 0.9m : il affiche 36,0 et pas 36)

        // consigne 3 : partager entre 4 amis
        total /= 4;        // pareil que : total = total / 4;
        Console.WriteLine("Chacun paie : " + total);

        // consigne 4 : 130 minutes = 2 heures complètes (120 min) + 10 minutes
        int minutes = 130;
        minutes %= 60;     // pareil que : minutes = minutes % 60;
        Console.WriteLine("Minutes en plus : " + minutes);
    }
}
