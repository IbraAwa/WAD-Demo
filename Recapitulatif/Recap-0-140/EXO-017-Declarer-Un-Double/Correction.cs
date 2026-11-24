// ===================================================================================
//  CORRECTION — EXO 017 — Déclarer un double
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : un nombre à virgule (écrit avec un point), pas besoin de suffixe pour un double
        double distanceKm = 12.75;

        // consigne 2 : la température
        double temperature = 21.5;

        // consigne 3 : afficher avec les variables
        Console.WriteLine($"Distance : {distanceKm} km");
        Console.WriteLine($"Température : {temperature} degrés");
    }
}
