// ===================================================================================
//  CORRECTION — EXO 011 — Les commentaires
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : un commentaire sur plusieurs lignes, une info par ligne
        /*
            Prénom : Marco
            Date   : 24/11/2026
            Exercice : EXO 011 - Les commentaires
        */

        // consigne 2 : un commentaire d'une ligne qui explique la ligne suivante
        // Affiche le message de bienvenue
        Console.WriteLine("Bienvenue au cinéma");

        // consigne 3 : la ligne mise en commentaire avec Ctrl+K puis Ctrl+C
        //              → C# l'ignore, elle ne s'affiche donc pas
        //Console.WriteLine("Je ne dois pas m'afficher");

        // consigne 4 : on lance, seule « Bienvenue au cinéma » s'affiche.
    }
}
