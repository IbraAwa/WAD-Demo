// ===================================================================================
//  CORRECTION — EXO 116 — is null, is not null et is 404
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : int? peut valoir null ; is 404 teste une valeur précise
        int? code = 404;
        if (code is 404)
        {
            Console.WriteLine("Page introuvable");
        }

        // consigne 2 : is null teste si le texte est vide (null)
        string? nom = null;
        if (nom is null)
        {
            Console.WriteLine("Pas de nom");
        }

        // consigne 3 : is not null → le contraire
        nom = "Léa";
        if (nom is not null)
        {
            Console.WriteLine(nom);
        }
    }
}
