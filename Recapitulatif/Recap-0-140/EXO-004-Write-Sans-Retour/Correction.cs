// ===================================================================================
//  CORRECTION — EXO 004 — Write : écrire sans revenir à la ligne
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : « Bonjour » avec un espace à la fin (le curseur reste sur la ligne)
        Console.Write("Bonjour ");

        // consigne 2 : « à tous » se colle juste après, sur la même ligne
        Console.Write("à tous");

        // consigne 3 : revenir à la ligne sans rien afficher de plus
        Console.WriteLine();

        // consigne 4 : la deuxième ligne
        Console.WriteLine("Deuxième ligne");

        // a) Console.Write affiche le texte et le curseur RESTE sur la même ligne :
        //    le prochain affichage se colle juste derrière.
        //    Console.WriteLine affiche le texte PUIS passe à la ligne suivante.
    }
}
