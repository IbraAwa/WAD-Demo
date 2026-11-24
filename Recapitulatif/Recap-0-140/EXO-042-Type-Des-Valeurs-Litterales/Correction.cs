// ===================================================================================
//  CORRECTION — EXO 042 — Le type des valeurs écrites dans le code
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 et 2 : var laisse C# choisir le type d'après la valeur écrite
        var a = 5;        // int    (un nombre entier → int par défaut)
        var b = 'a';      // char   (entre apostrophes → UN caractère)
        var c = 3.14;     // double (un nombre à virgule → double par défaut)
        var d = "Test";   // string (entre guillemets → un texte)

        // consigne 3 : GetType() affiche le nom complet du type
        Console.WriteLine(a.GetType());
        Console.WriteLine(b.GetType());
        Console.WriteLine(c.GetType());
        Console.WriteLine(d.GetType());
    }
}
