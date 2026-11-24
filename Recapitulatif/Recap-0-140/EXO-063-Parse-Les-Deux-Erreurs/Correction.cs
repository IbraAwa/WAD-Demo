// ===================================================================================
//  CORRECTION — EXO 063 — Les deux erreurs de Parse
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : int.Parse sur "12abc"
        // EXCEPTION : System.FormatException
        // "12abc" contient des lettres : ce n'est pas un nombre bien écrit, Parse ne sait pas le lire.
        // int x = int.Parse("12abc");

        // consigne 2 : int.Parse sur "99999999999" (onze 9)
        // EXCEPTION : System.OverflowException
        // c'est bien un nombre, mais il est trop grand pour un int (le maximum est 2 147 483 647).
        // int y = int.Parse("99999999999");

        // consigne 3 : le message
        Console.WriteLine("Les deux lignes qui plantent sont en commentaire");

        // a) FormatException  = le texte n'a pas la FORME d'un nombre (lettres, symboles...) : impossible à lire.
        //    OverflowException = le texte est bien un nombre, mais il « déborde » : il est trop grand
        //                        (ou trop petit) pour rentrer dans le type demandé (ici int).
    }
}
