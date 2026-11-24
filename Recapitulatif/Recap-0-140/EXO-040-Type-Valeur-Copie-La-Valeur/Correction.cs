// ===================================================================================
//  CORRECTION — EXO 040 — Type valeur : on copie la valeur
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1
        int ageLea = 30;

        // consigne 2 : ageMarco reçoit une COPIE de la valeur de ageLea (30)
        int ageMarco = ageLea;

        // consigne 3 : on change seulement ageMarco
        ageMarco = 31;

        // consigne 4 : prédiction → Léa a toujours 30 ans.
        // Un int est un type valeur : à la consigne 2, on a copié le nombre 30 dans ageMarco.
        // Les deux variables sont indépendantes : changer ageMarco ne touche pas à ageLea.
        Console.WriteLine($"Léa : {ageLea} ans");
        Console.WriteLine($"Marco : {ageMarco} ans");
    }
}
