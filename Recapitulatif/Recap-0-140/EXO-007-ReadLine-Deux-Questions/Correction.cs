// ===================================================================================
//  CORRECTION — EXO 007 — Poser deux questions
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : demander le prénom (Write pour rester sur la même ligne)
        Console.Write("Votre prénom : ");
        string? prenom = Console.ReadLine();

        // consigne 2 : demander la ville de la même façon
        Console.Write("Votre ville : ");
        string? ville = Console.ReadLine();

        // consigne 3 : une phrase avec les deux variables
        Console.WriteLine($"{prenom} habite à {ville}");
    }
}
