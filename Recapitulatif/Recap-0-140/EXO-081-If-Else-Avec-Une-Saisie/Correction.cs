// ===================================================================================
//  CORRECTION — EXO 081 — if ... else avec ce que l'utilisateur tape
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : la question (Write : la réponse se tape sur la même ligne), puis int.Parse
        Console.Write("Quelle température fait-il ? ");
        int temperature = int.Parse(Console.ReadLine()!);

        // consigne 2 : strictement plus que 25 -> >
        if (temperature > 25)
        {
            Console.WriteLine("Il fait chaud, prends de l'eau !");
        }
        // consigne 3 : sinon
        else
        {
            Console.WriteLine("Il ne fait pas trop chaud.");
        }

        // (avec 25 pile, on obtient « Il ne fait pas trop chaud. » : 25 > 25 est faux)
    }
}
