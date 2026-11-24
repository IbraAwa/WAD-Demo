// ===================================================================================
//  CORRECTION — EXO 014 — Déclarer un bool
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le magasin EST ouvert → true
        bool estOuvert = true;

        // consigne 2 : le magasin N'EST PAS complet → false
        bool estComplet = false;

        // consigne 3 : afficher avec les variables
        Console.WriteLine($"Magasin ouvert : {estOuvert}");
        Console.WriteLine($"Magasin complet : {estComplet}");

        // a) Dans le code on écrit true / false (en minuscules), mais à l'écran
        //    C# affiche True / False (avec une majuscule).
    }
}
