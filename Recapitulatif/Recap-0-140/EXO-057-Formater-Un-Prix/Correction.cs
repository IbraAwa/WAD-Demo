// ===================================================================================
//  CORRECTION — EXO 057 — Formater un prix : N2, C et l'alignement
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : de l'argent → decimal
        decimal prix = 1234.5m;

        // consigne 2 : N2 = nombre avec 2 chiffres après la virgule et séparateur de milliers
        Console.WriteLine($"{prix:N2}");

        // consigne 3 : C = monnaie (le symbole € vient de la langue du PC)
        Console.WriteLine($"{prix:C}");

        // Remarque : le séparateur de milliers dépend aussi de la langue du PC.
        // En français de France : 1 234,50 €   —   en français de Belgique : 1.234,50 €

        // consigne 4 : largeur 10 après la virgule ; positive = aligné à droite, négative = à gauche
        string nom = "Léa";
        Console.WriteLine($"[{nom,10}]");
        Console.WriteLine($"[{nom,-10}]");
    }
}
