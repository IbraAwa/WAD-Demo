// ===================================================================================
//  CORRECTION — EXO 091 — Regrouper des case
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le jour
        int jour = 6;

        switch (jour)
        {
            // consigne 2 : case 6 et case 7 l'un sous l'autre -> ils partagent le même code
            case 6:
            case 7:
                Console.WriteLine("Week-end");
                break;
            // consigne 3 : tous les autres jours
            default:
                Console.WriteLine("Semaine");
                break;
        }
    }
}
