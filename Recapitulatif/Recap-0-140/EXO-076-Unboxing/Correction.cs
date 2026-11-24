// ===================================================================================
//  CORRECTION — EXO 076 — Unboxing : ressortir de l'object
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : une boîte qui contient l'entier 3
        object boite = 3;

        // consigne 2 : unboxing -> on doit dire à C# ce qu'il y a dans la boîte, avec (int)
        int quantite = (int)boite;
        Console.WriteLine(quantite);

        // consigne 3 : sans cast
        // ERREUR CS0266 : Impossible de convertir implicitement le type 'object' en 'int'.
        //                 Une conversion explicite existe (un cast est-il manquant ?)
        // C# ne sait pas ce qu'il y a dans un object : il refuse de deviner, il faut un cast.
        // int q2 = boite;

        // consigne 4 : cast vers long
        // EXCEPTION : System.InvalidCastException
        // (« Unable to cast object of type 'System.Int32' to type 'System.Int64'. »)
        // Ça compile, mais ça plante au lancement : la boîte contient un int, et pour la « déballer »
        // il faut donner EXACTEMENT le type qu'il y a dedans (int), même si un int rentre dans un long.
        // long l = (long)boite;
    }
}
