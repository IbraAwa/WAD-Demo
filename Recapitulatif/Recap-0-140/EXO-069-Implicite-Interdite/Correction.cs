// ===================================================================================
//  CORRECTION — EXO 069 — long vers int : refusé par C#
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : un long
        long stock = 3000;

        // consigne 2 : ranger un long dans un int, sans conversion
        // ERREUR CS0266 : Impossible de convertir implicitement le type 'long' en 'int'.
        //                 Une conversion explicite existe (un cast est-il manquant ?)
        // int quantite = stock;

        // consigne 3 : affichage
        Console.WriteLine(stock);

        // a) C# ne regarde pas la VALEUR (3000), il regarde le TYPE (long).
        //    Un long peut contenir des nombres énormes qui ne rentrent pas dans un int :
        //    il y a donc un risque de perdre des données, et C# refuse de le faire tout seul.
        //    Pour le forcer, il faut l'écrire soi-même avec un cast (int) : on le verra à l'exo 072.
    }
}
