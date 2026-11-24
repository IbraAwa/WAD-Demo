// ===================================================================================
//  CORRECTION — EXO 012 — Déclarer un int
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le type (int), le nom (age), puis la valeur après le =
        int age = 30;

        // consigne 2 : afficher la variable toute seule (son nom, SANS guillemets)
        Console.WriteLine(age);

        // consigne 3 : la variable dans une phrase, avec le $ et les { }
        Console.WriteLine($"Léa a {age} ans");
    }
}
