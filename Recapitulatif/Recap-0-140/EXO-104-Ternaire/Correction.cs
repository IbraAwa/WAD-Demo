// ===================================================================================
//  CORRECTION — EXO 104 — L'opérateur ternaire ? :
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1
        int age = 20;
        // test de la consigne 3 : remplace 20 par 12 → on voit   Mineur
        // int age = 12;

        // consigne 2 : condition ? valeur si vrai : valeur si faux
        string statut = age >= 18 ? "Majeur" : "Mineur";

        // consigne 3
        Console.WriteLine(statut);
    }
}
