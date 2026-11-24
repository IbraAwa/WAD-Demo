// ===================================================================================
//  CORRECTION — EXO 006 — ReadLine : lire un prénom
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : la question, avec Write pour que la réponse soit tapée sur la même ligne
        Console.Write("Votre prénom : ");

        // consigne 2 : ReadLine renvoie ce que l'utilisateur a tapé, on le range dans prenom
        string? prenom = Console.ReadLine();

        // consigne 3 : on réutilise la variable dans le texte grâce au $ et aux { }
        Console.WriteLine($"Bonjour {prenom}");

        // consigne 4 : on lance, on tape Marco puis Entrée → Bonjour Marco
    }
}
