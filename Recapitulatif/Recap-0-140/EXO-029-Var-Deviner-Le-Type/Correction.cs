// ===================================================================================
//  CORRECTION — EXO 029 — var : laisser C# deviner le type
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : var → C# regarde la valeur à droite du = pour choisir le type
        // consigne 2 : prédictions
        var nombre = 42;     // prédiction : int      (un nombre entier sans suffixe)
        var nom = "Léa";     // prédiction : string   (du texte entre " ")
        var prix = 9.99m;    // prédiction : decimal  (le suffixe m)

        // consigne 3 : GetType() donne le « vrai nom » du type
        Console.WriteLine(nombre.GetType());
        Console.WriteLine(nom.GetType());
        Console.WriteLine(prix.GetType());

        // consigne 4 : System.Int32 = int, System.String = string, System.Decimal = decimal
        //              → les prédictions étaient justes.
    }
}
