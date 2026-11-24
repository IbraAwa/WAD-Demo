// ===================================================================================
//  CORRECTION — EXO 036 — Value sur un null : le programme plante
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : un entier qui peut être null, vide au départ
        int? age = null;

        // consigne 2 : EXCEPTION System.InvalidOperationException
        // (message : « Nullable object must have a value. »)
        // On demande la valeur alors qu'il n'y en a pas : le programme plante.
        // (Visual Studio prévenait déjà avec un soulignement vert : avertissement CS8629.)
        // C'est pour ça qu'il faut vérifier HasValue AVANT d'utiliser Value.
        // Console.WriteLine(age.Value);

        // consigne 3 : GetValueOrDefault() ne plante pas : s'il n'y a pas de valeur,
        // il donne la valeur par défaut du type, et pour un int c'est 0 → il affiche 0
        Console.WriteLine(age.GetValueOrDefault());
    }
}
