// ===================================================================================
//  CORRECTION — EXO 055 — string.Format
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1
        string nom = "Léa";
        int age = 30;

        // consigne 2 : nom remplace {0}, age remplace {1}
        string phrase = string.Format("{0} a {1} ans", nom, age);

        // consigne 3
        Console.WriteLine(phrase);
    }
}
