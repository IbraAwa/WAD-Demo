// ===================================================================================
//  CORRECTION — EXO 003 — Sauter une ligne
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le titre de la liste
        Console.WriteLine("Liste de courses :");

        // consigne 2 : une ligne vide
        // WriteLine sans texte n'affiche rien... mais passe quand même à la ligne
        Console.WriteLine();

        // consigne 3 : les 3 articles, un par ligne
        Console.WriteLine("- pain");
        Console.WriteLine("- lait");
        Console.WriteLine("- oeufs");
    }
}
