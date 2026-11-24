// ===================================================================================
//  CORRECTION — EXO 084 — Le OU : ||
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 2 : 6 = samedi
        int jour = 6;

        // consigne 3 : samedi (6) OU dimanche (7) -> il suffit qu'UNE des deux soit vraie
        if (jour == 6 || jour == 7)
        {
            Console.WriteLine("C'est le week-end !");
        }
        else
        {
            Console.WriteLine("Au travail !");
        }
    }
}
