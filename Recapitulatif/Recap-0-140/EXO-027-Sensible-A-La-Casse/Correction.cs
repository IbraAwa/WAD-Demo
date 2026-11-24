// ===================================================================================
//  CORRECTION — EXO 027 — Majuscules et minuscules comptent
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : même mot, mais pas les mêmes majuscules
        int age = 20;
        int Age = 25;
        int AGE = 35;

        // consigne 2 : les trois sur une seule ligne
        Console.WriteLine($"age = {age}, Age = {Age}, AGE = {AGE}");

        // a) J'ai créé 3 variables différentes : C# est sensible à la casse,
        //    une minuscule et une majuscule ne sont pas la même lettre pour lui.
        //    Donc age, Age et AGE sont trois noms différents (à éviter dans un vrai programme !).
    }
}
