// ===================================================================================
//  CORRECTION — EXO 058 — ToString : transformer en texte
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : l'entier 30 devient le texte "30"
        int age = 30;
        string ageTexte = age.ToString();
        Console.WriteLine(ageTexte);

        // consigne 2 : le bool true devient le texte "True"
        bool actif = true;
        string actifTexte = actif.ToString();
        Console.WriteLine(actifTexte);

        // consigne 3 : avec le format N2 → 2 chiffres après la virgule : 9,50
        double prix = 9.5;
        Console.WriteLine(prix.ToString("N2"));
    }
}
