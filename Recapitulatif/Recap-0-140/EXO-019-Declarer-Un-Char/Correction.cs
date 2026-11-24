// ===================================================================================
//  CORRECTION — EXO 019 — Déclarer un char
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : un seul caractère, entre SIMPLES guillemets
        char initiale = 'L';

        // consigne 2 : idem
        char groupe = 'B';

        // consigne 3 : afficher avec les variables
        Console.WriteLine($"Initiale : {initiale}, groupe : {groupe}");

        // consigne 4 : ERREUR PROVOQUÉE
        // CS0029 : impossible de convertir implicitement le type 'string' en 'char'.
        // Entre DOUBLES guillemets, "A" est un texte (string), pas un caractère (char).
        //char lettre = "A";
    }
}
