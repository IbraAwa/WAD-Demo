// ===================================================================================
//  CORRECTION — EXO 121 — L'opérateur as
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1
        object o = "Bonjour";

        // consigne 2 : as réussit (o contient bien un string) → texte vaut "Bonjour"
        string? texte = o as string;
        Console.WriteLine(texte);

        // consigne 3 : o ne contient pas un int → as ne plante pas, il renvoie null
        int? nombre = o as int?;
        Console.WriteLine(nombre is null);

        // consigne 4 : erreur provoquée
        // CS0077 : l'opérateur as doit être utilisé avec un type référence ou un type nullable
        // ('int' est un type valeur non nullable). En cas d'échec, as renvoie null,
        // et un int normal ne peut pas valoir null : C# refuse donc d'écrire ça.
        // int entier = o as int;
    }
}
