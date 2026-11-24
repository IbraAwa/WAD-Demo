// ===================================================================================
//  CORRECTION — EXO 064 — Lire un nombre tapé par l'utilisateur
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : la question, sans retour à la ligne
        Console.Write("Ton âge : ");

        // consigne 2 : lire ET convertir en une seule instruction
        // (le ! dit à C# « je sais que ReadLine ne renverra pas null ici » : plus de soulignement vert)
        int age = int.Parse(Console.ReadLine()!);

        // consigne 3 : le calcul se fait à partir de age
        Console.WriteLine($"Dans 10 ans tu auras {age + 10} ans");

        // consigne 4 / a) Quand on tape abc :
        //    le programme PLANTE sur la ligne int.Parse avec une System.FormatException
        //    (« The input string 'abc' was not in a correct format. »).
        //    "abc" n'est pas un nombre, Parse ne sait pas le convertir, et la dernière ligne ne s'affiche jamais.
        //    (la solution pour ne pas planter : TryParse, à l'exercice suivant)
    }
}
