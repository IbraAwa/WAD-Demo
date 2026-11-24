// ===================================================================================
//  CORRECTION — EXO 037 — string? : un texte qui peut être null
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : string? = un texte qui a le droit d'être null
        string? surnom = null;
        Console.WriteLine($"Surnom : {surnom}");

        // consigne 2 : AVERTISSEMENT CS8600 « Conversion de littéral ayant une valeur null
        // ou d'une éventuelle valeur null en type non-nullable ».
        // Ça compile quand même, mais C# nous prévient : sans le ?, le string n'est pas censé être null.
        // string nom = null;

        // consigne 3 : un string normal (sans ?) qui contient bien un texte
        string nom = "Dupont";
        Console.WriteLine($"Nom : {nom}");

        // a) Console.ReadLine() peut renvoyer null (par exemple quand il n'y a plus rien à lire,
        //    si l'entrée est fermée). Le ? dit « cette variable a le droit d'être null » :
        //    sans lui, on aurait l'avertissement CS8600 sur cette ligne.
    }
}
