// ===================================================================================
//  CORRECTION — EXO 120 — Tester une propriété : { Length: > 5 }
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1
        string mot = "Bonjour";
        // test de la consigne 4 : avec   Salut   (5 lettres, pas PLUS de 5) → Mot court, puis Longueur : 5
        // string mot = "Salut";

        // consigne 2 : on regarde DANS le mot sa propriété Length, et on teste > 5
        if (mot is { Length: > 5 })
        {
            Console.WriteLine("Mot long");
        }
        else
        {
            Console.WriteLine("Mot court");
        }

        // consigne 3
        Console.WriteLine("Longueur : " + mot.Length);
    }
}
