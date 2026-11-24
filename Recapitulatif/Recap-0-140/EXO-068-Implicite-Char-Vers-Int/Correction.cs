// ===================================================================================
//  CORRECTION — EXO 068 — char vers int : le code de la lettre
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : un char rangé directement dans un int
        char lettre = 'A';
        int code = lettre;   // conversion implicite : on récupère le numéro de la lettre
        Console.WriteLine($"{lettre} -> {code}");

        // consigne 2 : pareil avec le a minuscule (on réutilise les mêmes variables)
        lettre = 'a';
        code = lettre;
        Console.WriteLine($"{lettre} -> {code}");

        // les majuscules et les minuscules n'ont pas le même numéro (65 et 97) :
        // pour l'ordinateur, 'A' et 'a' sont deux caractères différents.
    }
}
