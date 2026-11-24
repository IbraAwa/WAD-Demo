// ===================================================================================
//  CORRECTION — EXO 039 — int ou Int32 : le même type
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : deux variables qui valent 5, une avec int, l'autre avec Int32
        int a = 5;
        Int32 b = 5;

        // consigne 2 : GetType() donne le vrai nom du type
        Console.WriteLine(a.GetType());
        Console.WriteLine(b.GetType());

        // consigne 3 : string est de la même façon le raccourci de System.String
        string s = "Bonjour";
        Console.WriteLine(s.GetType());

        // a) Oui : int est juste le mot-clé C# (le raccourci) pour le type System.Int32.
        //    Les deux s'affichent System.Int32 : c'est exactement le même type.
    }
}
