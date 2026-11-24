// ===================================================================================
//  CORRECTION — EXO 023 — Changer la valeur d'une variable
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : déclarer et afficher
        int age = 30;
        Console.WriteLine($"Âge : {age}");

        // consigne 2 : la variable existe déjà → on change juste sa valeur, SANS int devant
        age = 31;

        // consigne 3 : afficher la nouvelle valeur
        Console.WriteLine($"Âge : {age}");

        // consigne 4 : ERREUR PROVOQUÉE
        // CS0128 : une variable locale nommée 'age' est déjà définie dans cette portée.
        // Avec int devant, on essaie de CRÉER une 2e variable age : interdit, le nom est déjà pris.
        //int age = 32;
    }
}
