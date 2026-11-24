// ===================================================================================
//  CORRECTION — EXO 111 — Coalesce en chaîne : le premier numéro dispo (slide 126 n°3)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : deux textes qui ont le droit d'être null
        string? telPro = null;
        string? telPerso = "0470 12 34 56";

        // consigne 2 : on prend le premier qui n'est pas null, de gauche à droite
        Console.WriteLine("Numéro à appeler : " + (telPro ?? telPerso ?? "Aucun numéro"));
        // (les parenthèses sont obligatoires : sans elles, le + passerait avant le ??)

        // consigne 3 : les tests
        //    telPro = null et telPerso = null                       → Numéro à appeler : Aucun numéro
        //    telPro = "02 123 45 67" et telPerso = "0470 12 34 56"  → Numéro à appeler : 02 123 45 67
        //    (le pro gagne car il est écrit en premier)
    }
}
