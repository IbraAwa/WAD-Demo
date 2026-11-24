// ===================================================================================
//  CORRECTION — EXO 118 — switch avec des comparaisons (mention et âge)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : les branches sont testées dans l'ordre, la première qui marche gagne.
        // On commence donc par la plus exigeante (>= 16) : si on mettait >= 10 en premier,
        // une note de 15 donnerait « Réussi » au lieu de « Bien ».
        int note = 15;
        string mention = note switch
        {
            >= 16 => "Très bien",
            >= 14 => "Bien",
            >= 10 => "Réussi",
            _ => "Échec"
        };

        // consigne 2
        Console.WriteLine(mention);

        // consigne 3 : ici on commence par le plus petit (< 18), puis < 65, et _ pour le reste
        int age = 34;
        string categorie = age switch
        {
            < 18 => "mineur",
            < 65 => "adulte",
            _ => "senior"
        };
        Console.WriteLine(categorie);
    }
}
