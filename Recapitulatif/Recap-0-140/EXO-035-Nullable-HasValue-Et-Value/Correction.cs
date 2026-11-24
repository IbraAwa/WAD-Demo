// ===================================================================================
//  CORRECTION — EXO 035 — HasValue et Value
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : un entier qui peut être null, vide au départ
        int? noteExamen = null;

        // consigne 2 : prédiction → False, car la variable ne contient rien (null)
        Console.WriteLine($"A une valeur : {noteExamen.HasValue}");

        // consigne 3 : on lui donne une valeur
        noteExamen = 15;

        // consigne 4 : maintenant HasValue vaut True, et Value donne la valeur elle-même (15)
        Console.WriteLine($"A une valeur : {noteExamen.HasValue}");
        Console.WriteLine($"La valeur : {noteExamen.Value}");
    }
}
