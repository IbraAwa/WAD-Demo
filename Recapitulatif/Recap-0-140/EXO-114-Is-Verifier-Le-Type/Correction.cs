// ===================================================================================
//  CORRECTION — EXO 114 — is : vérifier le type
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1
        object o = 42;

        // consigne 2 : on vérifie d'abord le type, puis on convertit (cast) en int
        if (o is int)
        {
            int nombre = (int)o;
            Console.WriteLine(nombre * 2);
        }

        // consigne 3 : is renvoie un bool, on peut l'afficher directement
        Console.WriteLine(o is string);
    }
}
