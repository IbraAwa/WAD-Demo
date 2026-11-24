// ===================================================================================
//  CORRECTION — EXO 022 — Déclarer d'abord, donner la valeur ensuite
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : DÉCLARER = créer la boîte (type + nom), sans valeur
        int score;

        // consigne 2 : INITIALISER = mettre la toute première valeur (sans remettre int devant)
        score = 0;

        // consigne 3 : afficher avec la variable
        Console.WriteLine($"Score de départ : {score}");
    }
}
