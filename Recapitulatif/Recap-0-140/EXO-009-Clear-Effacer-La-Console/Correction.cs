// ===================================================================================
//  CORRECTION — EXO 009 — Clear : effacer la console
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le texte qui va disparaître
        Console.WriteLine("Ce texte va disparaître");

        // consigne 2 : attendre une touche (comme à l'exercice 8)
        Console.ReadKey();

        // consigne 3 : tout effacer
        Console.Clear();

        // consigne 4 : la console est vide, ce texte s'affiche tout en haut
        Console.WriteLine("Écran propre !");

        // a) Console.Clear() efface TOUT ce qui est affiché dans la console, pas seulement
        //    ce que tu as écrit toi : le titre « EXO 009 - ... » avait été affiché AVANT
        //    (par la première ligne de Program.cs), il disparaît donc lui aussi.
    }
}
