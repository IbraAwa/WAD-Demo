// ===================================================================================
//  CORRECTION — EXO 119 — switch sur le type d'une valeur
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : object? → peut contenir n'importe quoi, y compris null
        object? valeur = 3.5;
        // tests de la consigne 3 (remplace la ligne du dessus par une de celles-ci) :
        // object? valeur = -5;     → Entier négatif : -5
        // object? valeur = 42;     → Entier : 42
        // object? valeur = null;   → Aucune valeur (null)

        // consigne 2 : le cas le plus précis (int négatif) AVANT le cas général (int)
        switch (valeur)
        {
            case int entier when entier < 0:
                Console.WriteLine("Entier négatif : " + entier);
                break;
            case int entier:
                Console.WriteLine("Entier : " + entier);
                break;
            case double nombre:
                Console.WriteLine("Décimal " + nombre);
                break;
            case null:
                Console.WriteLine("Aucune valeur (null)");
                break;
            default:
                Console.WriteLine("Autre type : " + valeur);
                break;
        }
        // (si on mettait   case int entier:   en premier, le cas « négatif » ne serait jamais atteint :
        //  C# le signale même par l'erreur CS8120 : ce case ne peut plus jamais servir)
    }
}
